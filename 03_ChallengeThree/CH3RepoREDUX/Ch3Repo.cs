public class Ch3Repo
{
    private readonly Dictionary<int, Badge> _badgeDb = new Dictionary<int, Badge>();
    //Tkey^   ^Tvalue
    // Unique identifier
    // Like Apple, the word is the key 
    //The badge is the initial object and it will have an id on it
    private int _counter = 0;
    //everytime we add a badge we go up by 1

    public bool AddBadgeToDatabase(Badge badge)
    {
            if (badge == null)
            {
                return false;
           }
            _counter++;
            badge.BadgeID = _counter;
           _badgeDb.Add(badge.BadgeID, badge);
            return true;
    }
    public Dictionary<int, Badge> ShowAllBadges()
    //     When people say of type they mean <>
    {
            return _badgeDb;
    }
    
    public Badge GetBadgeByKey(int badgeId)
    {
            foreach(var KV in _badgeDb)
            {
                    if (KV.Key == badgeId)
                    {
                        return KV.Value;
                    }
            }
            return null;
    }
    public bool AddDoor(int badgeId, string doorName)
    {
            var badge = GetBadgeByKey(badgeId);
            if (badge == null)
            {
                    return false;
            }
            badge.Doors.Add(doorName);
                    return true;
    }
    public bool RemoveDoor(int badgeId, string doorName)
    // This will be different because we are looking for a door already in there, but one second
    {
             var badge = GetBadgeByKey(badgeId);
            if (badge == null)
            {
                    return false;
            }
            foreach(var door in badge.Doors)
            {
                    if (door == doorName)
                    {
                        badge.Doors.Remove(door);
                        return true;
                    }
            }
            return false;
    }
    public bool DeleteDoor(int badgeId)
    {
        var door = GetBadgeByKey(badgeId);
        if(door != null)
        {
            _badgeDb.Remove(badgeId);
            return true;
        }
        else
        {
            return false;
        }

}
}