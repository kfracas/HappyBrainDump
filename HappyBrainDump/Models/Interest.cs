﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HappyBrainDump.Models
{
    public class Interest
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public Interest()
        {
        }

        public Interest(string name)
        {
            Name = name;
        }

    }
}
