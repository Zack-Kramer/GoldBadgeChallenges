public class SeededClaims
{
    public void Seed()
    {
        Queue<Claim> ClaimQueue = new Queue<Claim>();

        var car = new Claim
        {
            ID = 1,
            ClaimType = ClaimType.Car,
            Description = "CarAccidentOn465",
            Amount = 400.00m,
            DateOfAccident = new DateTime (2018, 04, 25),
            DateOfClaim = new DateTime (2018, 27, 04),
            IsValid = true
        };

        var home = new Claim
        {
            ID = 2,
            ClaimType = ClaimType.Home,
            Description = "HouseFireInKitchen",
            Amount = 4000.00m,
            DateOfAccident = Convert.ToDateTime( "2018/04/11"),
            DateOfClaim = Convert.ToDateTime("2018/04/12/"),
            IsValid = true
        };

        var theft = new Claim
        {
            ID = 3,
            ClaimType = ClaimType.Theft,
            Description = "Stolenpancakes",
            Amount = 4.00m,
            DateOfAccident = new DateTime (2018, 27, 04),
            DateOfClaim = new DateTime (2018, 04, 01),
            IsValid = false
        };

        // ClaimQueue.Enqueue(1);
        // ClaimQueue.Enqueue(2);
        // ClaimQueue.Enqueue(3);

        foreach (Claim claim in ClaimQueue)
        {
            System.Console.WriteLine(claim);
        }



    }
}