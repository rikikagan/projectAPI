using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Subscriber.CORE.DTOs;
using Subscriber.CORE.Interface.BL;
using Subscriber.CORE.response;
using Subscriber.Data.Entities;

namespace WeightWatchers.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class SubscriberController : ControllerBase
    {
        readonly ISubscriberService _subscriberController;
        public SubscriberController(ISubscriberService subscriberController)
        {
            _subscriberController = subscriberController;
        }
        // POST: Subscriber_Controller/Create
        [HttpPost]
        public async Task<BaseResponse> add(SubscriberDTO subscriberDTO)
        {
            return await _subscriberController.add(subscriberDTO);
        }
        [HttpPost("/login")]
        public async Task<BaseResponseGeneral<int>> Login(LoginDTO login)
        {
            return await _subscriberController.Login(login);
        }
        
    }

}


