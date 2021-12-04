namespace Zaloweb.Api.Types.Messages
{
    public class GetMessagesResponse
    {
        public long MessId { get; set; }
        public long userId { get; set; }
        public string value { get; set; }

        public override string ToString()
        {
            return $"mId: {MessId}, usId: {userId} ,value: {value}";
        }
        public bool IsBool { get; set; }
    }
}
