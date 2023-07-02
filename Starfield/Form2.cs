using System;
using System.Drawing;
using System.Windows.Forms;

namespace Starfield
{
	public partial class Form2 : Form
	{
		public Form2() => InitializeComponent();
		//
		Form1 star_field = new Form1();
		ColorDialog MyDialog;
		//
		private void b_Start_Click(object sender, EventArgs e) => star_field.Show();
		private void b_Exit_Click(object sender, EventArgs e) => Dispose();
		private void b_Background_Color_Click(object sender, EventArgs e)
		{
			if (MyDialog == null)
				MyDialog = new ColorDialog();
			if (MyDialog.ShowDialog() == DialogResult.OK)
				star_field.background_color = MyDialog.Color;
		}
		private void b_Stars_Color_Click(object sender, EventArgs e)
		{
			if (MyDialog == null)
				MyDialog = new ColorDialog();
			if (MyDialog.ShowDialog() == DialogResult.OK)
				star_field.star_color = new SolidBrush(MyDialog.Color);
		}
	}
}
