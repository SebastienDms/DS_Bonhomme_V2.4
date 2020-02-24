using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    class Casquette : MonCercle
    {
        private MonRectangle visiere;

        internal MonRectangle Visiere { get => visiere; set => visiere = value; }

        public Casquette(PictureBox hebergeur, int x, int y, int rayon, Color crayon, Color pinceau)
            :base(hebergeur, x, y, rayon, crayon, pinceau)
        {
            Visiere = new MonRectangle(hebergeur, x, y, rayon / 2, 3*rayon, crayon, pinceau);
        }
        public override void Afficher(Graphics gr)
        {
            base.Afficher(gr);
            Visiere.Afficher(gr);
        }
    }
}
