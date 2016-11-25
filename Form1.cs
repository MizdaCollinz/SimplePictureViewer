using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
	public partial class Form1 : Form
	{
        Color bgColor = Color.AliceBlue;
		public Form1()
		{
			InitializeComponent();
		}

		private void setBGButton_Click(object sender, EventArgs e)
		{
            //Code to run when Background Colour is pressed

            //Show color dialog box, OK -> Change to the chosen color
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                bgColor = colorDialog1.Color;
                tableLayoutPanel1.Refresh();
		}

        private void showPictureButton_Click(object sender, EventArgs e)
        {
            //Code to run when Show Picture is pressed
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
               
            }
        }

        private void clearPictureButton_Click(object sender, EventArgs e)
        {
            //Code to run when clear the picture button is pressed
            pictureBox1.Image = null;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            //Code to run when close is pressed
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //Code to run when the Checkbox is toggled

            //If toggled on - Change picturebox sizemode to stretch
            if (checkBox1.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            //If toggled off - Change sizemode to normal
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;

        }     

        private void tableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if(e.Row == 0)
            {
                var b = new SolidBrush(bgColor);
                e.Graphics.FillRectangle(b, e.CellBounds);
            }
        }
    }
}
