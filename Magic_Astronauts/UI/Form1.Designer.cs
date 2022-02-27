﻿namespace Magic_Astronauts
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
            if (disposing && (components != null))
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.humidityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Browse_btn = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveBtn = new System.Windows.Forms.Button();
            this.load_Btn = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clear_Btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.avgTempAndHumidityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnShowAvg = new System.Windows.Forms.Button();
            this.btnnewAVG = new System.Windows.Forms.Button();
            this.mouldRiskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.avgTempAndHumidityBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.selectDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AverageHumidity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AverageTemperature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mouldRiskBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.SelectDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RiskForMould = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MouldIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMoldRisk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avgTempAndHumidityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mouldRiskBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avgTempAndHumidityBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mouldRiskBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // placeDataGridViewTextBoxColumn
            // 
            this.placeDataGridViewTextBoxColumn.DataPropertyName = "Place";
            this.placeDataGridViewTextBoxColumn.HeaderText = "Place";
            this.placeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.placeDataGridViewTextBoxColumn.Name = "placeDataGridViewTextBoxColumn";
            this.placeDataGridViewTextBoxColumn.Width = 125;
            // 
            // tempDataGridViewTextBoxColumn
            // 
            this.tempDataGridViewTextBoxColumn.DataPropertyName = "Temp";
            this.tempDataGridViewTextBoxColumn.HeaderText = "Temp";
            this.tempDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tempDataGridViewTextBoxColumn.Name = "tempDataGridViewTextBoxColumn";
            this.tempDataGridViewTextBoxColumn.Width = 125;
            // 
            // humidityDataGridViewTextBoxColumn
            // 
            this.humidityDataGridViewTextBoxColumn.DataPropertyName = "Humidity";
            this.humidityDataGridViewTextBoxColumn.HeaderText = "Humidity";
            this.humidityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.humidityDataGridViewTextBoxColumn.Name = "humidityDataGridViewTextBoxColumn";
            this.humidityDataGridViewTextBoxColumn.Width = 125;
            // 
            // Browse_btn
            // 
            this.Browse_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Browse_btn.Location = new System.Drawing.Point(265, 9);
            this.Browse_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Browse_btn.Name = "Browse_btn";
            this.Browse_btn.Size = new System.Drawing.Size(122, 29);
            this.Browse_btn.TabIndex = 1;
            this.Browse_btn.Text = "Browse";
            this.Browse_btn.UseVisualStyleBackColor = true;
            this.Browse_btn.Click += new System.EventHandler(this.Browse_btn_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(406, 15);
            this.txtFileName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(364, 23);
            this.txtFileName.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveBtn.Location = new System.Drawing.Point(647, 532);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(122, 29);
            this.saveBtn.TabIndex = 7;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // load_Btn
            // 
            this.load_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.load_Btn.Location = new System.Drawing.Point(265, 532);
            this.load_Btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.load_Btn.Name = "load_Btn";
            this.load_Btn.Size = new System.Drawing.Size(122, 29);
            this.load_Btn.TabIndex = 8;
            this.load_Btn.Text = "Load";
            this.load_Btn.UseVisualStyleBackColor = true;
            this.load_Btn.Click += new System.EventHandler(this.load_Btn_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(Magic_Astronauts.Core.Weather);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelectDate,
            this.RiskForMould,
            this.MouldIndex,
            this.locationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mouldRiskBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(265, 40);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(504, 485);
            this.dataGridView1.TabIndex = 9;
            // 
            // clear_Btn
            // 
            this.clear_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clear_Btn.Location = new System.Drawing.Point(458, 532);
            this.clear_Btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clear_Btn.Name = "clear_Btn";
            this.clear_Btn.Size = new System.Drawing.Size(122, 29);
            this.clear_Btn.TabIndex = 10;
            this.clear_Btn.Text = "Clear";
            this.clear_Btn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnMoldRisk);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.btnShowAvg);
            this.panel1.Controls.Add(this.btnnewAVG);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 573);
            this.panel1.TabIndex = 11;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selectDateDataGridViewTextBoxColumn,
            this.AverageHumidity,
            this.AverageTemperature,
            this.Location});
            this.dataGridView2.DataSource = this.avgTempAndHumidityBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(-1, 120);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(223, 381);
            this.dataGridView2.TabIndex = 14;
            // 
            // avgTempAndHumidityBindingSource
            // 
            this.avgTempAndHumidityBindingSource.DataSource = typeof(Magic_Astronauts.Core.AverageCalc);
            // 
            // btnShowAvg
            // 
            this.btnShowAvg.Location = new System.Drawing.Point(52, 91);
            this.btnShowAvg.Name = "btnShowAvg";
            this.btnShowAvg.Size = new System.Drawing.Size(75, 23);
            this.btnShowAvg.TabIndex = 13;
            this.btnShowAvg.Text = "Show AVG";
            this.btnShowAvg.UseVisualStyleBackColor = true;
            this.btnShowAvg.Click += new System.EventHandler(this.btnShowAvg_Click);
            // 
            // btnnewAVG
            // 
            this.btnnewAVG.Location = new System.Drawing.Point(52, 62);
            this.btnnewAVG.Name = "btnnewAVG";
            this.btnnewAVG.Size = new System.Drawing.Size(75, 23);
            this.btnnewAVG.TabIndex = 12;
            this.btnnewAVG.Text = "AVG";
            this.btnnewAVG.UseVisualStyleBackColor = true;
            this.btnnewAVG.Click += new System.EventHandler(this.btnnewAVG_Click);
            // 
            // mouldRiskBindingSource
            // 
            this.mouldRiskBindingSource.DataSource = typeof(Magic_Astronauts.Core.MouldData);
            // 
            // avgTempAndHumidityBindingSource1
            // 
            this.avgTempAndHumidityBindingSource1.DataSource = typeof(Magic_Astronauts.Core.AverageCalc);
            // 
            // selectDateDataGridViewTextBoxColumn
            // 
            this.selectDateDataGridViewTextBoxColumn.DataPropertyName = "SelectDate";
            this.selectDateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.selectDateDataGridViewTextBoxColumn.Name = "selectDateDataGridViewTextBoxColumn";
            // 
            // AverageHumidity
            // 
            this.AverageHumidity.DataPropertyName = "AverageHumidity";
            this.AverageHumidity.HeaderText = "Humidity";
            this.AverageHumidity.Name = "AverageHumidity";
            // 
            // AverageTemperature
            // 
            this.AverageTemperature.DataPropertyName = "AverageTemperature";
            this.AverageTemperature.HeaderText = "Temp";
            this.AverageTemperature.Name = "AverageTemperature";
            // 
            // Location
            // 
            this.Location.DataPropertyName = "Location";
            this.Location.HeaderText = "Location";
            this.Location.Name = "Location";
            // 
            // mouldRiskBindingSource1
            // 
            this.mouldRiskBindingSource1.DataSource = typeof(Magic_Astronauts.Core.MouldData);
            // 
            // SelectDate
            // 
            this.SelectDate.DataPropertyName = "SelectDate";
            this.SelectDate.HeaderText = "SelectDate";
            this.SelectDate.Name = "SelectDate";
            // 
            // RiskForMould
            // 
            this.RiskForMould.DataPropertyName = "RiskForMould";
            this.RiskForMould.HeaderText = "Risk Level";
            this.RiskForMould.Name = "RiskForMould";
            // 
            // MouldIndex
            // 
            this.MouldIndex.DataPropertyName = "MouldIndex";
            this.MouldIndex.HeaderText = "Info";
            this.MouldIndex.Name = "MouldIndex";
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.Width = 125;
            // 
            // btnMoldRisk
            // 
            this.btnMoldRisk.Location = new System.Drawing.Point(52, 33);
            this.btnMoldRisk.Name = "btnMoldRisk";
            this.btnMoldRisk.Size = new System.Drawing.Size(75, 23);
            this.btnMoldRisk.TabIndex = 12;
            this.btnMoldRisk.Text = "Mold Risk";
            this.btnMoldRisk.UseVisualStyleBackColor = true;
            this.btnMoldRisk.Click += new System.EventHandler(this.btnMoldRisk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(780, 571);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.clear_Btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.load_Btn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.Browse_btn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avgTempAndHumidityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mouldRiskBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avgTempAndHumidityBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mouldRiskBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button Browse_btn;
        private TextBox txtFileName;
        private OpenFileDialog openFileDialog1;
        private BindingSource weatherBindingSource;
        private Button saveBtn;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn placeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tempDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn humidityDataGridViewTextBoxColumn;
        private Button load_Btn;
        private BindingSource bindingSource1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private Button clear_Btn;
        private Panel panel1;
        private Button btnnewAVG;
        private Button btnShowAvg;
        private DataGridView dataGridView2;
        private BindingSource avgTempAndHumidityBindingSource;
        private DataGridViewTextBoxColumn platsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn SelectDate;
        private DataGridViewTextBoxColumn RiskForMould;
        private DataGridViewTextBoxColumn MouldIndex;
        private DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private BindingSource mouldRiskBindingSource1;
        private DataGridViewTextBoxColumn selectDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn AverageHumidity;
        private DataGridViewTextBoxColumn AverageTemperature;
        private DataGridViewTextBoxColumn Location;
        private BindingSource avgTempAndHumidityBindingSource1;
        private BindingSource mouldRiskBindingSource;
        private Button btnMoldRisk;
    }
}