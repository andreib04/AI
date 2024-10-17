using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic
{
	public class Graph
	{
		public List<Vertex> Vertices;
		public List<Edge> Edges;

		public Graph(string fileName) 
		{
			TextReader load = new StreamReader(fileName);	

			int n = int.Parse(load.ReadLine());
			Vertices = new List<Vertex>();

			for (int i = 0; i < n; i++) 
			{
				Vertices.Add(new Vertex(i.ToString()));
			}

			Edges = new List<Edge>();
			string line;
			while ((line = load.ReadLine()) != null) 
			{
				Edges.Add(new Edge(line, Vertices));
			}

			load.Close();
		}

		public void Draw(Graphics graphics)
		{
			foreach(Vertex v in Vertices)
				v.Draw(graphics);
			foreach(Edge e in Edges)
				e.Draw(graphics);
		}

		public Graph()
		{
			Vertices = new List<Vertex>();
			Edges = new List<Edge>();
		}

		public Graph Clone()
		{
			Graph clone = new Graph();

			for (int i = 0; i < this.Vertices.Count; i++)
			{
				clone.Vertices.Add(new Vertex(i.ToString()));
			}

			foreach(Edge edge in this.Edges)
			{
				clone.Edges.Add(new Edge(edge.info, clone.Vertices));
			}

			return clone;
		}
	}
}
