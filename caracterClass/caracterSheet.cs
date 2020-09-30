using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caracterClass
{
    public partial class caracterSheet : Form
    {
        public caracterSheet()
        {
            InitializeComponent();
        }

        private void caracterSheet_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void importImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JPeg|*.jpg";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(dialog.FileName);

                image = resizeImage(image, new Size(262, 111));

                imageCaracter.Image = image;


                //Set the SizeMode to center the image.
                this.imageCaracter.SizeMode = PictureBoxSizeMode.CenterImage;

                // Set the border style to a three-dimensional border.
                this.imageCaracter.BorderStyle = BorderStyle.Fixed3D;
            }

        }
        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

    }
}
