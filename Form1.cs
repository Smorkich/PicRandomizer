using static Picture2.BackGroundColors;

namespace Picture2
{
    public partial class Form1 : Form
    {
        Color someColor;
        BackGroundColors bC = new BackGroundColors();
        public Form1()
        {
            InitializeComponent();
            numericUpDown1.Maximum = 40;
            numericUpDown1.Minimum = 1;

            for (int i = 2; i <= 40; i++)
            {
                (Controls["pictureBox" + i] as PictureBox).Visible = false;
            }
            for (int i = 1; i <= 40; i++)
            {
                (Controls["pictureBox" + i] as PictureBox).Click += new EventHandler(MyButtonClick);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            for (int k = 2; k <= numericUpDown1.Value; k++)
                (Controls["pictureBox" + k] as PictureBox).Visible = true;

            for (int j = 40; j > numericUpDown1.Value; j--)
                (Controls["pictureBox" + j] as PictureBox).Visible = false;

            for (int c = 1; c <= 40; c++)
            {
                if (ImagesPath.fn.Length > 0) (Controls["pictureBox" + c] as PictureBox).Image = ImagesPath.GetImage();
                someColor = BackGroundColors.BackColors[SetColor()];
                (Controls["pictureBox" + c] as PictureBox).BackColor = someColor;
            }
        }
        private void MyButtonClick(object sender, EventArgs e)
        {
            ((PictureBox)sender).Image = ImagesPath.GetImage();
            Color someColor = BackGroundColors.BackColors[SetColor()];
            ((PictureBox)sender).BackColor = someColor;
        }
    }
}