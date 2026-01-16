using System;
public class HistoryNode
{
    private string url;
    private HistoryNode prev;
    private HistoryNode next;

    public string Url
    {
        get { return url; }
        set { url = value; }
    }

    public HistoryNode Prev
    {
        get { return prev; }
        set { prev = value; }
    }

    public HistoryNode Next
    {
        get { return next; }
        set { next = value; }
    }

    public HistoryNode(string url)
    {
        this.url = url;
        prev = null;
        next = null;
    }

    public override string ToString()
    {
        return url;
    }
}

