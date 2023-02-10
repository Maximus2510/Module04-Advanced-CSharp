namespace MessageApplication
{
    public abstract class Email : Message
    {
        public Email(int id, string title, string body, Importance importance)
            : base(id, title, body, importance)
        {
        }

        //public override string MessageType()
        //{
        //    return "Email";
        //}
    }
}
