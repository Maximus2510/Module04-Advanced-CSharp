namespace MessageApplication
{
    public abstract class Sms : Message
    {
        public Sms(int id, string title, string body, Importance importance)
            : base(id, title, body, importance)
        {
        }

        //public override string MessageType()
        //{
        //    return "Sms";
        //}
    }
}
