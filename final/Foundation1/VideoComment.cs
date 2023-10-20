
// Concrete class for a VideoComment
class VideoComment : Comment
{
    public VideoComment(string commenterName, string commentText) : base(commenterName, commentText)
    {
    }

    public override void Display()
    {
        Console.WriteLine($"- {CommenterName} posted a video comment: {CommentText}");
    }
}