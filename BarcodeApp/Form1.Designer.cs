namespace BarcodeApp
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
            txtEAN13 = new TextBox();
            btnGenerate = new Button();
            pictureBoxBarcode = new PictureBox();
            txtModelNumber = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            cmbModule = new ComboBox();
            btnExportIMG = new Button();
            btnExportPDF = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBarcode).BeginInit();
            SuspendLayout();
            // 
            // txtEAN13
            // 
            txtEAN13.Location = new Point(345, 38);
            txtEAN13.Name = "txtEAN13";
            txtEAN13.Size = new Size(163, 23);
            txtEAN13.TabIndex = 0;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(580, 80);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(92, 23);
            btnGenerate.TabIndex = 1;
            btnGenerate.Text = "generate me";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // pictureBoxBarcode
            // 
            pictureBoxBarcode.Location = new Point(107, 202);
            pictureBoxBarcode.Name = "pictureBoxBarcode";
            pictureBoxBarcode.Size = new Size(682, 322);
            pictureBoxBarcode.TabIndex = 2;
            pictureBoxBarcode.TabStop = false;
            // 
            // txtModelNumber
            // 
            txtModelNumber.Location = new Point(345, 137);
            txtModelNumber.Name = "txtModelNumber";
            txtModelNumber.Size = new Size(163, 23);
            txtModelNumber.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(230, 41);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 6;
            label1.Text = "BARCODE:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(230, 97);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 8;
            label3.Text = "MODULE:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(230, 138);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 9;
            label4.Text = "MODEL:";
            // 
            // cmbModule
            // 
            cmbModule.FormattingEnabled = true;
            cmbModule.Items.AddRange(new object[] { "5081", "5628", "3523", "5662" });
            cmbModule.Location = new Point(345, 97);
            cmbModule.Name = "cmbModule";
            cmbModule.Size = new Size(163, 23);
            cmbModule.TabIndex = 10;
            // 
            // btnExportIMG
            // 
            btnExportIMG.Location = new Point(580, 119);
            btnExportIMG.Name = "btnExportIMG";
            btnExportIMG.Size = new Size(120, 23);
            btnExportIMG.TabIndex = 11;
            btnExportIMG.Text = "export image";
            btnExportIMG.UseVisualStyleBackColor = true;
            btnExportIMG.Click += btnExportIMG_Click;
            // 
            // btnExportPDF
            // 
            btnExportPDF.Location = new Point(580, 160);
            btnExportPDF.Name = "btnExportPDF";
            btnExportPDF.Size = new Size(75, 23);
            btnExportPDF.TabIndex = 12;
            btnExportPDF.Text = "export pdf";
            btnExportPDF.UseVisualStyleBackColor = true;
            btnExportPDF.Click += btnExportPDF_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 623);
            Controls.Add(btnExportPDF);
            Controls.Add(btnExportIMG);
            Controls.Add(cmbModule);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtModelNumber);
            Controls.Add(pictureBoxBarcode);
            Controls.Add(btnGenerate);
            Controls.Add(txtEAN13);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxBarcode).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEAN13;
        private Button btnGenerate;
        private PictureBox pictureBoxBarcode;
        private TextBox txtModelNumber;
        private Label label1;
        private Label label3;
        private Label label4;
        private ComboBox cmbModule;
        private Button btnExportIMG;
        private Button btnExportPDF;
    }
}