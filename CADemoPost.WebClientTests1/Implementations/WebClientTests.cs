using Microsoft.VisualStudio.TestTools.UnitTesting;
using CADemoPost.WebClient.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CADemoPost.DTO.Models;
using CADemoPost.WebClient.Interfaces;

namespace CADemoPost.WebClient.Implementations.Tests
{
    [TestClass()]
    public class WebClientTests
    {
        [TestMethod()]
        public void GetPostsTest()
        {
            IWebClient<Post> webClient = new WebClient<Post>(@"http://jsonplaceholder.typicode.com/posts");
            webClient.GetPosts();
            
            Assert.Fail();
        }
    }
}