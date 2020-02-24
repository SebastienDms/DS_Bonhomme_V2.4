using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    class MonBonhomme : MonRectangle_movable
    {
        #region Donnees
        private MonCercle tete;
        private MonRectangle bras, jambe, pied;
        private MonBras brasg, brasd;
        private MaJambe jambeg, jambed;
        private PointF pt_trg, pt_trd;
        #endregion
        #region Accesseurs
        // coucou seb, je te vois coder...^^
        internal MonCercle Tete { get => tete; set => tete = value; }
        internal MonRectangle Bras { get => bras; set => bras = value; }
        internal MonRectangle Jambe { get => jambe; set => jambe = value; }
        internal MonRectangle Pied { get => pied; set => pied = value; }
        internal MaJambe Jambeg { get => jambeg; set => jambeg = value; }
        internal MaJambe Jambed { get => jambed; set => jambed = value; }
        internal MonBras Brasg { get => brasg; set => brasg = value; }
        internal MonBras Brasd { get => brasd; set => brasd = value; }
        public PointF Pt_trg { get => pt_trg; set => pt_trg = value; }
        public PointF Pt_trd { get => pt_trd; set => pt_trd = value; }
        #endregion
        #region Constructeurs
        public MonBonhomme(PictureBox hebergeur, int x, int y, int hauteur, int largeur, double angle, Color crayon, Color pinceau)
            : base(hebergeur, x, y, hauteur, largeur, angle, crayon, pinceau)
        {
            tete = new MonCercle(hebergeur, x+(50 * largeur / 100), y-(110 * largeur / 100), (70 * largeur / 100), Color.Pink, Color.Pink);
            Brasg = new MonBras(hebergeur, x + (25 * largeur / 100), y + (4 * hauteur / 100), (60 * hauteur / 100), (50 * largeur / 100), angle - DegreToRadian(15), Color.Black, Color.Pink);
            Brasd = new MonBras(hebergeur, x + (25 * largeur / 100), y + (4 * hauteur / 100), (60 * hauteur / 100), (50 * largeur / 100), angle, Color.Black, Color.Pink);
            Jambeg = new MaJambe(hebergeur, x + (0 * largeur / 100), y + (99 * hauteur / 100), (70 * hauteur / 100), (90 * largeur / 100), angle - DegreToRadian(15), Color.Black, Color.DarkBlue);
            Jambed = new MaJambe(hebergeur, x + (0 * largeur / 100), y + (99 * hauteur / 100), (70 * hauteur / 100), (90 * largeur / 100), angle + DegreToRadian(15), Color.Black, Color.DarkBlue);
        }
        #endregion
        #region Methodes
        public override void Afficher(Graphics gr)
        {
            Brasg.Afficher(gr);
            base.Afficher(gr);
            tete.Afficher(gr);
            //bras.Afficher(gr);
            //jambe.Afficher(gr);
            Jambeg.Afficher(gr);
            Jambed.Afficher(gr);
            //pied.Afficher(gr);
            Brasd.Afficher(gr);

        }
        public void Bougerb(int depl_x, int depl_y, int epaule, int coude, int hanche, int genou, double maxib, double maxij, double minj)
        {
            base.Bouger(depl_x, depl_y);
            tete.Bouger(depl_x, depl_y);
            //bras.Bouger(depl_x, depl_y);
            //Thread.Sleep(200);
            Brasg.Mouvement_b(depl_x, depl_y, epaule, coude, maxib, Math.PI / 12);
            Brasd.Mouvement_b(depl_x, depl_y, epaule, coude, maxib, Math.PI / 12);
            //jambe.Bouger(depl_x, depl_y);
            //pied.Bouger(depl_x, depl_y);
            Jambeg.Mouvement_j((int)base.MII.X, (int)base.MII.Y, depl_x, depl_y, hanche, genou, maxij, minj);
            Jambed.Mouvement_j((int)base.MII.X, (int)base.MII.Y, depl_x, depl_y, hanche, genou, maxij, minj);
        }
        #endregion
    }
}
