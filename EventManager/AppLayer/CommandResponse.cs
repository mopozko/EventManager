﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.AppLayer
{
    public class CommandResponse
    {
        public string Text { get; }

        public CommandResponse(string responseText)
        {
            Text = responseText;
        }
        
    }
}
