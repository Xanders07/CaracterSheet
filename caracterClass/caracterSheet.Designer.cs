namespace caracterClass
{
    partial class caracterSheet
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameCaracter = new System.Windows.Forms.TextBox();
            this.surnameCaracter = new System.Windows.Forms.TextBox();
            this.levelCaracter = new System.Windows.Forms.TextBox();
            this.classCaracter = new System.Windows.Forms.TextBox();
            this.PVCaracter = new System.Windows.Forms.TextBox();
            this.MCCaracter = new System.Windows.Forms.TextBox();
            this.PV = new System.Windows.Forms.Label();
            this.MC = new System.Windows.Forms.Label();
            this.surname = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.level = new System.Windows.Forms.Label();
            this.classNameCaracter = new System.Windows.Forms.Label();
            this.imageCaracter = new System.Windows.Forms.PictureBox();
            this.importImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageCaracter)).BeginInit();
            this.SuspendLayout();
            // 
            // nameCaracter
            // 
            this.nameCaracter.Location = new System.Drawing.Point(298, 48);
            this.nameCaracter.Name = "nameCaracter";
            this.nameCaracter.Size = new System.Drawing.Size(179, 27);
            this.nameCaracter.TabIndex = 0;
            this.nameCaracter.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // surnameCaracter
            // 
            this.surnameCaracter.Location = new System.Drawing.Point(483, 48);
            this.surnameCaracter.Name = "surnameCaracter";
            this.surnameCaracter.Size = new System.Drawing.Size(179, 27);
            this.surnameCaracter.TabIndex = 0;
            this.surnameCaracter.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // levelCaracter
            // 
            this.levelCaracter.Location = new System.Drawing.Point(668, 48);
            this.levelCaracter.Name = "levelCaracter";
            this.levelCaracter.Size = new System.Drawing.Size(62, 27);
            this.levelCaracter.TabIndex = 0;
            this.levelCaracter.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // classCaracter
            // 
            this.classCaracter.Location = new System.Drawing.Point(736, 48);
            this.classCaracter.Name = "classCaracter";
            this.classCaracter.Size = new System.Drawing.Size(179, 27);
            this.classCaracter.TabIndex = 0;
            this.classCaracter.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PVCaracter
            // 
            this.PVCaracter.Location = new System.Drawing.Point(298, 101);
            this.PVCaracter.Name = "PVCaracter";
            this.PVCaracter.Size = new System.Drawing.Size(179, 27);
            this.PVCaracter.TabIndex = 0;
            this.PVCaracter.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // MCCaracter
            // 
            this.MCCaracter.Location = new System.Drawing.Point(483, 101);
            this.MCCaracter.Name = "MCCaracter";
            this.MCCaracter.Size = new System.Drawing.Size(179, 27);
            this.MCCaracter.TabIndex = 0;
            this.MCCaracter.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PV
            // 
            this.PV.AutoSize = true;
            this.PV.Location = new System.Drawing.Point(298, 78);
            this.PV.Name = "PV";
            this.PV.Size = new System.Drawing.Size(26, 20);
            this.PV.TabIndex = 1;
            this.PV.Text = "PV";
            // 
            // MC
            // 
            this.MC.AutoSize = true;
            this.MC.Location = new System.Drawing.Point(483, 78);
            this.MC.Name = "MC";
            this.MC.Size = new System.Drawing.Size(31, 20);
            this.MC.TabIndex = 1;
            this.MC.Text = "MC";
            // 
            // surname
            // 
            this.surname.AutoSize = true;
            this.surname.Location = new System.Drawing.Point(298, 25);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(60, 20);
            this.surname.TabIndex = 1;
            this.surname.Text = "Prenom";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(483, 25);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(42, 20);
            this.name.TabIndex = 1;
            this.name.Text = "Nom";
            // 
            // level
            // 
            this.level.AutoSize = true;
            this.level.Location = new System.Drawing.Point(668, 25);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(55, 20);
            this.level.TabIndex = 1;
            this.level.Text = "Niveau";
            // 
            // classNameCaracter
            // 
            this.classNameCaracter.AutoSize = true;
            this.classNameCaracter.Location = new System.Drawing.Point(736, 25);
            this.classNameCaracter.Name = "classNameCaracter";
            this.classNameCaracter.Size = new System.Drawing.Size(50, 20);
            this.classNameCaracter.TabIndex = 1;
            this.classNameCaracter.Text = "Classe";
            // 
            // imageCaracter
            // 
            this.imageCaracter.Location = new System.Drawing.Point(12, 23);
            this.imageCaracter.Name = "imageCaracter";
            this.imageCaracter.Size = new System.Drawing.Size(262, 111);
            this.imageCaracter.TabIndex = 2;
            this.imageCaracter.TabStop = false;
            // 
            // importImage
            // 
            this.importImage.Location = new System.Drawing.Point(64, 140);
            this.importImage.Name = "importImage";
            this.importImage.Size = new System.Drawing.Size(152, 29);
            this.importImage.TabIndex = 3;
            this.importImage.Text = "Import";
            this.importImage.UseVisualStyleBackColor = true;
            this.importImage.Click += new System.EventHandler(this.importImage_Click);
            // 
            // caracterSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1470, 749);
            this.Controls.Add(this.importImage);
            this.Controls.Add(this.imageCaracter);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.name);
            this.Controls.Add(this.level);
            this.Controls.Add(this.classNameCaracter);
            this.Controls.Add(this.PV);
            this.Controls.Add(this.MC);
            this.Controls.Add(this.nameCaracter);
            this.Controls.Add(this.surnameCaracter);
            this.Controls.Add(this.levelCaracter);
            this.Controls.Add(this.classCaracter);
            this.Controls.Add(this.PVCaracter);
            this.Controls.Add(this.MCCaracter);
            this.Name = "caracterSheet";
            this.Text = "caracter sheet";
            this.Load += new System.EventHandler(this.caracterSheet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageCaracter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameCaracter;
        private System.Windows.Forms.TextBox surnameCaracter;
        private System.Windows.Forms.TextBox levelCaracter;
        private System.Windows.Forms.TextBox classCaracter;
        private System.Windows.Forms.TextBox PVCaracter;
        private System.Windows.Forms.TextBox MCCaracter;
        private System.Windows.Forms.Label surname;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label level;
        private System.Windows.Forms.Label classNameCaracter;
        private System.Windows.Forms.Label PV;
        private System.Windows.Forms.Label MC;
        private System.Windows.Forms.PictureBox imageCaracter;
        private System.Windows.Forms.Button importImage;
    }
}

