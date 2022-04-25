
public class Claim_Repo
{
    private readonly Queue<Claim> _gQueue = new Queue<Claim>();
    private int _count =0;
    public bool AddToQueue(Claim claim)
    {
        if(claim != null)
        {
            _count++;
            claim.ID = _count;
            _gQueue.Enqueue(claim);
            return true;
        }
        return false;
    }

    public Queue<Claim> GetClaims()
    {
        return _gQueue;
    }

    public Claim GetClaim()
    {
        if(_gQueue.Count > 0)
    {
        var Claim = _gQueue.Peek();
        return Claim;
    }
    else
    {
        return null;
    }
}


public bool ReleaseKomodo()
    {
        var Claim = GetClaim();
        if(Claim is null)
        {
            return false;
        }
        _gQueue.Dequeue();
        return true;
    }
}