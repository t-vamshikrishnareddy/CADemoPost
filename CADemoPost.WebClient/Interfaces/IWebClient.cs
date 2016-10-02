// ***********************************************************************
// Assembly         : CADemoPost.WebClient
// Author           : TV
// Created          : 10-01-2016
//
// Last Modified By : TV
// Last Modified On : 10-01-2016
// ***********************************************************************
// <copyright file="IWebClient.cs" company="">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CADemoPost.DTO.Models;

namespace CADemoPost.WebClient.Interfaces
{
    /// <summary>
    /// Interface IWebClient
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IWebClient<T> where T: class
    {
        /// <summary>
        /// Gets the posts.
        /// </summary>
        /// <returns>IEnumerable&lt;T&gt;.</returns>
        IEnumerable<T> GetPosts();
    }
}
