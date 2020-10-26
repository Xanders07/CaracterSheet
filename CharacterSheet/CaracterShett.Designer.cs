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
            this.ArrayDons = new System.Windows.Forms.TableLayoutPanel();
            this.CoutLabel = new System.Windows.Forms.Label();
            this.ActionLabel = new System.Windows.Forms.Label();
            this.EffetLabel = new System.Windows.Forms.Label();
            this.DonsLabel = new System.Windows.Forms.Label();
            this.CoutInput = new System.Windows.Forms.RichTextBox();
            this.ActionInput = new System.Windows.Forms.RichTextBox();
            this.NomDonsInput = new System.Windows.Forms.RichTextBox();
            this.EffetInput = new System.Windows.Forms.RichTextBox();
            this.DonsAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageCaracter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PvInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MCInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NiveauInput)).BeginInit();
            this.ArrayDons.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageCaracter
            // 
            this.imageCaracter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imageCaracter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imageCaracter.Location = new System.Drawing.Point(12, 13);
            this.imageCaracter.Name = "imageCaracter";
            this.imageCaracter.Size = new System.Drawing.Size(319, 206);
            this.imageCaracter.TabIndex = 0;
            this.imageCaracter.TabStop = false;
            // 
            // PrenomInput
            // 
            this.PrenomInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PrenomInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrenomInput.Location = new System.Drawing.Point(349, 41);
            this.PrenomInput.MaxLength = 1000;
            this.PrenomInput.Name = "PrenomInput";
            this.PrenomInput.Size = new System.Drawing.Size(297, 30);
            this.PrenomInput.TabIndex = 1;
            this.PrenomInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NomInput
            // 
            this.NomInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NomInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomInput.Location = new System.Drawing.Point(661, 41);
            this.NomInput.Name = "NomInput";
            this.NomInput.Size = new System.Drawing.Size(297, 30);
            this.NomInput.TabIndex = 2;
            this.NomInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ClasseInput
            // 
            this.ClasseInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ClasseInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClasseInput.Location = new System.Drawing.Point(972, 41);
            this.ClasseInput.Name = "ClasseInput";
            this.ClasseInput.Size = new System.Drawing.Size(297, 30);
            this.ClasseInput.TabIndex = 3;
            this.ClasseInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PrenomLabel
            // 
            this.PrenomLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PrenomLabel.AutoSize = true;
            this.PrenomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrenomLabel.Location = new System.Drawing.Point(463, 13);
            this.PrenomLabel.Name = "PrenomLabel";
            this.PrenomLabel.Size = new System.Drawing.Size(80, 25);
            this.PrenomLabel.TabIndex = 7;
            this.PrenomLabel.Text = "Prenom";
            // 
            // PVLabel
            // 
            this.PVLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PVLabel.AutoSize = true;
            this.PVLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PVLabel.Location = new System.Drawing.Point(471, 91);
            this.PVLabel.Name = "PVLabel";
            this.PVLabel.Size = new System.Drawing.Size(39, 25);
            this.PVLabel.TabIndex = 8;
            this.PVLabel.Text = "PV";
            // 
            // MCLabel
            // 
            this.MCLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MCLabel.AutoSize = true;
            this.MCLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MCLabel.Location = new System.Drawing.Point(780, 91);
            this.MCLabel.Name = "MCLabel";
            this.MCLabel.Size = new System.Drawing.Size(44, 25);
            this.MCLabel.TabIndex = 9;
            this.MCLabel.Text = "MC";
            // 
            // NomLabel
            // 
            this.NomLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NomLabel.AutoSize = true;
            this.NomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomLabel.Location = new System.Drawing.Point(779, 13);
            this.NomLabel.Name = "NomLabel";
            this.NomLabel.Size = new System.Drawing.Size(53, 25);
            this.NomLabel.TabIndex = 10;
            this.NomLabel.Text = "Nom";
            // 
            // NiveauLabel
            // 
            this.NiveauLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NiveauLabel.AutoSize = true;
            this.NiveauLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NiveauLabel.Location = new System.Drawing.Point(1074, 91);
            this.NiveauLabel.Name = "NiveauLabel";
            this.NiveauLabel.Size = new System.Drawing.Size(73, 25);
            this.NiveauLabel.TabIndex = 11;
            this.NiveauLabel.Text = "Niveau";
            // 
            // ClasseLabel
            // 
            this.ClasseLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ClasseLabel.AutoSize = true;
            this.ClasseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClasseLabel.Location = new System.Drawing.Point(1082, 13);
            this.ClasseLabel.Name = "ClasseLabel";
            this.ClasseLabel.Size = new System.Drawing.Size(73, 25);
            this.ClasseLabel.TabIndex = 12;
            this.ClasseLabel.Text = "Classe";
            // 
            // PvInput
            // 
            this.PvInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PvInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PvInput.Location = new System.Drawing.Point(349, 119);
            this.PvInput.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.PvInput.Name = "PvInput";
            this.PvInput.Size = new System.Drawing.Size(297, 30);
            this.PvInput.TabIndex = 13;
            this.PvInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MCInput
            // 
            this.MCInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MCInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MCInput.Location = new System.Drawing.Point(661, 119);
            this.MCInput.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.MCInput.Name = "MCInput";
            this.MCInput.Size = new System.Drawing.Size(297, 30);
            this.MCInput.TabIndex = 14;
            this.MCInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NiveauInput
            // 
            this.NiveauInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NiveauInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NiveauInput.Location = new System.Drawing.Point(972, 119);
            this.NiveauInput.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NiveauInput.Name = "NiveauInput";
            this.NiveauInput.Size = new System.Drawing.Size(297, 30);
            this.NiveauInput.TabIndex = 15;
            this.NiveauInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ImageImportButton
            // 
            this.ImageImportButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ImageImportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImageImportButton.Location = new System.Drawing.Point(12, 225);
            this.ImageImportButton.Name = "ImageImportButton";
            this.ImageImportButton.Size = new System.Drawing.Size(323, 37);
            this.ImageImportButton.TabIndex = 16;
            this.ImageImportButton.Text = "Import";
            this.ImageImportButton.UseVisualStyleBackColor = true;
            this.ImageImportButton.Click += new System.EventHandler(this.ImageImportButton_Click);
            // 
            // ArrayDons
            // 
            this.ArrayDons.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ArrayDons.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ArrayDons.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.ArrayDons.ColumnCount = 4;
            this.ArrayDons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.96159F));
            this.ArrayDons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.03841F));
            this.ArrayDons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 287F));
            this.ArrayDons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 177F));
            this.ArrayDons.Controls.Add(this.CoutLabel, 3, 0);
            this.ArrayDons.Controls.Add(this.ActionLabel, 2, 0);
            this.ArrayDons.Controls.Add(this.EffetLabel, 1, 0);
            this.ArrayDons.Controls.Add(this.DonsLabel, 0, 0);
            this.ArrayDons.Controls.Add(this.CoutInput, 3, 1);
            this.ArrayDons.Controls.Add(this.ActionInput, 2, 1);
            this.ArrayDons.Controls.Add(this.NomDonsInput, 0, 1);
            this.ArrayDons.Controls.Add(this.EffetInput, 1, 1);
            this.ArrayDons.Location = new System.Drawing.Point(12, 290);
            this.ArrayDons.Name = "ArrayDons";
            this.ArrayDons.RowCount = 3;
            this.ArrayDons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.98551F));
            this.ArrayDons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.0145F));
            this.ArrayDons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ArrayDons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ArrayDons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ArrayDons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ArrayDons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ArrayDons.Size = new System.Drawing.Size(1216, 250);
            this.ArrayDons.TabIndex = 22;
            // 
            // CoutLabel
            // 
            this.CoutLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CoutLabel.AutoSize = true;
            this.CoutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoutLabel.Location = new System.Drawing.Point(1094, 19);
            this.CoutLabel.Name = "CoutLabel";
            this.CoutLabel.Size = new System.Drawing.Size(63, 29);
            this.CoutLabel.TabIndex = 32;
            this.CoutLabel.Text = "Cout";
            // 
            // ActionLabel
            // 
            this.ActionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ActionLabel.AutoSize = true;
            this.ActionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActionLabel.Location = new System.Drawing.Point(853, 19);
            this.ActionLabel.Name = "ActionLabel";
            this.ActionLabel.Size = new System.Drawing.Size(79, 29);
            this.ActionLabel.TabIndex = 31;
            this.ActionLabel.Text = "Action";
            // 
            // EffetLabel
            // 
            this.EffetLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EffetLabel.AutoSize = true;
            this.EffetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EffetLabel.Location = new System.Drawing.Point(456, 19);
            this.EffetLabel.Name = "EffetLabel";
            this.EffetLabel.Size = new System.Drawing.Size(61, 29);
            this.EffetLabel.TabIndex = 30;
            this.EffetLabel.Text = "Effet";
            // 
            // DonsLabel
            // 
            this.DonsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DonsLabel.AutoSize = true;
            this.DonsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonsLabel.Location = new System.Drawing.Point(78, 19);
            this.DonsLabel.Name = "DonsLabel";
            this.DonsLabel.Size = new System.Drawing.Size(69, 29);
            this.DonsLabel.TabIndex = 23;
            this.DonsLabel.Text = "Dons";
            // 
            // CoutInput
            // 
            this.CoutInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoutInput.Location = new System.Drawing.Point(1040, 70);
            this.CoutInput.Name = "CoutInput";
            this.CoutInput.Size = new System.Drawing.Size(168, 91);
            this.CoutInput.TabIndex = 29;
            this.CoutInput.Text = "";
            // 
            // ActionInput
            // 
            this.ActionInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActionInput.Location = new System.Drawing.Point(752, 70);
            this.ActionInput.Name = "ActionInput";
            this.ActionInput.Size = new System.Drawing.Size(281, 91);
            this.ActionInput.TabIndex = 28;
            this.ActionInput.Text = "";
            // 
            // NomDonsInput
            // 
            this.NomDonsInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomDonsInput.Location = new System.Drawing.Point(4, 70);
            this.NomDonsInput.Name = "NomDonsInput";
            this.NomDonsInput.Size = new System.Drawing.Size(217, 91);
            this.NomDonsInput.TabIndex = 26;
            this.NomDonsInput.Text = "";
            // 
            // EffetInput
            // 
            this.EffetInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EffetInput.Location = new System.Drawing.Point(228, 70);
            this.EffetInput.Name = "EffetInput";
            this.EffetInput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.EffetInput.Size = new System.Drawing.Size(517, 91);
            this.EffetInput.TabIndex = 27;
            this.EffetInput.Text = "";
            // 
            // DonsAdd
            // 
            this.DonsAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DonsAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonsAdd.Location = new System.Drawing.Point(1234, 368);
            this.DonsAdd.Name = "DonsAdd";
            this.DonsAdd.Size = new System.Drawing.Size(39, 32);
            this.DonsAdd.TabIndex = 23;
            this.DonsAdd.Text = "+";
            this.DonsAdd.UseCompatibleTextRendering = true;
            this.DonsAdd.UseVisualStyleBackColor = true;
            this.DonsAdd.Click += new System.EventHandler(this.DonsAdd_Click);
            // 
            // FormCaracterSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 648);
            this.Controls.Add(this.DonsAdd);
            this.Controls.Add(this.ArrayDons);
            this.Controls.Add(this.ImageImportButton);
            this.Controls.Add(this.NiveauInput);
            this.Controls.Add(this.MCInput);
            this.Controls.Add(this.PvInput);
            this.Controls.Add(this.PrenomLabel);
            this.Controls.Add(this.ClasseLabel);
            this.Controls.Add(this.NiveauLabel);
            this.Controls.Add(this.NomLabel);
            this.Controls.Add(this.MCLabel);
            this.Controls.Add(this.PVLabel);
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
            this.ArrayDons.ResumeLayout(false);
            this.ArrayDons.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel ArrayDons;
        private System.Windows.Forms.Label DonsLabel;
        private System.Windows.Forms.Label CoutLabel;
        private System.Windows.Forms.Label ActionLabel;
        private System.Windows.Forms.Label EffetLabel;
        private System.Windows.Forms.RichTextBox ActionInput;
        private System.Windows.Forms.RichTextBox NomDonsInput;
        private System.Windows.Forms.RichTextBox EffetInput;
        private System.Windows.Forms.RichTextBox CoutInput;
        private System.Windows.Forms.Button DonsAdd;
    }
}

