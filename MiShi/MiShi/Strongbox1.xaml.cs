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
    public sealed partial class Strongbox1 : Page
    {
        public Strongbox1()
        {
            this.InitializeComponent();
            if (Standbox.GetHasInitPassword() == false)
            {
                Standbox.InitPassword();
                Standbox.SetHasInitPassword(true);
            }
            initStandboxShow();
            initPasswordShow();
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

        }

        void initStandboxShow()
        {
            this.One.Text = Standbox.GetPasswordShow(0).ToString();
            this.Two.Text = Standbox.GetPasswordShow(1).ToString();
            this.Three.Text = Standbox.GetPasswordShow(2).ToString();
            this.Four.Text = Standbox.GetPasswordShow(3).ToString();
        }

        void initPasswordShow()
        {
            this.PasswordShow.Text = "";
            for (int i = 0; i < 4; i++)
            {                
                this.PasswordShow.Text += Standbox.GetPassword(i).ToString();
            }
        }

        /// <summary>
        /// 在此页将要在 Frame 中显示时进行调用。
        /// </summary>
        /// <param name="e">描述如何访问此页的事件数据。Parameter
        /// 属性通常用于配置页。</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void BackStrongbox0_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Strongbox0));
        }

        private void PlusOne_Click(object sender, RoutedEventArgs e)
        {
            Standbox.SetPasswordShowPlus(0);
            if (Standbox.Check() == true)
            {
                this.Frame.Navigate(typeof(Strongbox2));
            }
            else
            {
                this.Frame.Navigate(typeof(Strongbox1));
            }
        }

        private void PlusTwo_Click(object sender, RoutedEventArgs e)
        {
            Standbox.SetPasswordShowPlus(1);
            if (Standbox.Check() == true)
            {
                this.Frame.Navigate(typeof(Strongbox2));
            }
            else
            {
                this.Frame.Navigate(typeof(Strongbox1));
            }
        }

        private void PlusThree_Click(object sender, RoutedEventArgs e)
        {
            Standbox.SetPasswordShowPlus(2);
            if (Standbox.Check() == true)
            {
                this.Frame.Navigate(typeof(Strongbox2));
            }
            else
            {
                this.Frame.Navigate(typeof(Strongbox1));
            }
        }

        private void PlusFour_Click(object sender, RoutedEventArgs e)
        {
            Standbox.SetPasswordShowPlus(3);
            if (Standbox.Check() == true)
            {
                this.Frame.Navigate(typeof(Strongbox2));
            }
            else
            {
                this.Frame.Navigate(typeof(Strongbox1));
            }
        }

        private void MinusOne_Click(object sender, RoutedEventArgs e)
        {
            Standbox.SetPasswordShowMinus(0);
            if (Standbox.Check() == true)
            {
                this.Frame.Navigate(typeof(Strongbox2));
            }
            else
            {
                this.Frame.Navigate(typeof(Strongbox1));
            }
        }

        private void MinusTwo_Click(object sender, RoutedEventArgs e)
        {
            Standbox.SetPasswordShowMinus(1);
            if (Standbox.Check() == true)
            {
                this.Frame.Navigate(typeof(Strongbox2));
            }
            else
            {
                this.Frame.Navigate(typeof(Strongbox1));
            }
        }

        private void MinusThree_Click(object sender, RoutedEventArgs e)
        {
            Standbox.SetPasswordShowMinus(2);
            if (Standbox.Check() == true)
            {
                this.Frame.Navigate(typeof(Strongbox2));
            }
            else
            {
                this.Frame.Navigate(typeof(Strongbox1));
            }
        }

        private void MinusFour_Click(object sender, RoutedEventArgs e)
        {
            Standbox.SetPasswordShowMinus(3);
            if (Standbox.Check() == true)
            {
                this.Frame.Navigate(typeof(Strongbox2));
            }
            else
            {
                this.Frame.Navigate(typeof(Strongbox1));
            }
        }
    }
}
