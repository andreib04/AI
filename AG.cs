using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic
{
	public static class AG
	{
		public static Graph theGraph;

		public static void Innit()
		{
			theGraph = new Graph(@"../../file.txt");
		}
	}
}
