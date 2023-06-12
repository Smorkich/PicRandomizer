
namespace Picture2
{
    public partial class Form1 : Form
    {
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

        Dictionary<Color, System.Drawing.Color> colors = new Dictionary<Color, System.Drawing.Color>();
        private string[] fn = System.IO.Directory.GetFiles(Application.StartupPath + "\\Picrures", "*.png");

        public Form1()
        {
            InitializeComponent();
            numericUpDown1.Maximum = 40;
            numericUpDown1.Minimum = 1;

            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            pictureBox19.Visible = false;
            pictureBox20.Visible = false;
            pictureBox21.Visible = false;
            pictureBox22.Visible = false;
            pictureBox23.Visible = false;
            pictureBox24.Visible = false;
            pictureBox25.Visible = false;
            pictureBox26.Visible = false;
            pictureBox27.Visible = false;
            pictureBox28.Visible = false;
            pictureBox29.Visible = false;
            pictureBox30.Visible = false;
            pictureBox31.Visible = false;
            pictureBox32.Visible = false;
            pictureBox33.Visible = false;
            pictureBox34.Visible = false;
            pictureBox35.Visible = false;
            pictureBox36.Visible = false;
            pictureBox37.Visible = false;
            pictureBox38.Visible = false;
            pictureBox39.Visible = false;
            pictureBox40.Visible = false;

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

        //private void DestroyPic()
        //{

        //}

        private void button1_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < 40; i++)
            //{

            //}
            if (numericUpDown1.Value == 2)
            {
                pictureBox2.Visible = true;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
            }
            if (numericUpDown1.Value == 3)
            {
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
            }
            if (numericUpDown1.Value == 4)
            {
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
            }
            if (numericUpDown1.Value == 5)
            {
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
            }
            if (numericUpDown1.Value == 6)
            {
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
            }
            if (numericUpDown1.Value == 7)
            {
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
            }
            if (numericUpDown1.Value == 8)
            {
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;

            }
            if (numericUpDown1.Value == 9)
            {
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
                pictureBox9.Visible = true;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
            }
            if (numericUpDown1.Value == 10)
            {
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
                pictureBox9.Visible = true;
                pictureBox10.Visible = true;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
            }
            if (numericUpDown1.Value == 11)
            {
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
                pictureBox9.Visible = true;
                pictureBox10.Visible = true;
                pictureBox11.Visible = true;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
            }
            if (numericUpDown1.Value == 12)
            {
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
                pictureBox9.Visible = true;
                pictureBox10.Visible = true;
                pictureBox11.Visible = true;
                pictureBox12.Visible = true;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
            }
            if (numericUpDown1.Value == 13)
            {
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
                pictureBox9.Visible = true;
                pictureBox10.Visible = true;
                pictureBox11.Visible = true;
                pictureBox12.Visible = true;
                pictureBox13.Visible = true;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;

            }
            if (numericUpDown1.Value == 14)
            {
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
                pictureBox9.Visible = true;
                pictureBox10.Visible = true;
                pictureBox11.Visible = true;
                pictureBox12.Visible = true;
                pictureBox13.Visible = true;
                pictureBox14.Visible = true;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
            }
            if (numericUpDown1.Value == 15)
            {
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
                pictureBox9.Visible = true;
                pictureBox10.Visible = true;
                pictureBox11.Visible = true;
                pictureBox12.Visible = true;
                pictureBox13.Visible = true;
                pictureBox14.Visible = true;
                pictureBox15.Visible = true;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
            }
            if (numericUpDown1.Value == 16)
            {
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
                pictureBox9.Visible = true;
                pictureBox10.Visible = true;
                pictureBox11.Visible = true;
                pictureBox12.Visible = true;
                pictureBox13.Visible = true;
                pictureBox14.Visible = true;
                pictureBox15.Visible = true;
                pictureBox16.Visible = true;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
            }
            if (numericUpDown1.Value == 17)
            {
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
                pictureBox9.Visible = true;
                pictureBox10.Visible = true;
                pictureBox11.Visible = true;
                pictureBox12.Visible = true;
                pictureBox13.Visible = true;
                pictureBox14.Visible = true;
                pictureBox15.Visible = true;
                pictureBox16.Visible = true;
                pictureBox17.Visible = true;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
            }
            if (numericUpDown1.Value == 18)
            {
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
                pictureBox9.Visible = true;
                pictureBox10.Visible = true;
                pictureBox11.Visible = true;
                pictureBox12.Visible = true;
                pictureBox13.Visible = true;
                pictureBox14.Visible = true;
                pictureBox15.Visible = true;
                pictureBox16.Visible = true;
                pictureBox17.Visible = true;
                pictureBox18.Visible = true;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
            }
            if (numericUpDown1.Value == 19)
            {
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
                pictureBox9.Visible = true;
                pictureBox10.Visible = true;
                pictureBox11.Visible = true;
                pictureBox12.Visible = true;
                pictureBox13.Visible = true;
                pictureBox14.Visible = true;
                pictureBox15.Visible = true;
                pictureBox16.Visible = true;
                pictureBox17.Visible = true;
                pictureBox18.Visible = true;
                pictureBox19.Visible = true;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
            }
            if (numericUpDown1.Value == 20)
            {
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
                pictureBox9.Visible = true;
                pictureBox10.Visible = true;
                pictureBox11.Visible = true;
                pictureBox12.Visible = true;
                pictureBox13.Visible = true;
                pictureBox14.Visible = true;
                pictureBox15.Visible = true;
                pictureBox16.Visible = true;
                pictureBox17.Visible = true;
                pictureBox18.Visible = true;
                pictureBox19.Visible = true;
                pictureBox20.Visible = true;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
            }

            if (numericUpDown1.Value == 21)
            {
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
                pictureBox9.Visible = true;
                pictureBox10.Visible = true;
                pictureBox11.Visible = true;
                pictureBox12.Visible = true;
                pictureBox13.Visible = true;
                pictureBox14.Visible = true;
                pictureBox15.Visible = true;
                pictureBox16.Visible = true;
                pictureBox17.Visible = true;
                pictureBox18.Visible = true;
                pictureBox19.Visible = true;
                pictureBox20.Visible = true;
                pictureBox21.Visible = true;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
            }
            if (numericUpDown1.Value == 22)
            {
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
                pictureBox9.Visible = true;
                pictureBox10.Visible = true;
                pictureBox11.Visible = true;
                pictureBox12.Visible = true;
                pictureBox13.Visible = true;
                pictureBox14.Visible = true;
                pictureBox15.Visible = true;
                pictureBox16.Visible = true;
                pictureBox17.Visible = true;
                pictureBox18.Visible = true;
                pictureBox19.Visible = true;
                pictureBox20.Visible = true;
                pictureBox21.Visible = true;
                pictureBox22.Visible = true;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
            }
            if (numericUpDown1.Value == 23)
            {
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
                pictureBox9.Visible = true;
                pictureBox10.Visible = true;
                pictureBox11.Visible = true;
                pictureBox12.Visible = true;
                pictureBox13.Visible = true;
                pictureBox14.Visible = true;
                pictureBox15.Visible = true;
                pictureBox16.Visible = true;
                pictureBox17.Visible = true;
                pictureBox18.Visible = true;
                pictureBox19.Visible = true;
                pictureBox20.Visible = true;
                pictureBox21.Visible = true;
                pictureBox22.Visible = true;
                pictureBox23.Visible = true;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
            }
            if (numericUpDown1.Value == 24)
            {
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
                pictureBox9.Visible = true;
                pictureBox10.Visible = true;
                pictureBox11.Visible = true;
                pictureBox12.Visible = true;
                pictureBox13.Visible = true;
                pictureBox14.Visible = true;
                pictureBox15.Visible = true;
                pictureBox16.Visible = true;
                pictureBox17.Visible = true;
                pictureBox18.Visible = true;
                pictureBox19.Visible = true;
                pictureBox20.Visible = true;
                pictureBox21.Visible = true;
                pictureBox22.Visible = true;
                pictureBox23.Visible = true;
                pictureBox24.Visible = true;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
            }
            if (numericUpDown1.Value == 25)
            {
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
                pictureBox9.Visible = true;
                pictureBox10.Visible = true;
                pictureBox11.Visible = true;
                pictureBox12.Visible = true;
                pictureBox13.Visible = true;
                pictureBox14.Visible = true;
                pictureBox15.Visible = true;
                pictureBox16.Visible = true;
                pictureBox17.Visible = true;
                pictureBox18.Visible = true;
                pictureBox19.Visible = true;
                pictureBox20.Visible = true;
                pictureBox21.Visible = true;
                pictureBox22.Visible = true;
                pictureBox23.Visible = true;
                pictureBox24.Visible = true;
                pictureBox25.Visible = true;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
            }
            if (numericUpDown1.Value == 26)
            {
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
                pictureBox9.Visible = true;
                pictureBox10.Visible = true;
                pictureBox11.Visible = true;
                pictureBox12.Visible = true;
                pictureBox13.Visible = true;
                pictureBox14.Visible = true;
                pictureBox15.Visible = true;
                pictureBox16.Visible = true;
                pictureBox17.Visible = true;
                pictureBox18.Visible = true;
                pictureBox19.Visible = true;
                pictureBox20.Visible = true;
                pictureBox21.Visible = true;
                pictureBox22.Visible = true;
                pictureBox23.Visible = true;
                pictureBox24.Visible = true;
                pictureBox25.Visible = true;
                pictureBox26.Visible = true;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
            }
            if (numericUpDown1.Value == 27)
            {
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
                pictureBox9.Visible = true;
                pictureBox10.Visible = true;
                pictureBox11.Visible = true;
                pictureBox12.Visible = true;
                pictureBox13.Visible = true;
                pictureBox14.Visible = true;
                pictureBox15.Visible = true;
                pictureBox16.Visible = true;
                pictureBox17.Visible = true;
                pictureBox18.Visible = true;
                pictureBox19.Visible = true;
                pictureBox20.Visible = true;
                pictureBox21.Visible = true;
                pictureBox22.Visible = true;
                pictureBox23.Visible = true;
                pictureBox24.Visible = true;
                pictureBox25.Visible = true;
                pictureBox26.Visible = true;
                pictureBox27.Visible = true;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
            }
            if (numericUpDown1.Value == 28)
            {
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
                pictureBox9.Visible = true;
                pictureBox10.Visible = true;
                pictureBox11.Visible = true;
                pictureBox12.Visible = true;
                pictureBox13.Visible = true;
                pictureBox14.Visible = true;
                pictureBox15.Visible = true;
                pictureBox16.Visible = true;
                pictureBox17.Visible = true;
                pictureBox18.Visible = true;
                pictureBox19.Visible = true;
                pictureBox20.Visible = true;
                pictureBox21.Visible = true;
                pictureBox22.Visible = true;
                pictureBox23.Visible = true;
                pictureBox24.Visible = true;
                pictureBox25.Visible = true;
                pictureBox26.Visible = true;
                pictureBox27.Visible = true;
                pictureBox28.Visible = true;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
            }
            if (numericUpDown1.Value == 29)
            {
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
                pictureBox9.Visible = true;
                pictureBox10.Visible = true;
                pictureBox11.Visible = true;
                pictureBox12.Visible = true;
                pictureBox13.Visible = true;
                pictureBox14.Visible = true;
                pictureBox15.Visible = true;
                pictureBox16.Visible = true;
                pictureBox17.Visible = true;
                pictureBox18.Visible = true;
                pictureBox19.Visible = true;
                pictureBox20.Visible = true;
                pictureBox21.Visible = true;
                pictureBox22.Visible = true;
                pictureBox23.Visible = true;
                pictureBox24.Visible = true;
                pictureBox25.Visible = true;
                pictureBox26.Visible = true;
                pictureBox27.Visible = true;
                pictureBox28.Visible = true;
                pictureBox29.Visible = true;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
            }
            if (numericUpDown1.Value == 30)
            {
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
                pictureBox9.Visible = true;
                pictureBox10.Visible = true;
                pictureBox11.Visible = true;
                pictureBox12.Visible = true;
                pictureBox13.Visible = true;
                pictureBox14.Visible = true;
                pictureBox15.Visible = true;
                pictureBox16.Visible = true;
                pictureBox17.Visible = true;
                pictureBox18.Visible = true;
                pictureBox19.Visible = true;
                pictureBox20.Visible = true;
                pictureBox21.Visible = true;
                pictureBox22.Visible = true;
                pictureBox23.Visible = true;
                pictureBox24.Visible = true;
                pictureBox25.Visible = true;
                pictureBox26.Visible = true;
                pictureBox27.Visible = true;
                pictureBox28.Visible = true;
                pictureBox29.Visible = true;
                pictureBox30.Visible = true;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
            }
            if (numericUpDown1.Value == 31)
            {
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
                pictureBox9.Visible = true;
                pictureBox10.Visible = true;
                pictureBox11.Visible = true;
                pictureBox12.Visible = true;
                pictureBox13.Visible = true;
                pictureBox14.Visible = true;
                pictureBox15.Visible = true;
                pictureBox16.Visible = true;
                pictureBox17.Visible = true;
                pictureBox18.Visible = true;
                pictureBox19.Visible = true;
                pictureBox20.Visible = true;
                pictureBox21.Visible = true;
                pictureBox22.Visible = true;
                pictureBox23.Visible = true;
                pictureBox24.Visible = true;
                pictureBox25.Visible = true;
                pictureBox26.Visible = true;
                pictureBox27.Visible = true;
                pictureBox28.Visible = true;
                pictureBox29.Visible = true;
                pictureBox30.Visible = true;
                pictureBox31.Visible = true;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
            }
            if (numericUpDown1.Value == 32)
            {
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
                pictureBox9.Visible = true;
                pictureBox10.Visible = true;
                pictureBox11.Visible = true;
                pictureBox12.Visible = true;
                pictureBox13.Visible = true;
                pictureBox14.Visible = true;
                pictureBox15.Visible = true;
                pictureBox16.Visible = true;
                pictureBox17.Visible = true;
                pictureBox18.Visible = true;
                pictureBox19.Visible = true;
                pictureBox20.Visible = true;
                pictureBox21.Visible = true;
                pictureBox22.Visible = true;
                pictureBox23.Visible = true;
                pictureBox24.Visible = true;
                pictureBox25.Visible = true;
                pictureBox26.Visible = true;
                pictureBox27.Visible = true;
                pictureBox28.Visible = true;
                pictureBox29.Visible = true;
                pictureBox30.Visible = true;
                pictureBox31.Visible = true;
                pictureBox32.Visible = true;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
            }
            if (numericUpDown1.Value == 33)
            {
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
                pictureBox9.Visible = true;
                pictureBox10.Visible = true;
                pictureBox11.Visible = true;
                pictureBox12.Visible = true;
                pictureBox13.Visible = true;
                pictureBox14.Visible = true;
                pictureBox15.Visible = true;
                pictureBox16.Visible = true;
                pictureBox17.Visible = true;
                pictureBox18.Visible = true;
                pictureBox19.Visible = true;
                pictureBox20.Visible = true;
                pictureBox21.Visible = true;
                pictureBox22.Visible = true;
                pictureBox23.Visible = true;
                pictureBox24.Visible = true;
                pictureBox25.Visible = true;
                pictureBox26.Visible = true;
                pictureBox27.Visible = true;
                pictureBox28.Visible = true;
                pictureBox29.Visible = true;
                pictureBox30.Visible = true;
                pictureBox31.Visible = true;
                pictureBox32.Visible = true;
                pictureBox33.Visible = true;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
            }
            if (numericUpDown1.Value == 34)
            {
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
                pictureBox9.Visible = true;
                pictureBox10.Visible = true;
                pictureBox11.Visible = true;
                pictureBox12.Visible = true;
                pictureBox13.Visible = true;
                pictureBox14.Visible = true;
                pictureBox15.Visible = true;
                pictureBox16.Visible = true;
                pictureBox17.Visible = true;
                pictureBox18.Visible = true;
                pictureBox19.Visible = true;
                pictureBox20.Visible = true;
                pictureBox21.Visible = true;
                pictureBox22.Visible = true;
                pictureBox23.Visible = true;
                pictureBox24.Visible = true;
                pictureBox25.Visible = true;
                pictureBox26.Visible = true;
                pictureBox27.Visible = true;
                pictureBox28.Visible = true;
                pictureBox29.Visible = true;
                pictureBox30.Visible = true;
                pictureBox31.Visible = true;
                pictureBox32.Visible = true;
                pictureBox33.Visible = true;
                pictureBox34.Visible = true;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
            }
            if (numericUpDown1.Value == 35)
            {
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
                pictureBox9.Visible = true;
                pictureBox10.Visible = true;
                pictureBox11.Visible = true;
                pictureBox12.Visible = true;
                pictureBox13.Visible = true;
                pictureBox14.Visible = true;
                pictureBox15.Visible = true;
                pictureBox16.Visible = true;
                pictureBox17.Visible = true;
                pictureBox18.Visible = true;
                pictureBox19.Visible = true;
                pictureBox20.Visible = true;
                pictureBox21.Visible = true;
                pictureBox22.Visible = true;
                pictureBox23.Visible = true;
                pictureBox24.Visible = true;
                pictureBox25.Visible = true;
                pictureBox26.Visible = true;
                pictureBox27.Visible = true;
                pictureBox28.Visible = true;
                pictureBox29.Visible = true;
                pictureBox30.Visible = true;
                pictureBox31.Visible = true;
                pictureBox32.Visible = true;
                pictureBox33.Visible = true;
                pictureBox34.Visible = true;
                pictureBox35.Visible = true;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
            }
            if (numericUpDown1.Value == 36)
            {
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
                pictureBox9.Visible = true;
                pictureBox10.Visible = true;
                pictureBox11.Visible = true;
                pictureBox12.Visible = true;
                pictureBox13.Visible = true;
                pictureBox14.Visible = true;
                pictureBox15.Visible = true;
                pictureBox16.Visible = true;
                pictureBox17.Visible = true;
                pictureBox18.Visible = true;
                pictureBox19.Visible = true;
                pictureBox20.Visible = true;
                pictureBox21.Visible = true;
                pictureBox22.Visible = true;
                pictureBox23.Visible = true;
                pictureBox24.Visible = true;
                pictureBox25.Visible = true;
                pictureBox26.Visible = true;
                pictureBox27.Visible = true;
                pictureBox28.Visible = true;
                pictureBox29.Visible = true;
                pictureBox30.Visible = true;
                pictureBox31.Visible = true;
                pictureBox32.Visible = true;
                pictureBox33.Visible = true;
                pictureBox34.Visible = true;
                pictureBox35.Visible = true;
                pictureBox36.Visible = true;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
            }
            if (numericUpDown1.Value == 37)
            {
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
                pictureBox9.Visible = true;
                pictureBox10.Visible = true;
                pictureBox11.Visible = true;
                pictureBox12.Visible = true;
                pictureBox13.Visible = true;
                pictureBox14.Visible = true;
                pictureBox15.Visible = true;
                pictureBox16.Visible = true;
                pictureBox17.Visible = true;
                pictureBox18.Visible = true;
                pictureBox19.Visible = true;
                pictureBox20.Visible = true;
                pictureBox21.Visible = true;
                pictureBox22.Visible = true;
                pictureBox23.Visible = true;
                pictureBox24.Visible = true;
                pictureBox25.Visible = true;
                pictureBox26.Visible = true;
                pictureBox27.Visible = true;
                pictureBox28.Visible = true;
                pictureBox29.Visible = true;
                pictureBox30.Visible = true;
                pictureBox31.Visible = true;
                pictureBox32.Visible = true;
                pictureBox33.Visible = true;
                pictureBox34.Visible = true;
                pictureBox35.Visible = true;
                pictureBox36.Visible = true;
                pictureBox37.Visible = true;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
            }
            if (numericUpDown1.Value == 38)
            {
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
                pictureBox9.Visible = true;
                pictureBox10.Visible = true;
                pictureBox11.Visible = true;
                pictureBox12.Visible = true;
                pictureBox13.Visible = true;
                pictureBox14.Visible = true;
                pictureBox15.Visible = true;
                pictureBox16.Visible = true;
                pictureBox17.Visible = true;
                pictureBox18.Visible = true;
                pictureBox19.Visible = true;
                pictureBox20.Visible = true;
                pictureBox21.Visible = true;
                pictureBox22.Visible = true;
                pictureBox23.Visible = true;
                pictureBox24.Visible = true;
                pictureBox25.Visible = true;
                pictureBox26.Visible = true;
                pictureBox27.Visible = true;
                pictureBox28.Visible = true;
                pictureBox29.Visible = true;
                pictureBox30.Visible = true;
                pictureBox31.Visible = true;
                pictureBox32.Visible = true;
                pictureBox33.Visible = true;
                pictureBox34.Visible = true;
                pictureBox35.Visible = true;
                pictureBox36.Visible = true;
                pictureBox37.Visible = true;
                pictureBox38.Visible = true;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
            }
            if (numericUpDown1.Value == 39)
            {
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
                pictureBox9.Visible = true;
                pictureBox10.Visible = true;
                pictureBox11.Visible = true;
                pictureBox12.Visible = true;
                pictureBox13.Visible = true;
                pictureBox14.Visible = true;
                pictureBox15.Visible = true;
                pictureBox16.Visible = true;
                pictureBox17.Visible = true;
                pictureBox18.Visible = true;
                pictureBox19.Visible = true;
                pictureBox20.Visible = true;
                pictureBox21.Visible = true;
                pictureBox22.Visible = true;
                pictureBox23.Visible = true;
                pictureBox24.Visible = true;
                pictureBox25.Visible = true;
                pictureBox26.Visible = true;
                pictureBox27.Visible = true;
                pictureBox28.Visible = true;
                pictureBox29.Visible = true;
                pictureBox30.Visible = true;
                pictureBox31.Visible = true;
                pictureBox32.Visible = true;
                pictureBox33.Visible = true;
                pictureBox34.Visible = true;
                pictureBox35.Visible = true;
                pictureBox36.Visible = true;
                pictureBox37.Visible = true;
                pictureBox38.Visible = true;
                pictureBox39.Visible = true;
                pictureBox40.Visible = false;
            }
            if (numericUpDown1.Value == 40)
            {
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
                pictureBox9.Visible = true;
                pictureBox10.Visible = true;
                pictureBox11.Visible = true;
                pictureBox12.Visible = true;
                pictureBox13.Visible = true;
                pictureBox14.Visible = true;
                pictureBox15.Visible = true;
                pictureBox16.Visible = true;
                pictureBox17.Visible = true;
                pictureBox18.Visible = true;
                pictureBox19.Visible = true;
                pictureBox20.Visible = true;
                pictureBox21.Visible = true;
                pictureBox22.Visible = true;
                pictureBox23.Visible = true;
                pictureBox24.Visible = true;
                pictureBox25.Visible = true;
                pictureBox26.Visible = true;
                pictureBox27.Visible = true;
                pictureBox28.Visible = true;
                pictureBox29.Visible = true;
                pictureBox30.Visible = true;
                pictureBox31.Visible = true;
                pictureBox32.Visible = true;
                pictureBox33.Visible = true;
                pictureBox34.Visible = true;
                pictureBox35.Visible = true;
                pictureBox36.Visible = true;
                pictureBox37.Visible = true;
                pictureBox38.Visible = true;
                pictureBox39.Visible = true;
                pictureBox40.Visible = true;
            }


            if (fn.Length > 0) pictureBox1.Image = GetImage();
            System.Drawing.Color someColor = colors[SetColor()];
            pictureBox1.BackColor = someColor;

            if (fn.Length > 0) pictureBox2.Image = GetImage();
            someColor = colors[SetColor()];
            pictureBox2.BackColor = someColor;

            if (fn.Length > 0) pictureBox3.Image = GetImage();
            someColor = colors[SetColor()];
            pictureBox3.BackColor = someColor;

            if (fn.Length > 0) pictureBox4.Image = GetImage();
            someColor = colors[SetColor()];
            pictureBox4.BackColor = someColor;

            if (fn.Length > 0) pictureBox5.Image = GetImage();
            someColor = colors[SetColor()];
            pictureBox5.BackColor = someColor;

            if (fn.Length > 0) pictureBox6.Image = GetImage();
            someColor = colors[SetColor()];
            pictureBox6.BackColor = someColor;

            if (fn.Length > 0) pictureBox7.Image = GetImage();
            someColor = colors[SetColor()];
            pictureBox7.BackColor = someColor;

            if (fn.Length > 0) pictureBox8.Image = GetImage();
            someColor = colors[SetColor()];
            pictureBox8.BackColor = someColor;

            if (fn.Length > 0) pictureBox9.Image = GetImage();
            someColor = colors[SetColor()];
            pictureBox9.BackColor = someColor;

            if (fn.Length > 0) pictureBox10.Image = GetImage();
            someColor = colors[SetColor()];
            pictureBox10.BackColor = someColor;

            if (fn.Length > 0) pictureBox11.Image = GetImage();
            someColor = colors[SetColor()];
            pictureBox11.BackColor = someColor;

            if (fn.Length > 0) pictureBox12.Image = GetImage();
            someColor = colors[SetColor()];
            pictureBox12.BackColor = someColor;

            if (fn.Length > 0) pictureBox13.Image = GetImage();
            someColor = colors[SetColor()];
            pictureBox13.BackColor = someColor;

            if (fn.Length > 0) pictureBox14.Image = GetImage();
            someColor = colors[SetColor()];
            pictureBox14.BackColor = someColor;

            if (fn.Length > 0) pictureBox15.Image = GetImage();
            someColor = colors[SetColor()];
            pictureBox15.BackColor = someColor;

            if (fn.Length > 0) pictureBox16.Image = GetImage();
            someColor = colors[SetColor()];
            pictureBox16.BackColor = someColor;

            if (fn.Length > 0) pictureBox17.Image = GetImage();
            someColor = colors[SetColor()];
            pictureBox17.BackColor = someColor;

            if (fn.Length > 0) pictureBox18.Image = GetImage();
            someColor = colors[SetColor()];
            pictureBox18.BackColor = someColor;

            if (fn.Length > 0) pictureBox19.Image = GetImage();
            someColor = colors[SetColor()];
            pictureBox19.BackColor = someColor;

            if (fn.Length > 0) pictureBox20.Image = GetImage();
            someColor = colors[SetColor()];
            pictureBox20.BackColor = someColor;
            if (fn.Length > 0) pictureBox21.Image = GetImage();
            someColor = colors[SetColor()];
            pictureBox21.BackColor = someColor;

            if (fn.Length > 0) pictureBox22.Image = GetImage();
            someColor = colors[SetColor()];
            pictureBox22.BackColor = someColor;

            if (fn.Length > 0) pictureBox23.Image = GetImage();
            someColor = colors[SetColor()];
            pictureBox23.BackColor = someColor;

            if (fn.Length > 0) pictureBox24.Image = GetImage();
            someColor = colors[SetColor()];
            pictureBox24.BackColor = someColor;

            if (fn.Length > 0) pictureBox25.Image = GetImage();
            someColor = colors[SetColor()];
            pictureBox25.BackColor = someColor;

            if (fn.Length > 0) pictureBox26.Image = GetImage();
            someColor = colors[SetColor()];
            pictureBox26.BackColor = someColor;

            if (fn.Length > 0) pictureBox27.Image = GetImage();
            someColor = colors[SetColor()];
            pictureBox27.BackColor = someColor;

            if (fn.Length > 0) pictureBox28.Image = GetImage();
            someColor = colors[SetColor()];
            pictureBox28.BackColor = someColor;

            if (fn.Length > 0) pictureBox29.Image = GetImage();
            someColor = colors[SetColor()];
            pictureBox29.BackColor = someColor;

            if (fn.Length > 0) pictureBox30.Image = GetImage();
            someColor = colors[SetColor()];
            pictureBox30.BackColor = someColor;
            if (fn.Length > 0) pictureBox31.Image = GetImage();
            someColor = colors[SetColor()];
            pictureBox31.BackColor = someColor;

            if (fn.Length > 0) pictureBox32.Image = GetImage();
            someColor = colors[SetColor()];
            pictureBox32.BackColor = someColor;

            if (fn.Length > 0) pictureBox33.Image = GetImage();
            someColor = colors[SetColor()];
            pictureBox33.BackColor = someColor;

            if (fn.Length > 0) pictureBox34.Image = GetImage();
            someColor = colors[SetColor()];
            pictureBox34.BackColor = someColor;

            if (fn.Length > 0) pictureBox35.Image = GetImage();
            someColor = colors[SetColor()];
            pictureBox35.BackColor = someColor;

            if (fn.Length > 0) pictureBox36.Image = GetImage();
            someColor = colors[SetColor()];
            pictureBox36.BackColor = someColor;

            if (fn.Length > 0) pictureBox37.Image = GetImage();
            someColor = colors[SetColor()];
            pictureBox37.BackColor = someColor;

            if (fn.Length > 0) pictureBox38.Image = GetImage();
            someColor = colors[SetColor()];
            pictureBox38.BackColor = someColor;

            if (fn.Length > 0) pictureBox39.Image = GetImage();
            someColor = colors[SetColor()];
            pictureBox39.BackColor = someColor;

            if (fn.Length > 0) pictureBox40.Image = GetImage();
            someColor = colors[SetColor()];
            pictureBox40.BackColor = someColor;
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