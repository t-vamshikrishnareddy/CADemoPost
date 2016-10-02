// ***********************************************************************
// Assembly         : CADemoPost.App
// Author           : TV
// Created          : 10-02-2016
//
// Last Modified By : TV
// Last Modified On : 10-02-2016
// ***********************************************************************
// <copyright file="ViewPostViewModel.cs" company="">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************
using CaDemoPost.VM;
using Newtonsoft.Json;

namespace CADemoPost.App.ViewModels
{
    /// <summary>
    /// Class ViewPostViewModel.
    /// </summary>
    /// <seealso cref="CADemoPost.App.ViewModels.BaseViewModel" />
    public class ViewPostViewModel:BaseViewModel
    {
        /// <summary>
        /// Gets or sets the post view model.
        /// </summary>
        /// <value>The post view model.</value>
        public PostViewModel PostViewModel { get; set; }

        public string Json { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewPostViewModel"/> class.
        /// </summary>
        /// <param name="postViewModel">The post view model.</param>
        public ViewPostViewModel(PostViewModel postViewModel)
        {
            this.PostViewModel = postViewModel;
            Json = JsonConvert.SerializeObject(postViewModel);
        }
    }
}
