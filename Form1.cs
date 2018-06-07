using System;
using System.Drawing;
using System.Windows.Forms;

namespace GeoQuizDavidJaniak
{
    public partial class Form1 : Form
    {
        Geoquiz quiz = new Geoquiz(); //Erstelle eine Variable quiz vom Typ Geoquiz
        Button AktuelleAuswahl = null; //Merker für den zuletzt geklickten Button
        Land[] Antworten = new Land[4]; //Array vom Typ Land 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Size = new Size(960, 300); //Größe bei Programmstart
            pictureBoxTitlebild.Image = Image.FromFile("quiz.png"); //QuizLogo            
        }

        private void checkBoxSpielart_Click(object sender, EventArgs e)
        {
            //Sobald eine CheckboxSpielart Checked wird werden alle Andere Checked = false
            CheckBox auswahl = (CheckBox)sender; 
            CheckBox[] cb = { checkBoxSpielartName, checkBoxSpielartFlagge, checkBoxSpielartHauptstadt };
            foreach (CheckBox i in cb) if (auswahl != i) i.Checked = false;
        }

        private void ErstelleRunde()
        {
            quiz.ErstelleFrage(); //Erstelle Frage in quiz
            Button[] Bts = { buttonAntwort1, buttonAntwort2, buttonAntwort3, buttonAntwort4 };  //Array aus den 4 Buttons auf der Form          
            Antworten = quiz.AktuelleAntworten; //fülle das globale Array mit den Antworten
            int i = 0;
            switch (quiz.Spielart)
            {   //Button Text zu Laendername und PictureBox Bild zu Bild von RichtigesLand aus quiz an der Stelle i
                case 0: foreach (Button value in Bts) { value.Text = quiz.AktuelleAntworten[i].Name; i++; }; pictureBox1.Image = quiz.RichtigesLand.Bild; 
                    break;
                //Button Bild zu Bild von AktuelleAntworten in quiz an der Stelle i
                case 1: foreach (Button value in Bts) { value.Image = quiz.AktuelleAntworten[i].Bild; i++; }; 
                    break;
                //Button Text zu Hauptstadt von AktuelleAntworten in quiz an der Stelle i
                case 2: foreach (Button value in Bts) { value.Text = quiz.AktuelleAntworten[i].Hauptstadt; i++; }; 
                    break;
            }
            labelFrage.Text = quiz.FrageText; //Setze LabelFrage zu FrageText aus quiz
        }

        private void button_click(object sender, EventArgs e)
        {
            //Bei klick auf einen Button wird dieser DunkelMagenta markiert und alle anderen bekommen die Standardfarbe
            AktuelleAuswahl = (Button)sender;
            AktuelleAuswahl.BackColor = Color.DarkMagenta;
            Button[] AntwortButtons = { buttonAntwort1, buttonAntwort2, buttonAntwort3, buttonAntwort4 };
            foreach (Button i in AntwortButtons) if (i != AktuelleAuswahl) { i.BackColor = default(Color); i.UseVisualStyleBackColor = true; }
        }

        private void buttonHighscore_Click(object sender, EventArgs e)
        {
            if (textBoxSpielername.Text != "" && textBoxSpielername.Text.Length > 3)
            {
                quiz.setHighscores(textBoxSpielername.Text);
                string s = "Punkte\tSpieler \tDatum\n";
                for (int i = 0; i < quiz.HisghscoreList.Count; i++) //Erstellt einen String aus der Liste highscore in quiz
                {
                    s += quiz.HisghscoreList[i].Punkte + "\t" + quiz.HisghscoreList[i].Name + "\t" + quiz.HisghscoreList[i].Datum + "\n";
                }
                MessageBox.Show(s, "Highscores für " + quiz.Spieler); //Zeigt Highscore in MessageBox  
            }
            else
            {
                if (textBoxSpielername.Text == "") MessageBox.Show("Bitte Spieler eintragen", "Bitte einloggen"); //Kein Spielername eingetragen
                if (textBoxSpielername.Text.Length < 3) MessageBox.Show("Spielername muss mind. 3 Zeichen land sein", "Spielername zu kurz"); //Spielername zu kurz
            }
        }

        private void buttonSpielStarten_Click(object sender, EventArgs e)
        {
            if (checkBoxSpielartName.Checked == false && 
                checkBoxSpielartFlagge.Checked == false && 
                checkBoxSpielartHauptstadt.Checked == false)  MessageBox.Show("Bitte Spielart asuwählen", "Keine Spielart ausgewählt"); //Wenn keine Checkbox ausgewählt MessageBox mit Hinweis
            if (textBoxSpielername.Text == "") MessageBox.Show("Bitte Spieler eintragen", "Bitte einloggen"); //Wenn keine Checkbox ausgewählt MessageBox mit Hinweis
            if (textBoxSpielername.Text.Length < 3) MessageBox.Show("Spielername muss mind. 3 Zeichen land sein", "Spielername zu kurz"); //Wenn keine Checkbox ausgewählt MessageBox mit Hinweis
            else
            {
                Size = new Size(960, 600); //Ändert Fenstergröße zu 960x600 Pixel
                Button[] Buttons = { buttonAntwort1, buttonAntwort2, buttonAntwort3, buttonAntwort4 };
                //if Anweisung für die drei Checkboxen auf der Form. Wählt die Spielart in quiz aus
                if (checkBoxSpielartName.Checked)
                {
                    quiz = new Geoquiz(0, textBoxSpielername.Text); //startet ein neues Geoquiz in quiz, Spielart Frage als Bild und Antworten Ländernamen
                    pictureBox1.Visible = true; //damit die PictureBox für die Frage sichtbar wird
                    foreach (Button i in Buttons) i.Image = null; //falls Bilder in den Button sind lösche diese
                }
                if (checkBoxSpielartFlagge.Checked)
                {
                    quiz = new Geoquiz(1, textBoxSpielername.Text);//startet ein neues Geoquiz in quiz, Spielart Frage als Ländername und Antworten als Bild
                    pictureBox1.Visible = false; //die diese Spielart wird keine Picturebox gebraucht als unsichtbar machen
                    foreach (Button i in Buttons) i.Text = ""; //der Button Text wird gelöscht
                }
                if (checkBoxSpielartHauptstadt.Checked)
                {
                    quiz = new Geoquiz(2, textBoxSpielername.Text); //startet ein neues Geoquiz in quiz, Spielart Frage als Ländername und Antworten Hauptstädte
                    pictureBox1.Visible = false;//die diese Spielart wird keine Picturebox gebraucht als unsichtbar machen
                    foreach (Button i in Buttons) i.Image = null; //falls Bilder in den Button sind lösche diese
                }

                panel2.Visible = true; //zeigt Panel für die Fragen
                panel1.Enabled = false; //deaktiviert Panel für die Spielerstellung
                labelAktuellePunkte.Text = "Aktuelle Punkte: " + quiz.Punktzahl; //Schreibe das Label für die Punkte
                ErstelleRunde(); //startet nächste Runde
            }
        }

        private void buttonAntwortAbgeben_Click(object sender, EventArgs e)
        {
            if (AktuelleAuswahl != null)
            {
                //da die button mit 1,2,3,4 enden kann man diese mit der Methode substring aus dem Namen des Button filter 
                quiz.PruefeAntwort(Antworten[Convert.ToInt32(AktuelleAuswahl.Name.Substring(13)) - 1]); //und den -1 damit man das Array Antworten in quiz an der richtige Stelle anspricht
                labelAktuellePunkte.Text = "Aktuelle Punkte: " + quiz.Punktzahl;
                Button[] AntwortButtons = { buttonAntwort1, buttonAntwort2, buttonAntwort3, buttonAntwort4 };
                foreach (Button i in AntwortButtons) { i.BackColor = default(Color); i.UseVisualStyleBackColor = true; } //alle Button wieder Standardfarbe

                if (quiz.SpielAktiv) ErstelleRunde(); //if Anweisung falls das Spiel nicht Vorbei ist erstelle neue Runde
                else //falls Spiel vorbei
                {
                    //je nach highscore oder nicht werden verschiedene MessageBoxen angezeigt
                    if (quiz.NeuerHighscore) MessageBox.Show("Neuer Highscore für " + quiz.Spieler + "!!!\n" + quiz.Punktzahl + " Punkte für " + quiz.Spieler + " in Datenbank eingetragen", "Neuer Highscore");
                    else MessageBox.Show(quiz.Punktzahl + " Punkte für " + quiz.Spieler + ". Leider kein neuer Highscore.", "Spiel Vorbei");
                    //führe die buttonAbbrechen_Click Methode aus
                    buttonAbbrechen_Click(sender, e);
                }
                //Setzte die AktuelleAuswahl auf NULL
                AktuelleAuswahl = null;
            }
            //falls keine Auswahl getroffen wird Benutzer darauf hingewiesen
            else MessageBox.Show("Auswahl treffen!");
        }

        private void buttonAbbrechen_Click(object sender, EventArgs e)
        {
            Size = new Size(960, 300); //Fenstergröße 960x300Pixel
            panel2.Visible = false; //Fragenpanel unsichtbarmachen
            panel1.Enabled = true; //Spieler und Spielartpanel aktivieren
            Button[] AntwortButtons = { buttonAntwort1, buttonAntwort2, buttonAntwort3, buttonAntwort4 };
            foreach (Button i in AntwortButtons) { i.BackColor = default(Color); i.UseVisualStyleBackColor = true; }
        }

        private void buttonHighscoreTop15_Click(object sender, EventArgs e)
        {
            quiz.setHighscores(quiz.Spieler);
            string s = "Punkte\tSpieler \tDatum\n";
            for (int i = 0; i < quiz.HisghscoreTop15List.Count; i++) //Erstellt einen String aus der Liste highscoretop15 in quiz
            {
                s += quiz.HisghscoreTop15List[i].Punkte + "\t" + quiz.HisghscoreTop15List[i].Name + "\t" + quiz.HisghscoreTop15List[i].Datum + "\n";
            }
            MessageBox.Show(s, "Top 15 Highscores"); //Zeigt Highscoretop15 in MessageBox
        }
    }
}
