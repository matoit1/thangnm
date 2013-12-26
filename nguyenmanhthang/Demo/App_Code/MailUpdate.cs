using System;

/// <summary>
/// Summary description for MailUpdate
/// </summary>
public class MailUpdate : IMailUpdate {
    #region members
    int id;
    DateTime timeStamp;
    string message;
    string cssClass;
    string author;
    int conversationId;
    #endregion
    #region properties
    public int Id {
        get { return id; }
        set { id = value; }
    }
    public string Message {
        get { return message; }
        set { message = value; }
    }
    public string CssClass {
        get { return cssClass; }
        set { cssClass = value; }
    }
    public string Author {
        get { return author; }
        set { author = value; }
    }
    public int ConversationId {
        get { return conversationId; }
        set { conversationId = value; }
    }
    public DateTime TimeStamp {
        get { return timeStamp; }
        set { timeStamp = value; }
    }
    public string DateString {
        get { return timeStamp.ToLongTimeString(); }
    }
    #endregion

    public MailUpdate() {
    }

    public void Save() {
        DAC.CreateMailUpdate(this);
    }
}