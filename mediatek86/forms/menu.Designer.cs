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
            label1 = new Label();
            SuspendLayout();
            // 
            // btnGestionPersonnel
            // 
            btnGestionPersonnel.BackColor = Color.Firebrick;
            btnGestionPersonnel.Font = new Font("Segoe Print", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnGestionPersonnel.Location = new Point(225, 130);
            btnGestionPersonnel.Margin = new Padding(3, 4, 3, 4);
            btnGestionPersonnel.Name = "btnGestionPersonnel";
            btnGestionPersonnel.Size = new Size(400, 62);
            btnGestionPersonnel.TabIndex = 7;
            btnGestionPersonnel.Text = "gestion personel";
            btnGestionPersonnel.UseVisualStyleBackColor = false;
            btnGestionPersonnel.Click += btnGestionPersonnel_Click;
            // 
            // btnGestionAbsence
            // 
            btnGestionAbsence.BackColor = Color.Firebrick;
            btnGestionAbsence.Font = new Font("Segoe Print", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnGestionAbsence.Location = new Point(225, 235);
            btnGestionAbsence.Margin = new Padding(3, 4, 3, 4);
            btnGestionAbsence.Name = "btnGestionAbsence";
            btnGestionAbsence.Size = new Size(400, 62);
            btnGestionAbsence.TabIndex = 8;
            btnGestionAbsence.Text = "gestion absences";
            btnGestionAbsence.UseVisualStyleBackColor = false;
            btnGestionAbsence.Click += btnGestionAbsence_Click;
            // 
            // btnDeconnexion
            // 
            btnDeconnexion.BackColor = Color.Firebrick;
            btnDeconnexion.Font = new Font("Segoe Print", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnDeconnexion.Location = new Point(225, 339);
            btnDeconnexion.Margin = new Padding(3, 4, 3, 4);
            btnDeconnexion.Name = "btnDeconnexion";
            btnDeconnexion.Size = new Size(400, 62);
            btnDeconnexion.TabIndex = 9;
            btnDeconnexion.Text = "Deconnexion";
            btnDeconnexion.UseVisualStyleBackColor = false;
            btnDeconnexion.Click += btnDeconnexion_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Print", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(295, 36);
            label1.Name = "label1";
            label1.Size = new Size(243, 51);
            label1.TabIndex = 10;
            label1.Text = "menu principal";
            // 
            // menu
            // 
            AutoScaleDimensions = new SizeF(8F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(850, 448);
            Controls.Add(label1);
            Controls.Add(btnDeconnexion);
            Controls.Add(btnGestionAbsence);
            Controls.Add(btnGestionPersonnel);
            Font = new Font("Segoe Print", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "menu";
            Text = "menu principal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGestionPersonnel;
        private Button btnGestionAbsence;
        private Button btnDeconnexion;
        private Label label1;
    }
}