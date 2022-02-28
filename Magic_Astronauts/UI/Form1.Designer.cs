namespace Magic_Astronauts
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SelectDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RiskForMould = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MouldIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mouldRiskBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDateTimePicker = new System.Windows.Forms.Button();
            this.btnnewAVG = new System.Windows.Forms.Button();
            this.outsideForm = new System.Windows.Forms.ListView();
            this.btnMeteoro = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnMoldRisk = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.selectDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AverageHumidity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AverageTemperature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avgTempAndHumidityBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnShowAvg = new System.Windows.Forms.Button();
            this.avgTempAndHumidityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mouldRiskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelWinter = new System.Windows.Forms.Label();
            this.labelAutumn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mouldRiskBindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avgTempAndHumidityBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avgTempAndHumidityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mouldRiskBindingSource)).BeginInit();
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
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
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
            this.dataGridView1.Location = new System.Drawing.Point(265, 32);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(489, 236);
            this.dataGridView1.TabIndex = 9;
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
            // mouldRiskBindingSource1
            // 
            this.mouldRiskBindingSource1.DataSource = typeof(Magic_Astronauts.Core.MouldCalc);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnDateTimePicker);
            this.panel1.Controls.Add(this.btnnewAVG);
            this.panel1.Controls.Add(this.outsideForm);
            this.panel1.Controls.Add(this.btnMeteoro);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 573);
            this.panel1.TabIndex = 11;
            // 
            // btnDateTimePicker
            // 
            this.btnDateTimePicker.Location = new System.Drawing.Point(3, 99);
            this.btnDateTimePicker.Name = "btnDateTimePicker";
            this.btnDateTimePicker.Size = new System.Drawing.Size(210, 23);
            this.btnDateTimePicker.TabIndex = 21;
            this.btnDateTimePicker.Text = "Display Date Time Day";
            this.btnDateTimePicker.UseVisualStyleBackColor = true;
            this.btnDateTimePicker.Click += new System.EventHandler(this.btnDateTimePicker_Click);
            // 
            // btnnewAVG
            // 
            this.btnnewAVG.Location = new System.Drawing.Point(3, 4);
            this.btnnewAVG.Name = "btnnewAVG";
            this.btnnewAVG.Size = new System.Drawing.Size(219, 23);
            this.btnnewAVG.TabIndex = 12;
            this.btnnewAVG.Text = "Get Data To Database";
            this.btnnewAVG.UseVisualStyleBackColor = true;
            this.btnnewAVG.Click += new System.EventHandler(this.btnnewAVG_Click);
            // 
            // outsideForm
            // 
            this.outsideForm.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.outsideForm.Location = new System.Drawing.Point(3, 128);
            this.outsideForm.Name = "outsideForm";
            this.outsideForm.Size = new System.Drawing.Size(210, 97);
            this.outsideForm.TabIndex = 12;
            this.outsideForm.UseCompatibleStateImageBehavior = false;
            this.outsideForm.View = System.Windows.Forms.View.Details;
            this.outsideForm.SelectedIndexChanged += new System.EventHandler(this.outsideForm_SelectedIndexChanged);
            // 
            // btnMeteoro
            // 
            this.btnMeteoro.Location = new System.Drawing.Point(3, 33);
            this.btnMeteoro.Name = "btnMeteoro";
            this.btnMeteoro.Size = new System.Drawing.Size(219, 23);
            this.btnMeteoro.TabIndex = 20;
            this.btnMeteoro.Text = "Display Meteorology";
            this.btnMeteoro.UseVisualStyleBackColor = true;
            this.btnMeteoro.Click += new System.EventHandler(this.btnMeteoro_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.ButtonHighlight;
            this.dateTimePicker1.Location = new System.Drawing.Point(3, 70);
            this.dateTimePicker1.MaxDate = new System.DateTime(2016, 11, 30, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2016, 10, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(210, 23);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.Value = new System.DateTime(2016, 11, 30, 0, 0, 0, 0);
            // 
            // btnMoldRisk
            // 
            this.btnMoldRisk.Location = new System.Drawing.Point(265, 12);
            this.btnMoldRisk.Name = "btnMoldRisk";
            this.btnMoldRisk.Size = new System.Drawing.Size(489, 23);
            this.btnMoldRisk.TabIndex = 12;
            this.btnMoldRisk.Text = "Display Mold Risk";
            this.btnMoldRisk.UseVisualStyleBackColor = true;
            this.btnMoldRisk.Click += new System.EventHandler(this.btnMoldRisk_Click);
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
            this.dataGridView2.Location = new System.Drawing.Point(265, 295);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(489, 264);
            this.dataGridView2.TabIndex = 14;
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
            // avgTempAndHumidityBindingSource1
            // 
            this.avgTempAndHumidityBindingSource1.DataSource = typeof(Magic_Astronauts.Core.DailyCalc);
            // 
            // btnShowAvg
            // 
            this.btnShowAvg.Location = new System.Drawing.Point(265, 273);
            this.btnShowAvg.Name = "btnShowAvg";
            this.btnShowAvg.Size = new System.Drawing.Size(489, 23);
            this.btnShowAvg.TabIndex = 13;
            this.btnShowAvg.Text = "Display Average Data";
            this.btnShowAvg.UseVisualStyleBackColor = true;
            this.btnShowAvg.Click += new System.EventHandler(this.btnShowAvg_Click);
            // 
            // avgTempAndHumidityBindingSource
            // 
            this.avgTempAndHumidityBindingSource.DataSource = typeof(Magic_Astronauts.Core.DailyCalc);
            // 
            // mouldRiskBindingSource
            // 
            this.mouldRiskBindingSource.DataSource = typeof(Magic_Astronauts.Core.MouldCalc);
            // 
            // labelWinter
            // 
            this.labelWinter.AutoSize = true;
            this.labelWinter.Location = new System.Drawing.Point(366, 440);
            this.labelWinter.Name = "labelWinter";
            this.labelWinter.Size = new System.Drawing.Size(0, 15);
            this.labelWinter.TabIndex = 17;
            // 
            // labelAutumn
            // 
            this.labelAutumn.AutoSize = true;
            this.labelAutumn.Location = new System.Drawing.Point(366, 485);
            this.labelAutumn.Name = "labelAutumn";
            this.labelAutumn.Size = new System.Drawing.Size(0, 15);
            this.labelAutumn.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(780, 571);
            this.Controls.Add(this.btnShowAvg);
            this.Controls.Add(this.btnMoldRisk);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.labelAutumn);
            this.Controls.Add(this.labelWinter);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mouldRiskBindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avgTempAndHumidityBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avgTempAndHumidityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mouldRiskBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private OpenFileDialog openFileDialog1;
        private BindingSource weatherBindingSource;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn placeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tempDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn humidityDataGridViewTextBoxColumn;
        private BindingSource bindingSource1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
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
        private ListView outsideForm;
        private DateTimePicker dateTimePicker1;
        private Label labelWinter;
        private Label labelAutumn;
        private Button btnMeteoro;
        private Button btnDateTimePicker;
    }
}