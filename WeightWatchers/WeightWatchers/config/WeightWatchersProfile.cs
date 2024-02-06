﻿using AutoMapper;
using Subscriber.CORE.DTOs;
using Subscriber.Data.Entities;
using Subscriber.Data.Migrations;
using System.Runtime.Intrinsics.X86;

namespace WeightWatchers.config
{
    public class WeightWatchersProfile:Profile
    {
        public WeightWatchersProfile()
        {
            CreateMap<SubscriberTable, SubscriberDTO>().ForMember(h=>h.Height,opt=>opt.Ignore()).ReverseMap();
        }
    }
}
