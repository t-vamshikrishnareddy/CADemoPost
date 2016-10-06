using CADemoPost.DTO.Models;
using CADemoPost.WebClient.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CADemoPost.WebClient.Implementations.Tests
{
    [TestClass()]
    public class WebClientTests
    {
        [TestMethod()]
        public void GetPostsTest()
        {
            IWebClient<Post> webClient = new WebClient<Post>(@"http://jsonplaceholder.typicode.com/posts");
            var list = webClient.GetPosts();
            
            Assert.Fail();
        }
    }
}