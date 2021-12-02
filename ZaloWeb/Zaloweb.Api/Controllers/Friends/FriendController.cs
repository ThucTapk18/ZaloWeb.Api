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
        [Route("is-exist")]
        public async Task<GetIsFriendExistResponse> IsUserExistAsync(long leftId)
        {
            try
            {
                var response = await friendServices.(userName);
                return new GetIsFriendExistResponse
                {
                    IsError = false,
                    IsExist = response
                };
            }
            catch
            {
                return new GetIsUserExistResponse
                {
                    IsError = true
                };
            }
        }

        [HttpGet]
        [Route("info")]
        public async Task<GetUserResponse> GetUserAsync(string userName = null, long? userId = null)
        {
            try
            {
                var response = await userService.GetUserAsync(userName, userId);
                return new GetUserResponse
                {
                    IsError = false,
                    Id = response.Id,
                    Name = response.Name
                };
            }
            catch
            {
                return new GetUserResponse
                {
                    IsError = true
                };
            }
        }

    }
}
