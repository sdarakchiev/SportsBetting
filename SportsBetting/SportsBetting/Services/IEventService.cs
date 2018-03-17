using SportsBetting.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsBetting.Services
{
    public interface IEventService
    {
        void AddEvent(string eventName, double oddsForFirstTeam, double oddsForDraw, double oddsForSecondTeam, DateTime eventStartDate);

        Event FindEvent(int eventId);

        void DeleteEvent(Event theEvent);

        void EditEvent(int eventId, string eventName, double oddsForFirstTeam, double oddsForDraw, double oddsForSecondTeam, DateTime eventStartDate);

        IEnumerable<Event> AllEvents();
    }
}
