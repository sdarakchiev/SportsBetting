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
    public class DeleteEvent_Should
    {
        [TestMethod]
        public void RemoveEventFromatabase_WhenParameterIsCorrect()
        {
            // Arrange
            var dbContextMock = new Mock<SportsBettingContext>();
            var newEvent = new Event();
            List<Event> events = new List<Event>() { newEvent };
            var articlesSetMock = new Mock<DbSet<Event>>().SetupData(events);

            dbContextMock.Setup(m => m.Events).Returns(articlesSetMock.Object);

            var service = new EventService(dbContextMock.Object);

            // Act
            service.DeleteEvent(newEvent);

            // Assert
            Assert.AreEqual(0, dbContextMock.Object.Events.Count());
        }

        [TestMethod]
        public void ThrowArgumentNullException_WhenParameterIsNull()
        {
            // Arrange
            var dbContextMock = new Mock<SportsBettingContext>();
            var service = new EventService(dbContextMock.Object);

            // Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() => service.DeleteEvent(null));
        }
    }
}
