using Xunit;

namespace xUnitPractice.Tests;

public class NamesTest
{
    [Fact]
    public void MakeFullNameTest()
    {
        var names = new Names();
        var result = names.MakeFullName("Cagdas", "Cetin");
        // Assert.Equal("Cagdas Cetin", result, ignoreCase:true);
        // Assert.Contains(" Cet", result, StringComparison.InvariantCultureIgnoreCase);
        // Assert.StartsWith("Cagdas", result, StringComparison.InvariantCultureIgnoreCase);
        // Assert.EndsWith("Cetin", result);
        Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+", result);
    }

    [Fact]
    public void NickName_MustBeNull()
    {
        var names = new Names();
        names.NickName = "Flash";
        Assert.NotNull(names.NickName);
    }

    [Fact]
    public void MakeFullName_AlwaysReturnValue()
    {
        var names = new Names();
        var result = names.MakeFullName("Cagdas", "Cetin");
        Assert.NotNull(result);
        Assert.False(string.IsNullOrEmpty(result));
    }
}