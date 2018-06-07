namespace GeoQuizDavidJaniak
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxSpielername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAntwortAbgeben = new System.Windows.Forms.Button();
            this.buttonSpielStarten = new System.Windows.Forms.Button();
            this.labelFrage = new System.Windows.Forms.Label();
            this.buttonHighscore = new System.Windows.Forms.Button();
            this.checkBoxSpielartName = new System.Windows.Forms.CheckBox();
            this.checkBoxSpielartFlagge = new System.Windows.Forms.CheckBox();
            this.checkBoxSpielartHauptstadt = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAntwort1 = new System.Windows.Forms.Button();
            this.buttonAntwort4 = new System.Windows.Forms.Button();
            this.buttonAntwort2 = new System.Windows.Forms.Button();
            this.buttonAntwort3 = new System.Windows.Forms.Button();
            this.labelAktuellePunkte = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonAbbrechen = new System.Windows.Forms.Button();
            this.pictureBoxTitlebild = new System.Windows.Forms.PictureBox();
            this.buttonHighscoreTop15 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitlebild)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxSpielername
            // 
            this.textBoxSpielername.Location = new System.Drawing.Point(96, 12);
            this.textBoxSpielername.Name = "textBoxSpielername";
            this.textBoxSpielername.Size = new System.Drawing.Size(204, 20);
            this.textBoxSpielername.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Spielername:";
            // 
            // buttonAntwortAbgeben
            // 
            this.buttonAntwortAbgeben.Location = new System.Drawing.Point(629, 200);
            this.buttonAntwortAbgeben.Name = "buttonAntwortAbgeben";
            this.buttonAntwortAbgeben.Size = new System.Drawing.Size(75, 23);
            this.buttonAntwortAbgeben.TabIndex = 6;
            this.buttonAntwortAbgeben.Text = "Antworten";
            this.buttonAntwortAbgeben.UseVisualStyleBackColor = true;
            this.buttonAntwortAbgeben.Click += new System.EventHandler(this.buttonAntwortAbgeben_Click);
            // 
            // buttonSpielStarten
            // 
            this.buttonSpielStarten.Location = new System.Drawing.Point(25, 74);
            this.buttonSpielStarten.Name = "buttonSpielStarten";
            this.buttonSpielStarten.Size = new System.Drawing.Size(275, 23);
            this.buttonSpielStarten.TabIndex = 7;
            this.buttonSpielStarten.Text = "Spiel Starten";
            this.buttonSpielStarten.UseVisualStyleBackColor = true;
            this.buttonSpielStarten.Click += new System.EventHandler(this.buttonSpielStarten_Click);
            // 
            // labelFrage
            // 
            this.labelFrage.AutoSize = true;
            this.labelFrage.Location = new System.Drawing.Point(63, 46);
            this.labelFrage.Name = "labelFrage";
            this.labelFrage.Size = new System.Drawing.Size(56, 13);
            this.labelFrage.TabIndex = 8;
            this.labelFrage.Text = "labelFrage";
            // 
            // buttonHighscore
            // 
            this.buttonHighscore.Location = new System.Drawing.Point(63, 109);
            this.buttonHighscore.Name = "buttonHighscore";
            this.buttonHighscore.Size = new System.Drawing.Size(120, 23);
            this.buttonHighscore.TabIndex = 9;
            this.buttonHighscore.Text = "Meine Highscores";
            this.buttonHighscore.UseVisualStyleBackColor = true;
            this.buttonHighscore.Click += new System.EventHandler(this.buttonHighscore_Click);
            // 
            // checkBoxSpielartName
            // 
            this.checkBoxSpielartName.AutoSize = true;
            this.checkBoxSpielartName.Location = new System.Drawing.Point(106, 46);
            this.checkBoxSpielartName.Name = "checkBoxSpielartName";
            this.checkBoxSpielartName.Size = new System.Drawing.Size(54, 17);
            this.checkBoxSpielartName.TabIndex = 10;
            this.checkBoxSpielartName.Text = "Name";
            this.checkBoxSpielartName.UseVisualStyleBackColor = true;
            this.checkBoxSpielartName.Click += new System.EventHandler(this.checkBoxSpielart_Click);
            // 
            // checkBoxSpielartFlagge
            // 
            this.checkBoxSpielartFlagge.AutoSize = true;
            this.checkBoxSpielartFlagge.Location = new System.Drawing.Point(160, 46);
            this.checkBoxSpielartFlagge.Name = "checkBoxSpielartFlagge";
            this.checkBoxSpielartFlagge.Size = new System.Drawing.Size(58, 17);
            this.checkBoxSpielartFlagge.TabIndex = 11;
            this.checkBoxSpielartFlagge.Text = "Flagge";
            this.checkBoxSpielartFlagge.UseVisualStyleBackColor = true;
            this.checkBoxSpielartFlagge.Click += new System.EventHandler(this.checkBoxSpielart_Click);
            // 
            // checkBoxSpielartHauptstadt
            // 
            this.checkBoxSpielartHauptstadt.AutoSize = true;
            this.checkBoxSpielartHauptstadt.Location = new System.Drawing.Point(224, 46);
            this.checkBoxSpielartHauptstadt.Name = "checkBoxSpielartHauptstadt";
            this.checkBoxSpielartHauptstadt.Size = new System.Drawing.Size(78, 17);
            this.checkBoxSpielartHauptstadt.TabIndex = 12;
            this.checkBoxSpielartHauptstadt.Text = "Hauptstadt";
            this.checkBoxSpielartHauptstadt.UseVisualStyleBackColor = true;
            this.checkBoxSpielartHauptstadt.Click += new System.EventHandler(this.checkBoxSpielart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Spielart wählen:";
            // 
            // buttonAntwort1
            // 
            this.buttonAntwort1.Location = new System.Drawing.Point(66, 80);
            this.buttonAntwort1.Name = "buttonAntwort1";
            this.buttonAntwort1.Size = new System.Drawing.Size(150, 90);
            this.buttonAntwort1.TabIndex = 14;
            this.buttonAntwort1.Text = "button1";
            this.buttonAntwort1.UseVisualStyleBackColor = true;
            this.buttonAntwort1.Click += new System.EventHandler(this.button_click);
            // 
            // buttonAntwort4
            // 
            this.buttonAntwort4.Location = new System.Drawing.Point(576, 80);
            this.buttonAntwort4.Name = "buttonAntwort4";
            this.buttonAntwort4.Size = new System.Drawing.Size(150, 90);
            this.buttonAntwort4.TabIndex = 15;
            this.buttonAntwort4.Text = "button4";
            this.buttonAntwort4.UseVisualStyleBackColor = true;
            this.buttonAntwort4.Click += new System.EventHandler(this.button_click);
            // 
            // buttonAntwort2
            // 
            this.buttonAntwort2.Location = new System.Drawing.Point(236, 80);
            this.buttonAntwort2.Name = "buttonAntwort2";
            this.buttonAntwort2.Size = new System.Drawing.Size(150, 90);
            this.buttonAntwort2.TabIndex = 16;
            this.buttonAntwort2.Text = "button2";
            this.buttonAntwort2.UseVisualStyleBackColor = true;
            this.buttonAntwort2.Click += new System.EventHandler(this.button_click);
            // 
            // buttonAntwort3
            // 
            this.buttonAntwort3.Location = new System.Drawing.Point(406, 80);
            this.buttonAntwort3.Name = "buttonAntwort3";
            this.buttonAntwort3.Size = new System.Drawing.Size(150, 90);
            this.buttonAntwort3.TabIndex = 17;
            this.buttonAntwort3.Text = "button3";
            this.buttonAntwort3.UseVisualStyleBackColor = true;
            this.buttonAntwort3.Click += new System.EventHandler(this.button_click);
            // 
            // labelAktuellePunkte
            // 
            this.labelAktuellePunkte.AutoSize = true;
            this.labelAktuellePunkte.Location = new System.Drawing.Point(468, 205);
            this.labelAktuellePunkte.Name = "labelAktuellePunkte";
            this.labelAktuellePunkte.Size = new System.Drawing.Size(88, 13);
            this.labelAktuellePunkte.TabIndex = 18;
            this.labelAktuellePunkte.Text = "Aktuelle Punkte: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(236, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonHighscoreTop15);
            this.panel1.Controls.Add(this.buttonSpielStarten);
            this.panel1.Controls.Add(this.textBoxSpielername);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.checkBoxSpielartName);
            this.panel1.Controls.Add(this.checkBoxSpielartFlagge);
            this.panel1.Controls.Add(this.checkBoxSpielartHauptstadt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonHighscore);
            this.panel1.Location = new System.Drawing.Point(64, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 138);
            this.panel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonAbbrechen);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.buttonAntwortAbgeben);
            this.panel2.Controls.Add(this.labelFrage);
            this.panel2.Controls.Add(this.labelAktuellePunkte);
            this.panel2.Controls.Add(this.buttonAntwort1);
            this.panel2.Controls.Add(this.buttonAntwort3);
            this.panel2.Controls.Add(this.buttonAntwort4);
            this.panel2.Controls.Add(this.buttonAntwort2);
            this.panel2.Location = new System.Drawing.Point(87, 290);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(793, 242);
            this.panel2.TabIndex = 21;
            this.panel2.Visible = false;
            // 
            // buttonAbbrechen
            // 
            this.buttonAbbrechen.Location = new System.Drawing.Point(710, 200);
            this.buttonAbbrechen.Name = "buttonAbbrechen";
            this.buttonAbbrechen.Size = new System.Drawing.Size(75, 23);
            this.buttonAbbrechen.TabIndex = 20;
            this.buttonAbbrechen.Text = "Abbrechen";
            this.buttonAbbrechen.UseVisualStyleBackColor = true;
            this.buttonAbbrechen.Click += new System.EventHandler(this.buttonAbbrechen_Click);
            // 
            // pictureBoxTitlebild
            // 
            this.pictureBoxTitlebild.Location = new System.Drawing.Point(400, 12);
            this.pictureBoxTitlebild.Name = "pictureBoxTitlebild";
            this.pictureBoxTitlebild.Size = new System.Drawing.Size(480, 240);
            this.pictureBoxTitlebild.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTitlebild.TabIndex = 22;
            this.pictureBoxTitlebild.TabStop = false;
            // 
            // buttonHighscoreTop15
            // 
            this.buttonHighscoreTop15.Location = new System.Drawing.Point(189, 109);
            this.buttonHighscoreTop15.Name = "buttonHighscoreTop15";
            this.buttonHighscoreTop15.Size = new System.Drawing.Size(73, 23);
            this.buttonHighscoreTop15.TabIndex = 14;
            this.buttonHighscoreTop15.Text = "Top 15 ";
            this.buttonHighscoreTop15.UseVisualStyleBackColor = true;
            this.buttonHighscoreTop15.Click += new System.EventHandler(this.buttonHighscoreTop15_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 561);
            this.Controls.Add(this.pictureBoxTitlebild);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "GeoQuiz";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitlebild)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSpielername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAntwortAbgeben;
        private System.Windows.Forms.Button buttonSpielStarten;
        private System.Windows.Forms.Label labelFrage;
        private System.Windows.Forms.Button buttonHighscore;
        private System.Windows.Forms.CheckBox checkBoxSpielartName;
        private System.Windows.Forms.CheckBox checkBoxSpielartFlagge;
        private System.Windows.Forms.CheckBox checkBoxSpielartHauptstadt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAntwort1;
        private System.Windows.Forms.Button buttonAntwort4;
        private System.Windows.Forms.Button buttonAntwort2;
        private System.Windows.Forms.Button buttonAntwort3;
        private System.Windows.Forms.Label labelAktuellePunkte;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonAbbrechen;
        private System.Windows.Forms.PictureBox pictureBoxTitlebild;
        private System.Windows.Forms.Button buttonHighscoreTop15;
    }
}

