using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    class Decor : MonRectangle
    {
        private Piste piste;
        private Stade stadium;
        private MonCercle soleil;
        private MonRectangle pelouse;
        private Sportif coureur;
        private Arbitre juge_arbitre;
        private Public public1, public2, public3, public4, public5, public6, public7, public8, public9, public10;
        private Public public11, public12, public13, public14, public15, public16, public17, public18, public19, public20;
        private Public public21, public22, public23, public24, public25, public26, public27, public28, public29, public30;
        private Public public31, public32, public33, public34, public35, public36, public37, public38, public39, public40;
        #region Accesseurs
        internal Piste Piste { get => piste; set => piste = value; }
        internal Stade Stadium { get => stadium; set => stadium = value; }
        internal MonRectangle Pelouse { get => pelouse; set => pelouse = value; }
        internal Sportif Coureur { get => coureur; set => coureur = value; }
        internal Public Public1 { get => public1; set => public1 = value; }
        internal Public Public2 { get => public2; set => public2 = value; }
        internal Public Public3 { get => public3; set => public3 = value; }
        internal Public Public4 { get => public4; set => public4 = value; }
        internal Public Public5 { get => public5; set => public5 = value; }
        internal Public Public6 { get => public6; set => public6 = value; }
        internal Public Public7 { get => public7; set => public7 = value; }
        internal Public Public8 { get => public8; set => public8 = value; }
        internal Public Public9 { get => public9; set => public9 = value; }
        internal Public Public10 { get => public10; set => public10 = value; }
        internal Public Public11 { get => public11; set => public11 = value; }
        internal Public Public12 { get => public12; set => public12 = value; }
        internal Public Public13 { get => public13; set => public13 = value; }
        internal Public Public14 { get => public14; set => public14 = value; }
        internal Public Public15 { get => public15; set => public15 = value; }
        internal Public Public16 { get => public16; set => public16 = value; }
        internal Public Public17 { get => public17; set => public17 = value; }
        internal Public Public18 { get => public18; set => public18 = value; }
        internal Public Public19 { get => public19; set => public19 = value; }
        internal Public Public20 { get => public20; set => public20 = value; }
        internal Public Public21 { get => public21; set => public21 = value; }
        internal Public Public22 { get => public22; set => public22 = value; }
        internal Public Public23 { get => public23; set => public23 = value; }
        internal Public Public24 { get => public24; set => public24 = value; }
        internal Public Public25 { get => public25; set => public25 = value; }
        internal Public Public26 { get => public26; set => public26 = value; }
        internal Public Public27 { get => public27; set => public27 = value; }
        internal Public Public28 { get => public28; set => public28 = value; }
        internal Public Public29 { get => public29; set => public29 = value; }
        internal Public Public30 { get => public30; set => public30 = value; }
        internal Public Public31 { get => public31; set => public31 = value; }
        internal Public Public32 { get => public32; set => public32 = value; }
        internal Public Public33 { get => public33; set => public33 = value; }
        internal Public Public34 { get => public34; set => public34 = value; }
        internal Public Public35 { get => public35; set => public35 = value; }
        internal Public Public36 { get => public36; set => public36 = value; }
        internal Public Public37 { get => public37; set => public37 = value; }
        internal Public Public38 { get => public38; set => public38 = value; }
        internal Public Public39 { get => public39; set => public39 = value; }
        internal Public Public40 { get => public40; set => public40 = value; }
        internal Arbitre Juge_arbitre { get => juge_arbitre; set => juge_arbitre = value; }
        internal MonCercle Soleil { get => soleil; set => soleil = value; }
        #endregion
        public Decor(PictureBox hebergeur, int x, int y, int hauteur, int largeur, Color crayon, Color pinceau)
            : base(hebergeur, x, y, hauteur, largeur, crayon, pinceau)
        {
            Soleil = new MonCercle(hebergeur, 760, 32, 30, Color.Yellow, Color.Yellow);
            Piste = new Piste(hebergeur, 0, 290, 41, 801, Color.Firebrick, Color.Firebrick);
            Stadium = new Stade(hebergeur, 10, 210, 50, 780, Color.Black, Color.LightGray);
            Pelouse = new MonRectangle(hebergeur, 0, 261, 28, 801, Color.Green, Color.Green);
            Coureur = new Sportif(hebergeur, 80, 250, 39, 10, 0, Color.Black, Color.Yellow);
            Public1 = new Public(hebergeur, 20, 195, 30, 9, 0, Color.Black, Color.Red);
            Public2 = new Public(hebergeur, 40, 195, 30, 9, 0, Color.Black, Color.Red);
            Public3 = new Public(hebergeur, 60, 195, 30, 9, 0, Color.Black, Color.Red);
            Public4 = new Public(hebergeur, 80, 195, 30, 9, 0, Color.Black, Color.Red);
            Public5 = new Public(hebergeur, 100, 195, 30, 9, 0, Color.Black, Color.Red);
            Public6 = new Public(hebergeur, 120, 195, 30, 9, 0, Color.Black, Color.Red);
            Public7 = new Public(hebergeur, 140, 195, 30, 9, 0, Color.Black, Color.Red);
            Public8 = new Public(hebergeur, 160, 195, 30, 9, 0, Color.Black, Color.Red);
            Public9 = new Public(hebergeur, 180, 195, 30, 9, 0, Color.Black, Color.Red);
            Public10 = new Public(hebergeur, 200, 195, 30, 9, 0, Color.Black, Color.Aqua);
            Public11 = new Public(hebergeur, 220, 195, 30, 9, 0, Color.Black, Color.Aqua);
            Public12 = new Public(hebergeur, 240, 195, 30, 9, 0, Color.Black, Color.Aqua);
            Public13 = new Public(hebergeur, 260, 195, 30, 9, 0, Color.Black, Color.Aqua);
            Public14 = new Public(hebergeur, 280, 195, 30, 9, 0, Color.Black, Color.Aqua);
            Public15 = new Public(hebergeur, 300, 195, 30, 9, 0, Color.Black, Color.Aqua);
            Public16 = new Public(hebergeur, 320, 195, 30, 9, 0, Color.Black, Color.Aqua);
            Public17 = new Public(hebergeur, 340, 195, 30, 9, 0, Color.Black, Color.Aqua);
            Public18 = new Public(hebergeur, 360, 195, 30, 9, 0, Color.Black, Color.Aqua);
            Public19 = new Public(hebergeur, 380, 195, 30, 9, 0, Color.Black, Color.Aqua);
            Public20 = new Public(hebergeur, 400, 195, 30, 9, 0, Color.Black, Color.Aqua);
            Public21 = new Public(hebergeur, 420, 195, 30, 9, 0, Color.Black, Color.Green);
            Public22 = new Public(hebergeur, 440, 195, 30, 9, 0, Color.Black, Color.Green);
            Public23 = new Public(hebergeur, 460, 195, 30, 9, 0, Color.Black, Color.Green);
            Public24 = new Public(hebergeur, 480, 195, 30, 9, 0, Color.Black, Color.Green);
            Public25 = new Public(hebergeur, 500, 195, 30, 9, 0, Color.Black, Color.Green);
            Public26 = new Public(hebergeur, 520, 195, 30, 9, 0, Color.Black, Color.Green);
            Public27 = new Public(hebergeur, 540, 195, 30, 9, 0, Color.Black, Color.Green);
            Public28 = new Public(hebergeur, 560, 195, 30, 9, 0, Color.Black, Color.Green);
            Public29 = new Public(hebergeur, 580, 195, 30, 9, 0, Color.Black, Color.Green);
            Public30 = new Public(hebergeur, 600, 195, 30, 9, 0, Color.Black, Color.Green);
            Public31 = new Public(hebergeur, 620, 195, 30, 9, 0, Color.Black, Color.Yellow);
            Public32 = new Public(hebergeur, 640, 195, 30, 9, 0, Color.Black, Color.Yellow);
            Public33 = new Public(hebergeur, 660, 195, 30, 9, 0, Color.Black, Color.Yellow);
            Public34 = new Public(hebergeur, 680, 195, 30, 9, 0, Color.Black, Color.Yellow);
            Public35 = new Public(hebergeur, 700, 195, 30, 9, 0, Color.Black, Color.Yellow);
            Public36 = new Public(hebergeur, 720, 195, 30, 9, 0, Color.Black, Color.Yellow);
            Public37 = new Public(hebergeur, 740, 195, 30, 9, 0, Color.Black, Color.Yellow);
            Public38 = new Public(hebergeur, 760, 195, 30, 9, 0, Color.Black, Color.Yellow);
            Juge_arbitre = new Arbitre(hebergeur, 100, 215, 30, 11, 0, 0, Color.Black, Color.White);
        }
        public void Afficher_Decor(Graphics gr)
        {
            base.Afficher(gr);
            Public1.Afficher(gr);
            Public2.Afficher(gr);
            Public3.Afficher(gr);
            Public4.Afficher(gr);
            Public5.Afficher(gr);
            Public6.Afficher(gr);
            Public7.Afficher(gr);
            Public8.Afficher(gr);
            Public9.Afficher(gr);
            Public10.Afficher(gr);
            Public11.Afficher(gr);
            Public12.Afficher(gr);
            Public13.Afficher(gr);
            Public14.Afficher(gr);
            Public15.Afficher(gr);
            Public16.Afficher(gr);
            Public17.Afficher(gr);
            Public18.Afficher(gr);
            Public19.Afficher(gr);
            Public20.Afficher(gr);
            Public21.Afficher(gr);
            Public22.Afficher(gr);
            Public23.Afficher(gr);
            Public24.Afficher(gr);
            Public25.Afficher(gr);
            Public26.Afficher(gr);
            Public27.Afficher(gr);
            Public28.Afficher(gr);
            Public29.Afficher(gr);
            Public30.Afficher(gr);
            Public31.Afficher(gr);
            Public32.Afficher(gr);
            Public33.Afficher(gr);
            Public34.Afficher(gr);
            Public35.Afficher(gr);
            Public36.Afficher(gr);
            Public37.Afficher(gr);
            Public38.Afficher(gr);
            Stadium.Afficher(gr);
            Pelouse.Afficher(gr);
            Piste.Afficher(gr);
            Juge_arbitre.Afficher(gr);
            Coureur.Afficher(gr);
        }
        public void Afficher_Pos_start(Graphics gr)
        {
            base.Afficher(gr);
            Public1.Afficher(gr);
            Public2.Afficher(gr);
            Public3.Afficher(gr);
            Public4.Afficher(gr);
            Public5.Afficher(gr);
            Public6.Afficher(gr);
            Public7.Afficher(gr);
            Public8.Afficher(gr);
            Public9.Afficher(gr);
            Public10.Afficher(gr);
            Public11.Afficher(gr);
            Public12.Afficher(gr);
            Public13.Afficher(gr);
            Public14.Afficher(gr);
            Public15.Afficher(gr);
            Public16.Afficher(gr);
            Public17.Afficher(gr);
            Public18.Afficher(gr);
            Public19.Afficher(gr);
            Public20.Afficher(gr);
            Public21.Afficher(gr);
            Public22.Afficher(gr);
            Public23.Afficher(gr);
            Public24.Afficher(gr);
            Public25.Afficher(gr);
            Public26.Afficher(gr);
            Public27.Afficher(gr);
            Public28.Afficher(gr);
            Public29.Afficher(gr);
            Public30.Afficher(gr);
            Public31.Afficher(gr);
            Public32.Afficher(gr);
            Public33.Afficher(gr);
            Public34.Afficher(gr);
            Public35.Afficher(gr);
            Public36.Afficher(gr);
            Public37.Afficher(gr);
            Public38.Afficher(gr);
            Stadium.Afficher(gr);
            Pelouse.Afficher(gr);
            Piste.Afficher(gr);
            Coureur.Pos_start();
            Juge_arbitre.Afficher(gr);
            Coureur.Afficher(gr);
        }
        public void Afficher_Pos_ready(Graphics gr)
        {
            base.Afficher(gr);
            Public1.Afficher(gr);
            Public2.Afficher(gr);
            Public3.Afficher(gr);
            Public4.Afficher(gr);
            Public5.Afficher(gr);
            Public6.Afficher(gr);
            Public7.Afficher(gr);
            Public8.Afficher(gr);
            Public9.Afficher(gr);
            Public10.Afficher(gr);
            Public11.Afficher(gr);
            Public12.Afficher(gr);
            Public13.Afficher(gr);
            Public14.Afficher(gr);
            Public15.Afficher(gr);
            Public16.Afficher(gr);
            Public17.Afficher(gr);
            Public18.Afficher(gr);
            Public19.Afficher(gr);
            Public20.Afficher(gr);
            Public21.Afficher(gr);
            Public22.Afficher(gr);
            Public23.Afficher(gr);
            Public24.Afficher(gr);
            Public25.Afficher(gr);
            Public26.Afficher(gr);
            Public27.Afficher(gr);
            Public28.Afficher(gr);
            Public29.Afficher(gr);
            Public30.Afficher(gr);
            Public31.Afficher(gr);
            Public32.Afficher(gr);
            Public33.Afficher(gr);
            Public34.Afficher(gr);
            Public35.Afficher(gr);
            Public36.Afficher(gr);
            Public37.Afficher(gr);
            Public38.Afficher(gr);
            Stadium.Afficher(gr);
            Pelouse.Afficher(gr);
            Piste.Afficher(gr);
            Coureur.Pos_ready();
            Juge_arbitre.Brasd = new MonBras(Juge_arbitre.Brasd.Hebergeur, Juge_arbitre.Brasd.X, Juge_arbitre.Brasd.Y, Juge_arbitre.Brasd.Hauteur, Juge_arbitre.Brasd.Largeur, - (3 * Math.PI / 4), Juge_arbitre.Brasd.Crayon, Juge_arbitre.Brasd.Pinceau);
            Juge_arbitre.Afficher(gr);
            Coureur.Afficher(gr);
        }
        public override void Bouger(int depl_x, int depl_y)
        {
            base.Bouger(depl_x, depl_y);
            Public1.Bougerb(depl_x, depl_y, 0, 0, 0, 0, 0, 0, 0);
            Public2.Bougerb(depl_x, depl_y, 0, 0, 0, 0, 0, 0, 0);
            Public3.Bougerb(depl_x, depl_y, 0, 0, 0, 0, 0, 0, 0);
            Public4.Bougerb(depl_x, depl_y, 0, 0, 0, 0, 0, 0, 0);
            Public5.Bougerb(depl_x, depl_y, 0, 0, 0, 0, 0, 0, 0);
            Public6.Bougerb(depl_x, depl_y, 0, 0, 0, 0, 0, 0, 0);
            Public7.Bougerb(depl_x, depl_y, 0, 0, 0, 0, 0, 0, 0);
            Public8.Bougerb(depl_x, depl_y, 0, 0, 0, 0, 0, 0, 0);
            Public9.Bougerb(depl_x, depl_y, 0, 0, 0, 0, 0, 0, 0);
            Public10.Bougerb(depl_x, depl_y, 0, 0, 0, 0, 0, 0, 0);
            Public11.Bougerb(depl_x, depl_y, 0, 0, 0, 0, 0, 0, 0);
            Public12.Bougerb(depl_x, depl_y, 0, 0, 0, 0, 0, 0, 0);
            Public13.Bougerb(depl_x, depl_y, 0, 0, 0, 0, 0, 0, 0);
            Public14.Bougerb(depl_x, depl_y, 0, 0, 0, 0, 0, 0, 0);
            Public15.Bougerb(depl_x, depl_y, 0, 0, 0, 0, 0, 0, 0);
            Public16.Bougerb(depl_x, depl_y, 0, 0, 0, 0, 0, 0, 0);
            Public17.Bougerb(depl_x, depl_y, 0, 0, 0, 0, 0, 0, 0);
            Public18.Bougerb(depl_x, depl_y, 0, 0, 0, 0, 0, 0, 0);
            Public19.Bougerb(depl_x, depl_y, 0, 0, 0, 0, 0, 0, 0);
            Public20.Bougerb(depl_x, depl_y, 0, 0, 0, 0, 0, 0, 0);
            Public21.Bougerb(depl_x, depl_y, 0, 0, 0, 0, 0, 0, 0);
            Public22.Bougerb(depl_x, depl_y, 0, 0, 0, 0, 0, 0, 0);
            Public23.Bougerb(depl_x, depl_y, 0, 0, 0, 0, 0, 0, 0);
            Public24.Bougerb(depl_x, depl_y, 0, 0, 0, 0, 0, 0, 0);
            Public25.Bougerb(depl_x, depl_y, 0, 0, 0, 0, 0, 0, 0);
            Public26.Bougerb(depl_x, depl_y, 0, 0, 0, 0, 0, 0, 0);
            Public27.Bougerb(depl_x, depl_y, 0, 0, 0, 0, 0, 0, 0);
            Public28.Bougerb(depl_x, depl_y, 0, 0, 0, 0, 0, 0, 0);
            Public29.Bougerb(depl_x, depl_y, 0, 0, 0, 0, 0, 0, 0);
            Public30.Bougerb(depl_x, depl_y, 0, 0, 0, 0, 0, 0, 0);
            Stadium.Bouger(depl_x, depl_y);
            Pelouse.Bouger(depl_x, depl_y);
            Piste.Bouger(depl_x, depl_y);
            //Coureur.Afficher(depl_x, depl_y);
        }
        // Public du gagnant content \\
        public void Public_happy()
        {
            // bras gauche se lèvent \\
            Public31.Brasg = new MonBras(Public31.Brasg.Hebergeur, Public31.Brasg.X, Public31.Brasg.Y, Public31.Brasg.Hauteur, Public31.Brasg.Largeur, Public31.Brasg.Angle + Math.PI, Public31.Brasg.Crayon, Public31.Brasg.Pinceau);
            Public32.Brasg = new MonBras(Public32.Brasg.Hebergeur, Public32.Brasg.X, Public32.Brasg.Y, Public32.Brasg.Hauteur, Public32.Brasg.Largeur, Public32.Brasg.Angle + Math.PI, Public32.Brasg.Crayon, Public32.Brasg.Pinceau);
            Public33.Brasg = new MonBras(Public33.Brasg.Hebergeur, Public33.Brasg.X, Public33.Brasg.Y, Public33.Brasg.Hauteur, Public33.Brasg.Largeur, Public33.Brasg.Angle + Math.PI, Public33.Brasg.Crayon, Public33.Brasg.Pinceau);
            Public34.Brasg = new MonBras(Public34.Brasg.Hebergeur, Public34.Brasg.X, Public34.Brasg.Y, Public34.Brasg.Hauteur, Public34.Brasg.Largeur, Public34.Brasg.Angle + Math.PI, Public34.Brasg.Crayon, Public34.Brasg.Pinceau);
            Public35.Brasg = new MonBras(Public35.Brasg.Hebergeur, Public35.Brasg.X, Public35.Brasg.Y, Public35.Brasg.Hauteur, Public35.Brasg.Largeur, Public35.Brasg.Angle + Math.PI, Public35.Brasg.Crayon, Public35.Brasg.Pinceau);
            Public36.Brasg = new MonBras(Public36.Brasg.Hebergeur, Public36.Brasg.X, Public36.Brasg.Y, Public36.Brasg.Hauteur, Public36.Brasg.Largeur, Public36.Brasg.Angle + Math.PI, Public36.Brasg.Crayon, Public36.Brasg.Pinceau);
            Public37.Brasg = new MonBras(Public37.Brasg.Hebergeur, Public37.Brasg.X, Public37.Brasg.Y, Public37.Brasg.Hauteur, Public37.Brasg.Largeur, Public37.Brasg.Angle + Math.PI, Public37.Brasg.Crayon, Public37.Brasg.Pinceau);
            Public38.Brasg = new MonBras(Public38.Brasg.Hebergeur, Public38.Brasg.X, Public38.Brasg.Y, Public38.Brasg.Hauteur, Public38.Brasg.Largeur, Public38.Brasg.Angle + Math.PI, Public38.Brasg.Crayon, Public38.Brasg.Pinceau);
            // Bras droits se lèvent\\
            Public31.Brasd = new MonBras(Public31.Brasd.Hebergeur, Public31.Brasd.X, Public31.Brasd.Y, Public31.Brasd.Hauteur, Public31.Brasd.Largeur, Public31.Brasd.Angle + Math.PI, Public31.Brasd.Crayon, Public31.Brasd.Pinceau);
            Public32.Brasd = new MonBras(Public32.Brasd.Hebergeur, Public32.Brasd.X, Public32.Brasd.Y, Public32.Brasd.Hauteur, Public32.Brasd.Largeur, Public32.Brasd.Angle + Math.PI, Public32.Brasd.Crayon, Public32.Brasd.Pinceau);
            Public33.Brasd = new MonBras(Public33.Brasd.Hebergeur, Public33.Brasd.X, Public33.Brasd.Y, Public33.Brasd.Hauteur, Public33.Brasd.Largeur, Public33.Brasd.Angle + Math.PI, Public33.Brasd.Crayon, Public33.Brasd.Pinceau);
            Public34.Brasd = new MonBras(Public34.Brasd.Hebergeur, Public34.Brasd.X, Public34.Brasd.Y, Public34.Brasd.Hauteur, Public34.Brasd.Largeur, Public34.Brasd.Angle + Math.PI, Public34.Brasd.Crayon, Public34.Brasd.Pinceau);
            Public35.Brasd = new MonBras(Public35.Brasd.Hebergeur, Public35.Brasd.X, Public35.Brasd.Y, Public35.Brasd.Hauteur, Public35.Brasd.Largeur, Public35.Brasd.Angle + Math.PI, Public35.Brasd.Crayon, Public35.Brasd.Pinceau);
            Public36.Brasd = new MonBras(Public36.Brasd.Hebergeur, Public36.Brasd.X, Public36.Brasd.Y, Public36.Brasd.Hauteur, Public36.Brasd.Largeur, Public36.Brasd.Angle + Math.PI, Public36.Brasd.Crayon, Public36.Brasd.Pinceau);
            Public37.Brasd = new MonBras(Public37.Brasd.Hebergeur, Public37.Brasd.X, Public37.Brasd.Y, Public37.Brasd.Hauteur, Public37.Brasd.Largeur, Public37.Brasd.Angle + Math.PI, Public37.Brasd.Crayon, Public37.Brasd.Pinceau);
            Public38.Brasd = new MonBras(Public38.Brasd.Hebergeur, Public38.Brasd.X, Public38.Brasd.Y, Public38.Brasd.Hauteur, Public38.Brasd.Largeur, Public38.Brasd.Angle + Math.PI, Public38.Brasd.Crayon, Public38.Brasd.Pinceau);
        }
        public void Scenario1()
        {
            Juge_arbitre.Brasd = new MonBras(Juge_arbitre.Brasd.Hebergeur, Juge_arbitre.Brasd.X, Juge_arbitre.Brasd.Y, Juge_arbitre.Brasd.Hauteur, Juge_arbitre.Brasd.Largeur, 0, Juge_arbitre.Brasd.Crayon, Juge_arbitre.Brasd.Pinceau);
            Coureur.start_run();
        }
        public void Scenario2()
        {
            Coureur.Run();
        }
        public void Scenario3()
        {
            Coureur.Jump();
        }
        public void Scenario_Victory(Graphics gr, int cpt)
        {
            base.Afficher(gr);
            Soleil.Afficher(gr);
            Pelouse.Afficher(gr);
            Piste.Ligne1.Crayon = Piste.Crayon;
            Piste.Ligne1.Pinceau = Piste.Pinceau;
            Piste.Ligne2.Crayon = Piste.Crayon;
            Piste.Ligne2.Pinceau = Piste.Pinceau;
            if(cpt==0)
                Piste.Haie1.Y = Piste.Haie1.Y + 7;
            Piste.Haie1.Pinceau = Piste.Pinceau;
            Piste.Haie1.Crayon = Piste.Crayon;
            Piste.Afficher(gr);
            if (cpt == 0)
            {
                Coureur = new Sportif(Coureur.Hebergeur, 370, 100, 95, 50, 0, Math.PI / 6, Coureur.Crayon, Coureur.Pinceau);
            }
            else
            {
                Coureur.Walk_face();
            }
        }
    }
}
