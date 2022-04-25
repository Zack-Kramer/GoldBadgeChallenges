// public class SeededClaims
// {
//     public void Seed()
//     {
//         Queue<Claim> ClaimQueue = new Queue<Claim>();

//         var car = new Claim
//         {
//             ID = 1,
//             ClaimType = ClaimType.Car,
//             Description = "CarAccidentOn465",
//             Amount = 400.00m,
//             DateOfAccident = new DateTime(2018, 04, 25),
//             DateOfClaim = new DateTime(2018, 27, 04),
//             IsValid = true
//         };

//         var home = new Claim
//         {
//             ID = 2,
//             ClaimType = ClaimType.Home,
//             Description = "HouseFireInKitchen",
//             Amount = 4000.00m,
//             DateOfAccident = Convert.ToDateTime("2018/04/11"),
//             DateOfClaim = Convert.ToDateTime("2018/04/12/"),
//             IsValid = true
//         };

//         var theft = new Claim
//         {
//             ID = 3,
//             ClaimType = ClaimType.Theft,
//             Description = "Stolenpancakes",
//             Amount = 4.00m,
//             DateOfAccident = new DateTime(2018, 27, 04),
//             DateOfClaim = new DateTime(2018, 04, 01),
//             IsValid = false
//         };

//         // ClaimQueue.Enqueue(1);
//         // ClaimQueue.Enqueue(2);
//         // ClaimQueue.Enqueue(3);

//         foreach (Claim claim in ClaimQueue)
//         {
//             Console.WriteLine(claim + " Do you want to deal with this claim now? [yes/no]");

//             string y = "yes";

//             string n = "no";

//             if (Console.ReadLine() == y)

//             {

//                 Console.WriteLine(" Alright lets proceed");

//             }

//             if (Console.ReadLine() == n)

//             {

//                 Console.WriteLine("Sad to see you leave");

//                 Environment.Exit(0);

//             }



//         }
//     }
// }