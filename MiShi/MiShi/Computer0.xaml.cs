using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// “空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=234238 上有介绍

namespace MiShi
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class Computer0 : Page
    {
        public Computer0()
        {
            this.InitializeComponent();
        }
        private bool IsPrinted = false;
        /// <summary>
        /// 在此页将要在 Frame 中显示时进行调用。
        /// </summary>
        /// <param name="e">描述如何访问此页的事件数据。Parameter
        /// 属性通常用于配置页。</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void SetIsPrinted()
        {
            IsPrinted = true;
        }

        private bool GetIsPrinted()
        {
            return IsPrinted;
        }

        private void ComputerDownButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void ScreenButton_Click(object sender, RoutedEventArgs e)
        {
            //this.Frame.Navigate(typeof(ComputerScreen0));
            this.Frame.Navigate(typeof(Start0));
        }

        private void GetPictureButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
