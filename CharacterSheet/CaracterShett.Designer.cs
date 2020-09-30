namespace CharacterSheet
{
    partial class FormCaracterSheet
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.imageCaracter = new System.Windows.Forms.PictureBox();
            this.PrenomInput = new System.Windows.Forms.TextBox();
            this.NomInput = new System.Windows.Forms.TextBox();
            this.ClasseInput = new System.Windows.Forms.TextBox();
            this.PrenomLabel = new System.Windows.Forms.Label();
            this.PVLabel = new System.Windows.Forms.Label();
            this.MCLabel = new System.Windows.Forms.Label();
            this.NomLabel = new System.Windows.Forms.Label();
            this.NiveauLabel = new System.Windows.Forms.Label();
            this.ClasseLabel = new System.Windows.Forms.Label();
            this.PvInput = new System.Windows.Forms.NumericUpDown();
            this.MCInput = new System.Windows.Forms.NumericUpDown();
            this.NiveauInput = new System.Windows.Forms.NumericUpDown();
            this.ImageImportButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageCaracter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PvInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MCInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NiveauInput)).BeginInit();
            this.SuspendLayout();
            // 
            // imageCaracter
            // 
            this.imageCaracter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imageCaracter.Location = new System.Drawing.Point(12, 12);
            this.imageCaracter.Name = "imageCaracter";
            this.imageCaracter.Size = new System.Drawing.Size(170, 94);
            this.imageCaracter.TabIndex = 0;
            this.imageCaracter.TabStop = false;
            // 
            // PrenomInput
            // 
            this.PrenomInput.Location = new System.Drawing.Point(206, 32);
            this.PrenomInput.Name = "PrenomInput";
            this.PrenomInput.Size = new System.Drawing.Size(140, 22);
            this.PrenomInput.TabIndex = 1;
            // 
            // NomInput
            // 
            this.NomInput.Location = new System.Drawing.Point(352, 32);
            this.NomInput.Name = "NomInput";
            this.NomInput.Size = new System.Drawing.Size(140, 22);
            this.NomInput.TabIndex = 2;
            // 
            // ClasseInput
            // 
            this.ClasseInput.Location = new System.Drawing.Point(498, 32);
            this.ClasseInput.Name = "ClasseInput";
            this.ClasseInput.Size = new System.Drawing.Size(140, 22);
            this.ClasseInput.TabIndex = 3;
            // 
            // PrenomLabel
            // 
            this.PrenomLabel.AutoSize = true;
            this.PrenomLabel.Location = new System.Drawing.Point(203, 12);
            this.PrenomLabel.Name = "PrenomLabel";
            this.PrenomLabel.Size = new System.Drawing.Size(57, 17);
            this.PrenomLabel.TabIndex = 7;
            this.PrenomLabel.Text = "Prenom";
            // 
            // PVLabel
            // 
            this.PVLabel.AutoSize = true;
            this.PVLabel.Location = new System.Drawing.Point(203, 64);
            this.PVLabel.Name = "PVLabel";
            this.PVLabel.Size = new System.Drawing.Size(26, 17);
            this.PVLabel.TabIndex = 8;
            this.PVLabel.Text = "PV";
            // 
            // MCLabel
            // 
            this.MCLabel.AutoSize = true;
            this.MCLabel.Location = new System.Drawing.Point(349, 64);
            this.MCLabel.Name = "MCLabel";
            this.MCLabel.Size = new System.Drawing.Size(28, 17);
            this.MCLabel.TabIndex = 9;
            this.MCLabel.Text = "MC";
            // 
            // NomLabel
            // 
            this.NomLabel.AutoSize = true;
            this.NomLabel.Location = new System.Drawing.Point(349, 12);
            this.NomLabel.Name = "NomLabel";
            this.NomLabel.Size = new System.Drawing.Size(37, 17);
            this.NomLabel.TabIndex = 10;
            this.NomLabel.Text = "Nom";
            // 
            // NiveauLabel
            // 
            this.NiveauLabel.AutoSize = true;
            this.NiveauLabel.Location = new System.Drawing.Point(495, 64);
            this.NiveauLabel.Name = "NiveauLabel";
            this.NiveauLabel.Size = new System.Drawing.Size(52, 17);
            this.NiveauLabel.TabIndex = 11;
            this.NiveauLabel.Text = "Niveau";
            // 
            // ClasseLabel
            // 
            this.ClasseLabel.AutoSize = true;
            this.ClasseLabel.Location = new System.Drawing.Point(495, 12);
            this.ClasseLabel.Name = "ClasseLabel";
            this.ClasseLabel.Size = new System.Drawing.Size(50, 17);
            this.ClasseLabel.TabIndex = 12;
            this.ClasseLabel.Text = "Classe";
            // 
            // PvInput
            // 
            this.PvInput.Location = new System.Drawing.Point(206, 84);
            this.PvInput.Name = "PvInput";
            this.PvInput.Size = new System.Drawing.Size(140, 22);
            this.PvInput.TabIndex = 13;
            // 
            // MCInput
            // 
            this.MCInput.Location = new System.Drawing.Point(352, 84);
            this.MCInput.Name = "MCInput";
            this.MCInput.Size = new System.Drawing.Size(140, 22);
            this.MCInput.TabIndex = 14;
            // 
            // NiveauInput
            // 
            this.NiveauInput.Location = new System.Drawing.Point(498, 84);
            this.NiveauInput.Name = "NiveauInput";
            this.NiveauInput.Size = new System.Drawing.Size(140, 22);
            this.NiveauInput.TabIndex = 15;
            // 
            // ImageImportButton
            // 
            this.ImageImportButton.Location = new System.Drawing.Point(12, 112);
            this.ImageImportButton.Name = "ImageImportButton";
            this.ImageImportButton.Size = new System.Drawing.Size(170, 27);
            this.ImageImportButton.TabIndex = 16;
            this.ImageImportButton.Text = "Import";
            this.ImageImportButton.UseVisualStyleBackColor = true;
            this.ImageImportButton.Click += new System.EventHandler(this.ImageImportButton_Click);
            // 
            // FormCaracterSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 363);
            this.Controls.Add(this.ImageImportButton);
            this.Controls.Add(this.NiveauInput);
            this.Controls.Add(this.MCInput);
            this.Controls.Add(this.PvInput);
            this.Controls.Add(this.ClasseLabel);
            this.Controls.Add(this.NiveauLabel);
            this.Controls.Add(this.NomLabel);
            this.Controls.Add(this.MCLabel);
            this.Controls.Add(this.PVLabel);
            this.Controls.Add(this.PrenomLabel);
            this.Controls.Add(this.ClasseInput);
            this.Controls.Add(this.NomInput);
            this.Controls.Add(this.PrenomInput);
            this.Controls.Add(this.imageCaracter);
            this.Name = "FormCaracterSheet";
            ((System.ComponentModel.ISupportInitialize)(this.imageCaracter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PvInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MCInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NiveauInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imageCaracter;
        private System.Windows.Forms.TextBox PrenomInput;
        private System.Windows.Forms.TextBox NomInput;
        private System.Windows.Forms.TextBox ClasseInput;
        private System.Windows.Forms.Label PrenomLabel;
        private System.Windows.Forms.Label PVLabel;
        private System.Windows.Forms.Label MCLabel;
        private System.Windows.Forms.Label NomLabel;
        private System.Windows.Forms.Label NiveauLabel;
        private System.Windows.Forms.Label ClasseLabel;
        private System.Windows.Forms.NumericUpDown PvInput;
        private System.Windows.Forms.NumericUpDown MCInput;
        private System.Windows.Forms.NumericUpDown NiveauInput;
        private System.Windows.Forms.Button ImageImportButton;
    }
}

