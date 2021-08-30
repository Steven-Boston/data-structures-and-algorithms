using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures;
using Xunit;

namespace DataStructuresTests
{
  public class GraphTests
  {
    [Fact]
    public void CanAddNodesAndEdges()
    {
      Graph<int> testGraph = new();
      Vertex<int> node1 = testGraph.AddNode(7);
      Vertex<int> node2 = testGraph.AddNode(9);
      testGraph.AddEdge(node1, node2, 12);
      Assert.Equal(7, testGraph.GetNodes()[0].Value);
      Assert.Equal(12, testGraph.AdjacencyLists[node1][0].Weight);
    }
    [Fact]
    public void CanGetNodes()
    {
      Graph<int> testGraph = new();
      Vertex<int> node1 = testGraph.AddNode(7);
      Vertex<int> node2 = testGraph.AddNode(9);
      Vertex<int> node3 = testGraph.AddNode(3);
      testGraph.AddEdge(node1, node2, 12);
      testGraph.AddEdge(node2, node3, 36);
      testGraph.AddEdge(node3, node1, 24);
      List<Vertex<int>> nodeNeighbors = testGraph.GetNeighbors(node1);
      Assert.Equal(node2, nodeNeighbors[0]);
      List<Vertex<int>> allNodes = testGraph.GetNodes();
      Assert.Equal(node3, allNodes[2]);

    }
    [Fact]
    public void CanTrackSize()
    {
      Graph<int> testGraph = new();
      Assert.Equal(0, testGraph.GetSize());
      testGraph.AddNode(7);
      testGraph.AddNode(9);
      testGraph.AddNode(3);
      Assert.Equal(3, testGraph.GetSize());
    }
  }
}
