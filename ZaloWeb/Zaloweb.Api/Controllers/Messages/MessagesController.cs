using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Zaloweb.Api.Types.Friends;
using Zaloweb.Api.Types.Messages;
using Zaloweb.Data.Serviecs;
using Zaloweb.Data.Serviecs.Messages;

namespace Zaloweb.Api.Controllers.Messages
{
    [ApiController]
    [Route("mess")]
    public class MessagesController : Controller
    {   
        
        private readonly MessageServices messServices;
        public MessagesController(MessageServices messServices)
        {
            this.messServices = messServices;
        }
        [HttpPost]
        [Route("info")]
        public async Task<GetMessagesResponse> GetMessageAsync(string value)
        {
            try
            {
                var response = await messServices.GetMessagesAsync(value);
                return new GetMessagesResponse
                {

                    MessId = response.MessId,
                    value = response.value,
                    userId = response.userId
                };
            }
            catch
            {
                return new GetMessagesResponse
                {
                    IsBool = true
                };
            }
        }
    }
}
