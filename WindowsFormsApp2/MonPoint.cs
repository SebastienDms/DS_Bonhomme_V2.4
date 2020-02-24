using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    class MonPoint
    {
        #region donnees
        private int x_dep;
        private int y_dep;
        private int x;
        private int y;
        private PictureBox hebergeur;
        private Color fond = Color.Silver;
        private Color crayon;
        private Color pinceau;
        #endregion
        #region accesseurs
        public int X_dep { get => x_dep; set => x_dep = value; }
        public int Y_dep { get => y_dep; set => y_dep = value; }
        public PictureBox Hebergeur { get => hebergeur; set => hebergeur = value; }
        public int X
        {
            get
            {
                return x;
            }
            set
            {
                //MessageBox.Show(hebergeur.ToString());
                if (value < 0)
                    x = 0;
                else
                {
                    if (value > this.hebergeur.Bounds.Size.Width)
                        x = 0;
                    else
                        x = value;
                }
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                if (value < 0)
                    y = 0;
                else
                {
                    if (value > this.hebergeur.Bounds.Size.Height)
                        y = 0;
                    else
                        y = value;
                }
            }
        }
        public Color Fond { get => fond; set => fond = value; }
        public Color Crayon { get => crayon; set => crayon = value; }
        public Color Pinceau { get => pinceau; set => pinceau = value; }
        #endregion
        #region Constructeur
        public MonPoint()
        {
            X_dep = 10;
            Y_dep = 10;
            X = X_dep;
            Y = Y_dep;
            this.hebergeur = null;
        }
        public MonPoint(PictureBox matv, int x, int y)
        {
            this.hebergeur = matv;
            X_dep = x;
            Y_dep = y;
            X = X_dep;
            Y = Y_dep;
        }
        public MonPoint(PictureBox matv, int x, int y, Color crayon, Color pinceau)
            : this(matv, x - 2, y - 2)
        {
            Crayon = crayon;
            Pinceau = pinceau;
        }
        #endregion
        #region Methodes
        public virtual void Affiche(IntPtr matv)
        {
            Graphics tv = Graphics.FromHwnd(matv);
            tv.DrawEllipse(new Pen(Crayon, 3), X, Y, 3, 3);
        }
        public virtual void Afficher(Graphics gr)
        {
            gr.DrawEllipse(new Pen(Crayon, 3), X, Y, 3, 3);
        }
        public virtual void Bouger(int depl_x, int depl_y)
        {
            X = X + depl_x;
            Y = Y + depl_y;
        }
        public void Clear(IntPtr matv)
        {
            Graphics tv = Graphics.FromHwnd(matv);
            tv.Clear(Fond);
        }
        #endregion

    }
}
