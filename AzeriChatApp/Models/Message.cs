namespace AzeriChatApp.Models;

public class Message
{
	private string? _text;

	public string Text
	{
		get { return _text; }
		set { _text = value; }
	}

	private DateTime _date;

	public DateTime Date
	{
		get { return _date; }
		set { _date = value; }
	}

    public Message(string text, DateTime date)
    {
		Text = text;
		Date = date;
	}
}
