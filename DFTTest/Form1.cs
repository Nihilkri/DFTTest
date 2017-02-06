using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NihilKri;

namespace DFTTest {
	public partial class Form1 : Form {
		#region Variables
		#region Graphics
		static Graphics gb,gf; static Bitmap gi;
		static int fx, fy, fx2, fy2;
		static Timer Timer1;

		#endregion Graphics
		#endregion Variables

		#region Events
		public Form1() {InitializeComponent();}

		private void Form1_Load(object sender, EventArgs e) {
			fx2 = (fx = Width) / 2; fy2 = (fy = Height) / 2;
			gi = new Bitmap(fx, fy);
			gb = Graphics.FromImage(gi);
			gf = CreateGraphics();
			Timer1 = new Timer() { Interval = (int)(1000.0 / 60) };
			Timer1.Tick += Timer1_Tick; //Timer1.Start();


			DateTime stim, ftim; Complex a; double ts = 0.0, tts = 0.0;
			gb.Clear(Color.Black);
			for(int i = 0; i < 10; i++) {
				stim = DateTime.Now;
				for(int q = 0; q < 1000000; q++) {
					a = new Complex(255.0, 255.0);
				}
				ftim = DateTime.Now;
				ts = (ftim - stim).TotalSeconds; tts += ts;
				gb.DrawString("#" + i + " = " + ts.ToString(), Font, Brushes.White, 0, i*16);
			}
			gb.DrawString((tts/10).ToString(), Font, Brushes.White, 0, 200);
		}

		private void Form1_Paint(object sender, PaintEventArgs e) {
			gf.DrawImage(gi, 0, 0);
		}

		private void Form1_KeyDown(object sender, KeyEventArgs e) {
			switch(e.KeyCode) {
				case Keys.Escape: Close(); break;

				default: break;
			}
		}

		private void Timer1_Tick(object sender, EventArgs e) {
			//throw new NotImplementedException();

		}

		#endregion Events
	}
}
