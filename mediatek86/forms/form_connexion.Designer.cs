namespace mediatek86.forms
{
    partial class form_connexion
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnConnexion = new Button();
            checkBox1 = new CheckBox();
            txtMdp = new TextBox();
            label3 = new Label();
            txtLogin = new TextBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightCoral;
            label1.Font = new Font("Segoe Print", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(300, 34);
            label1.Name = "label1";
            label1.Size = new Size(147, 37);
            label1.TabIndex = 0;
            label1.Text = "MediaTek86";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Salmon;
            groupBox1.Controls.Add(btnConnexion);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(txtMdp);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtLogin);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(143, 116);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(473, 284);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Connexion";
            // 
            // btnConnexion
            // 
            btnConnexion.BackColor = Color.Firebrick;
            btnConnexion.Location = new Point(155, 220);
            btnConnexion.Name = "btnConnexion";
            btnConnexion.Size = new Size(149, 36);
            btnConnexion.TabIndex = 5;
            btnConnexion.Text = "se connecter";
            btnConnexion.UseVisualStyleBackColor = false;
            btnConnexion.Click += btnConnexion_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(137, 173);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(193, 27);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Afficher le mot de passe ";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtMdp
            // 
            txtMdp.Location = new Point(131, 135);
            txtMdp.Name = "txtMdp";
            txtMdp.Size = new Size(206, 30);
            txtMdp.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(171, 109);
            label3.Name = "label3";
            label3.Size = new Size(103, 23);
            label3.TabIndex = 2;
            label3.Text = "Mot de passe :";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(131, 65);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(206, 30);
            txtLogin.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(171, 39);
            label2.Name = "label2";
            label2.Size = new Size(90, 23);
            label2.TabIndex = 0;
            label2.Text = "Identifiant :";
            // 
            // form_connexion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "form_connexion";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Button btnConnexion;
        private CheckBox checkBox1;
        private TextBox txtMdp;
        private Label label3;
        private TextBox txtLogin;
        private Label label2;
    }
}