namespace Pathfinder_Helper.Forms
{
    partial class WeatherMaintenance
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
			this.dataCSW = new System.Windows.Forms.DataGridView();
			this.Continent = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Season = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ExtraWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label1 = new System.Windows.Forms.Label();
			this.drpCSWContinent = new System.Windows.Forms.ComboBox();
			this.drpCSWSeason = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.numCSWWeightPlus = new System.Windows.Forms.NumericUpDown();
			this.btnCSWUpdate = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.drpNextWeather = new System.Windows.Forms.ComboBox();
			this.numDuration = new System.Windows.Forms.NumericUpDown();
			this.numWeight = new System.Windows.Forms.NumericUpDown();
			this.label7 = new System.Windows.Forms.Label();
			this.cbxHeatDanger = new System.Windows.Forms.CheckBox();
			this.cbxHeatLethal = new System.Windows.Forms.CheckBox();
			this.cbxColdDanger = new System.Windows.Forms.CheckBox();
			this.cbxColdLethal = new System.Windows.Forms.CheckBox();
			this.cbxHighWind = new System.Windows.Forms.CheckBox();
			this.cbxVisionObscured = new System.Windows.Forms.CheckBox();
			this.lbxWeather = new System.Windows.Forms.ListBox();
			this.btnCSWNew = new System.Windows.Forms.Button();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtEffects = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.btnNew = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataCSW)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numCSWWeightPlus)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numDuration)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numWeight)).BeginInit();
			this.SuspendLayout();
			// 
			// dataCSW
			// 
			this.dataCSW.AllowUserToAddRows = false;
			this.dataCSW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataCSW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Continent,
            this.Season,
            this.ExtraWeight});
			this.dataCSW.Location = new System.Drawing.Point(218, 160);
			this.dataCSW.Name = "dataCSW";
			this.dataCSW.ReadOnly = true;
			this.dataCSW.Size = new System.Drawing.Size(301, 150);
			this.dataCSW.TabIndex = 0;
			// 
			// Continent
			// 
			this.Continent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Continent.HeaderText = "Continent";
			this.Continent.Name = "Continent";
			this.Continent.ReadOnly = true;
			// 
			// Season
			// 
			this.Season.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Season.HeaderText = "Season";
			this.Season.Name = "Season";
			this.Season.ReadOnly = true;
			this.Season.Width = 68;
			// 
			// ExtraWeight
			// 
			this.ExtraWeight.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.ExtraWeight.HeaderText = "Weight+";
			this.ExtraWeight.Name = "ExtraWeight";
			this.ExtraWeight.ReadOnly = true;
			this.ExtraWeight.Width = 72;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(219, 319);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Continent";
			// 
			// drpCSWContinent
			// 
			this.drpCSWContinent.FormattingEnabled = true;
			this.drpCSWContinent.Location = new System.Drawing.Point(277, 316);
			this.drpCSWContinent.Name = "drpCSWContinent";
			this.drpCSWContinent.Size = new System.Drawing.Size(148, 21);
			this.drpCSWContinent.TabIndex = 2;
			// 
			// drpCSWSeason
			// 
			this.drpCSWSeason.FormattingEnabled = true;
			this.drpCSWSeason.Location = new System.Drawing.Point(277, 343);
			this.drpCSWSeason.Name = "drpCSWSeason";
			this.drpCSWSeason.Size = new System.Drawing.Size(148, 21);
			this.drpCSWSeason.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(219, 346);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Season";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(219, 373);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(47, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Weight+";
			// 
			// numCSWWeightPlus
			// 
			this.numCSWWeightPlus.Location = new System.Drawing.Point(277, 371);
			this.numCSWWeightPlus.Name = "numCSWWeightPlus";
			this.numCSWWeightPlus.Size = new System.Drawing.Size(148, 20);
			this.numCSWWeightPlus.TabIndex = 6;
			// 
			// btnCSWUpdate
			// 
			this.btnCSWUpdate.Location = new System.Drawing.Point(431, 369);
			this.btnCSWUpdate.Name = "btnCSWUpdate";
			this.btnCSWUpdate.Size = new System.Drawing.Size(72, 20);
			this.btnCSWUpdate.TabIndex = 8;
			this.btnCSWUpdate.Text = "Update";
			this.btnCSWUpdate.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(218, 15);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(82, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Weather Name:";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(306, 12);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(184, 20);
			this.txtName.TabIndex = 10;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(218, 67);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(76, 13);
			this.label5.TabIndex = 11;
			this.label5.Text = "Next Weather:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(218, 40);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(50, 13);
			this.label6.TabIndex = 12;
			this.label6.Text = "Duration:";
			// 
			// drpNextWeather
			// 
			this.drpNextWeather.FormattingEnabled = true;
			this.drpNextWeather.Location = new System.Drawing.Point(306, 64);
			this.drpNextWeather.Name = "drpNextWeather";
			this.drpNextWeather.Size = new System.Drawing.Size(184, 21);
			this.drpNextWeather.TabIndex = 13;
			// 
			// numDuration
			// 
			this.numDuration.Location = new System.Drawing.Point(306, 38);
			this.numDuration.Name = "numDuration";
			this.numDuration.Size = new System.Drawing.Size(59, 20);
			this.numDuration.TabIndex = 14;
			// 
			// numWeight
			// 
			this.numWeight.Location = new System.Drawing.Point(431, 38);
			this.numWeight.Name = "numWeight";
			this.numWeight.Size = new System.Drawing.Size(59, 20);
			this.numWeight.TabIndex = 16;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(381, 40);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(44, 13);
			this.label7.TabIndex = 15;
			this.label7.Text = "Weight:";
			// 
			// cbxHeatDanger
			// 
			this.cbxHeatDanger.AutoSize = true;
			this.cbxHeatDanger.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cbxHeatDanger.Location = new System.Drawing.Point(233, 114);
			this.cbxHeatDanger.Name = "cbxHeatDanger";
			this.cbxHeatDanger.Size = new System.Drawing.Size(90, 17);
			this.cbxHeatDanger.TabIndex = 17;
			this.cbxHeatDanger.Text = "Heat Danger:";
			this.cbxHeatDanger.UseVisualStyleBackColor = true;
			// 
			// cbxHeatLethal
			// 
			this.cbxHeatLethal.AutoSize = true;
			this.cbxHeatLethal.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cbxHeatLethal.Location = new System.Drawing.Point(335, 114);
			this.cbxHeatLethal.Name = "cbxHeatLethal";
			this.cbxHeatLethal.Size = new System.Drawing.Size(84, 17);
			this.cbxHeatLethal.TabIndex = 18;
			this.cbxHeatLethal.Text = "Heat Lethal:";
			this.cbxHeatLethal.UseVisualStyleBackColor = true;
			// 
			// cbxColdDanger
			// 
			this.cbxColdDanger.AutoSize = true;
			this.cbxColdDanger.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cbxColdDanger.Location = new System.Drawing.Point(235, 137);
			this.cbxColdDanger.Name = "cbxColdDanger";
			this.cbxColdDanger.Size = new System.Drawing.Size(88, 17);
			this.cbxColdDanger.TabIndex = 19;
			this.cbxColdDanger.Text = "Cold Danger:";
			this.cbxColdDanger.UseVisualStyleBackColor = true;
			// 
			// cbxColdLethal
			// 
			this.cbxColdLethal.AutoSize = true;
			this.cbxColdLethal.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cbxColdLethal.Location = new System.Drawing.Point(337, 137);
			this.cbxColdLethal.Name = "cbxColdLethal";
			this.cbxColdLethal.Size = new System.Drawing.Size(82, 17);
			this.cbxColdLethal.TabIndex = 20;
			this.cbxColdLethal.Text = "Cold Lethal:";
			this.cbxColdLethal.UseVisualStyleBackColor = true;
			// 
			// cbxHighWind
			// 
			this.cbxHighWind.AutoSize = true;
			this.cbxHighWind.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cbxHighWind.Location = new System.Drawing.Point(340, 91);
			this.cbxHighWind.Name = "cbxHighWind";
			this.cbxHighWind.Size = new System.Drawing.Size(79, 17);
			this.cbxHighWind.TabIndex = 21;
			this.cbxHighWind.Text = "High Wind:";
			this.cbxHighWind.UseVisualStyleBackColor = true;
			// 
			// cbxVisionObscured
			// 
			this.cbxVisionObscured.AutoSize = true;
			this.cbxVisionObscured.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cbxVisionObscured.Location = new System.Drawing.Point(217, 91);
			this.cbxVisionObscured.Name = "cbxVisionObscured";
			this.cbxVisionObscured.Size = new System.Drawing.Size(106, 17);
			this.cbxVisionObscured.TabIndex = 22;
			this.cbxVisionObscured.Text = "Vision Obscured:";
			this.cbxVisionObscured.UseVisualStyleBackColor = true;
			// 
			// lbxWeather
			// 
			this.lbxWeather.FormattingEnabled = true;
			this.lbxWeather.Location = new System.Drawing.Point(11, 12);
			this.lbxWeather.Name = "lbxWeather";
			this.lbxWeather.Size = new System.Drawing.Size(200, 407);
			this.lbxWeather.TabIndex = 23;
			// 
			// btnCSWNew
			// 
			this.btnCSWNew.Location = new System.Drawing.Point(431, 344);
			this.btnCSWNew.Name = "btnCSWNew";
			this.btnCSWNew.Size = new System.Drawing.Size(72, 20);
			this.btnCSWNew.TabIndex = 24;
			this.btnCSWNew.Text = "New CSW";
			this.btnCSWNew.UseVisualStyleBackColor = true;
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(525, 38);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(400, 80);
			this.txtDescription.TabIndex = 26;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(522, 19);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(63, 13);
			this.label8.TabIndex = 25;
			this.label8.Text = "Description:";
			// 
			// txtEffects
			// 
			this.txtEffects.Location = new System.Drawing.Point(525, 160);
			this.txtEffects.Multiline = true;
			this.txtEffects.Name = "txtEffects";
			this.txtEffects.Size = new System.Drawing.Size(400, 80);
			this.txtEffects.TabIndex = 28;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(522, 141);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(43, 13);
			this.label9.TabIndex = 27;
			this.label9.Text = "Effects:";
			// 
			// btnNew
			// 
			this.btnNew.Location = new System.Drawing.Point(525, 399);
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(106, 23);
			this.btnNew.TabIndex = 29;
			this.btnNew.Text = "New Weather";
			this.btnNew.UseVisualStyleBackColor = true;
			this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(815, 399);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(106, 23);
			this.btnSave.TabIndex = 30;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(637, 399);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(106, 23);
			this.btnDelete.TabIndex = 31;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			// 
			// WeatherMaintenance
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(933, 430);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnNew);
			this.Controls.Add(this.txtEffects);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.btnCSWNew);
			this.Controls.Add(this.lbxWeather);
			this.Controls.Add(this.cbxVisionObscured);
			this.Controls.Add(this.cbxHighWind);
			this.Controls.Add(this.cbxColdLethal);
			this.Controls.Add(this.cbxColdDanger);
			this.Controls.Add(this.cbxHeatLethal);
			this.Controls.Add(this.cbxHeatDanger);
			this.Controls.Add(this.numWeight);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.numDuration);
			this.Controls.Add(this.drpNextWeather);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnCSWUpdate);
			this.Controls.Add(this.numCSWWeightPlus);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.drpCSWSeason);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.drpCSWContinent);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataCSW);
			this.Name = "WeatherMaintenance";
			this.Text = "Weather Maintenance";
			((System.ComponentModel.ISupportInitialize)(this.dataCSW)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numCSWWeightPlus)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numDuration)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numWeight)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataCSW;
        private System.Windows.Forms.DataGridViewTextBoxColumn Continent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Season;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExtraWeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox drpCSWContinent;
        private System.Windows.Forms.ComboBox drpCSWSeason;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numCSWWeightPlus;
        private System.Windows.Forms.Button btnCSWUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox drpNextWeather;
        private System.Windows.Forms.NumericUpDown numDuration;
        private System.Windows.Forms.NumericUpDown numWeight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbxHeatDanger;
        private System.Windows.Forms.CheckBox cbxHeatLethal;
        private System.Windows.Forms.CheckBox cbxColdDanger;
        private System.Windows.Forms.CheckBox cbxColdLethal;
        private System.Windows.Forms.CheckBox cbxHighWind;
        private System.Windows.Forms.CheckBox cbxVisionObscured;
        private System.Windows.Forms.ListBox lbxWeather;
        private System.Windows.Forms.Button btnCSWNew;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEffects;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
    }
}