using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportsBetting.Models
{
    public class EventContainerViewModel
    {
        public EventViewModel EditEventModel { get; set; }

        public IEnumerable<EventViewModel> Events { get; set; }
    }
}