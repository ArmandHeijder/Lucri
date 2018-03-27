namespace OP3_Project_Lucri
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.wijknaamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wijkgemwozDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.huizenprijzenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oP3_Project_Lucri_DatabaseDataSet = new OP3_Project_Lucri.OP3_Project_Lucri_DatabaseDataSet();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.huizenprijzenTableAdapter = new OP3_Project_Lucri.OP3_Project_Lucri_DatabaseDataSetTableAdapters.HuizenprijzenTableAdapter();
            this.oP3_Project_Lucri_DatabaseDataSet1 = new OP3_Project_Lucri.OP3_Project_Lucri_DatabaseDataSet();
            this.tabControl1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.huizenprijzenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oP3_Project_Lucri_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oP3_Project_Lucri_DatabaseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 9);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(3545, 729);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.textBox1);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(3537, 700);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Home";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(36, 25);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(653, 310);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.chart1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(3537, 700);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Huizenprijzen";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wijknaamDataGridViewTextBoxColumn,
            this.wijkgemwozDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.huizenprijzenBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(8, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(592, 648);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // wijknaamDataGridViewTextBoxColumn
            // 
            this.wijknaamDataGridViewTextBoxColumn.DataPropertyName = "wijk_naam";
            this.wijknaamDataGridViewTextBoxColumn.HeaderText = "Wijken";
            this.wijknaamDataGridViewTextBoxColumn.Name = "wijknaamDataGridViewTextBoxColumn";
            // 
            // wijkgemwozDataGridViewTextBoxColumn
            // 
            this.wijkgemwozDataGridViewTextBoxColumn.DataPropertyName = "wijk_gem_woz";
            this.wijkgemwozDataGridViewTextBoxColumn.HeaderText = "Gemiddelde woningwaarde in euro x 1.000";
            this.wijkgemwozDataGridViewTextBoxColumn.Name = "wijkgemwozDataGridViewTextBoxColumn";
            // 
            // huizenprijzenBindingSource
            // 
            this.huizenprijzenBindingSource.DataMember = "Huizenprijzen";
            this.huizenprijzenBindingSource.DataSource = this.oP3_Project_Lucri_DatabaseDataSet;
            // 
            // oP3_Project_Lucri_DatabaseDataSet
            // 
            this.oP3_Project_Lucri_DatabaseDataSet.DataSetName = "OP3_Project_Lucri_DatabaseDataSet";
            this.oP3_Project_Lucri_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chart1
            // 
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Angle = -90;
            chartArea1.AxisX.Title = "Wijken";
            chartArea1.AxisY.Title = "Gemiddelde woningwaarde in euro x 1.000";
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.huizenprijzenBindingSource;
            legend1.Name = "Legend1";
            legend1.Position.Auto = false;
            legend1.Position.Height = 4.574132F;
            legend1.Position.Width = 4.629931F;
            legend1.Position.X = 1F;
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(567, 47);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Huizenprijzen";
            series1.XValueMember = "wijk_naam";
            series1.YValueMembers = "wijk_gem_woz";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(3068, 635);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(3537, 700);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Criminaliteit";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(3537, 700);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Recreatie";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(3537, 700);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Luchtkwaliteit";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // huizenprijzenTableAdapter
            // 
            this.huizenprijzenTableAdapter.ClearBeforeFill = true;
            // 
            // oP3_Project_Lucri_DatabaseDataSet1
            // 
            this.oP3_Project_Lucri_DatabaseDataSet1.DataSetName = "OP3_Project_Lucri_DatabaseDataSet";
            this.oP3_Project_Lucri_DatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1914, 768);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Huizenprijzen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.huizenprijzenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oP3_Project_Lucri_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oP3_Project_Lucri_DatabaseDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private OP3_Project_Lucri_DatabaseDataSet oP3_Project_Lucri_DatabaseDataSet;
        private System.Windows.Forms.BindingSource huizenprijzenBindingSource;
        private OP3_Project_Lucri_DatabaseDataSetTableAdapters.HuizenprijzenTableAdapter huizenprijzenTableAdapter;
        private OP3_Project_Lucri_DatabaseDataSet oP3_Project_Lucri_DatabaseDataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn wijknaamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wijkgemwozDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox textBox1;
    }
}

