using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    class MonCercle : MonPoint
    {
        #region Donnees
        private int rayon;
        #endregion
        #region Accesseurs
        public int Rayon { get => rayon; set => rayon = value; }
        #endregion
        #region Constructeur
        public MonCercle(PictureBox hebergeur, int x, int y)
            : base(hebergeur, x, y)
        {
            X_dep = x;
            Y_dep = y;
            Rayon = 20;
            X = X_dep;
            Y = Y_dep;
            this.Fond = Color.Silver;
            this.Crayon = Color.Yellow;
        }
        public MonCercle(PictureBox hebergeur, int x, int y, int rayon)
        {
            Rayon = rayon;
            X_dep = x;
            Y_dep = y;
            X = X_dep;
            Y = Y_dep;
            Pinceau = Color.Yellow;
        }
        public MonCercle(PictureBox hebergeur, int x, int y, int rayon, Color crayon, Color pinceau)
            : base(hebergeur, x + rayon, y + rayon, crayon, crayon)
        {
            X_dep = x;
            Y_dep = y;
            Rayon = rayon;
            X = X_dep;
            Y = Y_dep;
            Crayon = crayon;
            Pinceau = pinceau;
        }
        #endregion
        #region Methodes
        public override void Afficher(Graphics gr)
        {
            gr.FillEllipse(new SolidBrush(Pinceau), X - Rayon, Y - Rayon, 2 * Rayon, 2 * Rayon);
            gr.DrawEllipse(new Pen(Crayon), X - Rayon, Y - Rayon, 2 * Rayon, 2 * Rayon);
        }
        #endregion
    }
}
