using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SportsBetting.DbModels
{
    public class Event
    {
        public int EventID { get; set; }

        public string EventName { get; set; }

        [Range(1, Double.MaxValue, ErrorMessage = "The odd must be greater or equal to 1")]
        public double OddsForFirstTeam { get; set; }

        [Range(1, Double.MaxValue, ErrorMessage = "The odd must be greater or equal to 1")]
        public double OddsForDraw { get; set; }

        [Range(1, Double.MaxValue, ErrorMessage = "The odd must be greater or equal to 1")]
        public double OddsForSecondTeam { get; set; }

        public DateTime EventStartDate { get; set; }
    }
}