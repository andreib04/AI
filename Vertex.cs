using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic
{
	public class Vertex
	{
		public PointF loc;
		string name;

		public static Random rnd = new Random();
		public static int resX = 500, resY = 500;
		
		public Vertex(string name)
		{
			this.name = name;
			loc = new PointF(rnd.Next(resX), rnd.Next(resY));
		}

		public void Draw(Graphics graphics)
		{
			int size = 7;
			graphics.DrawEllipse(Pens.Black, loc.X - size, loc.Y - size, 2 * size + 1, 2 * size + 1);
			graphics.DrawString(name, new Font("Arial", 15, FontStyle.Bold), new SolidBrush(Color.Red),
				new PointF(loc.X - size / 2, loc.Y - size / 2));
		}
	}
}
