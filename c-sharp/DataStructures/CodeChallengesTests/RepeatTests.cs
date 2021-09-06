using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CodeChallenges;

namespace CodeChallengesTests
{
  public class RepeatTests
  {
    [Fact]
    public void CanFindRepeat()
    {
      string test = "are there several repeated words there or are there not?";
      Assert.Equal("there", RepeatedWords.RepeatedWord(test));
    }
    [Fact]
    public void CanFindNoRepeat()
    {
      string test = "their repeats have no bearing on the repeat bearer over there";
      Assert.Equal("No Repeated Words", RepeatedWords.RepeatedWord(test));
    }
    [Fact]
    public void CanCorrectCaps()
    {
      string test = "The test string has an odd quality in the design";
      Assert.Equal("the", RepeatedWords.RepeatedWord(test));
    }
  }
}
