namespace MessageApplication
{
    public abstract class Message
    {
        public int Id;
        public string Title;
        public string Body;
        public Importance Importance;

        public Message(int id, string title, string body, Importance importance)
        {
            this.Id = id;
            this.Title = title;
            this.Body = body;
            this.Importance = importance;
        }

        public int IdOfMessage
        {
            get { return Id; }
            set { Id = value; }
        }

        public string TitleOfMessage
        {
            get { return Title; }
            set { Title = value; }
        }

        public string BodyOfMessage
        {
            get { return Body; }
            set { Body = value; }
        }

        public Importance ImportanceOfMessage
        {
            get { return Importance; }
            set { Importance = value; }
        }

        public abstract string MessageType();

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
