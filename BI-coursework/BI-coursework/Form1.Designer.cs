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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnBuildFactTable = new System.Windows.Forms.Button();
            this.lstGetProductsDimension = new System.Windows.Forms.ListBox();
            this.btnGetProductsDimension = new System.Windows.Forms.Button();
            this.lstGetDatesDimension = new System.Windows.Forms.ListBox();
            this.btnGetDatesDimension = new System.Windows.Forms.Button();
            this.lstGetProducts = new System.Windows.Forms.ListBox();
            this.btnGetProducts = new System.Windows.Forms.Button();
            this.lstGetDates = new System.Windows.Forms.ListBox();
            this.btnGetDates = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnGetFromFactTable = new System.Windows.Forms.Button();
            this.lstGetFromFactTable = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(788, 438);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lstGetFromFactTable);
            this.tabPage1.Controls.Add(this.btnGetFromFactTable);
            this.tabPage1.Controls.Add(this.btnBuildFactTable);
            this.tabPage1.Controls.Add(this.lstGetProductsDimension);
            this.tabPage1.Controls.Add(this.btnGetProductsDimension);
            this.tabPage1.Controls.Add(this.lstGetDatesDimension);
            this.tabPage1.Controls.Add(this.btnGetDatesDimension);
            this.tabPage1.Controls.Add(this.lstGetProducts);
            this.tabPage1.Controls.Add(this.btnGetProducts);
            this.tabPage1.Controls.Add(this.lstGetDates);
            this.tabPage1.Controls.Add(this.btnGetDates);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(780, 412);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ETL";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnBuildFactTable
            // 
            this.btnBuildFactTable.Location = new System.Drawing.Point(524, 7);
            this.btnBuildFactTable.Name = "btnBuildFactTable";
            this.btnBuildFactTable.Size = new System.Drawing.Size(120, 40);
            this.btnBuildFactTable.TabIndex = 11;
            this.btnBuildFactTable.Text = "Build Fact Table";
            this.btnBuildFactTable.UseVisualStyleBackColor = true;
            this.btnBuildFactTable.Click += new System.EventHandler(this.btnBuildFactTable_Click);
            // 
            // lstGetProductsDimension
            // 
            this.lstGetProductsDimension.FormattingEnabled = true;
            this.lstGetProductsDimension.HorizontalScrollbar = true;
            this.lstGetProductsDimension.Location = new System.Drawing.Point(227, 202);
            this.lstGetProductsDimension.Name = "lstGetProductsDimension";
            this.lstGetProductsDimension.Size = new System.Drawing.Size(266, 95);
            this.lstGetProductsDimension.TabIndex = 10;
            // 
            // btnGetProductsDimension
            // 
            this.btnGetProductsDimension.Location = new System.Drawing.Point(227, 155);
            this.btnGetProductsDimension.Name = "btnGetProductsDimension";
            this.btnGetProductsDimension.Size = new System.Drawing.Size(266, 41);
            this.btnGetProductsDimension.TabIndex = 9;
            this.btnGetProductsDimension.Text = "Get Products From Dimension";
            this.btnGetProductsDimension.UseVisualStyleBackColor = true;
            this.btnGetProductsDimension.Click += new System.EventHandler(this.btnGetProductsDimension_Click);
            // 
            // lstGetDatesDimension
            // 
            this.lstGetDatesDimension.FormattingEnabled = true;
            this.lstGetDatesDimension.HorizontalScrollbar = true;
            this.lstGetDatesDimension.Location = new System.Drawing.Point(227, 53);
            this.lstGetDatesDimension.Name = "lstGetDatesDimension";
            this.lstGetDatesDimension.Size = new System.Drawing.Size(266, 95);
            this.lstGetDatesDimension.TabIndex = 8;
            // 
            // btnGetDatesDimension
            // 
            this.btnGetDatesDimension.Location = new System.Drawing.Point(227, 7);
            this.btnGetDatesDimension.Name = "btnGetDatesDimension";
            this.btnGetDatesDimension.Size = new System.Drawing.Size(266, 40);
            this.btnGetDatesDimension.TabIndex = 7;
            this.btnGetDatesDimension.Text = "Get Dates From Dimesion";
            this.btnGetDatesDimension.UseVisualStyleBackColor = true;
            this.btnGetDatesDimension.Click += new System.EventHandler(this.btnGetDatesDimension_Click);
            // 
            // lstGetProducts
            // 
            this.lstGetProducts.FormattingEnabled = true;
            this.lstGetProducts.Location = new System.Drawing.Point(29, 202);
            this.lstGetProducts.Name = "lstGetProducts";
            this.lstGetProducts.Size = new System.Drawing.Size(100, 95);
            this.lstGetProducts.TabIndex = 6;
            // 
            // btnGetProducts
            // 
            this.btnGetProducts.Location = new System.Drawing.Point(29, 154);
            this.btnGetProducts.Name = "btnGetProducts";
            this.btnGetProducts.Size = new System.Drawing.Size(100, 42);
            this.btnGetProducts.TabIndex = 5;
            this.btnGetProducts.Text = "Get Products From Source";
            this.btnGetProducts.UseVisualStyleBackColor = true;
            this.btnGetProducts.Click += new System.EventHandler(this.btnGetProducts_Click);
            // 
            // lstGetDates
            // 
            this.lstGetDates.FormattingEnabled = true;
            this.lstGetDates.Location = new System.Drawing.Point(29, 53);
            this.lstGetDates.Name = "lstGetDates";
            this.lstGetDates.Size = new System.Drawing.Size(100, 95);
            this.lstGetDates.TabIndex = 4;
            // 
            // btnGetDates
            // 
            this.btnGetDates.Location = new System.Drawing.Point(29, 6);
            this.btnGetDates.Name = "btnGetDates";
            this.btnGetDates.Size = new System.Drawing.Size(100, 41);
            this.btnGetDates.TabIndex = 3;
            this.btnGetDates.Text = "Get Dates From Source";
            this.btnGetDates.UseVisualStyleBackColor = true;
            this.btnGetDates.Click += new System.EventHandler(this.btnGetDates_Click);
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
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(780, 412);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Dashboard 3";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnGetFromFactTable
            // 
            this.btnGetFromFactTable.Location = new System.Drawing.Point(524, 53);
            this.btnGetFromFactTable.Name = "btnGetFromFactTable";
            this.btnGetFromFactTable.Size = new System.Drawing.Size(120, 37);
            this.btnGetFromFactTable.TabIndex = 12;
            this.btnGetFromFactTable.Text = "Get From Fact Table";
            this.btnGetFromFactTable.UseVisualStyleBackColor = true;
            // 
            // lstGetFromFactTable
            // 
            this.lstGetFromFactTable.FormattingEnabled = true;
            this.lstGetFromFactTable.HorizontalScrollbar = true;
            this.lstGetFromFactTable.Location = new System.Drawing.Point(524, 101);
            this.lstGetFromFactTable.Name = "lstGetFromFactTable";
            this.lstGetFromFactTable.Size = new System.Drawing.Size(120, 199);
            this.lstGetFromFactTable.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListBox lstGetDates;
        private System.Windows.Forms.Button btnGetDates;
        private System.Windows.Forms.ListBox lstGetProducts;
        private System.Windows.Forms.Button btnGetProducts;
        private System.Windows.Forms.ListBox lstGetDatesDimension;
        private System.Windows.Forms.Button btnGetDatesDimension;
        private System.Windows.Forms.ListBox lstGetProductsDimension;
        private System.Windows.Forms.Button btnGetProductsDimension;
        private System.Windows.Forms.Button btnBuildFactTable;
        private System.Windows.Forms.ListBox lstGetFromFactTable;
        private System.Windows.Forms.Button btnGetFromFactTable;
    }
}