using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    class Stade : MonRectangle
    {
        private MonRectangle cote_g, cote_d;

        internal MonRectangle Cote_g { get => cote_g; set => cote_g = value; }
        internal MonRectangle Cote_d { get => cote_d; set => cote_d = value; }

        public Stade(PictureBox hebergeur, int x, int y, int hauteur, int largeur, Color crayon, Color pinceau)
            :base(hebergeur, x, y, hauteur, largeur, crayon, pinceau)
        {
            Cote_g = new MonRectangle(hebergeur, 0, 80, 180, 15, Color.Black, Color.LightGray);
            Cote_d = new MonRectangle(hebergeur, 786, 80, 180, 15, Color.Black, Color.LightGray);
        }
        // Adapatation de l'affichage pour le stade \\
        public override void Afficher(Graphics gr)
        {
            base.Afficher(gr);
            Cote_g.Afficher(gr);
            Cote_d.Afficher(gr);
        }
        // Adapation de Bouger pour l'ensemble des éléments \\
        public override void Bouger(int depl_x, int depl_y)
        {
            base.Bouger(depl_x, depl_y);
            Cote_g.Bouger(depl_x, depl_y);
            Cote_d.Bouger(depl_x, depl_y);
        }
    }
}
