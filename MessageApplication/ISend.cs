namespace MessageApplication
{
    public interface ISend
    {
        void Send(Recipient recipient, Message message);
    }
}
