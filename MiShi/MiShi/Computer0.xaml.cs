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
            if (InterfacePrint.getIsPrinted() == true)
            {
                this.ImagePrinted.Visibility = Windows.UI.Xaml.Visibility.Visible;
                this.GetPictureButton.Visibility = Windows.UI.Xaml.Visibility.Visible;
            }
            else
            {
                this.ImagePrinted.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                this.GetPictureButton.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            }
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

            // 初始化最初的图片信息全部不显示
            this.InfoPictureImage.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            this.InfoMagnifierImage.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            this.InfoKeyImage.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            this.PictureTimeText.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            this.PictureChosenImage.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            this.MagnifierChosenImage.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            this.KeyChosenImage.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
        }


        private void InitPictureTimeText()
        {
            this.PictureTimeText.Visibility = Windows.UI.Xaml.Visibility.Visible;
            this.PictureTimeText.Text = "2010.09." + Standbox.GetPassword(2).ToString() + Standbox.GetPassword(3).ToString();
        }
        /// <summary>
        /// 在此页将要在 Frame 中显示时进行调用。
        /// </summary>
        /// <param name="e">描述如何访问此页的事件数据。Parameter
        /// 属性通常用于配置页。</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
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
            if (Box.getIsPictureShow() == false)
            {
                this.ImagePrinted.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                this.GetPictureButton.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                Box.setIsPictureShow(true);
                InterfacePrint.setIsPrinted(false);
                this.Frame.Navigate(typeof(Computer0));
                
            }
            else
            {
                //InterfacePrint.setIsPrinted(true);
            }
        }

        private void InfoPictureButton_Click(object sender, RoutedEventArgs e)
        {
            this.InfoMagnifierImage.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            this.InfoKeyImage.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            this.InfoPictureImage.Visibility = Windows.UI.Xaml.Visibility.Visible;

            this.PictureChosenImage.Visibility = Windows.UI.Xaml.Visibility.Visible;
            this.MagnifierChosenImage.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            this.KeyChosenImage.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            InitPictureTimeText();
        }

        private void InfoMagnifierButton_Click(object sender, RoutedEventArgs e)
        {
            this.InfoPictureImage.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            this.PictureTimeText.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            this.InfoKeyImage.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            this.InfoMagnifierImage.Visibility = Windows.UI.Xaml.Visibility.Visible;

            this.MagnifierChosenImage.Visibility = Windows.UI.Xaml.Visibility.Visible;
            this.PictureChosenImage.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            this.KeyChosenImage.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
        }

        private void InfoKeyButton_Click(object sender, RoutedEventArgs e)
        {
            this.InfoMagnifierImage.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            this.InfoPictureImage.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            this.PictureTimeText.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            this.InfoKeyImage.Visibility = Windows.UI.Xaml.Visibility.Visible;

            this.KeyChosenImage.Visibility = Windows.UI.Xaml.Visibility.Visible;
            this.PictureChosenImage.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            this.MagnifierChosenImage.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

        }

        private void InfoCloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.InfoMagnifierImage.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            this.InfoPictureImage.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            this.InfoKeyImage.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            this.PictureTimeText.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            this.PictureChosenImage.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            this.MagnifierChosenImage.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            this.KeyChosenImage.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
        }

        private void PictureChosenButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.PictureChosenImage.Visibility == Windows.UI.Xaml.Visibility.Collapsed)
            {
                if ((this.InfoMagnifierImage.Visibility == Windows.UI.Xaml.Visibility.Collapsed)
                    && (this.InfoKeyImage.Visibility == Windows.UI.Xaml.Visibility.Collapsed))
                {
                    this.PictureChosenImage.Visibility = Windows.UI.Xaml.Visibility.Visible;
                    this.MagnifierChosenImage.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                    this.KeyChosenImage.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                }
            }
            else
            {
                if (this.InfoPictureImage.Visibility == Windows.UI.Xaml.Visibility.Collapsed)
                {
                    this.PictureChosenImage.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                }
            }
        }

        private void MagnifierChosenButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.MagnifierChosenImage.Visibility == Windows.UI.Xaml.Visibility.Collapsed)
            {
                if ((this.InfoPictureImage.Visibility == Windows.UI.Xaml.Visibility.Collapsed)
                    && (this.InfoKeyImage.Visibility == Windows.UI.Xaml.Visibility.Collapsed))
                {
                    this.MagnifierChosenImage.Visibility = Windows.UI.Xaml.Visibility.Visible;
                    this.PictureChosenImage.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                    this.KeyChosenImage.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                }
            }
            else
            {
                if (this.InfoMagnifierImage.Visibility == Windows.UI.Xaml.Visibility.Collapsed)
                {
                    this.MagnifierChosenImage.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                }
            }
        }

        private void KeyChosenButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.KeyChosenImage.Visibility == Windows.UI.Xaml.Visibility.Collapsed)
            {
                if ((this.InfoPictureImage.Visibility == Windows.UI.Xaml.Visibility.Collapsed)
                    && (this.InfoMagnifierImage.Visibility == Windows.UI.Xaml.Visibility.Collapsed))
                {
                    this.KeyChosenImage.Visibility = Windows.UI.Xaml.Visibility.Visible;
                    //this.OpenDoorButton.Visibility = Windows.UI.Xaml.Visibility.Visible;
                    this.PictureChosenImage.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                    this.MagnifierChosenImage.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                }
            }
            else
            {
                if (this.InfoKeyImage.Visibility == Windows.UI.Xaml.Visibility.Collapsed)
                {
                    this.KeyChosenImage.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                    //this.OpenDoorButton.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                }
            }
        }
    }
}
