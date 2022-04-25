using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Program_UI
{
    private readonly Menu_Repository _mRepo = new Menu_Repository();
    // ^ can be used throughtout the entirety of the methods to recreate
    public void Run()
    {
        Seed();
        RunApplication();
    }

    private void RunApplication()
    {
        bool isRunning = true;
        while (isRunning)
        {
            Console.Clear();
             System.Console.WriteLine("Welcome to Komodo Menu\n"+
             "1. Create New Menu Item\n"+
             "2. View All Menu Items\n"+
             "3. View Menu Item By ID\n"+
             "4. Delete Menu Item\n"+
             "5. Close Application\n");

             string userInput = Console.ReadLine();

             switch(userInput)
             {
                 case "1": 
                 CreateMenuItem();
                 break;
                 case "2": 
                 ViewAllMenuItems();
                 break;
                 case "3": 
                 ViewMenuItemByID();
                 break;
                 case "4": 
                 DeleteItemMenu();
                 break;
                 case "5": 
                 isRunning = CloseApplication();
                 break;
                 // These guys get the PressAnyKey
                default:
                System.Console.WriteLine("Invalid Selection, Press Any Key To Continue");
                Console.ReadKey();
                break;
             }
        }
    }

    private void CreateMenuItem()
    {
        //When creating or adding, think about it as a FORM.
        Console.Clear();
        Menu newMenuItem = new Menu();
        System.Console.WriteLine("Please Enter A Meal Name");
        newMenuItem.MealName = Console.ReadLine();
        System.Console.WriteLine("Please enter a Meal Description");
        newMenuItem.MealDescription = Console.ReadLine();
        System.Console.WriteLine("Please Enter the Meal Ingredients");
        newMenuItem.MealIngredients = Console.ReadLine();
        System.Console.WriteLine("Please Enter the Meal Price");
        newMenuItem.MealPrice = Console.ReadLine();

        bool success = _mRepo.AddMenuItemToRepo(newMenuItem);
        if (success)
        {
            System.Console.WriteLine("SUCCESS!");
        }
        else
        {
            System.Console.WriteLine("Failure:(");
        }
        PressAnyKeyToContinue();
    }

    private void ViewAllMenuItems()
    {
        Console.Clear();
        List<Menu> menuItemsInDatabase = _mRepo.GetAllMenuItems();
                    //^ This a vault
        foreach(Menu item in menuItemsInDatabase)
        {
            DisplayMenuItemDetails(item);
        }
        PressAnyKeyToContinue();
    }

    private void ViewMenuItemByID()
    {
        Console.Clear();
        Console.WriteLine("Please Enter A Valid Menu Item ID");
        int userInput = int.Parse(Console.ReadLine());
        Menu userSelectedItem = _mRepo.GetmealNameByID(userInput);
        if (userSelectedItem == null)
        {
            System.Console.WriteLine($"Sorry, the Meal with the ID of {userInput} doesn't exist.");
        }
        else
        {
            DisplayMenuItemDetails(userSelectedItem);
        }
        PressAnyKeyToContinue();
    }

    private void DisplayMenuItemDetails(Menu userSelectedItem)
    {
        System.Console.WriteLine($"MenuID: {userSelectedItem.ID}\nMealName: {userSelectedItem.MealName}\nMealDescription: {userSelectedItem.MealDescription}\nMealIngredients: {userSelectedItem.MealIngredients}\nMealPrice: {userSelectedItem.MealPrice}\n");
    }

    private void DeleteItemMenu()
    {
        Console.Clear();
        Console.WriteLine("Please Enter A Valid Menu Item ID");
        int userInput = int.Parse(Console.ReadLine());
        if (_mRepo.DeleteMenuItemFromRepository(userInput))
        {
            System.Console.WriteLine("Menu Item Was Successfully Deleted");
        }
        else
        {
            System.Console.WriteLine("Sorry, The Menu Item Was Not Deleted.");
        }
        PressAnyKeyToContinue();
    }
    //Console.ReadLine is a string

    private void PressAnyKeyToContinue()
    {
        System.Console.WriteLine("Press Any Key To Continue");
                Console.ReadKey();
    }

    private bool CloseApplication()
    {
        System.Console.WriteLine("Thank you For Using The Application, Press Any Key To Continue");
                Console.ReadKey();
                return false; 
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