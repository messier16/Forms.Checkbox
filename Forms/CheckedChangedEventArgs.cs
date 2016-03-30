// ***********************************************************************
// Assembly         : Messier16.Forms.Controls
// Author           : XLabs Team
// Created          : 12-27-2015
// 
// Last Modified By : Antonio Feregrino
// Last Modified On : 03-27-2016
// ***********************************************************************
// <copyright file="EventArgs{T}.cs" company="XLabs Team">
//     Copyright (c) XLabs Team. All rights reserved.
// </copyright>
// <summary>
//       This project is licensed under the Apache 2.0 license
//       https://github.com/XLabs/Xamarin-Forms-Labs/blob/master/LICENSE
//       
//       XLabs is a open source project that aims to provide a powerfull and cross 
//       platform set of controls tailored to work with Xamarin Forms.
// </summary>
// ***********************************************************************
// 

using System;

namespace Messier16.Forms.Controls
{
    /// <summary>
    /// Generic event argument class
    /// </summary>
    /// <typeparam name="T">Type of the argument</typeparam>
    public class CheckedChangedEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventArgs"/> class.
        /// </summary>
        /// <param name = "chkd"></param>
        public CheckedChangedEventArgs(bool chkd)
        {
            this.IsChecked = chkd;
        }

        /// <summary>
        /// Gets the value of the event argument
        /// </summary>
        public bool IsChecked { get; private set; }
    }
}