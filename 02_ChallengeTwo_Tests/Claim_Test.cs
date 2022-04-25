using Xunit;
using System;
//^^ This is what stopped the datetime build errors

public class Claim_Test
{
    private readonly Claim_Repo _cRepo;
    public Claim_Test()
    {
        _cRepo = new Claim_Repo();
        Seed();
    }

    [Fact]
    public void AddToQueue_ShouldReturnTrue()
    {
        Claim claimD = new Claim(ClaimType.Car, "???", 1.00m, new DateTime(2022, 01, 01), new DateTime (2023, 01, 01));
        Assert.True(_cRepo.AddToQueue(claimD));
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
}