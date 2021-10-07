using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeChallenges;
using Xunit;

namespace CodeChallengesTests
{
  public class EdAryTests
  {
    [Fact]
    public void CanTraverse()
    {
      EdNode<int> rooty = new(13);
      EdNode<int> four = new(4);
      rooty.ChildList.Add(four);
      EdNode<int> eight = new(8);
      rooty.ChildList.Add(eight);
      EdNode<int> twelve = new(12);
      rooty.ChildList.Add(twelve);
      EdNode<int> one = new(1);
      four.ChildList.Add(one);
      EdNode<int> two = new(2);
      four.ChildList.Add(two);
      EdNode<int> three = new(3);
      four.ChildList.Add(three);
      EdNode<int> five = new(5);
      eight.ChildList.Add(five);
      EdNode<int> six = new(6);
      eight.ChildList.Add(six);
      EdNode<int> seven = new(7);
      eight.ChildList.Add(seven);
      EdNode<int> nine = new(9);
      twelve.ChildList.Add(nine);
      EdNode<int> ten = new(10);
      twelve.ChildList.Add(ten);
      EdNode<int> eleven = new(11);
      twelve.ChildList.Add(eleven);
      //Expected Output: [1,2,3,4,5,6,7,8,9,10,11,12,13]
      List<int> result = Ed_ary_tree<int>.EdTraversal(rooty);
      Assert.Equal(13, result[12]);
      Assert.Equal(1, result[0]);
      Assert.Equal(10, result[9]);
      Assert.Equal(5, result[4]);
    }
  }
}
