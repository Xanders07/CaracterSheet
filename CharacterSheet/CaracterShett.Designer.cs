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
            this.dons = new System.Windows.Forms.TextBox();
            this.panelDons = new System.Windows.Forms.Panel();
            this.panelSorts = new System.Windows.Forms.Panel();
            this.sort = new System.Windows.Forms.TextBox();
            this.addDons = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageCaracter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PvInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MCInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NiveauInput)).BeginInit();
            this.panelDons.SuspendLayout();
            this.panelSorts.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageCaracter
            // 
            this.imageCaracter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imageCaracter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imageCaracter.Location = new System.Drawing.Point(17, 12);
            this.imageCaracter.Name = "imageCaracter";
            this.imageCaracter.Size = new System.Drawing.Size(215, 147);
            this.imageCaracter.TabIndex = 0;
            this.imageCaracter.TabStop = false;
            // 
            // PrenomInput
            // 
            this.PrenomInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PrenomInput.Location = new System.Drawing.Point(238, 38);
            this.PrenomInput.MaxLength = 1000;
            this.PrenomInput.Name = "PrenomInput";
            this.PrenomInput.Size = new System.Drawing.Size(243, 22);
            this.PrenomInput.TabIndex = 1;
            // 
            // NomInput
            // 
            this.NomInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NomInput.Location = new System.Drawing.Point(487, 38);
            this.NomInput.Name = "NomInput";
            this.NomInput.Size = new System.Drawing.Size(243, 22);
            this.NomInput.TabIndex = 2;
            // 
            // ClasseInput
            // 
            this.ClasseInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ClasseInput.Location = new System.Drawing.Point(736, 38);
            this.ClasseInput.Name = "ClasseInput";
            this.ClasseInput.Size = new System.Drawing.Size(246, 22);
            this.ClasseInput.TabIndex = 3;
            // 
            // PrenomLabel
            // 
            this.PrenomLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PrenomLabel.AutoSize = true;
            this.PrenomLabel.Location = new System.Drawing.Point(336, 18);
            this.PrenomLabel.Name = "PrenomLabel";
            this.PrenomLabel.Size = new System.Drawing.Size(57, 17);
            this.PrenomLabel.TabIndex = 7;
            this.PrenomLabel.Text = "Prenom";
            // 
            // PVLabel
            // 
            this.PVLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PVLabel.AutoSize = true;
            this.PVLabel.Location = new System.Drawing.Point(349, 82);
            this.PVLabel.Name = "PVLabel";
            this.PVLabel.Size = new System.Drawing.Size(26, 17);
            this.PVLabel.TabIndex = 8;
            this.PVLabel.Text = "PV";
            // 
            // MCLabel
            // 
            this.MCLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MCLabel.AutoSize = true;
            this.MCLabel.Location = new System.Drawing.Point(592, 82);
            this.MCLabel.Name = "MCLabel";
            this.MCLabel.Size = new System.Drawing.Size(28, 17);
            this.MCLabel.TabIndex = 9;
            this.MCLabel.Text = "MC";
            // 
            // NomLabel
            // 
            this.NomLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NomLabel.AutoSize = true;
            this.NomLabel.Location = new System.Drawing.Point(592, 18);
            this.NomLabel.Name = "NomLabel";
            this.NomLabel.Size = new System.Drawing.Size(37, 17);
            this.NomLabel.TabIndex = 10;
            this.NomLabel.Text = "Nom";
            // 
            // NiveauLabel
            // 
            this.NiveauLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NiveauLabel.AutoSize = true;
            this.NiveauLabel.Location = new System.Drawing.Point(839, 82);
            this.NiveauLabel.Name = "NiveauLabel";
            this.NiveauLabel.Size = new System.Drawing.Size(52, 17);
            this.NiveauLabel.TabIndex = 11;
            this.NiveauLabel.Text = "Niveau";
            // 
            // ClasseLabel
            // 
            this.ClasseLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ClasseLabel.AutoSize = true;
            this.ClasseLabel.Location = new System.Drawing.Point(841, 18);
            this.ClasseLabel.Name = "ClasseLabel";
            this.ClasseLabel.Size = new System.Drawing.Size(50, 17);
            this.ClasseLabel.TabIndex = 12;
            this.ClasseLabel.Text = "Classe";
            // 
            // PvInput
            // 
            this.PvInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PvInput.Location = new System.Drawing.Point(241, 102);
            this.PvInput.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.PvInput.Name = "PvInput";
            this.PvInput.Size = new System.Drawing.Size(240, 22);
            this.PvInput.TabIndex = 13;
            // 
            // MCInput
            // 
            this.MCInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MCInput.Location = new System.Drawing.Point(487, 102);
            this.MCInput.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.MCInput.Name = "MCInput";
            this.MCInput.Size = new System.Drawing.Size(243, 22);
            this.MCInput.TabIndex = 14;
            // 
            // NiveauInput
            // 
            this.NiveauInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NiveauInput.Location = new System.Drawing.Point(736, 102);
            this.NiveauInput.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NiveauInput.Name = "NiveauInput";
            this.NiveauInput.Size = new System.Drawing.Size(246, 22);
            this.NiveauInput.TabIndex = 15;
            // 
            // ImageImportButton
            // 
            this.ImageImportButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ImageImportButton.Location = new System.Drawing.Point(17, 165);
            this.ImageImportButton.Name = "ImageImportButton";
            this.ImageImportButton.Size = new System.Drawing.Size(215, 27);
            this.ImageImportButton.TabIndex = 16;
            this.ImageImportButton.Text = "Import";
            this.ImageImportButton.UseVisualStyleBackColor = true;
            this.ImageImportButton.Click += new System.EventHandler(this.ImageImportButton_Click);
            // 
            // dons
            // 
            this.dons.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dons.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dons.Location = new System.Drawing.Point(-1, -1);
            this.dons.Name = "dons";
            this.dons.ReadOnly = true;
            this.dons.Size = new System.Drawing.Size(492, 30);
            this.dons.TabIndex = 21;
            this.dons.Text = "Dons";
            this.dons.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelDons
            // 
            this.panelDons.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelDons.BackColor = System.Drawing.SystemColors.Window;
            this.panelDons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDons.Controls.Add(this.addDons);
            this.panelDons.Controls.Add(this.dons);
            this.panelDons.Location = new System.Drawing.Point(12, 223);
            this.panelDons.Name = "panelDons";
            this.panelDons.Size = new System.Drawing.Size(492, 170);
            this.panelDons.TabIndex = 20;
            // 
            // panelSorts
            // 
            this.panelSorts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelSorts.BackColor = System.Drawing.SystemColors.Window;
            this.panelSorts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSorts.Controls.Add(this.sort);
            this.panelSorts.Location = new System.Drawing.Point(515, 223);
            this.panelSorts.Name = "panelSorts";
            this.panelSorts.Size = new System.Drawing.Size(492, 170);
            this.panelSorts.TabIndex = 22;
            // 
            // sort
            // 
            this.sort.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sort.Location = new System.Drawing.Point(-1, -1);
            this.sort.Name = "sort";
            this.sort.ReadOnly = true;
            this.sort.Size = new System.Drawing.Size(492, 30);
            this.sort.TabIndex = 21;
            this.sort.Text = "Sorts";
            this.sort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addDons
            // 
            this.addDons.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDons.Location = new System.Drawing.Point(450, 35);
            this.addDons.Name = "addDons";
            this.addDons.Size = new System.Drawing.Size(37, 37);
            this.addDons.TabIndex = 22;
            this.addDons.Text = "+";
            this.addDons.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addDons.UseVisualStyleBackColor = true;
            // 
            // FormCaracterSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1020, 449);
            this.Controls.Add(this.panelSorts);
            this.Controls.Add(this.panelDons);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.imageCaracter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PvInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MCInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NiveauInput)).EndInit();
            this.panelDons.ResumeLayout(false);
            this.panelDons.PerformLayout();
            this.panelSorts.ResumeLayout(false);
            this.panelSorts.PerformLayout();
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
        private System.Windows.Forms.TextBox dons;
        private System.Windows.Forms.Panel panelDons;
        private System.Windows.Forms.Panel panelSorts;
        private System.Windows.Forms.TextBox sort;
        private System.Windows.Forms.Button addDons;
    }
}

