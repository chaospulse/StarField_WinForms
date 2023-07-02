using System;
using System.Drawing;
using System.Windows.Forms;

namespace Starfield
{
    public partial class Form1 : Form
    {
		public Form1() { InitializeComponent(); }
		public class Star
        {
            public float x { get; set; }
            public float y { get; set; }
            public float z { get; set; }
        }
		//
		// the higher the value, the lower the fps. recommended field from 100 to 4000  
		private Star[] stars = new Star[1500];
        //
        private Random random = new Random();
		public Brush star_color { get; set; }
        public Color background_color { get; set; }
		public Graphics background { get; set; }
        //
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
			background = Graphics.FromImage(pictureBox1.Image);
            if(star_color == null)
                star_color = new SolidBrush(Color.White);
            background_color = Color.Black;

			for (int i = 0; i < stars.Length; i++)
            {
                stars[i] = new Star()
                {
                    x = random.Next(-pictureBox1.Width, pictureBox1.Width),
                    y = random.Next(-pictureBox1.Height, pictureBox1.Height),
                    z = random.Next(1, pictureBox1.Width)
                };
            }
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            background.Clear(background_color);

            foreach (var star in stars)
            {
                DrawStar(star);
                MoveStar(star);
            }
            pictureBox1.Refresh();
        }

        private void MoveStar(Star star)
        {
            star.z -= 29;
            if (star.z < 1)
            {
                star.x = random.Next(-pictureBox1.Width, pictureBox1.Width);
                star.y = random.Next(-pictureBox1.Height, pictureBox1.Height);
                star.z = random.Next(1, pictureBox1.Width);
            }
        }

        private void DrawStar(Star star)
        {
            float SizeOfStar = Map(star.z, 0, pictureBox1.Width, 8, 0);
            float x = Map(star.x / star.z, 0, 1, 0, pictureBox1.Width) + pictureBox1.Width / 2;
            float y = Map(star.y / star.z, 0, 1, 0, pictureBox1.Height) + pictureBox1.Height / 2;
            //
			background.FillEllipse(star_color, x, y, SizeOfStar, SizeOfStar);
        }

        private float Map(float n, float start1, float stop1, float start2, float stop2)
        {
            return ((n - start1) / (stop1 - start1)) * (stop2 - start2) + start2;
        }

		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
            //exit
            if (e.KeyCode == Keys.Escape)
            {
                Hide();
			}
            //stop
			if (e.KeyCode == Keys.Space)
				timer1.Enabled = !timer1.Enabled;
            //speed params
			if (e.KeyCode == Keys.Up && timer1.Interval != 1)
                     timer1.Interval -= 1;
			if (e.KeyCode == Keys.Down)
                    timer1.Interval += 1;
		}
	}
}