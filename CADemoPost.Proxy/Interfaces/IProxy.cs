// ***********************************************************************
// Assembly         : CADemoPost.Proxy
// Author           : TV
// Created          : 10-01-2016
//
// Last Modified By : TV
// Last Modified On : 10-02-2016
// ***********************************************************************
// <copyright file="IProxy.cs" company="">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaDemoPost.VM;

namespace CADemoPost.Proxy.Interfaces
{
    /// <summary>
    /// Interface IProxy
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="L"></typeparam>
    public interface IProxy<T,L> where T: class
        where L:class 
    {
        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns>IEnumerable&lt;T&gt;.</returns>
        IEnumerable<T> GetAll();
        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>T.</returns>
        T GetById(int id);
    }
}
