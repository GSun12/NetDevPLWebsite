﻿// -------------------------------------------------------------------------------------------------------------------
// <copyright company="Gemotial" file="NetGroup.cs" project="NetDevPL.Features.NetGroups" date="2016-09-29 23:06">
// 
// </copyright>
// -------------------------------------------------------------------------------------------------------------------

using System;

namespace NetDevPL.Features.NetGroups
{
    public class NetGroupMeeting
    {
        public string GroupKey { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public NetGroupMeetingSeat Seat { get; set; }
        public string Link { get; set; }
        public DateTime Date { get; set; }
    }
}