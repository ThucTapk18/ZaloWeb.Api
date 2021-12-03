using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zaloweb.Data.Types.Friends;

namespace Zaloweb.Data.Serviecs
{
    interface IFriendServices 
    {
        Task<GetFriendsResult> GetFriendsAsync(long? UserId);
    }
}
