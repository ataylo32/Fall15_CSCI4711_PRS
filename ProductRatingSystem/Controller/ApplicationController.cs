﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProductRatingSystem.Controller
{
    class ApplicationController:Controller
    {
        public void Logout()
        {
            Application.Restart();
        }
    }
}
