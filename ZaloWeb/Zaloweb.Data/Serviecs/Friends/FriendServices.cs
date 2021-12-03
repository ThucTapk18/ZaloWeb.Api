using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zaloweb.Data.Tables;
using Zaloweb.Data.Types.Friends;

namespace Zaloweb.Data.Serviecs
{
    public class FriendServices : IFriendServices
    {
        private readonly DBContext _context;
        private DbSet dBSet;
        public FriendServices(DBContext context)
        {
            this._context = context;
        }
        //ham check xem co ban be khong
        public async Task<GetFriendsResult> GetFriendsAsync(
            long? UserId)
        {
            var querryUser = _context.Users.Find(UserId);
            var result = _context.Friends.FindAsync(UserId);

            if(result == null)
            {
                throw new InvalidOperationException("Khong Tim Thay Ban Be");
            }
            var querry = _context.Friends.Where(x => x.LeftId == UserId || x.RightId == UserId).FirstOrDefault();
            return new GetFriendsResult
            {
                LeftId = querry.LeftId,
                RightId = querry.RightId,
                Name = querryUser.Name
            };
        }

    }
}
