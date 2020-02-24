namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TV = new System.Windows.Forms.PictureBox();
            this.bCreerBonhomme = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bTimerOff = new System.Windows.Forms.Button();
            this.bTimerOn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TV
            // 
            this.TV.BackColor = System.Drawing.Color.Gray;
            this.TV.Location = new System.Drawing.Point(-1, 2);
            this.TV.Name = "TV";
            this.TV.Size = new System.Drawing.Size(800, 330);
            this.TV.TabIndex = 0;
            this.TV.TabStop = false;
            // 
            // bCreerBonhomme
            // 
            this.bCreerBonhomme.Location = new System.Drawing.Point(190, 356);
            this.bCreerBonhomme.Name = "bCreerBonhomme";
            this.bCreerBonhomme.Size = new System.Drawing.Size(97, 37);
            this.bCreerBonhomme.TabIndex = 1;
            this.bCreerBonhomme.Text = "A vos marques";
            this.bCreerBonhomme.UseVisualStyleBackColor = true;
            this.bCreerBonhomme.Click += new System.EventHandler(this.bCreerBonhomme_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bTimerOff);
            this.groupBox1.Controls.Add(this.bTimerOn);
            this.groupBox1.Location = new System.Drawing.Point(588, 338);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestion du Film";
            // 
            // bTimerOff
            // 
            this.bTimerOff.Location = new System.Drawing.Point(51, 60);
            this.bTimerOff.Name = "bTimerOff";
            this.bTimerOff.Size = new System.Drawing.Size(114, 35);
            this.bTimerOff.TabIndex = 4;
            this.bTimerOff.Text = "Mettre en pause";
            this.bTimerOff.UseVisualStyleBackColor = true;
            this.bTimerOff.Click += new System.EventHandler(this.bTimerOff_Click);
            // 
            // bTimerOn
            // 
            this.bTimerOn.Location = new System.Drawing.Point(51, 19);
            this.bTimerOn.Name = "bTimerOn";
            this.bTimerOn.Size = new System.Drawing.Size(114, 35);
            this.bTimerOn.TabIndex = 3;
            this.bTimerOn.Text = "Démarrer la course";
            this.bTimerOn.UseVisualStyleBackColor = true;
            this.bTimerOn.Click += new System.EventHandler(this.bTimerOn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(190, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Prêts";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(321, 356);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 37);
            this.button2.TabIndex = 4;
            this.button2.Text = "Partez";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(321, 402);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 37);
            this.button3.TabIndex = 5;
            this.button3.Text = "Run";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(449, 356);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 37);
            this.button4.TabIndex = 6;
            this.button4.Text = "Jump";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(449, 402);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(97, 37);
            this.button5.TabIndex = 7;
            this.button5.Text = "Victoire !!";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(42, 376);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(97, 37);
            this.button6.TabIndex = 8;
            this.button6.Text = "Départ";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TV);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bCreerBonhomme);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox TV;
        private System.Windows.Forms.Button bCreerBonhomme;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bTimerOff;
        private System.Windows.Forms.Button bTimerOn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

