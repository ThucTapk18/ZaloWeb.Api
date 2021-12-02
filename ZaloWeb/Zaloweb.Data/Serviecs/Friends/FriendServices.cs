using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zaloweb.Data.Tables;
using Zaloweb.Data.Types.Friends;

namespace Zaloweb.Data.Serviecs
{
    public class FriendServices
    {
        private readonly DBContext context;
        public FriendServices(DBContext context)
        {
            this.context = context;
        }
        //ham check xem co ban be khong
        public async Task<GetFriendsResult> GetFriendsAsync(
            long? LeftId = null, long? rightId = null)
        {
            User user = null;
            Friend friend = null;
            if (friend == null)
            {
                throw new InvalidOperationException("Không tìm thấy user");
            }

            return new GetFriendsResult
            {
                LeftId = friend.LeftId,
                RightId = friend.RightId,
                Name = user.Name
                
            };
        }

    }
}
