
namespace Picture2
{
    public partial class Form1 : Form
    {
        
        public string[] fn = System.IO.Directory.GetFiles(Application.StartupPath + "\\Picrures", "*.png");
        System.Drawing.Color someColor;
        Dictionary<Color, System.Drawing.Color> colors = new Dictionary<Color, System.Drawing.Color>();
        enum Color
        {
            Aquamarine,
            Azure,
            burlywood,
            cadetblue,
            gainsboro,
            gold,
            khaki,
            lawngreen,
            lightgreen,
            lightskyblue,
            linen,
            mediumorchid,
            mediumpurple,
            mistyrose,
            olive,
            olivedrab,
            orange,
            orangered,
            orchid,
            paleturquoise,
            peru,
            pink,
            plum,
            royalblue,
            sandybrown,
            seagreen,
            steelblue,
        }
        public Form1()
        {
            InitializeComponent();
            numericUpDown1.Maximum = 40;
            numericUpDown1.Minimum = 1;

            for (int i = 2; i <= 40; i++)
            {
                (Controls["pictureBox" + i] as PictureBox).Visible = false;
            }
            colors.Add(Color.Aquamarine, System.Drawing.Color.Aquamarine);
            colors.Add(Color.Azure, System.Drawing.Color.Azure);
            colors.Add(Color.burlywood, System.Drawing.Color.BurlyWood);
            colors.Add(Color.cadetblue, System.Drawing.Color.CadetBlue);
            colors.Add(Color.gainsboro, System.Drawing.Color.Gainsboro);
            colors.Add(Color.gold, System.Drawing.Color.Gold);
            colors.Add(Color.khaki, System.Drawing.Color.Khaki);
            colors.Add(Color.lawngreen, System.Drawing.Color.LawnGreen);
            colors.Add(Color.lightgreen, System.Drawing.Color.LightGreen);
            colors.Add(Color.lightskyblue, System.Drawing.Color.LightSkyBlue);
            colors.Add(Color.linen, System.Drawing.Color.Linen);
            colors.Add(Color.mediumorchid, System.Drawing.Color.MediumOrchid);
            colors.Add(Color.mediumpurple, System.Drawing.Color.MediumPurple);
            colors.Add(Color.mistyrose, System.Drawing.Color.MistyRose);
            colors.Add(Color.olive, System.Drawing.Color.Olive);
            colors.Add(Color.olivedrab, System.Drawing.Color.OliveDrab);
            colors.Add(Color.orange, System.Drawing.Color.Orange);
            colors.Add(Color.orangered, System.Drawing.Color.OrangeRed);
            colors.Add(Color.orchid, System.Drawing.Color.Orchid);
            colors.Add(Color.paleturquoise, System.Drawing.Color.PaleTurquoise);
            colors.Add(Color.peru, System.Drawing.Color.Peru);
            colors.Add(Color.pink, System.Drawing.Color.Pink);
            colors.Add(Color.plum, System.Drawing.Color.Plum);
            colors.Add(Color.royalblue, System.Drawing.Color.RoyalBlue);
            colors.Add(Color.sandybrown, System.Drawing.Color.SandyBrown);
            colors.Add(Color.seagreen, System.Drawing.Color.SeaGreen);
            colors.Add(Color.steelblue, System.Drawing.Color.SteelBlue);

        }

        private static Color SetColor()
        {
            Array values = Enum.GetValues(typeof(Color));
            Random rnd = new Random();
            Color randomBar = (Color)values.GetValue(rnd.Next(values.Length));
            return randomBar;
        }

        private Image GetImage()
        {
            Random rand = new Random();

            return Image.FromFile(fn[rand.Next(0, fn.Length)]);
        }
        private void button1_Click(object sender, EventArgs e)
        {
                for (int k = 2; k <= numericUpDown1.Value; k++)
                    (Controls["pictureBox" + k] as PictureBox).Visible = true;

            for (int j = 40; j > numericUpDown1.Value; j--)
                    (Controls["pictureBox" + j] as PictureBox).Visible = false; 

                for (int c  = 1; c <= 40; c++)
                {
                    if (fn.Length > 0) (Controls["pictureBox" + c] as PictureBox).Image = GetImage();
                    someColor = colors[SetColor()];
                    (Controls["pictureBox" + c] as PictureBox).BackColor = someColor;
                }         
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (fn.Length > 0) pictureBox1.Image = GetImage();
            System.Drawing.Color someColor = colors[SetColor()];
            pictureBox1.BackColor = someColor;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (fn.Length > 0) pictureBox2.Image = GetImage();
            System.Drawing.Color someColor = colors[SetColor()];
            pictureBox2.BackColor = someColor;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (fn.Length > 0) pictureBox3.Image = GetImage();
            System.Drawing.Color someColor = colors[SetColor()];
            pictureBox3.BackColor = someColor;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (fn.Length > 0) pictureBox4.Image = GetImage();
            System.Drawing.Color someColor = colors[SetColor()];
            pictureBox4.BackColor = someColor;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (fn.Length > 0) pictureBox5.Image = GetImage();
            System.Drawing.Color someColor = colors[SetColor()];
            pictureBox5.BackColor = someColor;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (fn.Length > 0) pictureBox6.Image = GetImage();
            System.Drawing.Color someColor = colors[SetColor()];
            pictureBox6.BackColor = someColor;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (fn.Length > 0) pictureBox7.Image = GetImage();
            System.Drawing.Color someColor = colors[SetColor()];
            pictureBox7.BackColor = someColor;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (fn.Length > 0) pictureBox8.Image = GetImage();
            System.Drawing.Color someColor = colors[SetColor()];
            pictureBox8.BackColor = someColor;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (fn.Length > 0) pictureBox9.Image = GetImage();
            System.Drawing.Color someColor = colors[SetColor()];
            pictureBox9.BackColor = someColor;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (fn.Length > 0) pictureBox10.Image = GetImage();
            System.Drawing.Color someColor = colors[SetColor()];
            pictureBox10.BackColor = someColor;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (fn.Length > 0) pictureBox11.Image = GetImage();
            System.Drawing.Color someColor = colors[SetColor()];
            pictureBox11.BackColor = someColor;
        }
        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (fn.Length > 0) pictureBox12.Image = GetImage();
            System.Drawing.Color someColor = colors[SetColor()];
            pictureBox12.BackColor = someColor;
        }
        private void pictureBox13_Click(object sender, EventArgs e)
        {
            if (fn.Length > 0) pictureBox13.Image = GetImage();
            System.Drawing.Color someColor = colors[SetColor()];
            pictureBox13.BackColor = someColor;
        }
        private void pictureBox14_Click(object sender, EventArgs e)
        {
            if (fn.Length > 0) pictureBox14.Image = GetImage();
            System.Drawing.Color someColor = colors[SetColor()];
            pictureBox14.BackColor = someColor;
        }
        private void pictureBox15_Click(object sender, EventArgs e)
        {
            if (fn.Length > 0) pictureBox15.Image = GetImage();
            System.Drawing.Color someColor = colors[SetColor()];
            pictureBox15.BackColor = someColor;
        }
        private void pictureBox16_Click(object sender, EventArgs e)
        {
            if (fn.Length > 0) pictureBox16.Image = GetImage();
            System.Drawing.Color someColor = colors[SetColor()];
            pictureBox16.BackColor = someColor;
        }
        private void pictureBox17_Click(object sender, EventArgs e)
        {
            if (fn.Length > 0) pictureBox17.Image = GetImage();
            System.Drawing.Color someColor = colors[SetColor()];
            pictureBox17.BackColor = someColor;
        }
        private void pictureBox18_Click(object sender, EventArgs e)
        {
            if (fn.Length > 0) pictureBox18.Image = GetImage();
            System.Drawing.Color someColor = colors[SetColor()];
            pictureBox18.BackColor = someColor;
        }
        private void pictureBox19_Click(object sender, EventArgs e)
        {
            if (fn.Length > 0) pictureBox19.Image = GetImage();
            System.Drawing.Color someColor = colors[SetColor()];
            pictureBox19.BackColor = someColor;
        }
        private void pictureBox20_Click(object sender, EventArgs e)
        {
            if (fn.Length > 0) pictureBox20.Image = GetImage();
            System.Drawing.Color someColor = colors[SetColor()];
            pictureBox20.BackColor = someColor;
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            if (fn.Length > 0) pictureBox21.Image = GetImage();
            System.Drawing.Color someColor = colors[SetColor()];
            pictureBox21.BackColor = someColor;
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            if (fn.Length > 0) pictureBox22.Image = GetImage();
            System.Drawing.Color someColor = colors[SetColor()];
            pictureBox22.BackColor = someColor;
        }
        private void pictureBox23_Click(object sender, EventArgs e)
        {
            if (fn.Length > 0) pictureBox23.Image = GetImage();
            System.Drawing.Color someColor = colors[SetColor()];
            pictureBox23.BackColor = someColor;
        }
        private void pictureBox24_Click(object sender, EventArgs e)
        {
            if (fn.Length > 0) pictureBox24.Image = GetImage();
            System.Drawing.Color someColor = colors[SetColor()];
            pictureBox24.BackColor = someColor;
        }
        private void pictureBox25_Click(object sender, EventArgs e)
        {
            if (fn.Length > 0) pictureBox25.Image = GetImage();
            System.Drawing.Color someColor = colors[SetColor()];
            pictureBox25.BackColor = someColor;
        }
        private void pictureBox26_Click(object sender, EventArgs e)
        {
            if (fn.Length > 0) pictureBox26.Image = GetImage();
            System.Drawing.Color someColor = colors[SetColor()];
            pictureBox26.BackColor = someColor;
        }
        private void pictureBox27_Click(object sender, EventArgs e)
        {
            if (fn.Length > 0) pictureBox27.Image = GetImage();
            System.Drawing.Color someColor = colors[SetColor()];
            pictureBox27.BackColor = someColor;
        }
        private void pictureBox28_Click(object sender, EventArgs e)
        {
            if (fn.Length > 0) pictureBox28.Image = GetImage();
            System.Drawing.Color someColor = colors[SetColor()];
            pictureBox28.BackColor = someColor;
        }
        private void pictureBox29_Click(object sender, EventArgs e)
        {
            if (fn.Length > 0) pictureBox29.Image = GetImage();
            System.Drawing.Color someColor = colors[SetColor()];
            pictureBox29.BackColor = someColor;
        }
        private void pictureBox30_Click(object sender, EventArgs e)
        {
            if (fn.Length > 0) pictureBox30.Image = GetImage();
            System.Drawing.Color someColor = colors[SetColor()];
            pictureBox30.BackColor = someColor;
        }
        private void pictureBox31_Click(object sender, EventArgs e)
        {
            if (fn.Length > 0) pictureBox31.Image = GetImage();
            System.Drawing.Color someColor = colors[SetColor()];
            pictureBox31.BackColor = someColor;
        }
        private void pictureBox32_Click(object sender, EventArgs e)
        {
            if (fn.Length > 0) pictureBox32.Image = GetImage();
            System.Drawing.Color someColor = colors[SetColor()];
            pictureBox32.BackColor = someColor;
        }
        private void pictureBox33_Click(object sender, EventArgs e)
        {
            if (fn.Length > 0) pictureBox33.Image = GetImage();
            System.Drawing.Color someColor = colors[SetColor()];
            pictureBox33.BackColor = someColor;
        }
        private void pictureBox34_Click(object sender, EventArgs e)
        {
            if (fn.Length > 0) pictureBox34.Image = GetImage();
            System.Drawing.Color someColor = colors[SetColor()];
            pictureBox34.BackColor = someColor;
        }
        private void pictureBox35_Click(object sender, EventArgs e)
        {
            if (fn.Length > 0) pictureBox35.Image = GetImage();
            System.Drawing.Color someColor = colors[SetColor()];
            pictureBox35.BackColor = someColor;
        }
        private void pictureBox36_Click(object sender, EventArgs e)
        {
            if (fn.Length > 0) pictureBox36.Image = GetImage();
            System.Drawing.Color someColor = colors[SetColor()];
            pictureBox36.BackColor = someColor;
        }
        private void pictureBox37_Click(object sender, EventArgs e)
        {
            if (fn.Length > 0) pictureBox37.Image = GetImage();
            System.Drawing.Color someColor = colors[SetColor()];
            pictureBox37.BackColor = someColor;
        }

        private void pictureBox38_Click(object sender, EventArgs e)
        {
            if (fn.Length > 0) pictureBox38.Image = GetImage();
            System.Drawing.Color someColor = colors[SetColor()];
            pictureBox38.BackColor = someColor;
        }

        private void pictureBox39_Click(object sender, EventArgs e)
        {
            if (fn.Length > 0) pictureBox39.Image = GetImage();
            System.Drawing.Color someColor = colors[SetColor()];
            pictureBox39.BackColor = someColor;
        }

        private void pictureBox40_Click(object sender, EventArgs e)
        {
            if (fn.Length > 0) pictureBox40.Image = GetImage();
            System.Drawing.Color someColor = colors[SetColor()];
            pictureBox40.BackColor = someColor;
        }
    }
}