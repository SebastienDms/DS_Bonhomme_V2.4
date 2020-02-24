using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    class MonRectangle_movable : MonPoint
    {
        #region Donnees
        int montant = 1;
        private bool test = false;
        private int hauteur;
        private int largeur;
        private double angle;
        double radian = 0;
        private PointF CSG;
        private PointF CSD;
        private PointF CIG;
        private PointF CID;
        private PointF mis;
        private PointF mii;
        private PointF[] c_rect = new PointF[4];
        private PointF[] p_mil = new PointF[2];
        #endregion
        #region Accesseurs
        public double Angle { get => angle; set => angle = value; }
        public int Hauteur { get => hauteur; set => hauteur = value; }
        public int Largeur { get => largeur; set => largeur = value; }
        internal PointF CSG1
        {
            get { return new PointF(X, Y); }
            set { CSG = value; }
        }
        internal PointF CSD1
        {
            get { return new PointF((int)(X + Largeur * Math.Cos(Angle)), (int)(Y - Largeur * Math.Sin(Angle))); }
        }
        internal PointF CIG1
        {
            get { return new PointF((int)(X + Hauteur * Math.Cos(3 * Math.PI / 2 + Angle))+1, (int)(Y - Hauteur * Math.Sin(3 * Math.PI / 2 + Angle))); }
        }
        internal PointF CID1
        {
            get { return new PointF((int)(X + Largeur * Math.Cos(Angle) + Hauteur * Math.Cos(3 * Math.PI / 2 + Angle)+1), (int)(Y - Largeur * Math.Sin(Angle) - Hauteur * Math.Sin(3 * Math.PI / 2 + Angle))); }
        }
        public PointF[] C_rect { get => c_rect; set => c_rect = value; }
        public double Radian { get => radian; set => radian = value; }
        public PointF MIS
        {
            get { return new PointF((int)(CSG1.X + CSD1.X)/2, (int)(CSG1.Y + CSD1.Y)/2); }
        }
        public PointF MII
        {
            get { return new PointF((int)(CIG1.X + CID1.X)/2, (int)(CIG1.Y + CID1.Y)/2); }
        }

        public PointF[] P_mil { get => p_mil; set => p_mil = value; }
        public bool Test { get => test; set => test = value; }
        public int Montant { get => montant; set => montant = value; }
        #endregion
        #region Constructeur
        public MonRectangle_movable(PictureBox hebergeur, int x, int y, int hauteur, int largeur, double degre, Color crayon, Color pinceau)
            : base(hebergeur, x, y, crayon, pinceau)
        {
            Angle = degre;//Math.PI * 0 / 180.0;
            Hauteur = hauteur;
            Largeur = largeur;
            Crayon = crayon;
            Pinceau = pinceau;
            X = x;
            Y = y;
        }
        #endregion
        #region Methodes
        public override void Afficher(Graphics gr)
        {
            C_rect = new PointF[4];
            C_rect[0] = CSG1;
            C_rect[1] = CSD1;
            C_rect[2] = CID1;
            C_rect[3] = CIG1;
            P_mil = new PointF[2];
            P_mil[0] = MIS;
            P_mil[1] = MII;
            gr.FillClosedCurve(new SolidBrush(Pinceau), C_rect);
            gr.DrawClosedCurve(new Pen(Crayon), C_rect);
        }
        public virtual void Mouvement(int degre, double maxi, double min, bool montant)
        {
            if (montant)
            {
                if( Angle >= maxi )
                {
                    Angle = Angle;
                }
                else
                {
                    Angle = Angle + DegreToRadian(degre);
                }
            }
            else
            {
                if (Angle <= min)
                {
                    Angle = Angle;
                }
                else
                {
                    Angle = Angle - DegreToRadian(degre);
                }
            }
        }
        public bool RealMouve(int x, int y, int degre, double maxi, double min)
        {
            base.Bouger(x, y);
            if (Montant == 1)
            {
                if (Angle > maxi)
                {
                    Montant = 0;
                }
                Angle += DegreToRadian(degre);
                if (Montant == 0)
                    return false;
                return true;
            }
            else
            {
                if (Angle < -min)
                {
                    Montant = 1;
                }
                Angle -= DegreToRadian(degre);
                if (Montant ==1)
                    return true;
                return false;
            }
        }
        public virtual void MouvementInv(int degre, bool montant)
        {
            if (montant)
            {
                if (Angle > 0)
                {
                    Angle = 0;
                }
                else
                {
                    Angle = Angle - DegreToRadian(degre);
                }
            }
            else
            {
                if (Angle < -Math.PI/6)
                {
                    Angle = Angle;
                }
                else
                {
                    Angle = Angle + DegreToRadian(degre);
                }
            }
        }
        public void MouvementTib(double ang_base,int degre, bool montant, double maxi, double min)
        {
            // de base angle minimum -pi/4 et angle max 0 \\
            double ang_dif;
            ang_dif = ang_base - Angle;
            // A REFLECHIR !!!!!!  \\
            if (montant)
            {
                if (Angle < min / 4)
                {
                    Angle = Angle;
                }
                else
                {
                    Angle = Angle - DegreToRadian(degre);
                }
            }
            else
            {
                if (Angle >= maxi || ang_base < 0)
                {
                    Test = true;
                    Angle = Angle + ang_dif;
                    
                }
                if(!Test)
                {
                    Angle = Angle + DegreToRadian(degre);
                }
            }
        }
        #endregion
        #region Fonctions
        public double DegreToRadian(double degre)
        {
            return Math.PI * degre / 180.0;
        }
        public double RadianToDegre(double radian)
        {
            return radian * 180.0 / Math.PI;
        }
        #endregion
    }
}
