using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zaloweb.Api.Types.Friends;
using Zaloweb.Data.Serviecs;

namespace Zaloweb.Api.Controllers
{
    [ApiController]
    [Route("friend")]
    public class FriendController : ControllerBase
    {
        private readonly FriendServices friendServices;

        public FriendController(FriendServices friendService)
        {
            this.friendServices = friendService;
        }

        

        [HttpGet]
        [Route("info")]
        public async Task<GetFriendResponse> GetFriendAsync(long? leftId = null, long? rightId = null)
        {
            try
            {
                var response = await friendServices.GetFriendsAsync(leftId,rightId);
                return new GetFriendResponse
                {
                    IsError = false,
                    LeftId = response.LeftId,
                    RightId = response.RightId,
                    Name = response.Name
                };
            }
            catch
            {
                return new GetFriendResponse
                {
                    IsError = true
                };
            }
        }

    }
}
