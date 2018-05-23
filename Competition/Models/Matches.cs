﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competition.Models
{
    class Matches
    {
        public string index { get; set; }

        public string matchEvent { get; set; }

        public string name { get; set; }

        public string startTime { get; set; }

        public Matches(string _index, string _matchEvent, string _name, string _startTime)
        {
            this.index = _index;
            this.name = _name;
            this.matchEvent = _matchEvent;
            this.startTime = _startTime;
        }
    }
}