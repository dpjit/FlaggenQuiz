using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;


namespace GeoQuizDavidJaniak
{
    class Geoquiz
    {
        public int Spielart;
        public int Punktzahl;
        public string Spieler;
        public int Zaehler;
        public int[] Reihenfolge;
        public bool SpielAktiv;
        public bool NeuerHighscore;
        public string FrageText;
        public Land[] AktuelleAntworten = new Land[4];
        public Land RichtigesLand = new Land();
        public List<Land> AlleLaender = new List<Land>();
        public List<Spieler> HisghscoreList = new List<Spieler>();
        public List<Spieler> HisghscoreTop15List = new List<Spieler>();

        public Geoquiz()
        {
            HighscoreTop15AusDatenbank();
        }

        public Geoquiz(int spielart, string spieler)
        {
            SpielStarten(spielart, spieler);
        }

        private void LandAusDatenbank()
        {
            MySqlConnection c = new MySqlConnection("SERVER=localhost;UID=root;ENCRYPT=false;PASSWORD=root;");
            MySqlCommand command = c.CreateCommand();
            command.CommandText = "SELECT * FROM dbQuiz.tbLand";
            MySqlDataReader reader;
            c.Open();
            reader = command.ExecuteReader();
            AlleLaender.Clear();
            while (reader.Read())
            {
                Land a = new Land(reader[0].ToString(), reader[1].ToString());
                AlleLaender.Add(a);
            }
            c.Close();
        }
        public void setHighscores(string Spieler)
        {
            HighscoreAusDatenbank(Spieler);
            HighscoreTop15AusDatenbank();
        }
        private void HighscoreAusDatenbank(string Spieler)
        {
            MySqlConnection c = new MySqlConnection("SERVER=localhost;UID=root;ENCRYPT=false;PASSWORD=root;");
            MySqlCommand command = c.CreateCommand();
            command.CommandText = "SELECT * FROM dbQuiz.tbHighscore WHERE Spielername = '" + Spieler + "' ORDER BY Punkte DESC;";
            MySqlDataReader reader;
            c.Open();
            reader = command.ExecuteReader();
            HisghscoreList.Clear();
            while (reader.Read())
            {
                HisghscoreList.Add(new Spieler(reader.GetString(0), reader.GetInt32(1), reader.GetString(2)));
            }
            c.Close();
        }
        private void HighscoreTop15AusDatenbank()
        {
            MySqlConnection c = new MySqlConnection("SERVER=localhost;UID=root;ENCRYPT=false;PASSWORD=root;");
            MySqlCommand command = c.CreateCommand();
            command.CommandText = "SELECT Spielername,max(Punkte),Datum FROM dbQuiz.tbHighscore GROUP BY Spielername ORDER BY max(Punkte) DESC;";
            MySqlDataReader reader;
            c.Open();
            reader = command.ExecuteReader();
            HisghscoreTop15List.Clear();
            while (reader.Read())
            {
                HisghscoreTop15List.Add(new Spieler(reader.GetString(0), reader.GetInt32(1), reader.GetString(2)));
            }
            c.Close();
        }

        public void SpielStarten(int spielart, string spieler)
        {
            Spielart = spielart;
            Spieler = spieler;
            Punktzahl = 0;
            Zaehler = 0;
            SpielAktiv = true;
            LandAusDatenbank();
            HighscoreTop15AusDatenbank();
            ReihenfolgeFestlegen();
            ErstelleFrage();
        }

        private void ReihenfolgeFestlegen()
        {
            Random r = new Random();
            int anz = 0;
            Reihenfolge = new int[10];
            for (int i = 0; i < Reihenfolge.Length; i++)
            {
                int zahl = r.Next(1, AlleLaender.Count + 1);
                foreach (int j in Reihenfolge)
                {
                    if (zahl == j) anz++;
                }
                if (anz >= 1) i = i - 1;
                else Reihenfolge[i] = zahl;
                anz = 0;
            }
            for (int i = 0; i < Reihenfolge.Length; i++)
            {
                Reihenfolge[i] = Reihenfolge[i] - 1;
            }
        }

        private int[] ReihenfolgeAntworten()
        {
            int[] ReihenfolgeAntworten = new int[4];
            int anz = 0;
            for (int i = 0; i <= 3; i++)
            {
                Random r = new Random();
                int zahl = r.Next(1, 5);
                foreach (int j in ReihenfolgeAntworten) { if (zahl == j) anz++; }
                if (anz >= 1) i--;
                else ReihenfolgeAntworten[i] = zahl;
                anz = 0;
            }
            for (int i = 0; i < ReihenfolgeAntworten.Length; i++)
            {
                ReihenfolgeAntworten[i] = ReihenfolgeAntworten[i] - 1;
            }
            return ReihenfolgeAntworten;
        }

        public void ErstelleFrage()
        {
            RichtigesLand = AlleLaender[Reihenfolge[Zaehler]];
            int[] Antworten = ReihenfolgeAntworten();
            int[] AndereAntworten = Antwortmoeglichkeiten(Zaehler);

            for (int i = 0; i <= 3; i++)
            {
                if (i == 0) AktuelleAntworten[Antworten[i]] = RichtigesLand;
                else AktuelleAntworten[Antworten[i]] = AlleLaender[AndereAntworten[i - 1]];
            }

            switch (Spielart)
            {
                case 0:
                    FrageText = "Welches Land zeigt die Flagge?";
                    break;
                case 1:
                    FrageText = String.Format("Bitte Flagge von {0} auswählen?", AlleLaender[Reihenfolge[Zaehler]].Name);
                    break;
                case 2:
                    FrageText = String.Format("Was ist die Hauptstadt von {0}?", AlleLaender[Reihenfolge[Zaehler]].Name);
                    break;
            }
        }

        private int[] Antwortmoeglichkeiten(int Zaehler)
        {
            int anz = 0;
            int[] AndereAntworten = new int[3];
            for (int i = 0; i < AndereAntworten.Length; i++)
            {
                Random r = new Random();
                int zahl = r.Next(1, AlleLaender.Count);
                foreach (int j in AndereAntworten) { if (zahl == j || zahl == Zaehler + 1) anz++; }
                if (anz >= 1) i--;
                else AndereAntworten[i] = zahl;
                anz = 0;
            }
            for (int i = 0; i < AndereAntworten.Length; i++)
            {
                AndereAntworten[i] = AndereAntworten[i] - 1;
            }
            return AndereAntworten;
        }

        public bool PruefeAntwort(Land antwort)
        {
            bool ErgebnisAntwort = false;
            if (SpielAktiv)
            {
                if (antwort == RichtigesLand) { ErgebnisAntwort = true; Punktzahl += 100; }
                else ErgebnisAntwort = false;

                if (Zaehler >= 9) SpielBeenden();
                else Zaehler++;
            }
            return ErgebnisAntwort;
        }

        public void ScoreInDatenbank()
        {
            MySqlConnection c = new MySqlConnection("SERVER=localhost;UID=root;ENCRYPT=false;PASSWORD=root;");
            MySqlCommand command = c.CreateCommand();
            command.CommandText = "INSERT INTO dbQuiz.tbHighscore (Spielername,Punkte) values ('" + Spieler + "'," + Punktzahl + ");";
            c.Open();
            command.ExecuteNonQuery();
            c.Close();
        }

        private void CheckHighscore()
        {
            MySqlConnection c = new MySqlConnection("SERVER=localhost;UID=root;ENCRYPT=false;PASSWORD=root;");
            MySqlCommand command = c.CreateCommand();
            command.CommandText = "SELECT * FROM dbQuiz.tbHighscore WHERE Punkte >= " + Punktzahl + " AND Spielername = '" + Spieler + "';";
            c.Open();
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows) NeuerHighscore = false;
            else { NeuerHighscore = true; ScoreInDatenbank(); }
            c.Close();
        }

        public void SpielBeenden()
        {
            SpielAktiv = false;
            CheckHighscore();
        }
    }
}

