using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;

namespace MusicViewer
{
	internal partial class MusicViewer : Form
	{
		private XmlNode compositions;
		private XmlNode list;
		private XmlDocument musicList = new XmlDocument();
		private string number;
		private string path;

		public MusicViewer()
		{
			InitializeComponent();
		}

		public void OpenXml(string path)
		{
			List<string> artists = new List<string>();
			musicList.Load(path);
			XmlNode name = musicList.DocumentElement;

			foreach (XmlNode title in name.ChildNodes)
			{
				foreach (XmlNode track in title.ChildNodes)
				{
					if (track.Attributes.Count > 0)
					{
						XmlNode artist = track.Attributes.GetNamedItem("name");
						if (artist != null)
						{
							if (track.Name == "artist")
							{
								artists.Add(artist.Value);
							}
						}
					}
				}
			}

			artists.Sort();
			foreach (string art in artists)
			{
				MusicBox.Items.Add(art);
			}
		}

		private void LoadButton_Click(object sender, EventArgs e)
		{
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				path = openFileDialog.FileName;
				OpenXml(path);
			}
		}

		private void MusicBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			albumComposition.Text = "";
			releasedComposition.Text = "";
			lengthComposition.Text = "";
			genresComposition1.Text = "";
			genresComposition2.Text = "";
			genresComposition3.Text = "";
			MinimumMaximumDate();
		}

		private void MinimumMaximumDate()
		{
			List<string> listcompositions = new List<string>();
			if (ListComposition.Items.Count != 0)
			{
				ListComposition.Items.Clear();
			}

			compositions = musicList.DocumentElement;
			list = compositions.LastChild;

			foreach (XmlNode artist in compositions.ChildNodes)
			{
				if (artist.Name == "artists")
				{
					foreach (XmlNode idArtist in artist.ChildNodes)
					{
						if (idArtist.Attributes.GetNamedItem("name").Value == MusicBox.Items[MusicBox.SelectedIndex].ToString())
						{
							number = idArtist.Attributes.GetNamedItem("id").Value;
							break;
						}
					}
				}
			}

			bool minimum = true;
			foreach (XmlNode track in list.ChildNodes)
			{
				if (list.ChildNodes.Count != 0)
				{
					if (track.Attributes.GetNamedItem("artist-id").Value == number)
					{
						foreach (XmlNode comp in compositions.ChildNodes)
						{
							if (comp.Name == "artists")
							{
								foreach (XmlNode artistId in comp.ChildNodes)
								{
									if (artistId.Attributes.GetNamedItem("id").Value == number)
									{
										//listcompositions.Add(track.Attributes.GetNamedItem("name").Value);
										string[] dateComp = track.Attributes.GetNamedItem("released").Value.Split('.');
										int dateDay = Convert.ToInt32(dateComp[0]);
										int dateMonth = Convert.ToInt32(dateComp[1]);
										int dateYear = Convert.ToInt32(dateComp[2]);
										if (minimum)
										{
											minimumDate.MaxDate = DateTime.Now;
											maximumDate.MaxDate = DateTime.Now;
											minimumDate.MinDate = new DateTime(dateYear, dateMonth, dateDay);
											maximumDate.MinDate = new DateTime(dateYear, dateMonth, dateDay);
											minimumDate.MaxDate = new DateTime(dateYear, dateMonth, dateDay);// DateTime.Now;
											maximumDate.MaxDate = new DateTime(dateYear, dateMonth, dateDay);// DateTime.Now;
											minimum = false;
										}
										string[] array = minimumDate.MinDate.ToShortDateString().Split('.');
										int day = Convert.ToInt32(array[0]);
										int month = Convert.ToInt32(array[1]);
										int year = Convert.ToInt32(array[2]);

										if (dateYear < year)
										{
											minimumDate.MinDate = new DateTime(dateYear, dateMonth, dateDay);
											maximumDate.MinDate = new DateTime(dateYear, dateMonth, dateDay);
										}
										else if (dateYear == year)
										{
											if (dateMonth < month)
											{
												minimumDate.MinDate = new DateTime(dateYear, dateMonth, dateDay);
												maximumDate.MinDate = new DateTime(dateYear, dateMonth, dateDay);
											}
											else if (dateMonth == month)
											{
												if (dateDay < day)
												{
													minimumDate.MinDate = new DateTime(dateYear, dateMonth, dateDay);
													maximumDate.MinDate = new DateTime(dateYear, dateMonth, dateDay);
												}
											}
										}
										if (dateYear > year)
										{
											minimumDate.MaxDate = new DateTime(dateYear, dateMonth, dateDay);
											maximumDate.MaxDate = new DateTime(dateYear, dateMonth, dateDay);
										}
										else if (dateYear == year)
										{
											if (dateMonth > month)
											{
												minimumDate.MaxDate = new DateTime(dateYear, dateMonth, dateDay);
												maximumDate.MaxDate = new DateTime(dateYear, dateMonth, dateDay);
											}
											else if (dateMonth == month)
											{
												if (dateDay > day)
												{
													minimumDate.MaxDate = new DateTime(dateYear, dateMonth, dateDay);
													maximumDate.MaxDate = new DateTime(dateYear, dateMonth, dateDay);
												}
												//else
												//{
												//	minimumDate.MaxDate = minimumDate.MinDate;
												//	maximumDate.MaxDate = minimumDate.MinDate;
												//}
											}
										}
									}
								}
							}
						}
					}
				}
			}

			listcompositions.Sort();
			foreach (string comp in listcompositions)
			{
				ListComposition.Items.Add(comp);
			}
			minimumDate.Value = minimumDate.MinDate;
			maximumDate.Value = maximumDate.MaxDate;
			minimumDate.Visible = true;
			maximumDate.Visible = true;
		}

		private void ListComposition_SelectedValueChanged(object sender, EventArgs e)
		{
			genresComposition1.Text = "";
			genresComposition2.Text = "";
			genresComposition3.Text = "";

			foreach (XmlNode track in list.ChildNodes)
			{
				if (track.Attributes.GetNamedItem("name").Value == ListComposition.SelectedItem)
				{
					foreach (XmlNode albums in compositions.ChildNodes)
					{
						if (albums.Name == "albums")
						{
							foreach (XmlNode album in albums.ChildNodes)
							{
								if (album.Attributes.GetNamedItem("id").Value == track.Attributes.GetNamedItem("album-id").Value)
								{
									albumComposition.Text = album.Attributes.GetNamedItem("name").Value;
								}
							}
						}
					}

					lengthComposition.Text = track.Attributes.GetNamedItem("length").Value;
					releasedComposition.Text = track.Attributes.GetNamedItem("released").Value;
					XmlNode genre = track.FirstChild;

					foreach (XmlNode idGenre in genre)
					{
						foreach (XmlNode genres in compositions.ChildNodes)
						{
							if (genres.Name == "genres")
							{
								foreach (XmlNode id in genres.ChildNodes)
								{
									if (id.Attributes.GetNamedItem("id").Value == idGenre.Attributes.GetNamedItem("genre-id").Value)
									{
										if (genresComposition1.Text.Length == 0)
										{
											genresComposition1.Text = id.Attributes.GetNamedItem("name").Value;
										}
										else if (genresComposition2.Text.Length == 0)
										{
											genresComposition2.Text = id.Attributes.GetNamedItem("name").Value;
										}
										else if (genresComposition3.Text.Length == 0)
										{
											genresComposition3.Text = id.Attributes.GetNamedItem("name").Value;
										}
									}
								}
							}
						}
					}
				}
			}
		}

		private void MaximumDate_ValueChanged(object sender, EventArgs e)
		{
			//ListCompositions();
		}

		private void MinimumDate_ValueChanged(object sender, EventArgs e)
		{
			//ListCompositions();
		}
	}
}