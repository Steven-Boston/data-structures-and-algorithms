using System;
using Xunit;
using CodeChallenges;
using DataStructures;

namespace CodeChallengesTests
{
  public class BracketTests
  {
    [Fact]
    public void CanCheckGoodBrackets()
    {
      Assert.True(ValidateBrackets.ValidateBracketString("[(stuff){}]"));
      Assert.True(ValidateBrackets.ValidateBracketString("([thebigstuff(stuff){other stuff}])"));
      Assert.True(ValidateBrackets.ValidateBracketString("stuff"));
    }
    [Fact]
    public void CanCheckBadBrackets()
    {
      Assert.False(ValidateBrackets.ValidateBracketString("}([][][])"));
      Assert.False(ValidateBrackets.ValidateBracketString("[stu(]ff)"));
    }
    [Fact]
    public void CanCheckWeirdBrackets()
    {
      Assert.False(ValidateBrackets.ValidateBracketString("[[[][[[[[[[[[]]]]]]]]]["));
      Assert.True(ValidateBrackets.ValidateBracketString(""));
    }
  }
}
