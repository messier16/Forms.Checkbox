// ***********************************************************************
// Assembly         : XLabs.Forms
// Author           : XLabs Team
// Created          : 12-27-2015
// 
// Last Modified By : XLabs Team
// Last Modified On : 01-04-2016
// ***********************************************************************
// <copyright file="CheckBox.cs" company="XLabs Team">
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
using Xamarin.Forms;

namespace Messier16.Forms.Controls
{
    /// <summary>
    /// The check box.
    /// </summary>
    public class Checkbox : View
    {
        /// <summary>
        /// The checked state property.
        /// </summary>
        public static readonly BindableProperty CheckedProperty =
            BindableProperty.Create("Checked",
                typeof(bool),
                typeof(Checkbox),
                false, BindingMode.TwoWay, propertyChanged: OnCheckedPropertyChanged);

#if DEBUG
        /// <summary>
        /// The checked state property.
        /// </summary>
        public static readonly BindableProperty TestProperty =
            BindableProperty.Create("Test",
                typeof(string),
                typeof(Checkbox),
                "Test", BindingMode.TwoWay);

        /// <summary>
        /// Gets or sets a value indicating whether the control is checked.
        /// </summary>
        /// <value>The checked state.</value>
        public string Test
        {
            get
            {
                return (string)GetValue(TestProperty);
            }

            set
            {
                SetValue(TestProperty, value);
            }
        }
#endif

        /// <summary>
        /// Gets or sets a value indicating whether the control is checked.
        /// </summary>
        /// <value>The checked state.</value>
        public bool Checked
        {
            get
            {
                return (bool)GetValue(CheckedProperty);
            }

            set
            {
                if (this.Checked != value)
                {
                    SetValue(CheckedProperty, value);
                    if (CheckedChanged != null)
                        CheckedChanged.Invoke(this, new EventArgs<bool>(value));
                }
            }
        }

        /// <summary>
        /// The checked changed event.
        /// </summary>
        public event EventHandler<EventArgs<bool>> CheckedChanged;

        /// <summary>
        /// Called when [checked property changed].
        /// </summary>
        /// <param name="bindable">The bindable.</param>
        /// <param name="oldvalue">if set to <c>true</c> [oldvalue].</param>
        /// <param name="newvalue">if set to <c>true</c> [newvalue].</param>
        private static void OnCheckedPropertyChanged(BindableObject bindable, object oldvalue, object newvalue)
        {
            var checkBox = (Checkbox)bindable;
            checkBox.Checked = (bool)newvalue;
        }
    }
}