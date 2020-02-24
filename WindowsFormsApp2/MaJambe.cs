using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    class MaJambe : MonRectangle_movable
    {
        #region Donnees
        private MonRectangle_movable mollet, pied;
        private PointF pt_tr;
        #endregion
        #region Accesseurs
        internal MonRectangle_movable Mollet { get => mollet; set => mollet = value; }
        internal MonRectangle_movable Pied { get => pied; set => pied = value; }
        public PointF Pt_tr { get => pt_tr; set => pt_tr = value; }
        #endregion
        #region Constructeurs
        public MaJambe(PictureBox hebergeur, int x, int y, int hauteur, int largeur, double degre, Color crayon, Color pinceau)
            : base(hebergeur, x, y, hauteur, largeur, degre, crayon, pinceau)
        {
            Mollet = new MonRectangle_movable( base.Hebergeur, (int)base.CIG1.X, (int)base.CIG1.Y, (80 * base.Hauteur / 100), (100 * base.Largeur / 100), base.Angle, Color.Black, Color.Pink);
            Pied = new MonRectangle_movable(base.Hebergeur, (int)Mollet.CIG1.X, (int)Mollet.CIG1.Y, (15 * base.Hauteur / 100), (150 * base.Largeur / 100), base.Angle, Color.Black, Color.White);
        }
        #endregion
        #region Methodes
        public override void Afficher(Graphics gr)
        {
            base.Afficher(gr);
            Mollet.Afficher(gr);
            Pied.Afficher(gr);
        }
        public override void Bouger(int depl_x, int depl_y)
        {
            base.Bouger(depl_x, depl_y);
            Mollet.Bouger(depl_x, depl_y);
            Pied.Bouger(depl_x, depl_y);
        }
        public void Mouvement_j(int mix, int miy, int x, int y, int move_j, int move_g, double maxi, double min)
        {
            bool test;
            Pt_tr = new PointF(mix - base.MIS.X, miy - base.MIS.Y);
            test = base.RealMouve((int)Pt_tr.X, (int)Pt_tr.Y, move_j, maxi, min);
            //Form1.ActiveForm.Text = "Test vaut : " + test.ToString();
            Mollet.MouvementTib(base.Angle,move_g, test, 0, min);
            //Form1.ActiveForm.Text = "L'angle de la base vaut : " + RadianToDegre(base.Angle) + "L'angle du Mollet vaut : " + RadianToDegre(Mollet.Angle);
            Mollet = new MonRectangle_movable(base.Hebergeur, (int)base.CIG1.X, (int)base.CIG1.Y, (80 * base.Hauteur / 100), (100 * base.Largeur / 100), Mollet.Angle /*+ Ang)*/, Color.Black, Color.Pink);
            Pt_tr = new PointF(base.MII.X - Mollet.MIS.X, base.MII.Y - Mollet.MIS.Y);
            Mollet = new MonRectangle_movable(base.Hebergeur, (int)(base.CIG1.X + Pt_tr.X), (int)(base.CIG1.Y + Pt_tr.Y), (80 * base.Hauteur / 100), (100 * base.Largeur / 100), Mollet.Angle /*+ Ang)*/, Color.Black, Color.Pink);
            Pied = new MonRectangle_movable(base.Hebergeur, (int)Mollet.CIG1.X, (int)Mollet.CIG1.Y, (15 * base.Hauteur / 100), (150 * base.Largeur / 100), Mollet.Angle /*+ Ang)*/, Color.Black, Color.White);
        }
        #endregion
    }
}
