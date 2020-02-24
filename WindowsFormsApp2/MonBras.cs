using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    class MonBras : MonRectangle_movable
    {
        #region Donnees
        private MonRectangle_movable av_bras, main;
        private PointF pt_tr;
        #endregion
        #region Accesseurs
        public PointF Pt_tr { get => pt_tr; set => pt_tr = value; }
        internal MonRectangle_movable Av_bras { get => av_bras; set => av_bras = value; }
        internal MonRectangle_movable Main { get => main; set => main = value; }
        #endregion
        #region Constructeur
        public MonBras(PictureBox hebergeur, int x, int y, int hauteur, int largeur, double degre, Color crayon, Color pinceau)
            : base(hebergeur, x, y, hauteur, largeur, degre, crayon, pinceau)
        {
            Av_bras = new MonRectangle_movable(base.Hebergeur, (int)base.CIG1.X, (int)base.CIG1.Y, (80 * base.Hauteur / 100), (100 * base.Largeur / 100), base.Angle, Color.Black, Color.Pink);
            Main = new MonRectangle_movable(base.Hebergeur, (int)Av_bras.CIG1.X, (int)Av_bras.CIG1.Y, (10 * base.Hauteur / 100), (105 * base.Largeur / 100), base.Angle, Color.Black, Color.Pink);
        }
        #endregion
        #region Methodes
        public override void Afficher(Graphics gr)
        {
            base.Afficher(gr);
            Av_bras.Afficher(gr);
            Main.Afficher(gr);
        }
        public void Mouvement_b(int x, int y, int move_e, int move_c, double maxi, double min)
        {
            bool test;
            test = base.RealMouve(x, y, move_e, maxi, min);
            //Form1.ActiveForm.Text = "Test vaut : " + test.ToString();
            Av_bras.Mouvement(move_c, Math.PI/2, 0, test);
            //Form1.ActiveForm.Text = "L'angle de la base vaut : " + RadianToDegre(base.Angle) + "L'angle du Mollet vaut : " + RadianToDegre(Mollet.Angle);
            Av_bras = new MonRectangle_movable(base.Hebergeur, (int)base.CIG1.X, (int)base.CIG1.Y, (80 * base.Hauteur / 100), (100 * base.Largeur / 100), Av_bras.Angle, Color.Black, Color.Pink);
            Pt_tr = new PointF(base.MII.X - Av_bras.MIS.X, base.MII.Y - Av_bras.MIS.Y);
            Av_bras = new MonRectangle_movable(base.Hebergeur, (int)(base.CIG1.X + Pt_tr.X), (int)(base.CIG1.Y + Pt_tr.Y), (80 * base.Hauteur / 100), (100 * base.Largeur / 100), Av_bras.Angle, Color.Black, Color.Pink);
            Main = new MonRectangle_movable(base.Hebergeur, (int)Av_bras.CIG1.X, (int)Av_bras.CIG1.Y, (20 * base.Hauteur / 100), (105 * base.Largeur / 100), Av_bras.Angle, Color.Black, Color.Pink);
        }
        #endregion
    }
}
