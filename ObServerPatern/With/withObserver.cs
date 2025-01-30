using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObServerPatern.With
{
    using System;
    using System.Collections.Generic;

    #region NotificationService

    // اینترفیس آبزرور
    interface IObserver
    {
        void Update(string message);
    }

    // کلاس آبزرورهای مختلف
    class EmailNotifier : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine($"Email Notification: {message}");
        }
    }

    class SMSNotifier : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine($"SMS Notification: {message}");
        }
    }

    // کلاس انتشاردهنده (Publisher)
    class NotificationService
    {
        private List<IObserver> observers = new List<IObserver>();

        public void Subscribe(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Unsubscribe(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify(string message)
        {
            foreach (var observer in observers)
            {
                observer.Update(message);
            }
        }
    }

    class run
    {
        public run()
        {
            NotificationService service = new NotificationService();

            EmailNotifier emailNotifier = new EmailNotifier();
            SMSNotifier smsNotifier = new SMSNotifier();

            service.Subscribe(emailNotifier);
            service.Subscribe(smsNotifier);

            service.Notify("Hello, World!");
        }
    }

    #endregion


    #region AuthService


    interface ILoginObserver
    {
        void OnUserLogin(string username);
    }

    class Logger : ILoginObserver
    {
        public void OnUserLogin(string username)
        {
            Console.WriteLine($"Logging: {username} logged in at {DateTime.Now}");
        }
    }

    class AuthService
    {
        private List<ILoginObserver> observers = new List<ILoginObserver>();

        public void Subscribe(ILoginObserver observer)
        {
            observers.Add(observer);
        }

        public void Unsubscribe(ILoginObserver observer)
        {
            observers.Remove(observer);
        }

        public void Login(string username)
        {
            Console.WriteLine($"{username} has logged in.");
            foreach (var observer in observers)
            {
                observer.OnUserLogin(username);
            }
        }
    }



    class run1
    {
        public run1()
        {
            AuthService authService = new AuthService();
            Logger logger = new Logger();

            authService.Subscribe(logger);
            authService.Login("User123");
        }
    }

    #endregion


    #region Inventory



    interface IInventoryObserver
    {
        void UpdateStock(string product);
    }

    class Inventory : IInventoryObserver
    {
        public void UpdateStock(string product)
        {
            Console.WriteLine($"Stock updated for: {product}");
        }
    }

    class OrderService
    {
        private List<IInventoryObserver> observers = new List<IInventoryObserver>();

        public void Subscribe(IInventoryObserver observer)
        {
            observers.Add(observer);
        }

        public void Unsubscribe(IInventoryObserver observer)
        {
            observers.Remove(observer);
        }

        public void PlaceOrder(string product)
        {
            Console.WriteLine($"Order placed for: {product}");
            foreach (var observer in observers)
            {
                observer.UpdateStock(product);
            }
        }
    }

    class Program
    {
        static void Main()
        {
      
        }
    }
    class run2
    {
        public run2()
        {
            OrderService orderService = new OrderService();
            Inventory inventory = new Inventory();

            orderService.Subscribe(inventory);
            orderService.PlaceOrder("Laptop");
        }
    }

    #endregion

}
