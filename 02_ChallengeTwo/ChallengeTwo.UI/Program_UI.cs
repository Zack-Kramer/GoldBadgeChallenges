public class Program_UI
{
    private readonly Claim_Repo _cRepo = new Claim_Repo();
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
             System.Console.WriteLine("Welcome to Komodo Claims\n"+
             "1. Create New Claims\n"+
             "2. View All Claim\n"+
             "3. See Next Claim\n"+
             "4. Handle Next Claim\n"+
             "5. Close Application\n");

             string userInput = Console.ReadLine();

             switch(userInput)
             {
                 case "1": 
                 CreateNewClaim();
                 break;
                 case "2": 
                 ViewAllClaims();
                 break;
                 case "3": 
                 SeeNextClaim();
                 break;
                 case "4": 
                 HandleNextClaim();
                 break;
                 case "5": 
                 isRunning = CloseApplication();
                 break;
                 // These guys get the PressAnyKey
                default:
                System.Console.WriteLine("Invalid Selection, Press Any Key To Continue");
                Console.ReadKey();
                break;
             }    }
    }

    private void Seed()
    {
        Claim claimA = new Claim(ClaimType.Car, "???", 1.00m, new DateTime(2022, 01, 01), new DateTime (2023, 01, 01));
        Claim claimB = new Claim(ClaimType.Home, "???", 1.00m, new DateTime(2022, 01, 01), new DateTime (2021, 01, 10));
        Claim claimC = new Claim(ClaimType.Theft, "???", 1.00m, new DateTime(2023, 01, 01), new DateTime (2022, 01, 20));
        _cRepo.AddToQueue(claimA);
        _cRepo.AddToQueue(claimB);
        _cRepo.AddToQueue(claimC);
    }

    private bool CloseApplication()
    {
        System.Console.WriteLine("Thank you For Using The Application, Press Any Key To Continue");
                Console.ReadKey();
                return false; 
    }

    private void HandleNextClaim()
    {
        Console.Clear();
        Claim claim = _cRepo.GetClaim();
        if (claim == null)
        {
            System.Console.WriteLine("Sorry, There Are No More Claims in the Queue.");
        }
        else
        {
            DisplayClaimDetails(claim);
            System.Console.WriteLine("Do You Want To Handle This Claim? Y/N");
            string userInput = Console.ReadLine();
            if (userInput == "Y".ToLower())
            {

                var success = _cRepo.ReleaseKomodo();
                if (success)
                {
                    System.Console.WriteLine("SUCCESS");
                }
                else
                {
                    System.Console.WriteLine("FAIL");
                }
            }
        }
        PressAnyKeyToContinue();
    }

    private void SeeNextClaim()
    {
        Console.Clear();
        Claim claim = _cRepo.GetClaim();
        if (claim == null)
        {
            System.Console.WriteLine("Sorry, There Are No More Claims in the Queue.");
        }
        else
        {
            DisplayClaimDetails(claim);
        }
        PressAnyKeyToContinue();
    }

    private void ViewAllClaims()
    {
        Console.Clear();
        Queue<Claim> allQueuesinDb = _cRepo.GetClaims();
        foreach(Claim claim in allQueuesinDb)
        {
            DisplayClaimDetails(claim);
        }
        PressAnyKeyToContinue();
    }

    private void DisplayClaimDetails(Claim claim)
    {
         System.Console.WriteLine($"ClaimID: {claim.ID}\nClaimType: {claim.ClaimType}\nDescription: {claim.Description}\nAmount: {claim.Amount}\nDateofAccident: {claim.DateOfAccident}\nDateofClaim: {claim.DateOfClaim}\nIsValid: {claim.IsValid}");
    }

    private void CreateNewClaim()
    {
        Console.Clear();
        var claim = new Claim();
        System.Console.WriteLine("What Kind of Claim Is This?\n" + 
        "1. Car\n" +
        "2. Home\n" +
        "3. Theft\n");
        string userInputClaimType = Console.ReadLine();
        int intConversion = int.Parse(userInputClaimType);
        // ^^ Converting string to integer
        claim.ClaimType = (ClaimType)intConversion;
        // ^^ Casting an integer conversion to its associated ClaimType/Integer Value (lives in ClaimType.cs)
        // It is VERY important that they are all consistent numerically
        System.Console.WriteLine("Please enter a description");
        claim.Description = Console.ReadLine();
        System.Console.WriteLine("Please enter the amount");
        claim.Amount = decimal.Parse(Console.ReadLine());
        System.Console.WriteLine("What was the date of the accident?");
        claim.DateOfAccident = DateTime.Parse(Console.ReadLine());
        System.Console.WriteLine("When was the date of the claim?");
        claim.DateOfClaim = DateTime.Parse(Console.ReadLine());

        if (_cRepo.AddToQueue(claim))
        {
            System.Console.WriteLine("SUCCESS");
        }
        else
        {
            System.Console.WriteLine("FAIL");
        }
        
        PressAnyKeyToContinue();
    }

        private void PressAnyKeyToContinue()
    {
        System.Console.WriteLine("Press Any Key To Continue");
                Console.ReadKey();
    }

    
}
