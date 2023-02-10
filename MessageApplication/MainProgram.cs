using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageApplication
{
    public abstract class MainProgram
    {
        static void Main(string[] args)
        {
            var _messageUtilities = new MessageUtilities();
            var _recipientUtilities = new RecipientUtilities();

            Console.WriteLine("Welcome to the Console Application!");
            Console.WriteLine("What would you like to do?");

            while (true)
            {
                Console.WriteLine("\nEnter command:");
                string command = Console.ReadLine();

                try
                {
                    switch (command.ToLower())
                    {
                        case "create message":
                            CreateMessage(_messageUtilities);
                            break;
                        case "list messages":
                            GetAllMessages(_messageUtilities);
                            break;
                        case "delete message":
                            DeleteMessageById(_messageUtilities);
                            break;
                        case "create recipient":
                            CreateRecipient(_recipientUtilities);
                            break;
                        case "list recipients":
                            GetAllRecipients(_recipientUtilities);
                            break;
                        case "delete recipient":
                            DeleteRecipientById(_recipientUtilities);
                            break;
                        case "send message":
                            SendMessage();
                            break;
                        case "send all messages":
                            SendAllMessages();
                            break;
                        case "exit":
                            Console.WriteLine("Goodbye!");
                            return;
                        default:
                            Console.WriteLine("Invalid command.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }
        }

        private static void SendAllMessages()
        {
            
        }

        private static void SendMessage()
        {
            throw new NotImplementedException();
        }

        private static void DeleteRecipientById(RecipientUtilities recipientUtilities)
        {
            Console.WriteLine("Enter message id: ");
            int id = int.Parse(Console.ReadLine());
            recipientUtilities.DeleteRecipientById(id);
            Console.WriteLine("Message deleted!");
        }

        private static void GetAllRecipients(RecipientUtilities recipientUtilities)
        {
            Console.WriteLine("Recipients:");
            foreach (Recipient recipient in recipientUtilities.GetAllRecipients())
            {
                Console.WriteLine($"{recipient.Id}. Name: {recipient.Name} - Recipient Email: {recipient.Email} - Recipient Phone Number: {recipient.PhoneNumber}");
            }
        }

        private static void CreateRecipient(RecipientUtilities recipientUtilities)
        {
            Console.WriteLine("Enter recipient name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter recipient email:");
            string email = Console.ReadLine();
            Console.WriteLine("Enter recipient phone number:");
            string phone = Console.ReadLine();

            int idCounter = recipientUtilities.GetAllRecipients()
                .Last()
                .Id + 1;

            var recipient = new Recipient(idCounter, name, email, phone);

            recipientUtilities.CreateRecipient(recipient);
            Console.WriteLine("Message created!");
        }

        private static void DeleteMessageById(MessageUtilities messageUtilities)
        {
            Console.WriteLine("Enter message id: ");
            int id = int.Parse(Console.ReadLine());
            messageUtilities.DeleteMessageById(id);
            Console.WriteLine("Message deleted!");
        }


        private static void GetAllMessages(MessageUtilities messageUtilities)
        {
            Console.WriteLine("Messages: ");
            foreach (Message message in messageUtilities.GetAllMessages())
            {
                Console.WriteLine($"{message.IdOfMessage}. Title: {message.TitleOfMessage} - Body: {message.BodyOfMessage} - Importance: {message.ImportanceOfMessage}");
            }
        }

        private static void CreateMessage(MessageUtilities messageUtilities)
        {
            Console.WriteLine("Enter message title: ");
            string title = Console.ReadLine();
            Console.WriteLine("Enter message body: ");
            string body = Console.ReadLine();
            Console.WriteLine("Enter message importance (low, medium, high): ");
            string importance = Console.ReadLine();

            Importance messageImportance = Importance.Low;
            switch (importance.ToLower())
            {
                case "low":
                    messageImportance = Importance.Low;
                    break;
                case "medium":
                    messageImportance = Importance.Medium;
                    break;
                case "high":
                    messageImportance = Importance.High;
                    break;
            }

            int idCounter = messageUtilities.GetAllMessages()
                .Last()
                .Id + 1;

            var message = new Message(idCounter, title, body, messageImportance);

            messageUtilities.CreateMessage(message);
            Console.WriteLine("Message created!");
        }
    }
}
