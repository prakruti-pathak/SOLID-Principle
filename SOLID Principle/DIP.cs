using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principle
{
    //Dependency Inversion Principle (DIP):
    //Depend on abstractions, not on concrete implementations.
    public interface IMessageService
    {
        void SendMessage(string message);
    }

    public class EmailService : IMessageService
    {
        public void SendMessage(string message)
        {
            // Email sending logic
        }
    }

    public class Notification
    {
        private readonly IMessageService _messageService;

        public Notification(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public void Send(string message)
        {
            _messageService.SendMessage(message);
        }
    }


    //Violating DIP:
    public class EmailService1
    {
        public void SendEmail(string message)
        {
            // Email sending logic
        }
    }

    public class Notification1
    {
        private readonly EmailService1 _emailService;

        public Notification1(EmailService1 emailService)
        {
            _emailService = emailService;
        }

        public void Send(string message)
        {
            _emailService.SendEmail(message);
        }
    }


}
