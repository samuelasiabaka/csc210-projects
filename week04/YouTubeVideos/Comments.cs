class Comments
{
    private string _commentAuthor;
    private string _text;

    public Comments()
    {
    }

    public string GetCommentAuthor()
    {
        return _commentAuthor;
    }

    public string GetCommentText()
    {
        return _text;
    }

    public void SetCommentAuthor(string author)
    {
        _commentAuthor = author;
    }

    public void SetCommentText(string commentText)
    {
        _text = commentText;
    }
}