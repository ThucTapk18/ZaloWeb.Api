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
           long? MessId)
        {
            var querryUser = _context.Users.Find(MessId);
            var result = _context.Messages.FindAsync(MessId);

            if (result == null)
            {
                throw new InvalidOperationException("Không tìm thấy tin nhắn");
            }
            var querry = _context.Messages.Where(x => x.MessId == MessId).FirstOrDefault();
            return new GetMessagesResult
            {
                MessId = querry.MessId,
                roomId = querry.roomId,
                value = querry.value,
                userId=querry.userId
            };
        }

        public Task GetMessageAsync(long? messId)
        {
            throw new NotImplementedException();
        }
    }
    
}
