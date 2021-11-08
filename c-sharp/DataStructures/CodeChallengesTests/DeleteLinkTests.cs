using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using DataStructures;
using CodeChallenges;

namespace CodeChallengesTests
{
  public class DeleteLinkTests
  {
    [Fact]
    public void CanRemoveNode()
    {
      DataStructures.LinkedList<int> testList = new();
      testList.AppendLinked(1);
      testList.AppendLinked(2);
      testList.AppendLinked(3);
      testList.AppendLinked(4);
      testList.AppendLinked(5);
      DeleteLink.DeleteNode(testList.Head.Next);
      Assert.Equal(1, testList.Head.Value);
      Assert.Equal(3, testList.Head.Next.Value);
      Assert.Equal(4, testList.Head.Next.Next.Value);

    }

  }
}
