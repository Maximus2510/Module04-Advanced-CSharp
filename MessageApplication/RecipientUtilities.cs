namespace MessageApplication
{
    public class RecipientUtilities
    {
        public List<Recipient> Recipients = new List<Recipient>();

        public void CreateRecipient(Recipient recipient)
        {
            Recipients.Add(recipient);
        }

        public IEnumerable<Recipient> GetAllRecipients()
        {
            foreach (Recipient recipientEntryIenumReturn in Recipients)
            {
                yield return recipientEntryIenumReturn;
            }
        }

        public void DeleteRecipientById(int id)
        {
            var selectedRecipient = Recipients.Where(message => message.Id == id)
                .First();
            Recipients.Remove(selectedRecipient);
        }
    }
}
