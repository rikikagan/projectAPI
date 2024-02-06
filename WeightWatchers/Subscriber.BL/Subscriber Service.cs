﻿
using AutoMapper;
using Subscriber.CORE.DTOs;
using Subscriber.CORE.Interface.BL;
using Subscriber.CORE.Interface.DAL;
using Subscriber.CORE.response;
using Subscriber.Data;
using Subscriber.Data.Entities;


namespace Subscriber.BL
{
    public class Subscriber_Service : ISubscriberService
    {
        public readonly ISubscriberRepository _subscriberRepository;
        public readonly IMapper _mapper;
        public Subscriber_Service(ISubscriberRepository subscriberService, IMapper mapper)
        {
            _subscriberRepository = subscriberService;
            _mapper = mapper;
        }
        public async Task<BaseResponse> add(SubscriberDTO subscriberDTO)
        {
            BaseResponse res = new BaseResponse();
            if (!_subscriberRepository.IsExsistEmail(subscriberDTO.Email))
            {
                res = await _subscriberRepository.add(_mapper.Map<SubscriberTable>(subscriberDTO), subscriberDTO.Height);
            }
            return res;
        }
        public async Task<BaseResponseGeneral<int>> Login(LoginDTO login)
        {
            if (_subscriberRepository.IsValidLogin(login))
            {
                return await _subscriberRepository.Login(login);
            }
            return new BaseResponseGeneral<int>() { Date = -1, Message = "baddddd" };
        }
    }
}
