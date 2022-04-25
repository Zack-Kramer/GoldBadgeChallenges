using Xunit;

public class UnitTest1
{
    private readonly Menu_Repository _mRepo;
    public UnitTest1()
    {
        _mRepo = new Menu_Repository();
        Seed();
    }
    [Fact]
    public void AddMenuItemToRepo_ShouldReturnTrue()
    {
        Menu menuD = new Menu("Hamburger", "Seeded", "Tomatoes, beef, ketchup", "10.99");
        var actual = _mRepo.AddMenuItemToRepo(menuD);
        Assert.True(actual);
    }

    [Fact]
    public void GetAllMenuItems_ShouldReturnCorrectAccount()
    {
        var expected = 3;
        var actual = _mRepo.GetAllMenuItems().Count;
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void GetmealNameByID_ShouldReturnCorrectItem()
    {
        var expected = new Menu("Hot Dog", "Plain", "sausage, mustard", "8.99");
        var actual = _mRepo.GetmealNameByID(2);
        Assert.True(actual.MealIngredients.Contains(expected.MealIngredients));
        // RAM memory allocation process, or the address metaphor
    }

    [Fact]
    public void DeleteMenuItemFromRepository_ShouldReturnCorrectCount()
    {
        var expected = 2;
        var actual = _mRepo.DeleteMenuItemFromRepository(2);
        Assert.Equal(expected, _mRepo.GetAllMenuItems().Count);
        // RAM memory allocation process, or the address metaphor
    }


    private void Seed()
    {
        Menu menuA = new Menu("Hamburger", "Seeded", "Tomatoes, beef, ketchup", "10.99");
        Menu menuB = new Menu("Hot Dog", "Plain", "sausage, mustard", "8.99");
        Menu menuC = new Menu("Salad", "bowl", "ranch, lettuce, evil green things", "9.99");

        _mRepo.AddMenuItemToRepo(menuA);
        _mRepo.AddMenuItemToRepo(menuB);
        _mRepo.AddMenuItemToRepo(menuC);
    }
}

//^^ We don't need to AAA (Arrange Act and Assert)