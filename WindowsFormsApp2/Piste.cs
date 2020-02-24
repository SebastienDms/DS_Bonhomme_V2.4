using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    class Piste: MonRectangle
    {
        #region Donnees
        private MonRectangle ligne1, ligne2, haie1;
        #endregion
        #region Constructeur
        public Piste(PictureBox hebergeur, int x, int y, int hauteur, int largeur, Color crayon, Color pinceau)
            :base(hebergeur, x, y, hauteur, largeur, crayon, pinceau)
        {
            Ligne1 = new MonRectangle(hebergeur, 0, 310, 3, 801, Color.White, Color.White);
            Ligne2 = new MonRectangle(hebergeur, 0, 295, 2, 801, Color.White, Color.White);
            Haie1 = new MonRectangle(hebergeur, 730, 275, 56, 3, Color.Black, Color.Black);
        }
        #endregion
        #region Accesseurs
        internal MonRectangle Ligne1 { get => ligne1; set => ligne1 = value; }
        internal MonRectangle Ligne2 { get => ligne2; set => ligne2 = value; }
        internal MonRectangle Haie1 { get => haie1; set => haie1 = value; }
        #endregion
        #region Methodes
        public override void Afficher(Graphics gr)
        {
            base.Afficher(gr);
            Ligne1.Afficher(gr);
            Ligne2.Afficher(gr);
            Haie1.Afficher(gr);
        }
        public override void Bouger(int depl_x, int depl_y)
        {
            base.Bouger(depl_x, depl_y);
            Ligne1.Bouger(depl_x, depl_y);
            Ligne2.Bouger(depl_x, depl_y);
            Haie1.Bouger(depl_x, depl_y);
        }
        #endregion
    }
}
