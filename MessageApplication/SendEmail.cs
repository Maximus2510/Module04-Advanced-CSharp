namespace MessageApplication
{
    internal class SendEmail : ISend
    {
        public void Send(Recipient recipient, Message message)
        {
            Console.WriteLine($"Sending Email to: {recipient.Name}");
            Console.WriteLine($"Email Address: {recipient.Email}");
            Console.WriteLine($"Title: {message.Title}");
            Console.WriteLine($"Importance: {message.Importance}");
            Console.WriteLine($"Message: {message.Body}");
        }
    }
}
