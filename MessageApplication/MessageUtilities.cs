namespace MessageApplication
{
    public class MessageUtilities
    {
        public List<Message> Messages = new();

        public void CreateMessage(Message message)
        {
            Messages.Add(message);
        }

        public IEnumerable<Message> GetAllMessages()
        {
            foreach (Message messageEntryIEnumReturn in Messages)
            {
                yield return messageEntryIEnumReturn;
            }
        }

        public void DeleteMessageById(int id)
        {
            var selectedMessage = Messages.Where(message => message.Id == id)
                .First();
            Messages.Remove(selectedMessage);
        }

    }
}
