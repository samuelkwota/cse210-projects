
// Concrete class for a TextComment
class TextComment : Comment
{
    public TextComment(string commenterName, string commentText) : base(commenterName, commentText)
    {
    }

    public override void Display()
    {
        Console.WriteLine($"- {CommenterName}: {CommentText}");
    }
}
