/*----------------------------------------------------------------
// Copyright (C) 2013 ZGH
// 版权所有。
//
// 文件名：DialogResultDependProperty.cs
// 功能描述：
// 
// 创建时间： 11/4/2015 11:16:16 PM
//
//----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CSharp.Library.DependProperties
{
    /// <summary>
    /// public static readonly DependencyProperty DialogResultProperty =
    ///DependencyProperty.RegisterAttached(
    ///    "DialogResult",
    ///    typeof(bool?),
    ///    typeof(DialogResultDependProperty),
    ///    new PropertyMetadata(DialogResultChanged));

    ///private static void DialogResultChanged(
    ///    DependencyObject d,
    ///    DependencyPropertyChangedEventArgs e)
    ///{
    ///    var window = d as Window;
    ///    if (window != null)
    ///        window.DialogResult = e.NewValue as bool?;
    ///}

    ///public static void SetDialogResult(DependencyObject target, bool? value)
    ///{
    ///    target.SetValue(DialogResultProperty, value);
    ///}
    /// </summary>
    public static class DialogResultDependProperty
    {
        public static readonly DependencyProperty DialogResultProperty =
        DependencyProperty.RegisterAttached(
            "DialogResult",
            typeof(bool?),
            typeof(DialogResultDependProperty),
            new PropertyMetadata(DialogResultChanged));

        private static void DialogResultChanged(
            DependencyObject d,
            DependencyPropertyChangedEventArgs e)
        {
            var window = d as Window;
            if (window != null)
                window.DialogResult = e.NewValue as bool?;
        }

        public static void SetDialogResult(DependencyObject target, bool? value)
        {
            target.SetValue(DialogResultProperty, value);
        }
    }
}
