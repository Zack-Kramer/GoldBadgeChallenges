public class Badge
{
    public Badge()
    {
        
    }
    public Badge(List<string> doors)
    {
       Doors = doors;

    }
    public int BadgeID { get; set; }
    public List<string> Doors { get; set; }
}