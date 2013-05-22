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
    
    public sealed partial class Start0 : Page
    {
        //bool IsPicturePrinted = false;
        // 是否已打印

        public Start0()
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

            // 初始化最初的图片信息全部不显示
            this.InfoPictureImage.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            this.InfoMagnifierImage.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            this.InfoKeyImage.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            this.PictureTimeText.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            this.PictureChosenImage.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            this.MagnifierChosenImage.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            this.KeyChosenImage.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            //InitNoteTimeText();
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

        private void InitNoteTimeText()
        {
            this.NoteTimeText.Visibility = Windows.UI.Xaml.Visibility.Visible;
            //Standbox.InitPassword();
           // this.NoteTimeText.
            this.NoteTimeText.Text = "2012.05." + Standbox.GetPassword(0).ToString() + Standbox.GetPassword(1).ToString(); 

        }
        private void ComputerScreenDownButton_Click(object sender, RoutedEventArgs e)
        {
            /*
            if (IsPicturePrinted)
            {
                this.Frame.Navigate(typeof(AfterPicturePrinted));
            }
            else
            {
                this.Frame.Navigate(typeof(Computer0));
                
            }
             * */
          
            this.Frame.Navigate(typeof(Computer0));
        }

        
        
        

        private void StartBack_Click(object sender, RoutedEventArgs e)
        {
            //this.Frame.Navigate(typeof(ComputerScreen0));
            if (this.ChoiceImage.Visibility.Equals(Windows.UI.Xaml.Visibility.Visible))
            {
                this.ChoiceImage.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                this.PictureButton.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                //this.PictureButton.IsEnabled = true;
                this.VideoButton.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                //this.VideoButton.IsEnabled = true;
                this.NoteButton.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                /*
                this.PictureButton.IsEnabled = false;
                this.VideoButton.IsEnabled = false;
                this.NoteButton.IsEnabled = false;
                 * */
            }
            else
            {
                this.ChoiceImage.Visibility = Windows.UI.Xaml.Visibility.Visible;
                this.PictureButton.Visibility = Windows.UI.Xaml.Visibility.Visible;
                //this.PictureButton.IsEnabled = true;
                this.VideoButton.Visibility = Windows.UI.Xaml.Visibility.Visible;
                //this.VideoButton.IsEnabled = true;
                this.NoteButton.Visibility = Windows.UI.Xaml.Visibility.Visible;
                //this.NoteButton.IsEnabled = true;
            }
        }

        private void PictureButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.PictureImage.Visibility.Equals(Windows.UI.Xaml.Visibility.Collapsed))
            {
                this.PictureImage.Visibility = Windows.UI.Xaml.Visibility.Visible;
                this.ClosePictureButton.Visibility = Windows.UI.Xaml.Visibility.Visible;
                this.ClosePictureButton.IsEnabled = true;
                this.PrintPictureButton.IsEnabled = true;
            }
        }

        private void ClosePictureButton_Click(object sender, RoutedEventArgs e)
        {
            if(this.PictureImage.Visibility.Equals(Windows.UI.Xaml.Visibility.Visible))
            {
                this.PictureImage.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                this.ClosePictureButton.IsEnabled = false;
                this.ClosePictureButton.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                
                
            }
        }

        private void CloseVideoButton_Click(object sender, RoutedEventArgs e)
        {
            this.VideoImage.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            this.CloseVideoButton.IsEnabled = false;
            this.CloseVideoButton.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
        }

        private void CloseNoteButton_Click(object sender, RoutedEventArgs e)
        {
            this.NoteImage.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            this.CloseNoteButton.IsEnabled = false;
            this.CloseNoteButton.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            this.NoteTimeText.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
        }

        private void VideoButton_Click(object sender, RoutedEventArgs e)
        {
            this.VideoImage.Visibility = Windows.UI.Xaml.Visibility.Visible;
            this.CloseVideoButton.Visibility = Windows.UI.Xaml.Visibility.Visible;
            this.CloseVideoButton.IsEnabled = true;
            //this.PrintVideoButton.IsEnabled = true;
            
        }

        private void NoteButton_Click(object sender, RoutedEventArgs e)
        {
            this.NoteImage.Visibility = Windows.UI.Xaml.Visibility.Visible;
            //this.NoteTimeText.Visibility = Windows.UI.Xaml.Visibility.Visible;
            InitNoteTimeText();
            this.CloseNoteButton.Visibility = Windows.UI.Xaml.Visibility.Visible;
            this.CloseNoteButton.IsEnabled = true;
            //this.PrintVideoButton.IsEnabled = true;

        }

        private void PrintPictureButton_Click(object sender, RoutedEventArgs e)
        {
            //this.IsPicturePrinted = true;
            InterfacePrint.setIsPrinted(true);
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
