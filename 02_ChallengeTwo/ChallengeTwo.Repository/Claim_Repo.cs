
public class Claim_Repo
{
    private readonly Queue<Komodo> _gQueue = new Queue<Komodo>();
    private int _count =0;
    public bool AddKomodointoQueue(Komodo komodo)
    {
        if(komodo != null)
        {
            _count++;
            komodo.ID = _count =0;
            _gQueue.Enqueue(komodo);
            return true;
        }
        return false;
    }

    public Queue<Komodo> GetKomodos()
    {
        return _gQueue;
    }

    public Komodo GetKomodo()
    {
        if(_gQueue.Count > 0)
    {
        var komodo = _gQueue.Peek();
        return komodo;
    }
    else
    {
        return null;
    }
}


public bool ReleaseKomodo()
    {
        var komodo = GetKomodo();
        if(komodo is null)
        {
            return false;
        }
        _gQueue.Dequeue();
        return true;
    }
}