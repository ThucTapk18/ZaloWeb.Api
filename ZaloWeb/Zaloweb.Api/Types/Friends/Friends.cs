using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zaloweb.Data.Types.Friends;

namespace Zaloweb.Api.Types.Friends
{

    public class GetFriendResponse
    {
        public long LeftId { get; set; }

        public long RightId { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return $"lid: {LeftId}, rid: {RightId} ,name: {Name}";
        }

        public bool IsBool { get; set; }
    }
}
