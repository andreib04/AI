using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic
{
	public class Edge
	{
		Vertex start, end;
		public float pond;
		public string info;
		public float absDist()
		{
			return (float)Math.Sqrt((start.loc.X - end.loc.X) * (start.loc.X - end.loc.X)
										+ (start.loc.Y - end.loc.Y) * (start.loc.Y - end.loc.Y));
		}

		public Edge(string data, List<Vertex> vertices)
		{
			info = data;
			string[] dataSplit = data.Split(' ');
			start = vertices[int.Parse(dataSplit[0])];
			end = vertices[int.Parse(dataSplit[1])];
			pond = float.Parse(dataSplit[2]);
		}

		public void Draw(Graphics graphics)
		{
			graphics.DrawLine(Pens.Black, start.loc, end.loc);
		}
	}
}
