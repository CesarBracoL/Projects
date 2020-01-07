using System;
namespace DesignPattern.Proxy
{
    public class Proxy : ISubject
    {
        Subject subject;

        public string Request()
        {
            if (subject == null)
            {
                Console.WriteLine("Subject inactive");
                subject = new Subject();
            }

            Console.WriteLine("Subject active");
            return "Proxy: Call to " + subject.Request();
        }

    }
}