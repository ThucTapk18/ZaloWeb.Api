using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaloweb.Data.Types.Friends
{
    public class GetFriendsResult
    {
        public long LeftId { get; set; }
        public long RightId { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"lid: {LeftId}, rid: {RightId} ,name: {Name}";
        }
    }
}
