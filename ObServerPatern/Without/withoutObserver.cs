using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObServerPatern.Without
{
    //Sample1
    public class NotificationService
    {
        public void SendEmail(string message)
        {
            Console.WriteLine($"Email Notification: {message}");
        }

        public void SendSMS(string message)
        {
            Console.WriteLine($"SMS Notification: {message}");
        }
    }

    //Sample 2
    class Logger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Logging: {message}");
        }
    }

    class AuthService
    {
        private Logger _logger = new Logger();

        public void Login(string username)
        {
            Console.WriteLine($"{username} has logged in.");
            _logger.Log($"{username} logged in at {DateTime.Now}");
        }
    }

    //sample 3

    class Inventory
    {
        public void UpdateStock(string product)
        {
            Console.WriteLine($"Stock updated for: {product}");
        }
    }

    class OrderService
    {
        private Inventory _inventory = new Inventory();

        public void PlaceOrder(string product)
        {
            Console.WriteLine($"Order placed for: {product}");
            _inventory.UpdateStock(product);
        }
    }

    class main
    {
        public main()
        {
            //user Sample1
            NotificationService service = new NotificationService();
            service.SendEmail("Hello, World!");
            service.SendSMS("Hello, World!");

            //user Sample2
            AuthService authService = new AuthService();
            authService.Login("User123");
            //user Sample3
            OrderService orderService = new OrderService();
            orderService.PlaceOrder("Laptop");
        }
    }
}
