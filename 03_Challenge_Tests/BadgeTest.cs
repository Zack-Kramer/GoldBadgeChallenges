using Xunit;

public class Badge_Test
{
    private readonly Badge_Test _BRepo;

    [Fact]
    public Badge_Test()
    {
        _BRepo = new Badge_Test();
        Seed();
    }

    [Fact]
    public void AddBadgeToRepo_ShouldReturnTrue()
    {
    Badge badge = new Badge("#####", "Welcome");
    var actual = _BRepo.AddBadgeToRepo(badgeD);
    Assert.True(actual);
    }

    [Fact]
    public void ListAllBadges_ShouldReturnCorrectAmount()
    {
        var expected = 1;
        var actual = _BRepo.ListAllBadges().Count;
        Assert.Equal(expected, actual);
    }

    public void EditBadgeInRepo_ShouldReturnCorrectItem()
    {
        var expected = 1;
        var actual = _BRepo.EditBadgeInRepo(1);
        Assert.Equal(expected, _BRepo.ListAllBadges().Count);
    }

}