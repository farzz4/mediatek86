namespace mediatek86.forms
{
    partial class gestion_absence
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
            dataGridViewAbsences = new DataGridView();
            label2 = new Label();
            groupBox1 = new GroupBox();
            comboEmployees = new ComboBox();
            label7 = new Label();
            comboMotif = new ComboBox();
            renesialiser = new Button();
            dateTimePickerfin = new DateTimePicker();
            dateTimePickerdebut = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            btnretour = new Button();
            btnsupprimerabsen = new Button();
            btnmodifierabsen = new Button();
            btnajoutabsen = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAbsences).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkSalmon;
            label1.Font = new Font("Segoe Print", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(317, 42);
            label1.Name = "label1";
            label1.Size = new Size(147, 28);
            label1.TabIndex = 1;
            label1.Text = "Liste des absence";
            // 
            // dataGridViewAbsences
            // 
            dataGridViewAbsences.BackgroundColor = Color.Salmon;
            dataGridViewAbsences.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAbsences.Location = new Point(81, 73);
            dataGridViewAbsences.Name = "dataGridViewAbsences";
            dataGridViewAbsences.Size = new Size(631, 246);
            dataGridViewAbsences.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkSalmon;
            label2.Font = new Font("Segoe Print", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(305, 351);
            label2.Name = "label2";
            label2.Size = new Size(176, 28);
            label2.TabIndex = 3;
            label2.Text = "Gestion des absences";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Salmon;
            groupBox1.Controls.Add(comboEmployees);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(comboMotif);
            groupBox1.Controls.Add(renesialiser);
            groupBox1.Controls.Add(dateTimePickerfin);
            groupBox1.Controls.Add(dateTimePickerdebut);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(39, 393);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(322, 298);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gestion des absences";
            // 
            // comboEmployees
            // 
            comboEmployees.FormattingEnabled = true;
            comboEmployees.Location = new Point(16, 60);
            comboEmployees.Name = "comboEmployees";
            comboEmployees.Size = new Size(273, 31);
            comboEmployees.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 222);
            label7.Name = "label7";
            label7.Size = new Size(54, 23);
            label7.TabIndex = 12;
            label7.Text = "motif :";
            // 
            // comboMotif
            // 
            comboMotif.FormattingEnabled = true;
            comboMotif.Items.AddRange(new object[] { "1 vacances", "2 maladie", "3 motif familial", "4 congé parental" });
            comboMotif.Location = new Point(168, 219);
            comboMotif.Name = "comboMotif";
            comboMotif.Size = new Size(121, 31);
            comboMotif.TabIndex = 11;
            // 
            // renesialiser
            // 
            renesialiser.BackColor = Color.Firebrick;
            renesialiser.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            renesialiser.ForeColor = SystemColors.Control;
            renesialiser.Location = new Point(74, 256);
            renesialiser.Name = "renesialiser";
            renesialiser.Size = new Size(142, 37);
            renesialiser.TabIndex = 6;
            renesialiser.Text = "Rénitialiser";
            renesialiser.UseVisualStyleBackColor = false;
            // 
            // dateTimePickerfin
            // 
            dateTimePickerfin.Location = new Point(16, 186);
            dateTimePickerfin.Name = "dateTimePickerfin";
            dateTimePickerfin.Size = new Size(273, 30);
            dateTimePickerfin.TabIndex = 10;
            // 
            // dateTimePickerdebut
            // 
            dateTimePickerdebut.Location = new Point(16, 122);
            dateTimePickerdebut.Name = "dateTimePickerdebut";
            dateTimePickerdebut.Size = new Size(273, 30);
            dateTimePickerdebut.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe Print", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(16, 155);
            label6.Name = "label6";
            label6.Size = new Size(113, 28);
            label6.TabIndex = 8;
            label6.Text = "Date de fin :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe Print", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(16, 94);
            label5.Name = "label5";
            label5.Size = new Size(136, 28);
            label5.TabIndex = 7;
            label5.Text = "Date de debut :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe Print", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(16, 30);
            label3.Name = "label3";
            label3.Size = new Size(139, 28);
            label3.TabIndex = 6;
            label3.Text = "Nom et prenom";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Salmon;
            groupBox2.Controls.Add(btnretour);
            groupBox2.Controls.Add(btnsupprimerabsen);
            groupBox2.Controls.Add(btnmodifierabsen);
            groupBox2.Controls.Add(btnajoutabsen);
            groupBox2.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(454, 393);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(301, 266);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Adminstration";
            // 
            // btnretour
            // 
            btnretour.BackColor = Color.Firebrick;
            btnretour.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnretour.ForeColor = SystemColors.Control;
            btnretour.Location = new Point(35, 220);
            btnretour.Name = "btnretour";
            btnretour.Size = new Size(242, 37);
            btnretour.TabIndex = 10;
            btnretour.Text = "Retour";
            btnretour.UseVisualStyleBackColor = false;
            btnretour.Click += btnretour_Click;
            // 
            // btnsupprimerabsen
            // 
            btnsupprimerabsen.BackColor = Color.Firebrick;
            btnsupprimerabsen.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnsupprimerabsen.ForeColor = SystemColors.Control;
            btnsupprimerabsen.Location = new Point(83, 151);
            btnsupprimerabsen.Name = "btnsupprimerabsen";
            btnsupprimerabsen.Size = new Size(142, 37);
            btnsupprimerabsen.TabIndex = 9;
            btnsupprimerabsen.Text = "Supprimer";
            btnsupprimerabsen.UseVisualStyleBackColor = false;
            btnsupprimerabsen.Click += btnsupprimerabsen_Click_1;
            // 
            // btnmodifierabsen
            // 
            btnmodifierabsen.BackColor = Color.Firebrick;
            btnmodifierabsen.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnmodifierabsen.ForeColor = SystemColors.Control;
            btnmodifierabsen.Location = new Point(83, 94);
            btnmodifierabsen.Name = "btnmodifierabsen";
            btnmodifierabsen.Size = new Size(142, 37);
            btnmodifierabsen.TabIndex = 8;
            btnmodifierabsen.Text = "Modifier";
            btnmodifierabsen.UseVisualStyleBackColor = false;
            btnmodifierabsen.Click += btnmodifierabsen_Click;
            // 
            // btnajoutabsen
            // 
            btnajoutabsen.BackColor = Color.Firebrick;
            btnajoutabsen.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnajoutabsen.ForeColor = SystemColors.Control;
            btnajoutabsen.Location = new Point(83, 30);
            btnajoutabsen.Name = "btnajoutabsen";
            btnajoutabsen.Size = new Size(142, 37);
            btnajoutabsen.TabIndex = 7;
            btnajoutabsen.Text = "Ajouter";
            btnajoutabsen.UseVisualStyleBackColor = false;
            btnajoutabsen.Click += btnajoutabsen_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Location = new Point(81, 325);
            button1.Name = "button1";
            button1.Size = new Size(631, 23);
            button1.TabIndex = 11;
            button1.Text = "refraichir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // gestion_absence
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(800, 722);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(dataGridViewAbsences);
            Controls.Add(label1);
            Name = "gestion_absence";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)dataGridViewAbsences).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private DataGridView dataGridViewAbsences;
        private Label label2;
        private GroupBox groupBox1;
        private Button renesialiser;
        private DateTimePicker dateTimePickerfin;
        private DateTimePicker dateTimePickerdebut;
        private Label label6;
        private Label label5;
        private Label label3;
        private GroupBox groupBox2;
        private Button btnretour;
        private Button btnsupprimerabsen;
        private Button btnmodifierabsen;
        private Button btnajoutabsen;
        private Label label7;
        private ComboBox comboMotif;
        private ComboBox comboEmployees;
        private Button button1;
    }
}