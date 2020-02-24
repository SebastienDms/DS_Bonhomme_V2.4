using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    class Sportif : MonBonhomme
    {
        private MonCercle bouche, oeilg, oeild;
        int cpt = 0, cpt_w;

        internal MonCercle Bouche { get => bouche; set => bouche = value; }
        internal MonCercle Oeilg { get => oeilg; set => oeilg = value; }
        internal MonCercle Oeild { get => oeild; set => oeild = value; }
        public int Cpt { get => cpt; set => cpt = value; }
        public int Cpt_w { get => cpt_w; set => cpt_w = value; }

        public Sportif(PictureBox hebergeur, int x, int y, int hauteur, int largeur, double angle, Color crayon, Color pinceau)
            :base(hebergeur, x, y, hauteur, largeur, angle, crayon, pinceau)
        {

        }
        public Sportif(PictureBox hebergeur, int x, int y, int hauteur, int largeur, double angle_base, double angle_bras, Color crayon, Color pinceau)
            :base(hebergeur, x, y, hauteur, largeur, angle_base, crayon, pinceau)
        {
            Tete = new MonCercle(hebergeur, x + (50 * largeur / 100), y - (77 * largeur / 100), (50 * largeur / 100), Color.Pink, Color.Pink);
            Oeilg = new MonCercle(hebergeur, Tete.X + (20 * largeur / 100), Tete.Y - 2, (12 * largeur / 100), Color.Black, Color.White);
            Oeild = new MonCercle(hebergeur, Tete.X - (20 * largeur / 100), Tete.Y - 2, (12 * largeur / 100), Color.Black, Color.White);
            Bouche = new MonCercle(hebergeur, Tete.X, Tete.Y + (30 * largeur / 100), (10 * largeur / 100), Color.Black, Color.DeepPink);
            Brasg = new MonBras(hebergeur, x + (95 * largeur / 100), y + (10 * hauteur / 100), (60 * hauteur / 100), (40 * largeur / 100), angle_bras, Color.Black, Color.Pink);
            Brasd = new MonBras(hebergeur, x - (30 * largeur / 100), y + (4 * hauteur / 100), (60 * hauteur / 100), (40 * largeur / 100), -angle_bras, Color.Black, Color.Pink);
            Jambeg = new MaJambe(hebergeur, x + (70 * largeur / 100), y + (105 * hauteur / 100), (70 * hauteur / 100), (50 * largeur / 100), angle_base, Color.Black, Color.DarkBlue);
            Jambeg.Pied.Largeur = (50 * largeur / 100);
            Jambed = new MaJambe(hebergeur, x - (15 * largeur / 100), y + (105 * hauteur / 100), (70 * hauteur / 100), (50 * largeur / 100), angle_base, Color.Black, Color.DarkBlue);
            Jambed.Pied.Largeur = (50 * largeur / 100);
        }
        // Affiche de face du sportif de face \\
        public void Afficher_de_face(Graphics gr)
        {
            base.Afficher(gr);
            Oeilg.Afficher(gr);
            Oeild.Afficher(gr);
            Bouche.Afficher(gr);
            Brasg.Afficher(gr);
            Brasd.Afficher(gr);
            Jambeg.Afficher(gr);
            Jambed.Afficher(gr);
        }
        // Position à vos marques du sportif \\
        public void Pos_start()
        {
            base.Angle = -(DegreToRadian(75));
            this.Tete = new MonCercle(this.Hebergeur, base.X + (100 * base.Largeur / 100), base.Y - (30 * base.Largeur / 100), (70 * base.Largeur / 100), Color.Pink, Color.Pink);
            this.Brasg = new MonBras(this.Hebergeur, (int)base.MIS.X, (int)base.MIS.Y+5, Brasg.Hauteur, Brasg.Largeur, 0, Brasg.Crayon,Brasg.Pinceau);
            this.Brasd = new MonBras(this.Hebergeur, (int)base.MIS.X, (int)base.MIS.Y+5, Brasd.Hauteur, Brasd.Largeur, 0, Brasd.Crayon, Brasd.Pinceau);
            this.Jambeg = new MaJambe(this.Hebergeur, (int)base.MII.X, (int)base.MII.Y, Jambeg.Hauteur, Jambeg.Largeur, 0, Jambeg.Crayon, Jambeg.Pinceau);
            Jambeg.Mollet.Angle = -(DegreToRadian(90));
            Jambeg.Mollet.X = (int)Jambeg.MII.X;
            this.Jambeg.Pied = new MonRectangle_movable(this.Hebergeur, (int)Jambeg.Mollet.CIG1.X, (int)Jambeg.Mollet.CIG1.Y, Jambeg.Pied.Hauteur, Jambeg.Pied.Largeur, -(DegreToRadian(90)), Jambeg.Pied.Crayon, Jambeg.Pied.Pinceau);
            this.Jambed = new MaJambe(this.Hebergeur, (int)base.MII.X, (int)base.MII.Y, Jambed.Hauteur, Jambed.Largeur, DegreToRadian(35), Jambed.Crayon, Jambed.Pinceau);
            Jambed.Mollet.Angle = -(DegreToRadian(75));
            Jambed.Mollet.X = (int)Jambed.MII.X;
            this.Jambed.Pied = new MonRectangle_movable(this.Hebergeur, (int)Jambed.Mollet.CIG1.X, (int)Jambed.Mollet.CIG1.Y, Jambed.Pied.Hauteur, Jambed.Pied.Largeur, -(DegreToRadian(90)), Jambed.Pied.Crayon, Jambed.Pied.Pinceau);
            Jambed.Pied.Angle = Jambed.Pied.Angle + DegreToRadian(10);
        }
        // Position prêt au démarrage du sportif \\
        public void Pos_ready()
        {
            base.Angle = -(DegreToRadian(95));
            this.Tete = new MonCercle(this.Hebergeur, base.X + (100 * base.Largeur / 100), base.Y - (30 * base.Largeur / 100), (70 * base.Largeur / 100), Color.Pink, Color.Pink);
            this.Brasg = new MonBras(this.Hebergeur, (int)base.MIS.X, (int)base.MIS.Y + 5, Brasg.Hauteur, Brasg.Largeur, 0, Brasg.Crayon, Brasg.Pinceau);
            this.Brasd = new MonBras(this.Hebergeur, (int)base.MIS.X, (int)base.MIS.Y + 5, Brasd.Hauteur, Brasd.Largeur, 0, Brasd.Crayon, Brasd.Pinceau);
            this.Jambeg = new MaJambe(this.Hebergeur, (int)base.MII.X, (int)base.MII.Y, Jambeg.Hauteur, Jambeg.Largeur, -(DegreToRadian(5)), Jambeg.Crayon, Jambeg.Pinceau);
            Jambeg.Mollet.Angle = -(DegreToRadian(20));
            Jambeg.Mollet.X = (int)Jambeg.CIG1.X;
            this.Jambeg.Pied = new MonRectangle_movable(this.Hebergeur, (int)Jambeg.Mollet.CIG1.X, (int)Jambeg.Mollet.CIG1.Y, Jambeg.Pied.Hauteur, Jambeg.Pied.Largeur, -(DegreToRadian(90)), Jambeg.Pied.Crayon, Jambeg.Pied.Pinceau);
            Jambeg.Pied.Angle = Jambeg.Pied.Angle + DegreToRadian(80);
            this.Jambed = new MaJambe(this.Hebergeur, (int)base.MII.X, (int)base.MII.Y, Jambed.Hauteur, Jambed.Largeur, DegreToRadian(15), Jambed.Crayon, Jambed.Pinceau);
            Jambed.Mollet.Angle = -(DegreToRadian(15));
            Jambed.Mollet.X = (int)Jambed.MII.X;
            this.Jambed.Pied = new MonRectangle_movable(this.Hebergeur, (int)Jambed.Mollet.CIG1.X, (int)Jambed.Mollet.CIG1.Y, Jambed.Pied.Hauteur, Jambed.Pied.Largeur, -(DegreToRadian(90)), Jambed.Pied.Crayon, Jambed.Pied.Pinceau);
            Jambed.Pied.Angle = Jambed.Pied.Angle + DegreToRadian(80);
        }
        // Début de course du sportif \\
        public void start_run()
        {
            base.Angle = base.Angle + DegreToRadian(5);
            base.Bouger(5, -2);
            Tete.Bouger(5, -2);
            Brasg.Mouvement_b(5, -2, 0, 5, Math.PI / 4, Math.PI / 12);
            Brasd.Montant = 0;
            Brasd.Mouvement_b(5, -2, 5, 5, Math.PI / 4, DegreToRadian(75));
            Jambeg.Mouvement_j((int)base.MII.X, (int)base.MII.Y, 5, -2, 8, 3, DegreToRadian(75), Math.PI / 3);
            Jambed.Mouvement_j((int)base.MII.X, (int)base.MII.Y, 5, -2, -5, 3, DegreToRadian(50), Math.PI / 4);
        }
        // Methode pour faire courir le sportif \\
        public void Run()
        {
            base.Bouger(5, 0);
            Tete.Bouger(5, 0);
            Brasg.Mouvement_b(5, 0, 5, 3, Math.PI / 4, Math.PI / 12);
            Brasd.Mouvement_b(5, 0, 5, 3, Math.PI / 4, Math.PI / 12);
            Jambeg.Mouvement_j((int)base.MII.X, (int)base.MII.Y, 5, 0, 5, 3, DegreToRadian(50), Math.PI / 4);
            Jambed.Mouvement_j((int)base.MII.X, (int)base.MII.Y, 5, 0, 5, 3, DegreToRadian(50), Math.PI / 4);
        }
        // Methode pour sauter \\
        public void Jump()
        {
            // Si Sportif bouge \\
            base.Bouger(5, 0);
            Tete.Bouger(5, 0);
            Brasg.Mouvement_b(5, 0, 5, 3, Math.PI / 4, Math.PI / 12);
            Brasd.Mouvement_b(5, 0, 5, 3, Math.PI / 4, Math.PI / 12);
            // Si Decor bouge \\
            /*Brasg.Mouvement_b(0, 0, 5, 3, Math.PI / 4, Math.PI / 12);
            Brasd.Mouvement_b(0, 0, 5, 3, Math.PI / 4, Math.PI / 12);*/

            if (Cpt<29)
            {
                Jambeg.Montant = 0;
                Jambeg.Mouvement_j((int)base.MII.X, (int)base.MII.Y, 5, 0, 5, 3, DegreToRadian(95), DegreToRadian(90));
                //Jambeg.Mouvement_j((int)base.MII.X, (int)base.MII.Y, 0, 0, 5, 3, DegreToRadian(95), DegreToRadian(90));
            }
            else
            {
                //passage horizontale de la jambe
                if(Cpt<36)
                {
                    Jambeg.Bouger(5, 0);
                    Jambeg = new MaJambe(Jambeg.Hebergeur, Jambeg.X, Jambeg.Y, (80 * Jambeg.Hauteur / 100), Jambeg.Largeur, Jambeg.Angle, Jambeg.Crayon, Jambeg.Pinceau);
                }
                else
                {
                    if(Cpt<39)
                    {
                        Jambeg.Bouger(5, 0);
                        Jambeg = new MaJambe(Jambeg.Hebergeur, (int)base.CIG1.X, (int)base.CIG1.Y, (180 * Jambeg.Hauteur / 100), Jambeg.Largeur, Math.PI / 2, Jambeg.Crayon, Jambeg.Pinceau);
                    }
                    else
                    {
                        Jambeg = new MaJambe(base.Hebergeur, base.X + (0 * base.Largeur / 100), base.Y + (99 * base.Hauteur / 100), (70 * base.Hauteur / 100), (90 * base.Largeur / 100), Jambeg.Angle, Jambeg.Crayon, Jambeg.Pinceau);
                        Jambeg.Montant = 0;
                        Jambeg.Mouvement_j((int)base.MII.X, (int)base.MII.Y, 5, 0, 5, 3, DegreToRadian(95), DegreToRadian(-45));
                        //Jambeg.Mouvement_j((int)base.MII.X, (int)base.MII.Y, 0, 0, 5, 3, DegreToRadian(95), DegreToRadian(-45));
                    }
                }
            }
            if(Cpt<23)
            {
                Jambed.Montant = 1;
                Jambed.Mouvement_j((int)base.MII.X, (int)base.MII.Y, 5, 0, 7, 5, DegreToRadian(95), DegreToRadian(95));
                //Jambed.Mouvement_j((int)base.MII.X, (int)base.MII.Y, 0, 0, 7, 5, DegreToRadian(95), DegreToRadian(95));
            }
            else
            {
                Jambed.Montant = 0;
                Jambed.Mouvement_j((int)base.MII.X, (int)base.MII.Y, 5, 0, 7, 5, DegreToRadian(95), DegreToRadian(-10));
                //Jambed.Mouvement_j((int)base.MII.X, (int)base.MII.Y, 0, 0, 7, 5, DegreToRadian(95), DegreToRadian(-10));
            }
            Cpt++;
        }
        // Methode marche frontale \\
        public void Walk_face()
        {
            if(Cpt_w<3)
            {
                // Mouvement de bras \\
                Brasg = new MonBras(Brasg.Hebergeur, Brasg.X, Brasg.Y, Brasg.Hauteur, Brasg.Largeur, Brasg.Angle + DegreToRadian(10), Brasg.Crayon, Brasg.Pinceau);
                Brasd = new MonBras(Brasd.Hebergeur, Brasd.X, Brasd.Y, Brasd.Hauteur, Brasd.Largeur, Brasd.Angle - DegreToRadian(10), Brasd.Crayon, Brasd.Pinceau);
                // jambe gauche monte \\
                Jambeg = new MaJambe(Jambeg.Hebergeur, Jambeg.X, Jambeg.Y, Jambeg.Hauteur - (5 * Jambeg.Hauteur / 100), Jambeg.Largeur, Jambeg.Angle, Jambeg.Crayon, Jambeg.Pinceau);
                Jambeg.Pied.Largeur = (68 * Jambeg.Pied.Largeur / 100);
                Cpt_w++;
            }
            else
            {
                if (cpt_w < 6)
                {
                    // Mouvement de bras \\
                    Brasg = new MonBras(Brasg.Hebergeur, Brasg.X, Brasg.Y, Brasg.Hauteur, Brasg.Largeur, Brasg.Angle - DegreToRadian(10), Brasg.Crayon, Brasg.Pinceau);
                    Brasd = new MonBras(Brasd.Hebergeur, Brasd.X, Brasd.Y, Brasd.Hauteur, Brasd.Largeur, Brasd.Angle + DegreToRadian(10), Brasd.Crayon, Brasd.Pinceau);
                    // jambe gauche descend \\
                    Jambeg = new MaJambe(Jambeg.Hebergeur, Jambeg.X, Jambeg.Y, Jambeg.Hauteur + (5 * Jambeg.Hauteur / 100), Jambeg.Largeur, Jambeg.Angle, Jambeg.Crayon, Jambeg.Pinceau);
                    Jambeg.Pied.Largeur = (68 * Jambeg.Pied.Largeur / 100);
                    Cpt_w++;
                }
                else
                {
                    if (cpt_w < 10)
                    {
                        // Mouvement de bras \\
                        Brasg = new MonBras(Brasg.Hebergeur, Brasg.X, Brasg.Y, Brasg.Hauteur, Brasg.Largeur, Brasg.Angle + DegreToRadian(10), Brasg.Crayon, Brasg.Pinceau);
                        Brasd = new MonBras(Brasd.Hebergeur, Brasd.X, Brasd.Y, Brasd.Hauteur, Brasd.Largeur, Brasd.Angle - DegreToRadian(10), Brasd.Crayon, Brasd.Pinceau);
                        // jambe droite monte \\
                        Jambed = new MaJambe(Jambed.Hebergeur, Jambed.X, Jambed.Y, Jambed.Hauteur - (5 * Jambed.Hauteur / 100), Jambed.Largeur, Jambed.Angle, Jambed.Crayon, Jambed.Pinceau);
                        Jambed.Pied.Largeur = (68 * Jambed.Pied.Largeur / 100);
                        Cpt_w++;
                    }
                    else
                    {
                        // Mouvement de bras \\
                        Brasg = new MonBras(Brasg.Hebergeur, Brasg.X, Brasg.Y, Brasg.Hauteur, Brasg.Largeur, Brasg.Angle - DegreToRadian(10), Brasg.Crayon, Brasg.Pinceau);
                        Brasd = new MonBras(Brasd.Hebergeur, Brasd.X, Brasd.Y, Brasd.Hauteur, Brasd.Largeur, Brasd.Angle + DegreToRadian(10), Brasd.Crayon, Brasd.Pinceau);
                        // jambe droite descend \\
                        Jambed = new MaJambe(Jambed.Hebergeur, Jambed.X, Jambed.Y, Jambed.Hauteur + (5 * Jambed.Hauteur / 100), Jambed.Largeur, Jambed.Angle, Jambed.Crayon, Jambed.Pinceau);
                        Jambed.Pied.Largeur = (68 * Jambed.Pied.Largeur / 100);
                        Cpt_w++;
                    }
                }
            }
            if(Cpt_w>13)
            {
                Cpt_w = 0;
            }
        }
    }
}
