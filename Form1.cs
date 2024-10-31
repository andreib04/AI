using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Genetic
{
	public partial class Form1 : Form
	{
		MyGraphics grp;
		MyGraphics grp2;
		MyGraphics grp3;
		Population population;
		int etapa;
		
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			AG.Innit();

			grp = new MyGraphics(pictureBox1);
			grp2 = new MyGraphics(pictureBox2);
			grp3 = new MyGraphics(pictureBox3);
			etapa = 1000;

			population = new Population();

			

			grp.Refresh();
			grp2.Refresh();
			grp3.Refresh();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			etapa--;
			population.Do(etapa/3 + 1);

			grp.Clear();

			population.par[0].Draw(grp.grp);

			grp.Refresh();
			textBox1.Text = population.par[0].funAdecv().ToString();
			textBox2.Text = etapa.ToString();
			if(etapa == 20)
			{
				timer1.Stop();
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			timer1.Enabled = true;
		}
	}
}
