using RabbitMQ.Client;
using System;
using System.Text;

namespace Sender
{
    class Sender
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter your name or x to quit");
            String name = Console.ReadLine();

            while (name != "x")
            {
                string greeting = "Hello my name is";

                Send send = new Send(name, greeting);

                var factory = new ConnectionFactory() { HostName = "localhost" };
                using (var connection = factory.CreateConnection())
                using (var channel = connection.CreateModel())
                {
                    channel.QueueDeclare("greetingMessage", false, false, false, null);

                    string message = send.CompileMessage();
                    var body = Encoding.UTF8.GetBytes(message);

                    channel.BasicPublish("", "greetingMessage", null, body);
                    Console.WriteLine(send.CompileMessage());
                }

                Console.WriteLine("please enter your name or x to quit");
                name = Console.ReadLine();

            }
        }
    }
}
