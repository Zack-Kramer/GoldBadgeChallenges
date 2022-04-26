using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Program_UI
{
    private readonly Ch3Repo _bRepo = new Ch3Repo();

    public void Run()
    {
        Seed();
        RunApplication();
    }
    public void RunApplication()
    {
        bool isRunning = true;
        while (isRunning)
        {
            Console.Clear();
            System.Console.WriteLine("Hello security admin, what would you like to do?\n" +
            "1. Add Badge to Database\n" +
            "2. Edit Badge\n" +
            "3. Delete Badge\n" +
            "4. Remove Door\n");

            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    AddBadgetoDatabase();
                    break;
                case "2":
                    EditBadge();
                    break;
                case "3":
                    DeleteBadge();
                    break;
                case "4":
                    CloseApplication();
                    break;
            }
        }
    }

    private void AddBadgeToDatabase()
    {
        Console.Clear();
        Badge newBadgeItem = new Badge();
        System.Console.WriteLine("What is the number on the badge?");
        newBadgeItem.BadgeID = Console.ReadLine();
        System.Console.WriteLine("List a door that it needs access to: ");
        newBadgeItem.BadgeID = Console.ReadLine();
        System.Console.WriteLine("Any other doors(y/n)?");
        string userInput = Console.ReadLine();
        if (userInput == "Y".ToLower())
        {
            var success = _bRepo.AddDoor();
            if (success)
            {
                System.Console.WriteLine("DoorAccessed");
            }
            else
            {
                System.Console.WriteLine("Fail");
            }
        }
        PressAnyKeyToContinue();
    }

    private void EditBadge()
    {
        Console.Clear();
        Badge editBadgeItem = new Badge();
        System.Console.WriteLine("What is the Badge Number to Update?");
        editBadgeItem.BadgeID = Console.ReadLine();
        System.Console.WriteLine("What would you like to do? 1. Remove a door 2. Add a door.");
        string userInput = Console.ReadLine();
        if (userInput == "1".ToLower())
        {
            var success = _bRepo.RemoveDoor();
            if (success)
            {
                System.Console.WriteLine("Door has been removed");
            }
        }
        if (userInput == "2".ToLower())
        {
            var success = _bRepo.AddDoor();
            if (success)
            {
                System.Console.WriteLine("Door has been added");
            }
        }
        PressAnyKeyToContinue();
    }

    private void DeleteBadge()
    {
        Console.Clear();
        System.Console.WriteLine("Please Enter A Valid Badge ID");
        int userInput = int.Parse(Console.ReadLine());
        if (_bRepo.DeleteBadge(userInput))
        {
            System.Console.WriteLine("Badge was Successfully Deleted");
        }
        else
        {
            System.Console.WriteLine("Sorry, The Badge Was Not Deleted.");
        }
        PressAnyKeyToContinue();
    }

    private bool CloseApplication()
    {
        System.Console.WriteLine("Thank you For Using The Application, Press Any Key To Continue");
        Console.ReadKey();
        return false;
    }
    public void Seed()
    {

    }

}