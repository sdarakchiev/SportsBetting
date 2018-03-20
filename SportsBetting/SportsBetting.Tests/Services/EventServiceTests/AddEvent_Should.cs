using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SportsBetting.Data;
using SportsBetting.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

using System.Text;
using System.Threading.Tasks;
using SportsBetting.Services;

namespace SportsBetting.Tests.Services.EventServiceTests
{
    [TestClass]
    public class AddEvent_Should
    {
        [TestMethod]
        public void CreateEventAndAddItToDb_WhenParametersAreCorrect()
        {
            // Arrange
            var dbContextMock = new Mock<SportsBettingContext>();
            List<Event> events = new List<Event>();

            string eventName = "eventName";
            double oddsForFirstTeam = 1.00;
            double oddsForDraw = 2.00;
            double oddsForSecondTeam = 3.00;
            string eventStartDate = "eventStartDate";

            var eventsSetMock = new Mock<DbSet<Event>>().SetupData(events);

            dbContextMock.SetupGet(m => m.Events).Returns(eventsSetMock.Object);

            EventService service = new EventService(dbContextMock.Object);

            // Act
            service.AddEvent(eventName, oddsForFirstTeam, oddsForDraw, oddsForSecondTeam, eventStartDate);

            // Assert
            var newEvent = dbContextMock.Object.Events.Single();

            Assert.AreEqual(eventName, newEvent.EventName);
            Assert.AreEqual(oddsForFirstTeam, newEvent.OddsForFirstTeam);
            Assert.AreEqual(oddsForDraw, newEvent.OddsForDraw);
            Assert.AreEqual(oddsForSecondTeam, newEvent.OddsForSecondTeam);
            Assert.AreEqual( eventStartDate, newEvent.EventStartDate);

            dbContextMock.Verify(m => m.SaveChanges(), Times.Once());
        }
    }
}
