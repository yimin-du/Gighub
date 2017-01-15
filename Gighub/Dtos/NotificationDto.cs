﻿using Gighub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gighub.Controllers.Api
{
    public class NotificationDto
    {

        public DateTime DateTime { get; set; }

        public NotificationType Type { get; set; }

        public DateTime? OriginalDateTime { get; set; }

        public String OriginalVenue { get; set; }

        public GigDto Gig { get; set; }
    }
}