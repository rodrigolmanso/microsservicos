using System.Threading.Tasks;
using EasyNetQ;
using Microsoft.AspNetCore.Mvc;
using mqmodel;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TesteController: ControllerBase
    {
        private readonly IBus bus;
        private static int counter = 0;

        public TesteController(IBus bus) {
            this.bus = bus;
        }

        [HttpGet]
        public async Task<IActionResult> IndexAsync()
        {
            //--- Validações
            //--- Acesso ao repositório (Leitura e Gravação de Dados)
            
            var message = new Message(counter++ , $"Mensagem: {counter}");
            if (bus.IsConnected)
                await bus.SendAsync<Message>(Message.QUEUE, message);
            return Ok();
        }
    }
}