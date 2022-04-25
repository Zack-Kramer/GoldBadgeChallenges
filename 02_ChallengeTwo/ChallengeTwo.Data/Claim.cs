public class Claim
{
    public Claim()
    {
        //When making a full constructor (below) make an empty one (this one)
    }
    public Claim(ClaimType claimtype, string description, 
    decimal amount, DateTime dateOfAccident, 
    DateTime dateOfClaim)
    {
        ClaimType = claimtype;
        Description = description;
        Amount = amount;
        DateOfAccident = dateOfAccident;
        DateOfClaim = dateOfClaim;
    }
    public int ID { get; set; }
    public ClaimType ClaimType { get; set; }
    public string Description { get; set; }
    public decimal Amount { get; set; }
    public DateTime DateOfAccident { get; set; }
    public DateTime DateOfClaim { get; set; }
    public bool IsValid
    {
        get
        {
            TimeSpan span = DateOfClaim - DateOfAccident;
            if (span.TotalDays <= 30)
            {
            return true;
            }
            else
            {
                return false;
            }
        }
    }

}