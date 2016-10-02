// ***********************************************************************
// Assembly         : CADemoPost.WebClient
// Author           : TV
// Created          : 10-01-2016
//
// Last Modified By : TV
// Last Modified On : 10-02-2016
// ***********************************************************************
// <copyright file="WebClient.cs" company="">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using CADemoPost.DTO.Models;
using CADemoPost.WebClient.Interfaces;

namespace CADemoPost.WebClient.Implementations
{
    /// <summary>
    /// Class WebClient.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="CADemoPost.WebClient.Interfaces.IWebClient{T}" />
    public class WebClient<T> : IWebClient<T> where T: class
    {
        /// <summary>
        /// Gets or sets the URL.
        /// </summary>
        /// <value>The URL.</value>
        public string Url { get; set; }
        /// <summary>
        /// Gets or sets the HTTP client.
        /// </summary>
        /// <value>The HTTP client.</value>
        public HttpClient HttpClient { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebClient{T}"/> class.
        /// </summary>
        /// <param name="url">The URL.</param>
        public WebClient(string url)
        {
            this.Url = url;
            this.HttpClient = new HttpClient();
            this.HttpClient.BaseAddress = new Uri(this.Url);
        }

        /// <summary>
        /// Gets the posts.
        /// </summary>
        /// <returns>IEnumerable&lt;T&gt;.</returns>
        public IEnumerable<T> GetPosts()
        {
            try
            {
                HttpResponseMessage response = HttpClient.GetAsync(Url).Result;
                return response.Content.ReadAsAsync<IEnumerable<T>>().Result;
            }
            catch (AggregateException exception)
            {
                return new List<T>();
            }
        } 
    }
}
