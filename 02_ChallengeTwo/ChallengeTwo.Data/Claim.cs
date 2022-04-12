public class Claim
{
    public int ID { get; set; }
    public ClaimType ClaimType { get; set; }
    public string Description { get; set; }
    public decimal Amount { get; set; }
    public DateTime DateOfAccident { get; set; }
    public DateTime DateOfClaim { get; set; }
    public bool IsValid { get; set; }

}