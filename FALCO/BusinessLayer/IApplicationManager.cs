﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public interface IApplicationManager

    {
        void sendEmail(String message, String address);
    }
}