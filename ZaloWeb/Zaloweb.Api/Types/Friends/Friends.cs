using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zaloweb.Data.Types.Friends;

namespace Zaloweb.Api.Types.Friends
{
    public class GetIsFriendExistResponse
    {
        public bool IsError { get; set; }
        public bool IsExist { get; set; }
    }

    public class GetFriendResponse : GetFriendsResult
    {
        public bool IsError { get; set; }
    }
}
