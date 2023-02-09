namespace MessageApplication
{
    public class SendSms : ISend
    {
        public void Send(Recipient recipient, Message message)
        {
            Console.WriteLine($"Sending SMS to: {recipient.Name}");
            Console.WriteLine($"Phone Number: {recipient.PhoneNumber}");
            Console.WriteLine($"Message: {message.Body}");
        }
    }
}
