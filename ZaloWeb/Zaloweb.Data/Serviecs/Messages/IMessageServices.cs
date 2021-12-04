using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zaloweb.Data.Types.Messages;

namespace Zaloweb.Data.Serviecs.Messages
{
    interface  IMessageServices
    {
        Task<GetMessagesResult> GetMessagesAsync(string? value);
    }
}
