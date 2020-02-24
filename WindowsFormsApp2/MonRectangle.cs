using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    class MonRectangle : MonPoint
    {
        #region Donnees
        private int hauteur;
        private int largeur;
        #endregion
        #region Accesseur
        public int Hauteur { get => hauteur; set => hauteur = value; }
        public int Largeur { get => largeur; set => largeur = value; }
        #endregion
        #region Constructeur
        public MonRectangle(PictureBox hebergeur, int x, int y)
            : base(hebergeur, x, y)
        {
            Hauteur = 100;
            Largeur = 200;
            Crayon = Color.Green;
        }
        public MonRectangle(PictureBox hebergeur, int x, int y, int hauteur, int largeur, Color crayon, Color pinceau)
            : base(hebergeur, (x + (largeur / 2)), (y + (hauteur / 2)), crayon, crayon)
        {
            Hauteur = hauteur;
            Largeur = largeur;
            Crayon = crayon;
            Pinceau = pinceau;
        }
        #endregion
        #region Methodes
        public override void Afficher(Graphics gr)
        {
            gr.FillRectangle(new SolidBrush(this.Pinceau), X - (Largeur / 2), Y - (Hauteur / 2), Largeur, Hauteur);
            gr.DrawRectangle(new Pen(this.Crayon), X - (Largeur / 2), Y - (Hauteur / 2), Largeur, Hauteur);
        }
        #endregion
    }
}
