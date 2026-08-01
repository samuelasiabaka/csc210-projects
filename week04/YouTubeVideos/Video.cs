class Video
{
    private string _title;
    private string _author;
    private int _lengthInSeconds;

    private List<Comments> comments;

    public Video()
    {
        comments = new List<Comments>();
    }

    public void AddComment(Comments comment)
    {
        comments.Add(comment);
    }

    public List<Comments> GetComments()
    {
        return comments;
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public int GetLengthInSeconds()
    {
        return _lengthInSeconds;
    }

    public void SetTitle(string title)
    {
        _title = title;
    }

    public void SetAuthor(string author)
    {
        _author = author;
    }
    public void SetLengthInSeconds(int lengthInSeconds)
    {
        _lengthInSeconds = lengthInSeconds;
    }

    public int GetNumberOfComments()
    {
        return comments.Count;
    }
    
}