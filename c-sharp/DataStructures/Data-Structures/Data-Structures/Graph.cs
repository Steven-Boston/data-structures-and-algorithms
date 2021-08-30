using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
  public class Vertex<T>
  {
    public T Value { get; set; }

    public Vertex(T value)
    {
      Value = value;
    }
}
  public class Edge<T>
  {
    public Vertex<T> Vertex { get; set; }
    public int Weight { get; set; }

    public Edge(Vertex<T> vertex, int weight)
    {
      Vertex = vertex;
      Weight = weight;
    }
  }
  public class Graph<T>
  {
    private int _size;
    public Dictionary<Vertex<T>, List<Edge<T>>> AdjacencyLists { get; set; }

    public Graph()
    {
      AdjacencyLists = new();
      _size = 0;
    }

    public Vertex<T> AddNode(T value)
    {
      Vertex<T> vertex = new(value);
      AdjacencyLists.Add(vertex, new List<Edge<T>>());
      _size++;

      return vertex;
    }
    public void AddEdge(Vertex<T> source, Vertex<T> dest, int weight)
    {
      AdjacencyLists[source].Add(new Edge<T>(dest, weight));
    }

    public List<Vertex<T>> GetNodes()
    {
      List<Vertex<T>> nodes = new();
      foreach(var entry in AdjacencyLists)
      {
        nodes.Add(entry.Key);
      }
      return nodes;
    }
    public List<Vertex<T>> GetNeighbors(Vertex<T> vertex)
    {
      var adjList = AdjacencyLists[vertex];
      List<Vertex<T>> neighborList = new();

      foreach(Edge<T> edge in adjList)
      {
        neighborList.Add(edge.Vertex);
      };
      return neighborList;
    }
    public int GetSize()
    {
      return _size;
    }

    //Ed's Bizarro print method. Probably not how I would have written it, but I was coding along so I kept it around.
    public void Print()
    {
      foreach(var key in AdjacencyLists)
      {
        Console.Write($"{key.Key.Value} -> ");
        var adjacencyList = AdjacencyLists[key.Key];

        foreach(Edge<T> edge in adjacencyList)
        {
          Console.Write($"{edge.Vertex.Value} -> ");
        }
        Console.WriteLine("NULL");
      }
      Console.WriteLine();
    }
  }

}
