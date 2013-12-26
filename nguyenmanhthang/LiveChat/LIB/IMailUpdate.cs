using System;
namespace LiveChat
{
    public interface IMailUpdate
    {
        int Id { get; }
        string DateString { get; }
        string Message { get; }
        string CssClass { get; }
        string Author { get; }
    }
}