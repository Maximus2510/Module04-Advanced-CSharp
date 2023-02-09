using System;
using System.Collections.Generic;
using System.Linq;

namespace MessageApplication
{
    public abstract class MessageUttlities
    {
        public List<Message> Messages = new List<Message>();
        public List<Recipient> Recipients = new List<Recipient>();

        public bool CreateMessage(Message message)
        {
            foreach(Message messageEntry in Messages)
            {
                if (messageEntry.Id == message.Id)
                {
                    return false;
                }
            }
            Messages.Add(message);
            return true;
        }

        public bool CreateRecipient(Recipient recipient)
        {
            foreach(Recipient recipientEntry in Recipients)
            {
                if(recipientEntry.Id == recipient.Id)
                {
                    return false;
                }
            }
            Recipients.Add(recipient);
            return true;
        }

        public IEnumerable<Message> GetAllMessages(Message messages)
        {
            foreach(Message messageEntryIEnumReturn in Messages)
            {
                yield return messageEntryIEnumReturn;
            }
        }

        public IEnumerable<Recipient> GetAllRecipients(Recipient recipient)
        {
            foreach(Recipient recipientEntryIenumReturn in Recipients)
            {
                yield return recipientEntryIenumReturn;
            }
        }
    }
}
