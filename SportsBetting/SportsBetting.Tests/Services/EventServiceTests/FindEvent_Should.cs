using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SportsBetting.Data;
using SportsBetting.DbModels;
using SportsBetting.Services;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsBetting.Tests.Services.EventServiceTests
{
    [TestClass]
    public class FindEvent_Should
    {
        [TestMethod]
        public void ReturnCorrectEvent_WhenIdIsValid()
        {
            //Arrange
            var dbContextMock = new Mock<SportsBettingContext>();
            var eventSetMock = new Mock<DbSet<Event>>();

            var newEvent = new Event() { EventID = 1 };
            var events = new List<Event>()
            {
                newEvent
            };

            eventSetMock.SetupData(events);
            dbContextMock.Setup(m => m.Events).Returns(eventSetMock.Object);

            EventService service = new EventService(dbContextMock.Object);

            //Act
            var result = service.FindEvent(1);

            //Assert
            Assert.AreSame(newEvent, result);
        }
    }
}
