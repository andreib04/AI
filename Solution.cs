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
		Graph graph;
		public static float k = 1;

		public Solution(Graph graph) 
		{
			this.graph = graph.Clone();
		}

		public float funAdecv()
		{
			float toR = 0;

			foreach (Edge edge in graph.Edges)
			{
				toR += ((edge.absDist - edge.pond * k) 
							* (edge.absDist - edge.pond * k));
			}

			return toR;
		}

		public void Draw(Graphics graphics)
		{
			graph.Draw(graphics);
		}
	}
}
