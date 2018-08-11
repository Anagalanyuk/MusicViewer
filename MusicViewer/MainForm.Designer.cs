namespace MusicViewer
{
	partial class MusicViewer
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.loadButton = new System.Windows.Forms.Button();
			this.ListComposition = new System.Windows.Forms.ListBox();
			this.MusicBox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.minimumDate = new System.Windows.Forms.DateTimePicker();
			this.maximumDate = new System.Windows.Forms.DateTimePicker();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.album = new System.Windows.Forms.Label();
			this.released = new System.Windows.Forms.Label();
			this.length = new System.Windows.Forms.Label();
			this.genres = new System.Windows.Forms.Label();
			this.albumComposition = new System.Windows.Forms.Label();
			this.releasedComposition = new System.Windows.Forms.Label();
			this.lengthComposition = new System.Windows.Forms.Label();
			this.genresComposition = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// loadButton
			// 
			this.loadButton.Location = new System.Drawing.Point(12, 12);
			this.loadButton.Name = "loadButton";
			this.loadButton.Size = new System.Drawing.Size(75, 23);
			this.loadButton.TabIndex = 0;
			this.loadButton.Text = "Load";
			this.loadButton.UseVisualStyleBackColor = true;
			this.loadButton.Click += new System.EventHandler(this.LoadButton_Click);
			// 
			// ListComposition
			// 
			this.ListComposition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ListComposition.FormattingEnabled = true;
			this.ListComposition.ItemHeight = 16;
			this.ListComposition.Location = new System.Drawing.Point(12, 93);
			this.ListComposition.Name = "ListComposition";
			this.ListComposition.Size = new System.Drawing.Size(255, 308);
			this.ListComposition.TabIndex = 1;
			this.ListComposition.SelectedValueChanged += new System.EventHandler(this.ListComposition_SelectedValueChanged);
			// 
			// MusicBox
			// 
			this.MusicBox.FormattingEnabled = true;
			this.MusicBox.Location = new System.Drawing.Point(93, 14);
			this.MusicBox.Name = "MusicBox";
			this.MusicBox.Size = new System.Drawing.Size(424, 21);
			this.MusicBox.TabIndex = 2;
			this.MusicBox.SelectedIndexChanged += new System.EventHandler(this.MusicBox_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(9, 49);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 16);
			this.label1.TabIndex = 3;
			this.label1.Text = "From:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(273, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(28, 16);
			this.label2.TabIndex = 5;
			this.label2.Text = "To:";
			// 
			// minimumDate
			// 
			this.minimumDate.Location = new System.Drawing.Point(57, 49);
			this.minimumDate.Name = "minimumDate";
			this.minimumDate.Size = new System.Drawing.Size(210, 20);
			this.minimumDate.TabIndex = 6;
			this.minimumDate.Value = new System.DateTime(2018, 8, 2, 1, 2, 17, 0);
			this.minimumDate.Visible = false;
			this.minimumDate.ValueChanged += new System.EventHandler(this.MinimumDate_ValueChanged);
			// 
			// maximumDate
			// 
			this.maximumDate.Location = new System.Drawing.Point(307, 49);
			this.maximumDate.MaxDate = new System.DateTime(2018, 8, 2, 0, 0, 0, 0);
			this.maximumDate.MinDate = new System.DateTime(2018, 6, 25, 0, 0, 0, 0);
			this.maximumDate.Name = "maximumDate";
			this.maximumDate.Size = new System.Drawing.Size(210, 20);
			this.maximumDate.TabIndex = 7;
			this.maximumDate.Value = new System.DateTime(2018, 8, 2, 0, 0, 0, 0);
			this.maximumDate.Visible = false;
			this.maximumDate.ValueChanged += new System.EventHandler(this.MaximumDate_ValueChanged);
			// 
			// album
			// 
			this.album.AutoSize = true;
			this.album.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.album.Location = new System.Drawing.Point(290, 93);
			this.album.Name = "album";
			this.album.Size = new System.Drawing.Size(58, 20);
			this.album.TabIndex = 8;
			this.album.Text = "Album:";
			// 
			// released
			// 
			this.released.AutoSize = true;
			this.released.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.released.Location = new System.Drawing.Point(267, 135);
			this.released.Name = "released";
			this.released.Size = new System.Drawing.Size(81, 20);
			this.released.TabIndex = 9;
			this.released.Text = "Released:";
			// 
			// length
			// 
			this.length.AutoSize = true;
			this.length.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.length.Location = new System.Drawing.Point(285, 183);
			this.length.Name = "length";
			this.length.Size = new System.Drawing.Size(63, 20);
			this.length.TabIndex = 10;
			this.length.Text = "Length:";
			// 
			// genres
			// 
			this.genres.AutoSize = true;
			this.genres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.genres.Location = new System.Drawing.Point(282, 232);
			this.genres.Name = "genres";
			this.genres.Size = new System.Drawing.Size(66, 20);
			this.genres.TabIndex = 11;
			this.genres.Text = "Genres:";
			// 
			// albumComposition
			// 
			this.albumComposition.AutoSize = true;
			this.albumComposition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.albumComposition.Location = new System.Drawing.Point(355, 93);
			this.albumComposition.Name = "albumComposition";
			this.albumComposition.Size = new System.Drawing.Size(0, 20);
			this.albumComposition.TabIndex = 12;
			// 
			// releasedComposition
			// 
			this.releasedComposition.AutoSize = true;
			this.releasedComposition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.releasedComposition.Location = new System.Drawing.Point(354, 135);
			this.releasedComposition.Name = "releasedComposition";
			this.releasedComposition.Size = new System.Drawing.Size(0, 20);
			this.releasedComposition.TabIndex = 13;
			// 
			// lengthComposition
			// 
			this.lengthComposition.AutoSize = true;
			this.lengthComposition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lengthComposition.Location = new System.Drawing.Point(355, 183);
			this.lengthComposition.Name = "lengthComposition";
			this.lengthComposition.Size = new System.Drawing.Size(0, 20);
			this.lengthComposition.TabIndex = 14;
			// 
			// genresComposition
			// 
			this.genresComposition.AutoSize = true;
			this.genresComposition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.genresComposition.Location = new System.Drawing.Point(355, 232);
			this.genresComposition.Name = "genresComposition";
			this.genresComposition.Size = new System.Drawing.Size(0, 20);
			this.genresComposition.TabIndex = 15;
			// 
			// MusicViewer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(523, 432);
			this.Controls.Add(this.genresComposition);
			this.Controls.Add(this.lengthComposition);
			this.Controls.Add(this.releasedComposition);
			this.Controls.Add(this.albumComposition);
			this.Controls.Add(this.genres);
			this.Controls.Add(this.length);
			this.Controls.Add(this.released);
			this.Controls.Add(this.album);
			this.Controls.Add(this.maximumDate);
			this.Controls.Add(this.minimumDate);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.MusicBox);
			this.Controls.Add(this.ListComposition);
			this.Controls.Add(this.loadButton);
			this.MaximizeBox = false;
			this.Name = "MusicViewer";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Music Viewer";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button loadButton;
		private System.Windows.Forms.ListBox ListComposition;
		private System.Windows.Forms.ComboBox MusicBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker minimumDate;
		private System.Windows.Forms.DateTimePicker maximumDate;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.Label album;
		private System.Windows.Forms.Label released;
		private System.Windows.Forms.Label length;
		private System.Windows.Forms.Label genres;
		private System.Windows.Forms.Label albumComposition;
		private System.Windows.Forms.Label releasedComposition;
		private System.Windows.Forms.Label lengthComposition;
		private System.Windows.Forms.Label genresComposition;
	}
}

