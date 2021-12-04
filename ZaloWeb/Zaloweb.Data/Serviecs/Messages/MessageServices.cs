using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zaloweb.Data.Types.Messages;

namespace Zaloweb.Data.Serviecs.Messages
{
    public class MessageServices : IMessageServices
    {
        private readonly DBContext _context;
        private DbSet dBSet;

        public MessageServices(DBContext context)
        {
            this._context = context;
        }
        public async Task<GetMessagesResult> GetMessagesAsync(
           string value)
        {
            //var querryUser = _context.Users.Find(value);
            var result = _context.Messages.FindAsync(value);

            if (result == null)
            {
                throw new InvalidOperationException("Không tìm thấy tin nhắn");
            }
            var querry = _context.Messages.Where(x => x.value == value).FirstOrDefault();
            return new GetMessagesResult
            {
                MessId = querry.MessId,
                value = querry.value,
                userId=querry.userId
            };
        }

        public Task GetMessageAsync(string value)
        {
            throw new NotImplementedException();
        }
    }
    
}
