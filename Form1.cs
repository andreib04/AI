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
		Graph graph = new Graph(@"../../file.txt");
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			grp = new MyGraphics(pictureBox1);
			grp2 = new MyGraphics(pictureBox2);
			
			Solution sol1 = new Solution(graph);
			Solution sol2 = new Solution(graph);

			sol1.Draw(grp.grp);
			sol2.Draw(grp2.grp);

			//graph.Draw(grp.grp);

			//Graph T = graph.Clone();
			//T.Draw(grp2.grp);

			grp.Refresh();
			grp2.Refresh();

			textBox1.Text = sol1.funAdecv().ToString("0.000");
			textBox2.Text = sol2.funAdecv().ToString("0.000");
		}
	}
}
