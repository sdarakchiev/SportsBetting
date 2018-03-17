using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SportsBetting.DbModels;
using SportsBetting.Data;
using Bytes2you.Validation;

namespace SportsBetting.Services
{
    public class EventService : IEventService
    {
        private SportsBettingContext dbContext;

        public EventService(SportsBettingContext dbContext)
        {
            Guard.WhenArgument(dbContext, "dbContext").IsNull().Throw();
            this.dbContext = dbContext;
        }

        public void AddEvent(string eventName, double oddsForFirstTeam, double oddsForDraw, double oddsForSecondTeam, DateTime eventStartDate)
        {
            Event newEvent = new Event()
            {
                EventName = eventName,
                OddsForFirstTeam = oddsForFirstTeam,
                OddsForDraw = oddsForDraw,
                OddsForSecondTeam = oddsForSecondTeam,
                EventStartDate = eventStartDate
            };

            this.dbContext.Events.Add(newEvent);
            this.dbContext.SaveChanges();
        }

        public IEnumerable<Event> AllEvents()
        {
            return this.dbContext.Events.ToList();
        }

        public void DeleteEvent(Event theEvent)
        {
            Guard.WhenArgument(theEvent, "event").IsNull().Throw();

            this.dbContext.Events.Remove(theEvent);
            this.dbContext.SaveChanges();
        }

        public void EditEvent(int eventId, string eventName, double oddsForFirstTeam, double oddsForDraw, double oddsForSecondTeam, DateTime eventStartDate)
        {
            var theEvent = this.dbContext.Events.Find(eventId);
            Guard.WhenArgument(theEvent, "event").IsNull().Throw();

            theEvent.EventName = eventName;
            theEvent.OddsForFirstTeam = oddsForFirstTeam;
            theEvent.OddsForDraw = oddsForDraw;
            theEvent.OddsForSecondTeam = oddsForSecondTeam;
            theEvent.EventStartDate = eventStartDate;

            this.dbContext.SaveChanges();
        }

        public Event FindEvent(int eventId)
        {
            return this.dbContext.Events.First(e => e.EventID == eventId);
        }
    }
}