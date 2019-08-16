namespace BI_coursework
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstGetFromFactTable = new System.Windows.Forms.ListBox();
            this.btnBuildFactTable = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGetDatesDimension = new System.Windows.Forms.Button();
            this.lstGetProductsDimension = new System.Windows.Forms.ListBox();
            this.lstGetDatesDimension = new System.Windows.Forms.ListBox();
            this.btnGetProductsDimension = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGetDates = new System.Windows.Forms.Button();
            this.btnGetProducts = new System.Windows.Forms.Button();
            this.lstGetProducts = new System.Windows.Forms.ListBox();
            this.lstGetDates = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.chtColumn = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chtLine = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtColumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtLine)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(780, 412);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ETL";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstGetFromFactTable);
            this.groupBox3.Controls.Add(this.btnBuildFactTable);
            this.groupBox3.Location = new System.Drawing.Point(524, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(169, 385);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fact Table";
            // 
            // lstGetFromFactTable
            // 
            this.lstGetFromFactTable.FormattingEnabled = true;
            this.lstGetFromFactTable.HorizontalScrollbar = true;
            this.lstGetFromFactTable.Location = new System.Drawing.Point(17, 103);
            this.lstGetFromFactTable.Name = "lstGetFromFactTable";
            this.lstGetFromFactTable.Size = new System.Drawing.Size(136, 264);
            this.lstGetFromFactTable.TabIndex = 13;
            // 
            // btnBuildFactTable
            // 
            this.btnBuildFactTable.Location = new System.Drawing.Point(17, 31);
            this.btnBuildFactTable.Name = "btnBuildFactTable";
            this.btnBuildFactTable.Size = new System.Drawing.Size(136, 63);
            this.btnBuildFactTable.TabIndex = 11;
            this.btnBuildFactTable.Text = "Build Fact Table";
            this.btnBuildFactTable.UseVisualStyleBackColor = true;
            this.btnBuildFactTable.Click += new System.EventHandler(this.btnBuildFactTable_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGetDatesDimension);
            this.groupBox2.Controls.Add(this.lstGetProductsDimension);
            this.groupBox2.Controls.Add(this.lstGetDatesDimension);
            this.groupBox2.Controls.Add(this.btnGetProductsDimension);
            this.groupBox2.Location = new System.Drawing.Point(215, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(303, 385);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Database Data";
            // 
            // btnGetDatesDimension
            // 
            this.btnGetDatesDimension.Location = new System.Drawing.Point(20, 32);
            this.btnGetDatesDimension.Name = "btnGetDatesDimension";
            this.btnGetDatesDimension.Size = new System.Drawing.Size(266, 40);
            this.btnGetDatesDimension.TabIndex = 7;
            this.btnGetDatesDimension.Text = "Get Dates From Dimesion";
            this.btnGetDatesDimension.UseVisualStyleBackColor = true;
            this.btnGetDatesDimension.Click += new System.EventHandler(this.btnGetDatesDimension_Click);
            // 
            // lstGetProductsDimension
            // 
            this.lstGetProductsDimension.FormattingEnabled = true;
            this.lstGetProductsDimension.HorizontalScrollbar = true;
            this.lstGetProductsDimension.Location = new System.Drawing.Point(20, 259);
            this.lstGetProductsDimension.Name = "lstGetProductsDimension";
            this.lstGetProductsDimension.Size = new System.Drawing.Size(266, 108);
            this.lstGetProductsDimension.TabIndex = 10;
            // 
            // lstGetDatesDimension
            // 
            this.lstGetDatesDimension.FormattingEnabled = true;
            this.lstGetDatesDimension.HorizontalScrollbar = true;
            this.lstGetDatesDimension.Location = new System.Drawing.Point(20, 78);
            this.lstGetDatesDimension.Name = "lstGetDatesDimension";
            this.lstGetDatesDimension.Size = new System.Drawing.Size(266, 108);
            this.lstGetDatesDimension.TabIndex = 8;
            // 
            // btnGetProductsDimension
            // 
            this.btnGetProductsDimension.Location = new System.Drawing.Point(20, 201);
            this.btnGetProductsDimension.Name = "btnGetProductsDimension";
            this.btnGetProductsDimension.Size = new System.Drawing.Size(266, 42);
            this.btnGetProductsDimension.TabIndex = 9;
            this.btnGetProductsDimension.Text = "Get Products From Dimension";
            this.btnGetProductsDimension.UseVisualStyleBackColor = true;
            this.btnGetProductsDimension.Click += new System.EventHandler(this.btnGetProductsDimension_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGetDates);
            this.groupBox1.Controls.Add(this.btnGetProducts);
            this.groupBox1.Controls.Add(this.lstGetProducts);
            this.groupBox1.Controls.Add(this.lstGetDates);
            this.groupBox1.Location = new System.Drawing.Point(8, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 385);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Source Data";
            // 
            // btnGetDates
            // 
            this.btnGetDates.Location = new System.Drawing.Point(6, 31);
            this.btnGetDates.Name = "btnGetDates";
            this.btnGetDates.Size = new System.Drawing.Size(188, 41);
            this.btnGetDates.TabIndex = 3;
            this.btnGetDates.Text = "Get Dates From Source";
            this.btnGetDates.UseVisualStyleBackColor = true;
            this.btnGetDates.Click += new System.EventHandler(this.btnGetDates_Click);
            // 
            // btnGetProducts
            // 
            this.btnGetProducts.Location = new System.Drawing.Point(6, 201);
            this.btnGetProducts.Name = "btnGetProducts";
            this.btnGetProducts.Size = new System.Drawing.Size(188, 42);
            this.btnGetProducts.TabIndex = 5;
            this.btnGetProducts.Text = "Get Products From Source";
            this.btnGetProducts.UseVisualStyleBackColor = true;
            this.btnGetProducts.Click += new System.EventHandler(this.btnGetProducts_Click);
            // 
            // lstGetProducts
            // 
            this.lstGetProducts.FormattingEnabled = true;
            this.lstGetProducts.Location = new System.Drawing.Point(6, 259);
            this.lstGetProducts.Name = "lstGetProducts";
            this.lstGetProducts.Size = new System.Drawing.Size(188, 108);
            this.lstGetProducts.TabIndex = 6;
            // 
            // lstGetDates
            // 
            this.lstGetDates.FormattingEnabled = true;
            this.lstGetDates.Location = new System.Drawing.Point(6, 78);
            this.lstGetDates.Name = "lstGetDates";
            this.lstGetDates.Size = new System.Drawing.Size(188, 108);
            this.lstGetDates.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(788, 438);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chtLine);
            this.tabPage2.Controls.Add(this.chtColumn);
            this.tabPage2.Controls.Add(this.btnLoadData);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(780, 412);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sales";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(9, 21);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(75, 23);
            this.btnLoadData.TabIndex = 0;
            this.btnLoadData.Text = "Load Data";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // chtColumn
            // 
            chartArea7.Name = "ChartArea1";
            this.chtColumn.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chtColumn.Legends.Add(legend7);
            this.chtColumn.Location = new System.Drawing.Point(9, 76);
            this.chtColumn.Name = "chtColumn";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.chtColumn.Series.Add(series7);
            this.chtColumn.Size = new System.Drawing.Size(300, 300);
            this.chtColumn.TabIndex = 1;
            this.chtColumn.Text = "chart1";
            // 
            // chtLine
            // 
            chartArea8.Name = "ChartArea1";
            this.chtLine.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chtLine.Legends.Add(legend8);
            this.chtLine.Location = new System.Drawing.Point(362, 90);
            this.chtLine.Name = "chtLine";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.chtLine.Series.Add(series8);
            this.chtLine.Size = new System.Drawing.Size(300, 300);
            this.chtLine.TabIndex = 2;
            this.chtLine.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 443);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chtColumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtLine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox lstGetFromFactTable;
        private System.Windows.Forms.Button btnBuildFactTable;
        private System.Windows.Forms.ListBox lstGetProductsDimension;
        private System.Windows.Forms.Button btnGetProductsDimension;
        private System.Windows.Forms.ListBox lstGetDatesDimension;
        private System.Windows.Forms.Button btnGetDatesDimension;
        private System.Windows.Forms.ListBox lstGetProducts;
        private System.Windows.Forms.Button btnGetProducts;
        private System.Windows.Forms.ListBox lstGetDates;
        private System.Windows.Forms.Button btnGetDates;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtLine;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtColumn;
    }
}