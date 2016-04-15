using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ExpensiveTSAApp {
	public partial class Form1 : Form {
		Image l = Image.FromFile("left.png");
		Image r = Image.FromFile("right.png");
		Random rand = new Random();
		public Form1(){
			InitializeComponent();
		}

		private void setArrow() {
		}

		private void button1_Click(object sender, EventArgs e) {
			pictureBox1.Visible = true;
			if (rand.Next(0, 2) == 0) pictureBox1.Image = l;
			else pictureBox1.Image = r;
			new Thread(arrowHandler).Start();
		}
		private void arrowHandler() {
			button1.Enabled = false;
			Thread.Sleep(1000);
			button1.Enabled = true;
			pictureBox1.Image = null;
			pictureBox1.Visible = false;
		}
	}
}