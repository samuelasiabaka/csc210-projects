class Comments
{
    private string commentAuthor;
    private string text;

    public Comments()
    {
    }

    public string GetCommentAuthor()
    {
        return commentAuthor;
    }

    public string GetCommentText()
    {
        return text;
    }

    public void SetCommentAuthor(string author)
    {
        commentAuthor = author;
    }

    public void SetCommentText(string commentText)
    {
        text = commentText;
    }
}