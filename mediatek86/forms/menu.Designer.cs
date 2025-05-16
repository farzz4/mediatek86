namespace mediatek86.forms
{
    partial class menu
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
            btnGestionPersonnel = new Button();
            btnGestionAbsence = new Button();
            btnDeconnexion = new Button();
            SuspendLayout();
            // 
            // btnGestionPersonnel
            // 
            btnGestionPersonnel.BackColor = Color.Firebrick;
            btnGestionPersonnel.Font = new Font("Segoe Print", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnGestionPersonnel.Location = new Point(12, 12);
            btnGestionPersonnel.Name = "btnGestionPersonnel";
            btnGestionPersonnel.Size = new Size(350, 44);
            btnGestionPersonnel.TabIndex = 7;
            btnGestionPersonnel.Text = "gestion personel";
            btnGestionPersonnel.UseVisualStyleBackColor = false;
            btnGestionPersonnel.Click += btnGestionPersonnel_Click;
            // 
            // btnGestionAbsence
            // 
            btnGestionAbsence.BackColor = Color.Firebrick;
            btnGestionAbsence.Font = new Font("Segoe Print", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnGestionAbsence.Location = new Point(12, 62);
            btnGestionAbsence.Name = "btnGestionAbsence";
            btnGestionAbsence.Size = new Size(350, 44);
            btnGestionAbsence.TabIndex = 8;
            btnGestionAbsence.Text = "gestion absences";
            btnGestionAbsence.UseVisualStyleBackColor = false;
            btnGestionAbsence.Click += btnGestionAbsence_Click;
            // 
            // btnDeconnexion
            // 
            btnDeconnexion.BackColor = Color.Firebrick;
            btnDeconnexion.Font = new Font("Segoe Print", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnDeconnexion.Location = new Point(12, 112);
            btnDeconnexion.Name = "btnDeconnexion";
            btnDeconnexion.Size = new Size(350, 44);
            btnDeconnexion.TabIndex = 9;
            btnDeconnexion.Text = "Deconnexion";
            btnDeconnexion.UseVisualStyleBackColor = false;
            btnDeconnexion.Click += btnDeconnexion_Click;
            // 
            // menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(369, 171);
            Controls.Add(btnDeconnexion);
            Controls.Add(btnGestionAbsence);
            Controls.Add(btnGestionPersonnel);
            Name = "menu";
            Text = "menu principal";
            ResumeLayout(false);
        }

        #endregion

        private Button btnGestionPersonnel;
        private Button btnGestionAbsence;
        private Button btnDeconnexion;
    }
}