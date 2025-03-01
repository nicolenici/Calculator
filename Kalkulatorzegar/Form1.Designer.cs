using System.Runtime.CompilerServices;
using System.Security;

namespace Kalkulatorzegar
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.przycisk7 = new System.Windows.Forms.Button();
            this.przycisk8 = new System.Windows.Forms.Button();
            this.przycisk9 = new System.Windows.Forms.Button();
            this.przycisk4 = new System.Windows.Forms.Button();
            this.przycisk5 = new System.Windows.Forms.Button();
            this.przycisk6 = new System.Windows.Forms.Button();
            this.przycisk1 = new System.Windows.Forms.Button();
            this.przycisk2 = new System.Windows.Forms.Button();
            this.przycisk3 = new System.Windows.Forms.Button();
            this.przycisk0 = new System.Windows.Forms.Button();
            this.kropka = new System.Windows.Forms.Button();
            this.równasie = new System.Windows.Forms.Button();
            this.dodawanie = new System.Windows.Forms.Button();
            this.odejmowanie = new System.Windows.Forms.Button();
            this.mnozenie = new System.Windows.Forms.Button();
            this.dzielenie = new System.Windows.Forms.Button();
            this.pierwiastek = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.zmianakoloru = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labeltime = new System.Windows.Forms.Label();
            this.zmianazegara = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.zeruj = new System.Windows.Forms.Button();
            this.procent = new System.Windows.Forms.Button();
            this.zmianaznaku = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // przycisk7
            // 
            this.przycisk7.Location = new System.Drawing.Point(267, 170);
            this.przycisk7.Name = "przycisk7";
            this.przycisk7.Size = new System.Drawing.Size(80, 74);
            this.przycisk7.TabIndex = 0;
            this.przycisk7.Text = "7";
            this.przycisk7.UseVisualStyleBackColor = true;
            this.przycisk7.Click += new System.EventHandler(this.ButtonLiczba_Click);
            // 
            // przycisk8
            // 
            this.przycisk8.Location = new System.Drawing.Point(353, 170);
            this.przycisk8.Name = "przycisk8";
            this.przycisk8.Size = new System.Drawing.Size(79, 74);
            this.przycisk8.TabIndex = 1;
            this.przycisk8.Text = "8\r\n";
            this.przycisk8.UseVisualStyleBackColor = true;
            this.przycisk8.Click += new System.EventHandler(this.ButtonLiczba_Click);
            // 
            // przycisk9
            // 
            this.przycisk9.Location = new System.Drawing.Point(438, 170);
            this.przycisk9.Name = "przycisk9";
            this.przycisk9.Size = new System.Drawing.Size(77, 74);
            this.przycisk9.TabIndex = 2;
            this.przycisk9.Text = "9";
            this.przycisk9.UseVisualStyleBackColor = true;
            this.przycisk9.Click += new System.EventHandler(this.ButtonLiczba_Click);
            // 
            // przycisk4
            // 
            this.przycisk4.Location = new System.Drawing.Point(267, 273);
            this.przycisk4.Name = "przycisk4";
            this.przycisk4.Size = new System.Drawing.Size(79, 74);
            this.przycisk4.TabIndex = 3;
            this.przycisk4.Text = "4";
            this.przycisk4.UseVisualStyleBackColor = true;
            this.przycisk4.Click += new System.EventHandler(this.ButtonLiczba_Click);
            // 
            // przycisk5
            // 
            this.przycisk5.Location = new System.Drawing.Point(352, 273);
            this.przycisk5.Name = "przycisk5";
            this.przycisk5.Size = new System.Drawing.Size(80, 74);
            this.przycisk5.TabIndex = 4;
            this.przycisk5.Text = "5";
            this.przycisk5.UseVisualStyleBackColor = true;
            this.przycisk5.Click += new System.EventHandler(this.ButtonLiczba_Click);
            // 
            // przycisk6
            // 
            this.przycisk6.Location = new System.Drawing.Point(438, 274);
            this.przycisk6.Name = "przycisk6";
            this.przycisk6.Size = new System.Drawing.Size(77, 73);
            this.przycisk6.TabIndex = 5;
            this.przycisk6.Text = "6";
            this.przycisk6.UseVisualStyleBackColor = true;
            this.przycisk6.Click += new System.EventHandler(this.ButtonLiczba_Click);
            // 
            // przycisk1
            // 
            this.przycisk1.Location = new System.Drawing.Point(267, 358);
            this.przycisk1.Name = "przycisk1";
            this.przycisk1.Size = new System.Drawing.Size(79, 77);
            this.przycisk1.TabIndex = 6;
            this.przycisk1.Text = "1";
            this.przycisk1.UseVisualStyleBackColor = true;
            this.przycisk1.Click += new System.EventHandler(this.ButtonLiczba_Click);
            // 
            // przycisk2
            // 
            this.przycisk2.Location = new System.Drawing.Point(353, 358);
            this.przycisk2.Name = "przycisk2";
            this.przycisk2.Size = new System.Drawing.Size(79, 77);
            this.przycisk2.TabIndex = 7;
            this.przycisk2.Text = "2";
            this.przycisk2.UseVisualStyleBackColor = true;
            this.przycisk2.Click += new System.EventHandler(this.ButtonLiczba_Click);
            // 
            // przycisk3
            // 
            this.przycisk3.Location = new System.Drawing.Point(438, 358);
            this.przycisk3.Name = "przycisk3";
            this.przycisk3.Size = new System.Drawing.Size(77, 77);
            this.przycisk3.TabIndex = 8;
            this.przycisk3.Text = "3";
            this.przycisk3.UseVisualStyleBackColor = true;
            this.przycisk3.Click += new System.EventHandler(this.ButtonLiczba_Click);
            // 
            // przycisk0
            // 
            this.przycisk0.Location = new System.Drawing.Point(267, 444);
            this.przycisk0.Name = "przycisk0";
            this.przycisk0.Size = new System.Drawing.Size(80, 74);
            this.przycisk0.TabIndex = 9;
            this.przycisk0.Text = "0";
            this.przycisk0.UseVisualStyleBackColor = true;
            this.przycisk0.Click += new System.EventHandler(this.ButtonLiczba_Click);
            // 
            // kropka
            // 
            this.kropka.Location = new System.Drawing.Point(352, 444);
            this.kropka.Name = "kropka";
            this.kropka.Size = new System.Drawing.Size(81, 74);
            this.kropka.TabIndex = 10;
            this.kropka.Text = ".";
            this.kropka.UseVisualStyleBackColor = true;
            this.kropka.Click += new System.EventHandler(this.ButtonKropka_Click);
            // 
            // równasie
            // 
            this.równasie.Location = new System.Drawing.Point(439, 444);
            this.równasie.Name = "równasie";
            this.równasie.Size = new System.Drawing.Size(75, 71);
            this.równasie.TabIndex = 11;
            this.równasie.Text = "=";
            this.równasie.UseVisualStyleBackColor = true;
            this.równasie.Click += new System.EventHandler(this.ButtonEquals_Click);
            // 
            // dodawanie
            // 
            this.dodawanie.Location = new System.Drawing.Point(521, 358);
            this.dodawanie.Name = "dodawanie";
            this.dodawanie.Size = new System.Drawing.Size(78, 77);
            this.dodawanie.TabIndex = 12;
            this.dodawanie.Text = "+";
            this.dodawanie.UseVisualStyleBackColor = true;
            this.dodawanie.Click += new System.EventHandler(this.ButtonOperator_Click);
            // 
            // odejmowanie
            // 
            this.odejmowanie.Location = new System.Drawing.Point(521, 273);
            this.odejmowanie.Name = "odejmowanie";
            this.odejmowanie.Size = new System.Drawing.Size(78, 73);
            this.odejmowanie.TabIndex = 13;
            this.odejmowanie.Text = "-";
            this.odejmowanie.UseVisualStyleBackColor = true;
            this.odejmowanie.Click += new System.EventHandler(this.ButtonOperator_Click);
            // 
            // mnozenie
            // 
            this.mnozenie.Location = new System.Drawing.Point(521, 170);
            this.mnozenie.Name = "mnozenie";
            this.mnozenie.Size = new System.Drawing.Size(78, 74);
            this.mnozenie.TabIndex = 14;
            this.mnozenie.Text = "x";
            this.mnozenie.UseVisualStyleBackColor = true;
            this.mnozenie.Click += new System.EventHandler(this.ButtonOperator_Click);
            // 
            // dzielenie
            // 
            this.dzielenie.Location = new System.Drawing.Point(610, 172);
            this.dzielenie.Name = "dzielenie";
            this.dzielenie.Size = new System.Drawing.Size(76, 72);
            this.dzielenie.TabIndex = 15;
            this.dzielenie.Text = "/";
            this.dzielenie.UseVisualStyleBackColor = true;
            this.dzielenie.Click += new System.EventHandler(this.ButtonOperator_Click);
            // 
            // pierwiastek
            // 
            this.pierwiastek.Location = new System.Drawing.Point(610, 273);
            this.pierwiastek.Name = "pierwiastek";
            this.pierwiastek.Size = new System.Drawing.Size(76, 74);
            this.pierwiastek.TabIndex = 16;
            this.pierwiastek.Text = "√";
            this.pierwiastek.UseVisualStyleBackColor = true;
            this.pierwiastek.Click += new System.EventHandler(this.ButtonPierwiastek_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Pink;
            this.pictureBox1.Location = new System.Drawing.Point(224, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(516, 552);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkOrchid;
            this.label1.Location = new System.Drawing.Point(329, 75);
            this.label1.MinimumSize = new System.Drawing.Size(300, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 60);
            this.label1.TabIndex = 18;
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // zmianakoloru
            // 
            this.zmianakoloru.Location = new System.Drawing.Point(858, 423);
            this.zmianakoloru.Name = "zmianakoloru";
            this.zmianakoloru.Size = new System.Drawing.Size(154, 54);
            this.zmianakoloru.TabIndex = 19;
            this.zmianakoloru.Text = "zmianakoloru";
            this.zmianakoloru.UseVisualStyleBackColor = true;
            this.zmianakoloru.Click += new System.EventHandler(this.zmianakoloru_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.ZegarTimer_Tick);
            // 
            // labeltime
            // 
            this.labeltime.AutoSize = true;
            this.labeltime.Location = new System.Drawing.Point(875, 110);
            this.labeltime.Name = "labeltime";
            this.labeltime.Size = new System.Drawing.Size(0, 25);
            this.labeltime.TabIndex = 20;
            // 
            // zmianazegara
            // 
            this.zmianazegara.Location = new System.Drawing.Point(838, 230);
            this.zmianazegara.Name = "zmianazegara";
            this.zmianazegara.Size = new System.Drawing.Size(187, 51);
            this.zmianazegara.TabIndex = 21;
            this.zmianazegara.Text = "zmień zegar";
            this.zmianazegara.UseVisualStyleBackColor = true;
            this.zmianazegara.Click += new System.EventHandler(this.ZmianaZegaru_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(820, 138);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 75);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // zeruj
            // 
            this.zeruj.Location = new System.Drawing.Point(610, 358);
            this.zeruj.Name = "zeruj";
            this.zeruj.Size = new System.Drawing.Size(76, 77);
            this.zeruj.TabIndex = 23;
            this.zeruj.Text = "zeruj";
            this.zeruj.UseVisualStyleBackColor = true;
            this.zeruj.Click += new System.EventHandler(this.zeruj_Click);
            // 
            // procent
            // 
            this.procent.Location = new System.Drawing.Point(610, 444);
            this.procent.Name = "procent";
            this.procent.Size = new System.Drawing.Size(76, 74);
            this.procent.TabIndex = 24;
            this.procent.Text = "%";
            this.procent.UseVisualStyleBackColor = true;
            this.procent.Click += new System.EventHandler(this.procent_Click);
            // 
            // zmianaznaku
            // 
            this.zmianaznaku.Location = new System.Drawing.Point(521, 444);
            this.zmianaznaku.Name = "zmianaznaku";
            this.zmianaznaku.Size = new System.Drawing.Size(78, 71);
            this.zmianaznaku.TabIndex = 25;
            this.zmianaznaku.Text = "+/-";
            this.zmianaznaku.UseVisualStyleBackColor = true;
            this.zmianaznaku.Click += new System.EventHandler(this.zmianaznaku_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 576);
            this.Controls.Add(this.zmianaznaku);
            this.Controls.Add(this.procent);
            this.Controls.Add(this.zeruj);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.zmianazegara);
            this.Controls.Add(this.labeltime);
            this.Controls.Add(this.zmianakoloru);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pierwiastek);
            this.Controls.Add(this.dzielenie);
            this.Controls.Add(this.mnozenie);
            this.Controls.Add(this.odejmowanie);
            this.Controls.Add(this.dodawanie);
            this.Controls.Add(this.równasie);
            this.Controls.Add(this.kropka);
            this.Controls.Add(this.przycisk0);
            this.Controls.Add(this.przycisk3);
            this.Controls.Add(this.przycisk2);
            this.Controls.Add(this.przycisk1);
            this.Controls.Add(this.przycisk6);
            this.Controls.Add(this.przycisk5);
            this.Controls.Add(this.przycisk4);
            this.Controls.Add(this.przycisk9);
            this.Controls.Add(this.przycisk8);
            this.Controls.Add(this.przycisk7);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button przycisk7;
        private Button przycisk8;
        private Button przycisk9;
        private Button przycisk4;
        private Button przycisk5;
        private Button przycisk6;
        private Button przycisk1;
        private Button przycisk2;
        private Button przycisk3;
        private Button przycisk0;
        private Button kropka;
        private Button równasie;
        private Button dodawanie;
        private Button odejmowanie;
        private Button mnozenie;
        private Button dzielenie;
        private Button pierwiastek;
        private PictureBox pictureBox1;
        private Label label1;
        private Button zmianakoloru;
        //private System.Windows.Forms.Timer timer1;
        private Label labeltime;
        private Button zmianazegara;
        private PictureBox pictureBox2;
        private Button zeruj;
        private Button procent;
        private Button zmianaznaku;
    }
}