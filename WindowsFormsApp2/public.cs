using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    class Public : MonBonhomme
    {
        public Public(PictureBox hebergeur, int x, int y, int hauteur, int largeur, double angle, Color crayon, Color pinceau)
            :base(hebergeur, x, y, hauteur, largeur, angle, crayon, pinceau)
        {
            // placement des bras pour être visibles de face \\
            Brasg = new MonBras(hebergeur, x - (50 * largeur / 100), y + (4 * hauteur / 100), (60 * hauteur / 100), (50 * largeur / 100), angle, Color.Black, Color.Pink);
            Brasd = new MonBras(hebergeur, x + (100 * largeur / 100), y + (4 * hauteur / 100), (60 * hauteur / 100), (50 * largeur / 100), angle, Color.Black, Color.Pink);
        }
        // Adaptation de Afficher pour un public de face \\
        public override void Afficher(Graphics gr)
        {
            base.Afficher(gr);
            Brasg.Afficher(gr);
            Brasd.Afficher(gr);
            Jambeg.Afficher(gr);
            Jambed.Afficher(gr);
        }
    }
}
