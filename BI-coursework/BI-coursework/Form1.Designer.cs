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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnGetDates = new System.Windows.Forms.Button();
            this.lstGetDates = new System.Windows.Forms.ListBox();
            this.btnGetProducts = new System.Windows.Forms.Button();
            this.lstGetProducts = new System.Windows.Forms.ListBox();
            this.btnGetDatesDimension = new System.Windows.Forms.Button();
            this.lstGetDatesDimension = new System.Windows.Forms.ListBox();
            this.btnGetProductsDimension = new System.Windows.Forms.Button();
            this.lstGetProductsDimension = new System.Windows.Forms.ListBox();
            this.btnBuildFactTable = new System.Windows.Forms.Button();
            this.btnGetFromFactTable = new System.Windows.Forms.Button();
            this.lstGetFromFactTable = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(780, 412);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Dashboard 2";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(780, 412);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dashboard 1";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // lstGetDates
            // 
            this.lstGetDates.FormattingEnabled = true;
            this.lstGetDates.Location = new System.Drawing.Point(6, 78);
            this.lstGetDates.Name = "lstGetDates";
            this.lstGetDates.Size = new System.Drawing.Size(188, 108);
            this.lstGetDates.TabIndex = 4;
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
            // lstGetProductsDimension
            // 
            this.lstGetProductsDimension.FormattingEnabled = true;
            this.lstGetProductsDimension.HorizontalScrollbar = true;
            this.lstGetProductsDimension.Location = new System.Drawing.Point(20, 259);
            this.lstGetProductsDimension.Name = "lstGetProductsDimension";
            this.lstGetProductsDimension.Size = new System.Drawing.Size(266, 108);
            this.lstGetProductsDimension.TabIndex = 10;
            // 
            // btnBuildFactTable
            // 
            this.btnBuildFactTable.Location = new System.Drawing.Point(17, 78);
            this.btnBuildFactTable.Name = "btnBuildFactTable";
            this.btnBuildFactTable.Size = new System.Drawing.Size(136, 40);
            this.btnBuildFactTable.TabIndex = 11;
            this.btnBuildFactTable.Text = "Build Fact Table";
            this.btnBuildFactTable.UseVisualStyleBackColor = true;
            this.btnBuildFactTable.Click += new System.EventHandler(this.btnBuildFactTable_Click);
            // 
            // btnGetFromFactTable
            // 
            this.btnGetFromFactTable.Location = new System.Drawing.Point(17, 35);
            this.btnGetFromFactTable.Name = "btnGetFromFactTable";
            this.btnGetFromFactTable.Size = new System.Drawing.Size(136, 37);
            this.btnGetFromFactTable.TabIndex = 12;
            this.btnGetFromFactTable.Text = "Get From Fact Table";
            this.btnGetFromFactTable.UseVisualStyleBackColor = true;
            // 
            // lstGetFromFactTable
            // 
            this.lstGetFromFactTable.FormattingEnabled = true;
            this.lstGetFromFactTable.HorizontalScrollbar = true;
            this.lstGetFromFactTable.Location = new System.Drawing.Point(17, 129);
            this.lstGetFromFactTable.Name = "lstGetFromFactTable";
            this.lstGetFromFactTable.Size = new System.Drawing.Size(136, 238);
            this.lstGetFromFactTable.TabIndex = 13;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(788, 438);
            this.tabControl1.TabIndex = 0;
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnGetFromFactTable);
            this.groupBox3.Controls.Add(this.lstGetFromFactTable);
            this.groupBox3.Controls.Add(this.btnBuildFactTable);
            this.groupBox3.Location = new System.Drawing.Point(524, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(169, 385);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fact Table";
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
            this.tabControl1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox lstGetFromFactTable;
        private System.Windows.Forms.Button btnGetFromFactTable;
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
    }
}