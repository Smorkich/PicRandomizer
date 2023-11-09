using static Picture2.BackGroundColors;

namespace Picture2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            numericUpDown1.Maximum = 40;
            numericUpDown1.Minimum = 1;

            foreach (PictureBox pb in Controls.OfType<PictureBox>())
            {
                pb.Visible = false;
            }

            foreach (PictureBox pb in Controls.OfType<PictureBox>())
            {
                pb.Click += (s, e) =>
                {
                    ((PictureBox)s).Image = ImagesPath.GetImage();                 
                    ((PictureBox)s).BackColor = BackGroundColors.BackColors[SetColor()];
                };
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            for (int k = 1; k <= numericUpDown1.Value; k++)
                (Controls["pictureBox" + k] as PictureBox).Visible = true;

            for (int j = 40; j > numericUpDown1.Value; j--)
                (Controls["pictureBox" + j] as PictureBox).Visible = false;

            foreach (PictureBox pb in Controls.OfType<PictureBox>())
            {
                if (ImagesPath.fn.Length > 0) pb.Image = ImagesPath.GetImage();
                    pb.BackColor = BackGroundColors.BackColors[SetColor()];
            }
        }
    }
}