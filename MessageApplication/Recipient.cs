namespace MessageApplication
{
    public class Recipient
    {
        public int Id;
        public string Name;
        public string Email;

        public string PhoneNumber;

        public Recipient(int id, string name, string email, string phoneNumber)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.PhoneNumber = phoneNumber;
        }

        public int UserId
        {
            get { return Id; }
            set { Id = value; }
        }

        public string UserName
        {
            get { return Name; }
            set { Name = value; }
        }

        public string UserEmail
        {
            get { return Email; }
            set { Email = value; }
        }

        public string UserPhoneNumber
        {
            get { return PhoneNumber; }
            set { PhoneNumber = value; }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
