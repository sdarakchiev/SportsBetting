using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportsBetting.Models
{
    public class EditEventViewModel
    {
        public int EventId { get; set; }

        public string EventName { get; set; }

        public double OddsForFirstTeam { get; set; }

        public double OddsForDraw { get; set; }

        public double OddsForSecondTeam { get; set; }

        public string EventStartDate { get; set; }
    }
}