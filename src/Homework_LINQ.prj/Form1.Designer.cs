namespace Homework_LINQ
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.country_en = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.region_en = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.city_en = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.country = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.region = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.city = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lat = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lng = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.population = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 415);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(99, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Choose dataset";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.country_en,
            this.region_en,
            this.city_en,
            this.country,
            this.region,
            this.city,
            this.lat,
            this.lng,
            this.population});
			this.dataGridView1.Location = new System.Drawing.Point(12, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 25;
			this.dataGridView1.Size = new System.Drawing.Size(1064, 397);
			this.dataGridView1.TabIndex = 1;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// ID
			// 
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			// 
			// country_en
			// 
			this.country_en.HeaderText = "country_en";
			this.country_en.Name = "country_en";
			// 
			// region_en
			// 
			this.region_en.HeaderText = "region_en";
			this.region_en.Name = "region_en";
			// 
			// city_en
			// 
			this.city_en.HeaderText = "city_en";
			this.city_en.Name = "city_en";
			// 
			// country
			// 
			this.country.HeaderText = "country";
			this.country.Name = "country";
			// 
			// region
			// 
			this.region.HeaderText = "region";
			this.region.Name = "region";
			// 
			// city
			// 
			this.city.HeaderText = "city";
			this.city.Name = "city";
			// 
			// lat
			// 
			this.lat.HeaderText = "lat";
			this.lat.Name = "lat";
			// 
			// lng
			// 
			this.lng.HeaderText = "lng";
			this.lng.Name = "lng";
			// 
			// population
			// 
			this.population.HeaderText = "population";
			this.population.Name = "population";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1083, 450);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn country_en;
		private System.Windows.Forms.DataGridViewTextBoxColumn region_en;
		private System.Windows.Forms.DataGridViewTextBoxColumn city_en;
		private System.Windows.Forms.DataGridViewTextBoxColumn country;
		private System.Windows.Forms.DataGridViewTextBoxColumn region;
		private System.Windows.Forms.DataGridViewTextBoxColumn city;
		private System.Windows.Forms.DataGridViewTextBoxColumn lat;
		private System.Windows.Forms.DataGridViewTextBoxColumn lng;
		private System.Windows.Forms.DataGridViewTextBoxColumn population;
	}
}
