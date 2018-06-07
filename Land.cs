using System.Drawing;

namespace GeoQuizDavidJaniak
{
    class Land
    {
        public string Name;
        public string Hauptstadt;
        public Image Bild;

        public Land() { }
        public Land(string name, string hauptstadt)
        {
            Name = name;
            Hauptstadt = hauptstadt;
            Bild = Image.FromFile("flaggen/" + Name + ".gif");
        }
    }    
}
