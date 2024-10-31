using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic
{
	public class Solution
	{
		public static Random rnd = new Random();

		public Graph graph;
		public static float k = 2;

		public Solution(Graph graph) 
		{
			this.graph = graph.Clone();
		}

		public void Mutate(float radius)
		{
			int r = rnd.Next(this.graph.Vertices.Count);
			float alpha = (float)(rnd.NextDouble() * 2 * Math.PI);

			float xP = this.graph.Vertices[r].loc.X + radius * (float)Math.Cos(alpha);
			float yP = this.graph.Vertices[r].loc.Y + radius * (float)Math.Sin(alpha);

			this.graph.Vertices[r].loc.X = xP;
			this.graph.Vertices[r].loc.Y = yP;
		}

		public float funAdecv()
		{
			float toR = 0;

			foreach (Edge edge in graph.Edges)
			{
				toR += ((edge.absDist() - edge.pond * k) * (edge.absDist() - edge.pond * k));
			}

			return toR;
		}

		public void Draw(Graphics graphics)
		{
			graph.Draw(graphics);
		}
	}
}
