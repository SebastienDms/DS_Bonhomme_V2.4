using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        #region Donnees
        private int i = 0, cpt = 0;
        private BufferedGraphics bufferG = null;
        private Graphics g;
        private Font drawfont = new Font("Comic Sans MS", 16);
        private SolidBrush drawbrush = new SolidBrush(Color.Gold);
        private Decor stade;
        private MonBonhomme bonhome;
        #endregion
        #region Accesseurs
        internal MonBonhomme Bonhome { get => bonhome; set => bonhome = value; }
        public int I { get => i; set => i = value; }
        internal Decor Stade { get => stade; set => stade = value; }
        public Font Drawfont { get => drawfont; set => drawfont = value; }
        public SolidBrush Drawbrush { get => drawbrush; set => drawbrush = value; }
        public int Cpt { get => cpt; set => cpt = value; }
        #endregion
        public Form1()
        {
            InitializeComponent();
            bufferG = BufferedGraphicsManager.Current.Allocate(TV.CreateGraphics(), TV.DisplayRectangle);
            g = bufferG.Graphics;
        }
        private void bCreerBonhomme_Click(object sender, EventArgs e)
        {
            g.Clear(TV.BackColor);
            Stade.Afficher_Pos_start(g);
            bufferG.Render();
        }

        private void bTimerOn_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void bTimerOff_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int i;
            // Scénario départ
            g.Clear(TV.BackColor);
            Stade.Afficher_Pos_ready(g);
            bufferG.Render();
            //Scénario 1
            for (i = 0; i < 16; i++)
            {
                g.Clear(TV.BackColor);
                Stade.Scenario1();
                Stade.Afficher_Decor(g);
                bufferG.Render();
            }
            Stade.Coureur.Tete.Bouger(-5, -11);
            Stade.Coureur.Brasd.Bouger(2, -6);
            Stade.Afficher_Decor(g);
            bufferG.Render();
            // Scénario 2
            for (i = 0; i < 90; i++)
            {
                g.Clear(TV.BackColor);
                Stade.Scenario2();
                Stade.Afficher_Decor(g);
                bufferG.Render();
            }
            //Scénario 3
            for (i = 0; i < 46; i++)
            {
                g.Clear(TV.BackColor);
                Stade.Scenario3();
                Stade.Afficher_Decor(g);
                bufferG.Render();
            }
            // Transformation de la haie en ligne d'arrivee \\
            Stade.Piste.Haie1.Crayon = Color.White;
            Stade.Piste.Haie1.Pinceau = Color.White;
            Stade.Piste.Haie1.Hauteur = 41;
            Stade.Piste.Haie1.Y = Stade.Piste.Haie1.Y + 7;
            Stade.Afficher_Decor(g);
            bufferG.Render();
            for (i = 0; i < 150; i++)
            {
                g.Clear(TV.BackColor);
                Stade.Scenario2();
                if(i==135)
                {
                    Stade.Public_happy();
                }
                Stade.Afficher_Decor(g);
                bufferG.Render();
            }
            // Pause \\
            Thread.Sleep(1000);
            // Scenario 4 Victoire \\
            for (i = 0; i < 15; i++)
            {
                g.Clear(TV.BackColor);
                if (i % 2 == 0)
                {
                    g.DrawString("YELLOW IS THE WINNER !!", Drawfont, Drawbrush, 10, 100);
                }
                else
                {
                    g.DrawString("YELLOW IS THE WINNER !!", Drawfont, Drawbrush, 501, 100);
                }
                Stade.Scenario_Victory(g, i);
                Stade.Coureur.Afficher_de_face(g);
                bufferG.Render();
                Thread.Sleep(100);
            }
            // Fin de la séance \\
            timer1.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Stade = new Decor(TV, 0, 0, 79, 801, Color.LightSkyBlue, Color.LightSkyBlue);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            g.Clear(TV.BackColor);
            Stade.Afficher_Pos_ready(g);
            bufferG.Render();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i;
            for(i=0;i<16;i++)
            {
                g.Clear(TV.BackColor);
                Stade.Scenario1();
                Stade.Afficher_Decor(g);
                bufferG.Render();
            }
            Stade.Coureur.Tete.Bouger(-2, -9);
            Stade.Coureur.Brasd.Bouger(2, -6);
            Stade.Afficher_Decor(g);
            bufferG.Render();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i;
            for(i=0;i<90;i++)
            {
                g.Clear(TV.BackColor);
                Stade.Scenario2();
                Stade.Afficher_Decor(g);
                bufferG.Render();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i;
            for(i=0;i<46; i++)
            {
                g.Clear(TV.BackColor);
                Stade.Scenario3();
                Stade.Afficher_Decor(g);
                bufferG.Render();
            }
            // Transformation de la haie en ligne d'arrivee \\
            Stade.Piste.Haie1.Crayon = Color.White;
            Stade.Piste.Haie1.Pinceau = Color.White;
            Stade.Piste.Haie1.Hauteur = 41;
            Stade.Piste.Haie1.Y = Stade.Piste.Haie1.Y + 7;
            Stade.Afficher_Decor(g);
            bufferG.Render();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Stade = new Decor(TV, 0, 0, 79, 801, Color.LightSkyBlue, Color.LightSkyBlue);
            g.Clear(TV.BackColor);
            Stade.Afficher_Decor(g);
            bufferG.Render();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int i = 0;
            for(i=0;i<15;i++)
            {
                g.Clear(TV.BackColor);
                if(i%2==0)
                {
                    g.DrawString("YELLOW IS THE WINNER !!", Drawfont, Drawbrush, 10, 100);
                }
                else
                {
                    g.DrawString("YELLOW IS THE WINNER !!", Drawfont, Drawbrush, 500, 100);
                }
                Stade.Scenario_Victory(g, i);
                Stade.Coureur.Afficher_de_face(g);
                bufferG.Render();
                Thread.Sleep(200);
            }
            /*if(cpt==0)
            {
                g.Clear(TV.BackColor);
                g.DrawString("YELLOW IS THE WINNER !!", Drawfont, Drawbrush, 260, 5);
                Stade.Coureur = new Sportif(TV, 370, 100, 95, 50, 0, Math.PI / 6, Stade.Coureur.Crayon, Stade.Coureur.Pinceau);
                Stade.Coureur.Afficher_de_face(g);
                bufferG.Render();

            }
            else
            {
                g.Clear(TV.BackColor);
                g.DrawString("YELLOW IS THE WINNER !!", Drawfont, Drawbrush, 260, 5);
                Stade.Coureur.Brasg.Angle = Math.PI / 2;
                Stade.Coureur.Walk_face();
                Stade.Coureur.Afficher_de_face(g);
                bufferG.Render();
            }
            cpt++;*/
        }
    }
}
