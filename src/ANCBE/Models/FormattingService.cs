﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ANCBE.Models
{
    public class FormattingService
    {
        public string AsReadableDate(DateTime dateTime)
        {
            return dateTime.ToString("d");
        }
    }
}
