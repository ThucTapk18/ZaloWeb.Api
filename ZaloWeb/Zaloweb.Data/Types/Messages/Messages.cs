using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaloweb.Data.Types.Messages
{
    public class GetMessagesResult
    {
        public long MessId { get; set; }
        public long userId { get; set; }
        public string value { get; set; }

        public override string ToString()
        {
            return $"mId: {MessId}, usId: {userId} ,value: {value}";
        }
    }
}
