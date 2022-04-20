#region BadEmail
public class BadEmail
{
    public void SendEmail()
    {
        // code to send mail
    }
}

public class BadNotification
{
    private BadEmail _email;

    public BadNotification()
    {
        _email = new BadEmail();
    }

    public void PromotionalNotification()
    {
        _email.SendEmail();
    }
}
#endregion

public interface IEmail
{
    void SendEmail();
}

public class Email : IEmail
{
	public void SendEmail()
	{
        //Code
	}
}

public interface INotification
{
    void PromotionalNotification();

    void PromotionalNotification(IEmail e);
}

public class Notification : INotification
{
    public IEmail email;

    public Notification()
	{
        email = new Email();
	}

	public void PromotionalNotification()
	{
        //Send email
	}

	public void PromotionalNotification(IEmail e)
	{
        //Send specific
	}
}

public class TestEmail : IEmail
{
	public void SendEmail() { }
}