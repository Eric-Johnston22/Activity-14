using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            // Get image string from listbox
            string selectedImage = listBox_images.SelectedItem.ToString();

            // Display image to picture box
            this.pictureBox1.Image = Image.FromFile(@"C:\Users\ejohn\source\repos\Grand Canyon University\CST-150\Activity 14\images\" + selectedImage + ".jpg");

            // Change form colors
            if (radio_lightmode.Checked)
            {
                this.BackColor = SystemColors.Control;
                this.ForeColor = SystemColors.ControlText;
            }
            if (radio_darkmode.Checked)
            {
                this.BackColor = SystemColors.Desktop;
                this.ForeColor = SystemColors.ButtonShadow;
            }

            // Display name of image
            if(checkBox_name.Checked)
            {
                lbl_name.Text = selectedImage + ".jpg";
            }
            // Display date
            if(checkBox_date.Checked)
            {
                lbl_date.Text = DateTime.Now.ToString();
            }
        }
    }
}
