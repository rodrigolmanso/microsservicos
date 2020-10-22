using System;
using EasyNetQ;
using mqmodel;

namespace consumer
{
    public class Consumer
    {
        IBus bus;

        public void StartClient()
        {
            bus = RabbitHutch.CreateBus("host=localhost");
            bus.Receive<Message>(Message.QUEUE, (message) =>
            {
                Console.WriteLine(message.Mensagem);
            });
        }

        static void Main(string[] args)
        {
            Consumer consumer = new Consumer();
            consumer.StartClient();
        }
    }
}
