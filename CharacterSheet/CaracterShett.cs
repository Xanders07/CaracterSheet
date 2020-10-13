using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterSheet
{
    public partial class FormCaracterSheet : Form
    {
        public FormCaracterSheet()
        {
            InitializeComponent();

            this.NiveauInput.Controls[0].Visible = false;
            this.MCInput.Controls[0].Visible = false;
            this.PvInput.Controls[0].Visible = false;

            this.NiveauInput.Text = "";
            this.MCInput.Text = "";
            this.PvInput.Text = "";
        }

        private void ImageImportButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JPeg|*.jpg";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Image caracterImage = Image.FromFile(dialog.FileName);


                caracterImage = resizeImage(caracterImage, new Size(319, 206));

                imageCaracter.Image = caracterImage;
                //Set the SizeMode to center the image.
                this.imageCaracter.SizeMode = PictureBoxSizeMode.CenterImage;
            }

        }
        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }
    }
}
