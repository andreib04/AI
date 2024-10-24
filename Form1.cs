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

			Population population = new Population();

			population.Sort();
			population.Selection();
			population.par[0].Draw(grp.grp);
			population.par[29].Draw(grp2.grp);

			Solution test = population.Crossover(population.par[0], population.par[1]);
			test.Mutate(200);
			test.Draw(grp3.grp);

			grp.Refresh();
			grp2.Refresh();
			grp3.Refresh();

			textBox1.Text = population.par[0].funAdecv().ToString("0.000");
			textBox2.Text = population.par[29].funAdecv().ToString("0.000");
			textBox3.Text = test.funAdecv().ToString("0.000");
		}
	}
}
