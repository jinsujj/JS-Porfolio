﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Models
{
    public class Log
    {
        public string ip { get; set; }
        public string page { get; set; }
        public DateTime date { get; set; }

        public string query { get; set; }
    }
}
