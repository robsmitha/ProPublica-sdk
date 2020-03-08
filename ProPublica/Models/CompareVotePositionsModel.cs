﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProPublica.Models
{
    public class CompareVotePositionsModel
    {
        public string first_member_id { get; set; }
        public string first_member_api_uri { get; set; }
        public string second_member_id { get; set; }
        public string second_member_api_uri { get; set; }
        public string congress { get; set; }
        public string chamber { get; set; }
        public int common_votes { get; set; }
        public int disagree_votes { get; set; }
        public decimal agree_percent { get; set; }
        public decimal disagree_percent { get; set; }
    }
}
