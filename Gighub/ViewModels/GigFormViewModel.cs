﻿using Gighub.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Gighub.ViewModels
{
    public class GigFormViewModel
    {
        public int Id { get; set; }

        public string Heading { get; set; }

        [Required]
        public string Venue { get; set; }

        [Required]
        [FutureDate]
        public string Date { get; set; }

        [Required]
        [ValidTime]
        public string Time { get; set; }

        [Required]
        public byte Genre { get; set; }

        public string Action {
            get
            {
                return (Id != 0) ? "Update" : "Create"; 
            } 
                
        }

        public IEnumerable<Genre> Genres { get; set; }

        public DateTime GetDateTime() {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time)); 
        }
    }
}