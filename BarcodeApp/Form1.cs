using BarcodeLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarcodeApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            const string DI = "DI";
            string modelNumber = txtModelNumber.Text.Trim();
            string module = cmbModule.Text.Trim();
            string ean13 = txtEAN13.Text.Trim();

            // strict 13 digits only
            if (ean13.Length != 13)
            {
                MessageBox.Show("EAN-13 must have exactly 13 digits.",
                    "Invalid Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // strict numbers only
            if (!ean13.All(char.IsDigit))
            {
                MessageBox.Show("EAN-13 must contain digits only.",
                    "Invalid Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Format barcode ID: 1234567 12345 1
            string formattedEAN =
                $"{ean13.Substring(0, 7)} {ean13.Substring(7, 5)} {ean13.Substring(12, 1)}";

            try
            {
                Barcode barcode = new Barcode();
                barcode.IncludeLabel = false; // remove default text
                barcode.Alignment = AlignmentPositions.CENTER;

                Image barcodeImage =
                    barcode.Encode(TYPE.EAN13, ean13, Color.Black, Color.White, 500, 180);

                Bitmap finalImage =
                    new Bitmap(barcodeImage.Width + 40, barcodeImage.Height + 150);

                using (Graphics g = Graphics.FromImage(finalImage))
                {
                    g.Clear(Color.White);

                    // Top Left (Model Name)
                    using (Font font = new Font("OCR-B", 20, FontStyle.Bold))
                    {
                        g.DrawString(modelNumber, font, Brushes.Black, new PointF(10, 5));
                    }

                    // Box Module
                    using (Font font = new Font("OCR-B", 20, FontStyle.Bold))
                    {
                        SizeF textSize = g.MeasureString(module, font);
                        RectangleF rect =
                            new RectangleF(10, 35, textSize.Width + 10, textSize.Height + 5);

                        g.DrawRectangle(Pens.Black, rect.X, rect.Y, rect.Width, rect.Height);
                        g.DrawString(module, font, Brushes.Black,
                            new PointF(rect.X + 5, rect.Y + 2));
                    }

                    // Top Right (DI)
                    using (Font font = new Font("OCR-B", 20, FontStyle.Bold))
                    {
                        SizeF textSize = g.MeasureString(DI, font);
                        g.DrawString(DI, font, Brushes.Black,
                            new PointF(finalImage.Width - textSize.Width - 10, 35));
                    }

                    // Draw Barcode
                    int barcodeX = 20;
                    int barcodeY = 80;

                    g.DrawImage(barcodeImage, new Point(barcodeX, barcodeY));

                    using (Font font = new Font("OCR-B", 20, FontStyle.Bold))
                    {
                        float textY = barcodeY + barcodeImage.Height + 5;

                        char[] chars = formattedEAN.ToCharArray();
                        int charCount = chars.Length;

                        float totalWidth = barcodeImage.Width;
                        float firstCharWidth = g.MeasureString(chars[0].ToString(), font).Width;
                        float lastCharWidth = g.MeasureString(chars[charCount - 1].ToString(), font).Width;
                        float usableWidth = totalWidth - lastCharWidth;
                        float spacing = usableWidth / (charCount - 1);

                        for (int i = 0; i < charCount; i++)
                        {
                            float x = barcodeX + (spacing * i);
                            g.DrawString(chars[i].ToString(), font, Brushes.Black, x, textY);
                        }
                    }
                }

                pictureBoxBarcode.Image = finalImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating barcode: " + ex.Message);
            }
        }
    }
}
