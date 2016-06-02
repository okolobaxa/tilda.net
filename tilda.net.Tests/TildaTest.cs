using TildaNET.Client;
using Xunit;

namespace TildaNET.Tests
{
    public class TildaTest
    {
        private readonly long projectId = 1;
        private readonly long pageId = 1;

        private static IWebClient webClient = new FakeWebClientWrapper();
        private TildaClient client = new TildaClient(webClient);

        [Fact]
        public void GetProjectsListTest()
        {
            var result = client.GetProjectsList();

            Assert.NotNull(result);
            Assert.True(result.Count > 0);
        }

        [Fact]
        public void GetProjectTest()
        {
            var result = client.GetProject(projectId);

            Assert.NotNull(result);
        }

        [Fact]
        public void GetProjectExportTest()
        {
            var result = client.GetProjectExport(projectId);

            Assert.NotNull(result);
        }

        [Fact]
        public void GetPagesListTest()
        {
            var result = client.GetPagesList(projectId);

            Assert.NotNull(result);
            Assert.True(result.Count > 0);
        }

        [Fact]
        public void GetPageTest()
        {
            var result = client.GetPage(pageId);

            Assert.NotNull(result);
        }

        [Fact]
        public void GetPageFull()
        {
            var result = client.GetPageFull(pageId);

            Assert.NotNull(result);
        }

        [Fact]
        public void GetPageExport()
        {
            var result = client.GetPageExport(pageId);

            Assert.NotNull(result);
        }

        [Fact]
        public void GetPageFullExport()
        {
            var result = client.GetPageFullExport(pageId);

            Assert.NotNull(result);
        }
    }
}
