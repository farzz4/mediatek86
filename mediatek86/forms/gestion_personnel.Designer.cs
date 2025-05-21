namespace mediatek86.forms
{
    partial class gestion_personnel
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtnom = new TextBox();
            txtprenom = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txttel = new TextBox();
            txtemail = new TextBox();
            label7 = new Label();
            boxservice = new ComboBox();
            but_rnitialiser = new Button();
            label8 = new Label();
            btnajouterpersonel = new Button();
            btnmodifierpersonel = new Button();
            btnsupprimerpersonel = new Button();
            gereabsence = new Button();
            label9 = new Label();
            dataGridpersonel = new DataGridView();
            idpersonnel = new DataGridViewTextBoxColumn();
            nom = new DataGridViewTextBoxColumn();
            prenom = new DataGridViewTextBoxColumn();
            tel = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            service = new DataGridViewTextBoxColumn();
            flowLayoutPanel1 = new FlowLayoutPanel();
            groupBox2 = new GroupBox();
            btncharger = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridpersonel).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkSalmon;
            label1.Font = new Font("Segoe Print", 15.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(252, 36);
            label1.Name = "label1";
            label1.Size = new Size(240, 37);
            label1.TabIndex = 1;
            label1.Text = "Gestion du personnel";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkSalmon;
            label2.Font = new Font("Segoe Print", 15.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 98);
            label2.Name = "label2";
            label2.Size = new Size(289, 37);
            label2.TabIndex = 2;
            label2.Text = "Informations personnelles";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Maroon;
            label3.Font = new Font("Segoe Print", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(53, 21);
            label3.TabIndex = 3;
            label3.Text = "Nom : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Maroon;
            label4.Font = new Font("Segoe Print", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(3, 50);
            label4.Name = "label4";
            label4.Size = new Size(71, 21);
            label4.TabIndex = 4;
            label4.Text = "Prénom : ";
            // 
            // txtnom
            // 
            txtnom.Location = new Point(3, 24);
            txtnom.Name = "txtnom";
            txtnom.Size = new Size(89, 23);
            txtnom.TabIndex = 5;
            // 
            // txtprenom
            // 
            txtprenom.Location = new Point(3, 74);
            txtprenom.Name = "txtprenom";
            txtprenom.Size = new Size(94, 23);
            txtprenom.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Maroon;
            label5.Font = new Font("Segoe Print", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(3, 150);
            label5.Name = "label5";
            label5.Size = new Size(52, 21);
            label5.TabIndex = 7;
            label5.Text = "Eamil :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Maroon;
            label6.Font = new Font("Segoe Print", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(3, 100);
            label6.Name = "label6";
            label6.Size = new Size(41, 21);
            label6.TabIndex = 8;
            label6.Text = "Tel : ";
            // 
            // txttel
            // 
            txttel.Location = new Point(3, 124);
            txttel.Name = "txttel";
            txttel.Size = new Size(224, 23);
            txttel.TabIndex = 9;
            // 
            // txtemail
            // 
            txtemail.Location = new Point(3, 174);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(224, 23);
            txtemail.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Maroon;
            label7.Font = new Font("Segoe Print", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(3, 200);
            label7.Name = "label7";
            label7.Size = new Size(66, 21);
            label7.TabIndex = 11;
            label7.Text = "Service : ";
            // 
            // boxservice
            // 
            boxservice.FormattingEnabled = true;
            boxservice.Items.AddRange(new object[] { "1 administration", "2 médiation culturelle", "3 prêt" });
            boxservice.Location = new Point(3, 224);
            boxservice.Name = "boxservice";
            boxservice.Size = new Size(223, 23);
            boxservice.TabIndex = 12;
            // 
            // but_rnitialiser
            // 
            but_rnitialiser.BackColor = Color.Firebrick;
            but_rnitialiser.Font = new Font("Segoe Print", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            but_rnitialiser.ForeColor = Color.White;
            but_rnitialiser.Location = new Point(3, 253);
            but_rnitialiser.Name = "but_rnitialiser";
            but_rnitialiser.Size = new Size(160, 41);
            but_rnitialiser.TabIndex = 13;
            but_rnitialiser.Text = "Réinitialiser";
            but_rnitialiser.UseVisualStyleBackColor = false;
            but_rnitialiser.Click += but_rnitialiser_Click_1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.DarkSalmon;
            label8.Font = new Font("Segoe Print", 15.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label8.Location = new Point(433, 98);
            label8.Name = "label8";
            label8.Size = new Size(178, 37);
            label8.TabIndex = 5;
            label8.Text = "Administration";
            // 
            // btnajouterpersonel
            // 
            btnajouterpersonel.BackColor = Color.Firebrick;
            btnajouterpersonel.Font = new Font("Segoe Print", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnajouterpersonel.Location = new Point(36, 31);
            btnajouterpersonel.Name = "btnajouterpersonel";
            btnajouterpersonel.Size = new Size(195, 44);
            btnajouterpersonel.TabIndex = 6;
            btnajouterpersonel.Text = "Ajouter";
            btnajouterpersonel.UseVisualStyleBackColor = false;
            btnajouterpersonel.Click += btnajouterpersonel_Click;
            // 
            // btnmodifierpersonel
            // 
            btnmodifierpersonel.BackColor = Color.Firebrick;
            btnmodifierpersonel.Font = new Font("Segoe Print", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnmodifierpersonel.Location = new Point(39, 97);
            btnmodifierpersonel.Name = "btnmodifierpersonel";
            btnmodifierpersonel.Size = new Size(195, 44);
            btnmodifierpersonel.TabIndex = 7;
            btnmodifierpersonel.Text = "Modifier";
            btnmodifierpersonel.UseVisualStyleBackColor = false;
            btnmodifierpersonel.Click += btnmodifierpersonel_Click;
            // 
            // btnsupprimerpersonel
            // 
            btnsupprimerpersonel.BackColor = Color.Firebrick;
            btnsupprimerpersonel.Font = new Font("Segoe Print", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnsupprimerpersonel.Location = new Point(39, 179);
            btnsupprimerpersonel.Name = "btnsupprimerpersonel";
            btnsupprimerpersonel.Size = new Size(195, 44);
            btnsupprimerpersonel.TabIndex = 8;
            btnsupprimerpersonel.Text = "Supprimer";
            btnsupprimerpersonel.UseVisualStyleBackColor = false;
            btnsupprimerpersonel.Click += btnsupprimerpersonel_Click;
            // 
            // gereabsence
            // 
            gereabsence.BackColor = Color.Firebrick;
            gereabsence.Font = new Font("Segoe Print", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            gereabsence.Location = new Point(39, 259);
            gereabsence.Name = "gereabsence";
            gereabsence.Size = new Size(195, 44);
            gereabsence.TabIndex = 9;
            gereabsence.Text = "Gérer les absence";
            gereabsence.UseVisualStyleBackColor = false;
            gereabsence.Click += gereabsence_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.DarkSalmon;
            label9.Font = new Font("Segoe Print", 15.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label9.Location = new Point(252, 503);
            label9.Name = "label9";
            label9.Size = new Size(195, 37);
            label9.TabIndex = 10;
            label9.Text = "Liste de personel";
            // 
            // dataGridpersonel
            // 
            dataGridpersonel.BackgroundColor = Color.Salmon;
            dataGridpersonel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridpersonel.Columns.AddRange(new DataGridViewColumn[] { idpersonnel, nom, prenom, tel, email, service });
            dataGridpersonel.Location = new Point(21, 543);
            dataGridpersonel.Name = "dataGridpersonel";
            dataGridpersonel.Size = new Size(664, 150);
            dataGridpersonel.TabIndex = 11;
            // 
            // idpersonnel
            // 
            idpersonnel.HeaderText = "ID";
            idpersonnel.Name = "idpersonnel";
            // 
            // nom
            // 
            nom.HeaderText = "Nom";
            nom.Name = "nom";
            // 
            // prenom
            // 
            prenom.HeaderText = "Prenom";
            prenom.Name = "prenom";
            // 
            // tel
            // 
            tel.HeaderText = "Tel";
            tel.Name = "tel";
            // 
            // email
            // 
            email.HeaderText = "Email";
            email.Name = "email";
            // 
            // service
            // 
            service.HeaderText = "Service";
            service.Name = "service";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Salmon;
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(txtnom);
            flowLayoutPanel1.Controls.Add(label4);
            flowLayoutPanel1.Controls.Add(txtprenom);
            flowLayoutPanel1.Controls.Add(label6);
            flowLayoutPanel1.Controls.Add(txttel);
            flowLayoutPanel1.Controls.Add(label5);
            flowLayoutPanel1.Controls.Add(txtemail);
            flowLayoutPanel1.Controls.Add(label7);
            flowLayoutPanel1.Controls.Add(boxservice);
            flowLayoutPanel1.Controls.Add(but_rnitialiser);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(21, 148);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(320, 321);
            flowLayoutPanel1.TabIndex = 12;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Salmon;
            groupBox2.Controls.Add(gereabsence);
            groupBox2.Controls.Add(btnsupprimerpersonel);
            groupBox2.Controls.Add(btnmodifierpersonel);
            groupBox2.Controls.Add(btnajouterpersonel);
            groupBox2.ForeColor = SystemColors.Control;
            groupBox2.Location = new Point(412, 148);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(273, 321);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            // 
            // btncharger
            // 
            btncharger.BackColor = Color.Firebrick;
            btncharger.Font = new Font("Segoe Print", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btncharger.ForeColor = Color.White;
            btncharger.Location = new Point(252, 699);
            btncharger.Name = "btncharger";
            btncharger.Size = new Size(160, 41);
            btncharger.TabIndex = 14;
            btncharger.Text = "charger";
            btncharger.UseVisualStyleBackColor = false;
            // 
            // gestion_personnel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(800, 799);
            Controls.Add(btncharger);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(dataGridpersonel);
            Controls.Add(label9);
            Controls.Add(groupBox2);
            Controls.Add(label8);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "gestion_personnel";
            Text = "gestion_personnel";
            ((System.ComponentModel.ISupportInitialize)dataGridpersonel).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtemail;
        private TextBox txttel;
        private Label label6;
        private Label label5;
        private TextBox txtprenom;
        private TextBox txtnom;
        private Label label4;
        private Label label7;
        private Button but_rnitialiser;
        private ComboBox boxservice;
        private Label label8;
        private Button btnajouterpersonel;
        private Button gereabsence;
        private Button btnsupprimerpersonel;
        private Button btnmodifierpersonel;
        private Label label9;
        private DataGridView dataGridpersonel;
        private FlowLayoutPanel flowLayoutPanel1;
        private GroupBox groupBox2;
        private Button btncharger;
        private DataGridViewTextBoxColumn idpersonnel;
        private DataGridViewTextBoxColumn nom;
        private DataGridViewTextBoxColumn prenom;
        private DataGridViewTextBoxColumn tel;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn service;
    }
}