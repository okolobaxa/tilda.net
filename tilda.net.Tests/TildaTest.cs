using TildaNET.Client;
using Xunit;

namespace TildaNET.Tests
{
    public class TildaTest
    {
        private readonly long projectId = 1;
        private readonly long pageId = 1;

        private static readonly IWebClient WebClient = new FakeWebClientWrapper();
        private readonly TildaClient _client = new TildaClient(WebClient);

        [Fact]
        public void GetProjectsListTest()
        {
            var result = _client.GetProjectsList();

            Assert.NotNull(result);
            Assert.True(result.Count > 0);
        }

        [Fact]
        public void GetProjectTest()
        {
            var result = _client.GetProject(projectId);

            Assert.NotNull(result);
        }

        [Fact]
        public void GetProjectExportTest()
        {
            var result = _client.GetProjectExport(projectId);

            Assert.NotNull(result);
        }

        [Fact]
        public void GetPagesListTest()
        {
            var result = _client.GetPagesList(projectId);

            Assert.NotNull(result);
            Assert.True(result.Count > 0);
        }

        [Fact]
        public void GetPageTest()
        {
            var result = _client.GetPage(pageId);

            Assert.NotNull(result);
        }

        [Fact]
        public void GetPageFull()
        {
            var result = _client.GetPageFull(pageId);

            Assert.NotNull(result);
        }

        [Fact]
        public void GetPageExport()
        {
            var result = _client.GetPageExport(pageId);

            Assert.NotNull(result);
        }

        [Fact]
        public void GetPageFullExport()
        {
            var result = _client.GetPageFullExport(pageId);

            Assert.NotNull(result);
        }
    }
}
