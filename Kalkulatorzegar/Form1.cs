using static System.Net.Mime.MediaTypeNames;

namespace Kalkulatorzegar
{
    public partial class Form1 : Form
    {
        private string poprzedniUzytyOperator = " ";
        private bool kliknietyOperator = false;
        public double aktualnaWartosc=0;
        private bool znakZostalJuzUzyty = false;
        private double liczbaPoZnaku = 0;
        private System.Windows.Forms.Timer timer;
        private bool znakiPodRzad = false;
        private bool kolejnaOperacja = false;
        bool wystapilBlad = false;
        
        public Form1()
        {
            InitializeComponent();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; 
            timer.Tick += ZegarTimer_Tick;
            timer.Start();
            pictureBox2.Paint += pictureBox2_Paint;
            label1.Text="0";
            this.KeyPress += new KeyPressEventHandler(Form1_KeyPress);
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);

            this.KeyPreview = true;
        }
        
        private void ButtonLiczba_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(label1.Text, out _))
            {
                label1.Text = "0"; 
            }
            if (kolejnaOperacja==true)
            {
                label1.Text="";
                
                kolejnaOperacja=false;
                aktualnaWartosc=0;
            }
            if (kliknietyOperator)
            {
                label1.Text = "";  
                kliknietyOperator = false;

            }
            if (label1.Text == "0")
            {
                label1.Text = ""; 
            }
            
            Button button = (Button)sender;  //pozyskiwanie wiadomosci o liczbie
            label1.Text += button.Text ;
            znakiPodRzad=false;
            
        }

        private void ButtonKropka_Click(object sender, EventArgs e)
        {   
            if (!label1.Text.Contains(",")) { 
                label1.Text += ",";
            }
            znakiPodRzad=false;

        }

        private void ButtonOperator_Click(object sender, EventArgs e)
        {
            string operatorText;

            if (sender is Button button)
            {
                operatorText = button.Text;
            }
            else if (sender is string op)
            {
                operatorText = op;
            }
            else
            {
                return; 
            }

            kliknietyOperator = true;

            try
            {
                if (!string.IsNullOrEmpty(label1.Text))
                {
                    if (znakiPodRzad)
                    {
                        label1.Text = aktualnaWartosc.ToString();
                    }
                    else if (znakZostalJuzUzyty)
                    {
                        liczbaPoZnaku = Convert.ToDouble(label1.Text);
                        switch (poprzedniUzytyOperator)
                        {
                            case "+":
                                aktualnaWartosc += liczbaPoZnaku;
                                break;
                            case "-":
                                aktualnaWartosc -= liczbaPoZnaku;
                                break;
                            case "x":
                                aktualnaWartosc *= liczbaPoZnaku;
                                break;
                            case "/":
                                if (liczbaPoZnaku != 0)
                                {
                                    aktualnaWartosc /= liczbaPoZnaku;
                                }
                                else
                                {
                                    label1.Text = "B³¹d: Dzielenie przez 0";
                                    wystapilBlad=true;
                                    zeruj_Click(sender, e);
                                    return;
                                }
                                break;
                        }
                        poprzedniUzytyOperator = operatorText;
                        label1.Text = aktualnaWartosc.ToString();
                    }
                    else
                    {
                        aktualnaWartosc = Convert.ToDouble(label1.Text);
                        poprzedniUzytyOperator = operatorText;
                        label1.Text = aktualnaWartosc.ToString();
                        znakZostalJuzUzyty = true;
                    }
                }
                znakiPodRzad = true;
                kolejnaOperacja = false;
            }
            catch (FormatException)
            {
                label1.Text = "B³¹d: Nieprawid³owy format liczby";
                wystapilBlad=true;
                zeruj_Click(sender, e);
            }

           
        }
        private void ButtonPierwiastek_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.TryParse(label1.Text, out liczbaPoZnaku))
                {
                    if (liczbaPoZnaku>0)
                    {
                        double wynik = Math.Sqrt(liczbaPoZnaku);
                        label1.Text = wynik.ToString();
                    }
                    else if (liczbaPoZnaku < 0)
                    {
                        label1.Text = "B³¹d: Liczba nie mo¿e byæ ujemna";
                        wystapilBlad=true;
                        zeruj_Click(sender, e);
                    }
                }
            }
            catch (OverflowException)
            {
                label1.Text = "B³¹d: Liczba zbyt du¿a";
                wystapilBlad=true;
                zeruj_Click(sender, e);
            }
            catch (Exception)
            {
                label1.Text = "B³¹d: Nieoczekiwany problem";
                zeruj_Click(sender, e);
            }
        }

        private void ButtonEquals_Click(object sender, EventArgs e)
        {
            try
            {
                if (poprzedniUzytyOperator != " " && !znakiPodRzad)
                {
                    double liczbaPoZnaku = Convert.ToDouble(label1.Text);
                    switch (poprzedniUzytyOperator)
                    {
                        case "+":
                            aktualnaWartosc += liczbaPoZnaku;
                            break;
                        case "-":
                            aktualnaWartosc -= liczbaPoZnaku;
                            break;
                        case "x":
                            aktualnaWartosc *= liczbaPoZnaku;
                            break;
                        case "/":
                            if (liczbaPoZnaku != 0)
                            {
                                aktualnaWartosc /= liczbaPoZnaku;
                            }
                            else
                            {
                                label1.Text = "B³¹d: Dzielenie przez 0";
                                wystapilBlad=true;
                                zeruj_Click(sender, e);
                                return;
                            }
                            break;
                    }
                    label1.Text = aktualnaWartosc.ToString();
                    poprzedniUzytyOperator = " ";
                    kolejnaOperacja = true;
                    znakZostalJuzUzyty = false;
                }
            }
            catch (FormatException)
            {
                label1.Text = "B³¹d: Nieprawid³owy format liczby";
                wystapilBlad=true;
                zeruj_Click(sender, e);
            }
        }
        private void zeruj_Click(object sender, EventArgs e) 
        {
            
            if (wystapilBlad==false)
            {
                label1.Text = "0";
            }
           
            aktualnaWartosc = 0;
            poprzedniUzytyOperator = " ";
            kliknietyOperator = false;
            znakZostalJuzUzyty = false;
            liczbaPoZnaku = 0;
            znakiPodRzad = false;
            kolejnaOperacja = false;
            wystapilBlad=false;
            
        }

        private void zmianakoloru_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int r = random.Next(0, 256); // Generowanie losowego koloru
            int g = random.Next(0, 256);
            int b = random.Next(0, 256);

            this.pictureBox1.BackColor = Color.FromArgb(r, g, b);
        }

        private bool jestzegarcyfrowy = true;
        private void ZegarTimer_Tick(object sender, EventArgs e)
        {
            if (jestzegarcyfrowy)
            {
                labeltime.Text = DateTime.Now.ToString("HH:mm:ss");
                pictureBox2.Visible = false;
            }
            else
            {
                pictureBox2.Invalidate(); //Odœwie¿anie
            }
        }
        private void ZmianaZegaru_Click(object sender, EventArgs e) {
            jestzegarcyfrowy = !jestzegarcyfrowy; // Prze³¹cz tryb

            if (jestzegarcyfrowy)
            {
                labeltime.Visible = true;   
                pictureBox2.Visible = false;    
            }
            else
            {
                labeltime.Visible = false;  
                pictureBox2.Visible = true;   
                pictureBox2.Invalidate();
               
            }
        }
        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            if (!jestzegarcyfrowy)
            {
                DateTime teraz = DateTime.Now;
                int srodekX = pictureBox2.Width / 2;
                int srodekY = pictureBox2.Height / 2;
                int promien = Math.Min(srodekX, srodekY) - 10;

                // Rysowanie tarczy zegara
                e.Graphics.DrawEllipse(Pens.Pink, srodekX - promien, srodekY - promien, promien * 2, promien * 2);

                // wskazówka h
                RysujWskazowke(e.Graphics, srodekX, srodekY, (teraz.Hour % 12 + teraz.Minute / 60.0) * 30, promien * 0.5f, Pens.Black);

                // wskazówka min
                RysujWskazowke(e.Graphics, srodekX, srodekY, teraz.Minute * 6, promien * 0.75f, Pens.DarkViolet);

                // wskazówka s
                RysujWskazowke(e.Graphics, srodekX, srodekY, teraz.Second * 6, promien * 0.9f, Pens.Red);
            }
        }

        private void RysujWskazowke(Graphics g, int srodekX, int srodekY, double katStopni, float dlugosc, Pen kolor)
        {
            double katRadiany = (katStopni - 90) * Math.PI / 180.0;
            int koniecX = srodekX + (int)(dlugosc * Math.Cos(katRadiany));
            int koniecY = srodekY + (int)(dlugosc * Math.Sin(katRadiany));
            g.DrawLine(kolor, srodekX, srodekY, koniecX, koniecY);
        }
       
        private void procent_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(label1.Text))
                {
                    double wartosc = Convert.ToDouble(label1.Text);
                    label1.Text = (wartosc / 100).ToString();
                }
            }
            catch (FormatException)
            {
                label1.Text = "B³¹d: Nieprawid³owy format liczby";
                wystapilBlad=true;
                zeruj_Click(sender, e);
            }

        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.ActiveControl = null;

            char key = e.KeyChar;

            if (char.IsDigit(key))
            {
                if (kolejnaOperacja)
                {
                    label1.Text = "";
                    aktualnaWartosc = 0;
                    poprzedniUzytyOperator=" ";
                    znakZostalJuzUzyty=false;
                    kolejnaOperacja=false;
                }
                if (kliknietyOperator)
                {
                    label1.Text = "";
                    kliknietyOperator = false;
                }
                if (label1.Text == "0" || kliknietyOperator)
                {
                    label1.Text = ""; 
                    kliknietyOperator = false;
                }

                label1.Text += key;
                znakiPodRzad=false;
            }
            else if (key == ',' && !label1.Text.Contains(","))
            {
                if (string.IsNullOrWhiteSpace(label1.Text))
                    label1.Text = "0";

                label1.Text += ",";
            }
            
            else if (key == (char)Keys.Escape)
            {
                zeruj_Click(sender, e);
            }
            else if (key == (char)Keys.Back && label1.Text.Length > 0)
            {
                label1.Text = label1.Text.Remove(label1.Text.Length - 1);
                if (string.IsNullOrEmpty(label1.Text))
                    label1.Text = "0";
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            this.ActiveControl = null;

            if (e.KeyCode == Keys.Enter)  
            {
                ButtonEquals_Click(sender, e);  
            }
            else
            {
                switch (e.KeyCode)
                {
                    case Keys.Add:
                    case Keys.Oemplus:
                        ButtonOperator_Click("+", EventArgs.Empty);
                        break;

                    case Keys.Subtract:
                    case Keys.OemMinus:
                        ButtonOperator_Click("-", EventArgs.Empty);
                        break;

                    case Keys.Multiply:
                    case Keys.D8 when e.Shift:
                        ButtonOperator_Click("x", EventArgs.Empty);
                        break;

                    case Keys.Divide: 
                    case Keys.Oem2:
                        ButtonOperator_Click("/", EventArgs.Empty);
                        break;
                }
            }
        }

        private void zmianaznaku_Click(object sender, EventArgs e)
        {
            if (double.TryParse(label1.Text, out double liczba))  // Sprawdzamy, czy na wyœwietlaczu jest liczba, której mo¿na zmieniæ znak
            {
                liczba = -liczba;

                label1.Text = liczba.ToString();
            }
            else
            {
                label1.Text = "B³¹d: Nieprawid³owy format liczby";
                wystapilBlad=true;
                zeruj_Click(sender, e);
            }
        }
    }
}