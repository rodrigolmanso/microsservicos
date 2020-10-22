using System;

namespace mqmodel
{
    public class Message
    {
        public const string QUEUE = "ST2020.SimpleMessage";

        public Message(int id, string message) {
            this.Mensagem = message;
            this.Id = id;
        }

        public string Mensagem { get; set; }
        public int Id { get; set; }

    }
}
