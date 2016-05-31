using Xunit;

namespace tilda.net.Tests
{
    public class TildaTest
    {
        [Fact]
        public void GetProjectsListTest()
        {

            var client = new TildaClient("", "");
            var result = client.GetProjectsList();

            Assert.NotNull(result);
            Assert.True(result.Count > 0);
        }

        [Fact]
        public void GetProjectTest()
        {

            var client = new TildaClient("", "");
            var result = client.GetProject(1);

            Assert.NotNull(result);
        }

        [Fact]
        public void GetProjectExportTest()
        {

            var client = new TildaClient("", "");
            var result = client.GetProjectsList();

            Assert.NotNull(result);
            Assert.True(result.Count > 0);
        }

        [Fact]
        public void GetPagesListTest()
        {

            var client = new TildaClient("", "");
            var result = client.GetPagesList(1);

            Assert.NotNull(result);
            Assert.True(result.Count > 0);
        }

        [Fact]
        public void GetPageTest()
        {

            var client = new TildaClient("", "");
            var result = client.GetPage(1);

            Assert.NotNull(result);
        }

        [Fact]
        public void GetPageFull()
        {

            var client = new TildaClient("", "");
            var result = client.GetPageFull(1);

            Assert.NotNull(result);
        }

        [Fact]
        public void GetPageExport()
        {

            var client = new TildaClient("", "");
            var result = client.GetPageExport(1);

            Assert.NotNull(result);
        }

        [Fact]
        public void GetPageFullExport()
        {

            var client = new TildaClient("", "");
            var result = client.GetPageFull(1);

            Assert.NotNull(result);
        }
    }
}
