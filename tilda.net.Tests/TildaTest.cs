using System.Threading.Tasks;
using NUnit.Framework;
using TildaNET.Client;

namespace TildaNET.Tests
{
    [TestFixture]
    public class TildaTest
    {
        private readonly long projectId = 1;
        private readonly long pageId = 1;

        private static readonly IHttpClient HttpClient = new FakeHttpClientWrapper();
        private readonly TildaClient _client = new TildaClient(HttpClient);

        [Test]
        public async Task GetProjectsListTest()
        {
            var result = await _client.GetProjectsList();

            Assert.NotNull(result);
            Assert.True(result.Count > 0);
        }

        [Test]
        public async Task GetProjectTest()
        {
            var result = await _client.GetProject(projectId);

            Assert.NotNull(result);
        }

        [Test]
        public async Task GetProjectExportTest()
        {
            var result = await _client.GetProjectExport(projectId);

            Assert.NotNull(result);
        }

        [Test]
        public async Task GetPagesListTest()
        {
            var result = await _client.GetPagesList(projectId);

            Assert.NotNull(result);
            Assert.True(result.Count > 0);
        }

        [Test]
        public async Task GetPageTest()
        {
            var result = await _client.GetPage(pageId);

            Assert.NotNull(result);
        }

        [Test]
        public async Task GetPageFull()
        {
            var result = await _client.GetPageFull(pageId);

            Assert.NotNull(result);
        }

        [Test]
        public async Task GetPageExport()
        {
            var result = await _client.GetPageExport(pageId);

            Assert.NotNull(result);
        }

        [Test]
        public async Task GetPageFullExport()
        {
            var result = await _client.GetPageFullExport(pageId);

            Assert.NotNull(result);
        }
    }
}
