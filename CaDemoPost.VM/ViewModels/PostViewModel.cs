// ***********************************************************************
// Assembly         : CaDemoPost.VM
// Author           : TV
// Created          : 10-01-2016
//
// Last Modified By : TV
// Last Modified On : 10-02-2016
// ***********************************************************************
// <copyright file="PostViewModel.cs" company="">
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
using CaDemoPost.VM.ViewModels;

namespace CaDemoPost.VM
{
    /// <summary>
    /// Class PostViewModel.
    /// </summary>
    /// <seealso cref="CaDemoPost.VM.ViewModels.BaseViewModel" />
    public class PostViewModel : BaseViewModel
    {
        /// <summary>
        /// The userid
        /// </summary>
        private int userid;
        /// <summary>
        /// The identifier
        /// </summary>
        private int id;
        /// <summary>
        /// The title
        /// </summary>
        private string title;
        /// <summary>
        /// The body
        /// </summary>
        private string body;

        /// <summary>
        /// Gets or sets the user identifier.
        /// </summary>
        /// <value>The user identifier.</value>
        public int UserId
        {
            get { return userid; }
            set
            {
                userid = value;
                NotifyPropertyChanged("UserId");
            }
        }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                NotifyPropertyChanged("Id");
            }
        }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>The title.</value>
        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                NotifyPropertyChanged("Title");
            }
        }

        /// <summary>
        /// Gets or sets the body.
        /// </summary>
        /// <value>The body.</value>
        public string Body
        {
            get { return body; }
            set
            {
                body = value;
                NotifyPropertyChanged("Body");
            }
        }

    }
}
