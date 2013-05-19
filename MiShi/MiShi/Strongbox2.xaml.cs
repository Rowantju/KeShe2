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
    public sealed partial class Strongbox2 : Page
    {
        public Strongbox2()
        {
            this.InitializeComponent();
            if (Box.getIsPictureShow() == true)
            {
                this.PictureInBox.Visibility = Windows.UI.Xaml.Visibility.Visible;
            }
            else
            {
                this.PictureInBox.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            }
            if (Box.getIsMagnifierShow() == true)
            {
                this.MagnifierInBox.Visibility = Windows.UI.Xaml.Visibility.Visible;
            }
            else
            {
                this.MagnifierInBox.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            }
            if (Box.getIsKeyShow() == true)
            {
                this.KeyInBox.Visibility = Windows.UI.Xaml.Visibility.Visible;
            }
            else
            {
                this.KeyInBox.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            }
            if (Box.getIsKeyShow() == true)
            {
                Key.setIsKeyShow(false);
                Key.setIsRectangleShow(true);

            }
            else
            {
                Key.setIsKeyShow(true);
                Key.setIsRectangleShow(false);
            }
            InitRectangleAndButtonShow();
        }

        void InitRectangleAndButtonShow()
        {
            if (Key.getIsRectangleShow() == true)
            {
                this.CoverKeyImage.Visibility = Windows.UI.Xaml.Visibility.Visible;
                this.GetKeyButton.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            }
            else
            {
                this.CoverKeyImage.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                this.GetKeyButton.Visibility = Windows.UI.Xaml.Visibility.Visible;
            }
        }
        /*
        void InitKeyShow(bool b)
        {
            if(Key.getIsKeyShow() == true)
            {
                this.
        }
         * */
        /// <summary>
        /// 在此页将要在 Frame 中显示时进行调用。
        /// </summary>
        /// <param name="e">描述如何访问此页的事件数据。Parameter
        /// 属性通常用于配置页。</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void GetKeyButton_Click(object sender, RoutedEventArgs e)
        {
            Key.setIsKeyShow(false);
            Key.setIsRectangleShow(true);
            Box.setIsKeyShow(true);
            //this.CoverKeyRectangle.Visibility = Windows.UI.Xaml.Visibility.Visible;
            this.GetKeyButton.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            //this.KeyInBox.Visibility = Windows.UI.Xaml.Visibility.Visible;
            this.Frame.Navigate(typeof(Strongbox2));
        }

        private void BackStrongbox1Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(East));
        }
    }
}
