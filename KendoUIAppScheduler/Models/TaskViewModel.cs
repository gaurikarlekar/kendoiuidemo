﻿using Kendo.Mvc.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KendoUIAppScheduler.Models
{
    public class TaskViewModel : ISchedulerEvent
    {
        public int TaskID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        private DateTime start;
        public DateTime Start
        {
            get
            {
                return start;
            }
            set
            {
                start = value.ToUniversalTime();
            }
        }

        private DateTime end;
        public DateTime End
        {
            get
            {
                return end;
            }
            set
            {
                end = value.ToUniversalTime();
            }
        }
        public string RecurrenceRule { get; set; }
        
        public int? RecurrenceID { get; set; }
        public string RecurrenceException { get; set; }
        public bool IsAllDay { get; set; }
        public int? OwnerID { get; set; }

        //private string starttimezone;
        public string StartTimezone { get; set; }

        //private string endtimezone;
        public string EndTimezone { get; set; }

    }
}