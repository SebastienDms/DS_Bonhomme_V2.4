using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    class Arbitre : MonBonhomme
    {
        private Casquette ma_casquette;

        internal Casquette Ma_casquette { get => ma_casquette; set => ma_casquette = value; }

        public Arbitre(PictureBox hebergeur, int x, int y, int hauteur, int largeur, double angle_base, double angle_bras, Color crayon, Color pinceau)
            :base(hebergeur, x, y, hauteur, largeur, angle_base, crayon, pinceau)
        {
            Ma_casquette = new Casquette(hebergeur, x + (45 * largeur / 100), y - (68 * hauteur / 100), 6, Color.Black, Color.Black);
            Brasg = new MonBras(hebergeur, x + (95 * largeur / 100), y + (10 * hauteur / 100), (60 * hauteur / 100), (40 * largeur / 100), angle_bras, Color.Black, Color.Pink);
            Brasd = new MonBras(hebergeur, x - (40 * largeur / 100), y + (4 * hauteur / 100), (60 * hauteur / 100), (40 * largeur / 100), -angle_bras, Color.Black, Color.Pink);
            Jambeg = new MaJambe(hebergeur, x + (70 * largeur / 100), y + (105 * hauteur / 100), (70 * hauteur / 100), (50 * largeur / 100), angle_base, Color.Black, Color.DarkBlue);
            Jambeg.Pied.Largeur = (50 * largeur / 100);
            Jambed = new MaJambe(hebergeur, x - (15 * largeur / 100), y + (105 * hauteur / 100), (70 * hauteur / 100), (50 * largeur / 100), angle_base, Color.Black, Color.DarkBlue);
            Jambed.Pied.Largeur = (50 * largeur / 100);
        }

        public override void Afficher(Graphics gr)
        {
            Ma_casquette.Afficher(gr);
            base.Afficher(gr);
            Tete.Afficher(gr);
            Brasg.Afficher(gr);
            Brasd.Afficher(gr);
            Jambeg.Afficher(gr);
            Jambed.Afficher(gr);
        }
    }
}
