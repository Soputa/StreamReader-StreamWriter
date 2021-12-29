
namespace RainfallCalculator
{
    partial class Rainfall_Calculator
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
            this.labelValidRows = new System.Windows.Forms.Label();
            this.labelTotalRows = new System.Windows.Forms.Label();
            this.labelHighestValue = new System.Windows.Forms.Label();
            this.labelLowestValue = new System.Windows.Forms.Label();
            this.labelAverageRainfall = new System.Windows.Forms.Label();
            this.buttonImport = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.textBoxTotalRows = new System.Windows.Forms.TextBox();
            this.textBoxHighestValue = new System.Windows.Forms.TextBox();
            this.textBoxLowestValue = new System.Windows.Forms.TextBox();
            this.textBoxAverageRainfall = new System.Windows.Forms.TextBox();
            this.textBoxValidRows = new System.Windows.Forms.TextBox();
            this.buttonSaveFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelValidRows
            // 
            this.labelValidRows.AutoSize = true;
            this.labelValidRows.Location = new System.Drawing.Point(66, 128);
            this.labelValidRows.Name = "labelValidRows";
            this.labelValidRows.Size = new System.Drawing.Size(63, 13);
            this.labelValidRows.TabIndex = 1;
            this.labelValidRows.Text = "Valid Rows:";
            // 
            // labelTotalRows
            // 
            this.labelTotalRows.AutoSize = true;
            this.labelTotalRows.Location = new System.Drawing.Point(66, 185);
            this.labelTotalRows.Name = "labelTotalRows";
            this.labelTotalRows.Size = new System.Drawing.Size(64, 13);
            this.labelTotalRows.TabIndex = 2;
            this.labelTotalRows.Text = "Total Rows:";
            // 
            // labelHighestValue
            // 
            this.labelHighestValue.AutoSize = true;
            this.labelHighestValue.Location = new System.Drawing.Point(66, 238);
            this.labelHighestValue.Name = "labelHighestValue";
            this.labelHighestValue.Size = new System.Drawing.Size(76, 13);
            this.labelHighestValue.TabIndex = 3;
            this.labelHighestValue.Text = "Highest Value:";
            // 
            // labelLowestValue
            // 
            this.labelLowestValue.AutoSize = true;
            this.labelLowestValue.Location = new System.Drawing.Point(66, 283);
            this.labelLowestValue.Name = "labelLowestValue";
            this.labelLowestValue.Size = new System.Drawing.Size(74, 13);
            this.labelLowestValue.TabIndex = 4;
            this.labelLowestValue.Text = "Lowest Value:";
            // 
            // labelAverageRainfall
            // 
            this.labelAverageRainfall.AutoSize = true;
            this.labelAverageRainfall.Location = new System.Drawing.Point(66, 327);
            this.labelAverageRainfall.Name = "labelAverageRainfall";
            this.labelAverageRainfall.Size = new System.Drawing.Size(88, 13);
            this.labelAverageRainfall.TabIndex = 5;
            this.labelAverageRainfall.Text = "Average Rainfall:";
            // 
            // buttonImport
            // 
            this.buttonImport.Location = new System.Drawing.Point(106, 390);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(75, 23);
            this.buttonImport.TabIndex = 6;
            this.buttonImport.Text = "Import";
            this.buttonImport.UseVisualStyleBackColor = true;
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(419, 390);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 7;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // textBoxTotalRows
            // 
            this.textBoxTotalRows.Location = new System.Drawing.Point(170, 185);
            this.textBoxTotalRows.Name = "textBoxTotalRows";
            this.textBoxTotalRows.Size = new System.Drawing.Size(100, 20);
            this.textBoxTotalRows.TabIndex = 9;
            // 
            // textBoxHighestValue
            // 
            this.textBoxHighestValue.Location = new System.Drawing.Point(170, 238);
            this.textBoxHighestValue.Name = "textBoxHighestValue";
            this.textBoxHighestValue.Size = new System.Drawing.Size(100, 20);
            this.textBoxHighestValue.TabIndex = 10;
            // 
            // textBoxLowestValue
            // 
            this.textBoxLowestValue.Location = new System.Drawing.Point(170, 283);
            this.textBoxLowestValue.Name = "textBoxLowestValue";
            this.textBoxLowestValue.Size = new System.Drawing.Size(100, 20);
            this.textBoxLowestValue.TabIndex = 11;
            // 
            // textBoxAverageRainfall
            // 
            this.textBoxAverageRainfall.Location = new System.Drawing.Point(170, 327);
            this.textBoxAverageRainfall.Name = "textBoxAverageRainfall";
            this.textBoxAverageRainfall.Size = new System.Drawing.Size(100, 20);
            this.textBoxAverageRainfall.TabIndex = 12;
            // 
            // textBoxValidRows
            // 
            this.textBoxValidRows.Location = new System.Drawing.Point(170, 128);
            this.textBoxValidRows.Name = "textBoxValidRows";
            this.textBoxValidRows.Size = new System.Drawing.Size(100, 20);
            this.textBoxValidRows.TabIndex = 13;
            // 
            // buttonSaveFile
            // 
            this.buttonSaveFile.Location = new System.Drawing.Point(270, 390);
            this.buttonSaveFile.Name = "buttonSaveFile";
            this.buttonSaveFile.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveFile.TabIndex = 14;
            this.buttonSaveFile.Text = "Save";
            this.buttonSaveFile.UseVisualStyleBackColor = true;
            this.buttonSaveFile.Click += new System.EventHandler(this.buttonSaveFile_Click);
            // 
            // Rainfall_Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSaveFile);
            this.Controls.Add(this.textBoxValidRows);
            this.Controls.Add(this.textBoxAverageRainfall);
            this.Controls.Add(this.textBoxLowestValue);
            this.Controls.Add(this.textBoxHighestValue);
            this.Controls.Add(this.textBoxTotalRows);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonImport);
            this.Controls.Add(this.labelAverageRainfall);
            this.Controls.Add(this.labelLowestValue);
            this.Controls.Add(this.labelHighestValue);
            this.Controls.Add(this.labelTotalRows);
            this.Controls.Add(this.labelValidRows);
            this.Name = "Rainfall_Calculator";
            this.Text = "Rainfall Calculator";
            this.Load += new System.EventHandler(this.Rainfall_Calculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelValidRows;
        private System.Windows.Forms.Label labelTotalRows;
        private System.Windows.Forms.Label labelHighestValue;
        private System.Windows.Forms.Label labelLowestValue;
        private System.Windows.Forms.Label labelAverageRainfall;
        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TextBox textBoxTotalRows;
        private System.Windows.Forms.TextBox textBoxHighestValue;
        private System.Windows.Forms.TextBox textBoxLowestValue;
        private System.Windows.Forms.TextBox textBoxAverageRainfall;
        private System.Windows.Forms.TextBox textBoxValidRows;
        private System.Windows.Forms.Button buttonSaveFile;
    }
}

