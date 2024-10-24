using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic
{
	public class Population
	{
		public static Random rnd = new Random();

		static int N = 5000;
		static int K = 30;
		public List<Solution> solutions;
		public List<Solution> par;

		public Population()
		{
			solutions = new List<Solution>();
			par = new List<Solution>();
			for (int i = 0; i < N; i++)
			{
				solutions.Add(new Solution(AG.theGraph));
			}
		}

		public void Selection()
		{
			par.Clear();
			for (int i = 0; i < K; i++)
			{
				par.Add(solutions[i]);
			}
		}

		public Solution Crossover(Solution A, Solution B)
		{
			Solution toReturn = new Solution(AG.theGraph);

			int t = rnd.Next(1, toReturn.graph.Vertices.Count - 1);

			for(int i = 0; i < t; i++)
			{
				toReturn.graph.Vertices[i].loc.X = A.graph.Vertices[i].loc.X;
				toReturn.graph.Vertices[i].loc.Y = A.graph.Vertices[i].loc.Y;
			}

			for (int i = 0; i < B.graph.Vertices.Count; i++)
			{
				toReturn.graph.Vertices[i].loc.X = B.graph.Vertices[i].loc.X;
				toReturn.graph.Vertices[i].loc.Y = B.graph.Vertices[i].loc.Y;
			}

			return toReturn;
		}

		public void Sort()
		{
			solutions.Sort(delegate (Solution A, Solution B)
			{
				return A.funAdecv().CompareTo(B.funAdecv());
			});
		}
	}
}
