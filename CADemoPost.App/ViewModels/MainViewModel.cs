// ***********************************************************************
// Assembly         : CADemoPost.App
// Author           : TV
// Created          : 10-01-2016
//
// Last Modified By : TV
// Last Modified On : 10-02-2016
// ***********************************************************************
// <copyright file="MainViewModel.cs" company="">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CaDemoPost.VM;
using CADemoPost.App.Commands;
using CADemoPost.DTO.Enum;
using CADemoPost.DTO.Models;
using CADemoPost.Proxy;
using CADemoPost.Proxy.Interfaces;

namespace CADemoPost.App.ViewModels
{
    /// <summary>
    /// Class MainViewModel.
    /// </summary>
    /// <seealso cref="CADemoPost.App.ViewModels.BaseViewModel" />
    public class MainViewModel: BaseViewModel
    {
        /// <summary>
        /// The main window
        /// </summary>
        private MainWindow _MainWindow;
        /// <summary>
        /// Gets or sets the post view models.
        /// </summary>
        /// <value>The post view models.</value>
        public IEnumerable<PostViewModel> PostViewModels { get; set; }
        /// <summary>
        /// Gets or sets the proxy.
        /// </summary>
        /// <value>The proxy.</value>
        public IProxy<PostViewModel, Post> Proxy { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MainViewModel"/> class.
        /// </summary>
        /// <param name="mainWindow">The main window.</param>
        public MainViewModel(MainWindow mainWindow)
        {
            this._MainWindow = mainWindow;
            PostViewModels = GetData();
        }

        /// <summary>
        /// Gets the data.
        /// </summary>
        /// <returns>IEnumerable&lt;PostViewModel&gt;.</returns>
        private IEnumerable<PostViewModel> GetData()
        {
            Proxy = new Proxy<PostViewModel, Post>(@"http://jsonplaceholder.typicode.com/posts");
            return Proxy.GetAll();
        }
        /// <summary>
        /// Gets the refresh command.
        /// </summary>
        /// <value>The refresh command.</value>
        public ICommand RefreshCommand => new DelegateCommand(Refresh);

        /// <summary>
        /// Gets the view post command.
        /// </summary>
        /// <value>The view post command.</value>
        public ICommand ViewPostCommand => new RelayCommand(ViewPost);

        /// <summary>
        /// Refreshes this instance.
        /// </summary>
        private void Refresh()
        {
            PostViewModels = GetData();
            NotifyPropertyChanged("PostViewModels");
        }

        /// <summary>
        /// Views the post.
        /// </summary>
        /// <param name="post">The post.</param>
        private void ViewPost(object post)
        {
            if (post != null)
            {
                ViewPost child = new ViewPost();
                child.DataContext = new ViewPostViewModel(post as PostViewModel);
                child.ShowDialog();
            }
        }
    }
}

