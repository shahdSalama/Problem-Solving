// An Iterative C# program to do DFS traversal from
// a given source vertex. DFS() traverses vertices
// reachable from s.
using System;
using System.Collections.Generic;

class DFSGFG
{
	// This class represents a directed graph using adjacency
	// list representation
	class Graph
	{
		public int V; // Number of Vertices

		public List<int>[] adj; // adjacency lists

		// Constructor
		public Graph(int V)
		{
			this.V = V;
			adj = new List<int>[V];

			for (int i = 0; i < adj.Length; i++)
				adj[i] = new List<int>();

		}

		// To add an edge to graph
		public void addEdge(int v, int w)
		{
			adj[v].Add(w); // Add w to v’s list.
		}

		// prints all not yet visited vertices reachable from s
		public void DFSUtil(int s, List<Boolean> visited)
		{
			// Create a stack for DFS
			Stack<int> stack = new Stack<int>();

			// Push the current source node
			stack.Push(s);

			while (stack.Count != 0)
			{
				// Pop a vertex from stack and print it
				s = stack.Pop();

				// Stack may contain same vertex twice. So
				// we need to print the popped item only
				// if it is not visited.
				if (visited[s] == false)
				{
					Console.Write(s + " ");
					visited[s] = true;
				}

				// Get all adjacent vertices of the popped vertex s
				// If a adjacent has not been visited, then push it
				// to the stack.
				foreach (int itr in adj[s])
				{
					int v = itr;
					if (!visited[v])
						stack.Push(v);
				}

			}
		}

		// prints all vertices in DFS manner
		public void DFS()
		{
			List<Boolean> visited = new List<Boolean>(V);

			// Mark all the vertices as not visited
			for (int i = 0; i < V; i++)
				visited.Add(false);

			for (int i = 0; i < V; i++)
				if (!visited[i])
					DFSUtil(i, visited);
		}
	}

	// Driver public static void Main(
	//public static void Main(String[] args)
	//{
	//	Graph g = new Graph(5);
	//	g.addEdge(1, 0);
	//	g.addEdge(2, 1);
	//	g.addEdge(3, 4);
	//	g.addEdge(4, 0);

	//	Console.WriteLine("Following is Depth First Traversal");
	//	g.DFS();
	//}
}

// This code is contributed by 29AjayKumar
