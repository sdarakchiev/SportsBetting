using SportsBetting.Data;

namespace SportsBetting.Tests.Services.EventServiceTests
{
    internal class ArticleServices
    {
        private SportsBettingContext @object;

        public ArticleServices(SportsBettingContext @object)
        {
            this.@object = @object;
        }
    }
}