namespace Starfield
{
	partial class Form2
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.b_Start = new System.Windows.Forms.Button();
			this.b_Stars_Color = new System.Windows.Forms.Button();
			this.b_Exit = new System.Windows.Forms.Button();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.b_Background_Color = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// b_Start
			// 
			this.b_Start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.b_Start.Location = new System.Drawing.Point(48, 12);
			this.b_Start.Name = "b_Start";
			this.b_Start.Size = new System.Drawing.Size(112, 50);
			this.b_Start.TabIndex = 0;
			this.b_Start.Text = "Start";
			this.b_Start.UseVisualStyleBackColor = false;
			this.b_Start.Click += new System.EventHandler(this.b_Start_Click);
			// 
			// b_Stars_Color
			// 
			this.b_Stars_Color.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.b_Stars_Color.Location = new System.Drawing.Point(48, 68);
			this.b_Stars_Color.Name = "b_Stars_Color";
			this.b_Stars_Color.Size = new System.Drawing.Size(112, 50);
			this.b_Stars_Color.TabIndex = 1;
			this.b_Stars_Color.Text = "Stars Color";
			this.b_Stars_Color.UseVisualStyleBackColor = false;
			this.b_Stars_Color.Click += new System.EventHandler(this.b_Stars_Color_Click);
			// 
			// b_Exit
			// 
			this.b_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.b_Exit.Location = new System.Drawing.Point(48, 183);
			this.b_Exit.Name = "b_Exit";
			this.b_Exit.Size = new System.Drawing.Size(112, 50);
			this.b_Exit.TabIndex = 2;
			this.b_Exit.Text = "Exit";
			this.b_Exit.UseVisualStyleBackColor = false;
			this.b_Exit.Click += new System.EventHandler(this.b_Exit_Click);
			// 
			// b_Background_Color
			// 
			this.b_Background_Color.BackColor = System.Drawing.Color.Gold;
			this.b_Background_Color.Location = new System.Drawing.Point(48, 124);
			this.b_Background_Color.Name = "b_Background_Color";
			this.b_Background_Color.Size = new System.Drawing.Size(112, 50);
			this.b_Background_Color.TabIndex = 3;
			this.b_Background_Color.Text = "Background Color";
			this.b_Background_Color.UseVisualStyleBackColor = false;
			this.b_Background_Color.Click += new System.EventHandler(this.b_Background_Color_Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(206, 245);
			this.Controls.Add(this.b_Background_Color);
			this.Controls.Add(this.b_Exit);
			this.Controls.Add(this.b_Stars_Color);
			this.Controls.Add(this.b_Start);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "Form2";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Menu";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button b_Start;
		private System.Windows.Forms.Button b_Stars_Color;
		private System.Windows.Forms.Button b_Exit;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.Button b_Background_Color;
	}
}