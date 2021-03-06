﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// “空白应用程序”模板在 http://go.microsoft.com/fwlink/?LinkId=234227 上有介绍

namespace MiShi
{
    /// <summary>
    /// 提供特定于应用程序的行为，以补充默认的应用程序类。
    /// </summary>
    
    public static class InterfacePrint
    {
        private static bool IsPrinted = false;
        
        public static void setIsPrinted(bool b1)
        {
            //set { IsPrinted = true; }
            IsPrinted = b1;
        }
        public static bool getIsPrinted()
        {
            //get { return IsPrinted; }
            return IsPrinted;
        }

    }
    public static class Magnifier
    {
        private static bool IsShow = true;
        public static void setIsShow(bool b)
        {
            IsShow = b;
        }
        public static bool getIsShow()
        {
            return IsShow;
        }
    }
    public static class Key
    {
        private static bool IsKeyShow = true;
        private static bool IsRectangleShow = false;


        public static void setIsKeyShow(bool b)
        {
            IsKeyShow = b;
        }
        public static bool getIsKeyShow()
        {
            return IsKeyShow;
        }

        public static void setIsRectangleShow(bool b)
        {
            IsRectangleShow = b;
        }
        public static bool getIsRectangleShow()
        {
            return IsRectangleShow;
        }

    }

    public static class Box
    {
        private static bool IsPictureShow = false;
        private static bool IsMagnifierShow = false;
        private static bool IsKeyShow = false;
        public static void setIsPictureShow(bool b)
        {
            IsPictureShow = b;
        }
        public static bool getIsPictureShow()
        {
            return IsPictureShow;
        }

        public static void setIsMagnifierShow(bool b)
        {
            IsMagnifierShow = b;
        }
        public static bool getIsMagnifierShow()
        {
            return IsMagnifierShow;
        }

        public static void setIsKeyShow(bool b)
        {
            IsKeyShow = b;
        }
        public static bool getIsKeyShow()
        {
            return IsKeyShow;
        }
    }
  
    public static class Standbox
    {
        private static int [] password = { 0, 0, 0, 0 };
        private static bool HasInitPassword = false;
        //private int[] num = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        public static void InitPassword()
        {
            Random ra = new Random();
            password[0] = ra.Next(0, 4);
            if (password[0] == 3)
            {
                password[1] = ra.Next(0, 2);
            }
            else
            {
                password[1] = ra.Next(0, 10);
            }
            password[2] = ra.Next(0, 4);
            if (password[2] == 3)
            {
                password[3] = 0;
            }
            else
            {
                password[3] = ra.Next(0, 10);
            }
            /*
            for (int i = 0; i < 4; i++)
            {
                //password[i] = (new Random()).Next()%10;
                password[i] = ra.Next(1,9);
            }
             * */
        }
        //Random ra1 = new Random();
       
        public static void SetHasInitPassword(bool b)
        {
            HasInitPassword = b;
        }
        public static bool GetHasInitPassword()
        {
            return HasInitPassword;
        }

        public static int GetPassword(int i)
        {
            return password[i];
        }
        private static int[] passwordShow = { 0, 0, 0, 0 };
        public static void SetPasswordShowZeros()
        {
            //passwordShow = {0,0,0,0};
            for(int i = 0; i < 4; i++)
                passwordShow[i] = 0;
        }
        public static void SetPasswordShowPlus(int i)
        {
            if (passwordShow[i] == 9)
            {
                passwordShow[i] = 0;
            }
            else
            {
                passwordShow[i] += 1;
            }
           
        }
        public static void SetPasswordShowMinus(int i)
        {
            if (passwordShow[i] == 0)
            {
                passwordShow[i] = 9;
            }
            else
            {
                passwordShow[i] -= 1;
            }

        }
        public static int GetPasswordShow(int i)
        {           
                return passwordShow[i];
        }
        public static bool Check()
        {
            int temp = 0;
            for (int i = 0; i < 4; i++)
            {
                if (password[i].Equals(passwordShow[i]))
                {
                    temp++;
                }
                else
                {
                    temp--;
                }
                //return password.Equals(passwordShow);
            }
            return (temp==4);
        }
    }
/*
    public class Info
    {
        private bool IsInfoPictureShow = false;
        private bool IsInfoMagnifierShow = false;
        private bool IsInfoKeyShow = false;


        
    }
 * */




    sealed partial class App : Application
    {
        /// <summary>
        /// 初始化单一实例应用程序对象。这是执行的创作代码的第一行，
        /// 逻辑上等同于 main() 或 WinMain()。
        /// </summary>

        
        public App()
        {
            ///int num = 0;
            this.InitializeComponent();
            this.Suspending += OnSuspending;
        }

        


        /// <summary>
        /// 在应用程序由最终用户正常启动时进行调用。
        /// 当启动应用程序以执行打开特定的文件或显示搜索结果等操作时
        /// 将使用其他入口点。
        /// </summary>
        /// <param name="args">有关启动请求和过程的详细信息。</param>
        protected override void OnLaunched(LaunchActivatedEventArgs args)
        {
            Frame rootFrame = Window.Current.Content as Frame;

            // 不要在窗口已包含内容时重复应用程序初始化，
            // 只需确保窗口处于活动状态
            if (rootFrame == null)
            {
                // 创建要充当导航上下文的框架，并导航到第一页
                rootFrame = new Frame();

                if (args.PreviousExecutionState == ApplicationExecutionState.Terminated)
                {
                    //TODO: 从之前挂起的应用程序加载状态
                }

                // 将框架放在当前窗口中
                Window.Current.Content = rootFrame;
            }

            if (rootFrame.Content == null)
            {
                // 当未还原导航堆栈时，导航到第一页，
                // 并通过将所需信息作为导航参数传入来配置
                // 参数
                if (!rootFrame.Navigate(typeof(MainPage), args.Arguments))
                {
                    throw new Exception("Failed to create initial page");
                }
            }
            // 确保当前窗口处于活动状态
            Window.Current.Activate();
        }

        /// <summary>
        /// 在将要挂起应用程序执行时调用。在不知道应用程序
        /// 将被终止还是恢复的情况下保存应用程序状态，
        /// 并让内存内容保持不变。
        /// </summary>
        /// <param name="sender">挂起的请求的源。</param>
        /// <param name="e">有关挂起的请求的详细信息。</param>
        private void OnSuspending(object sender, SuspendingEventArgs e)
        {
            var deferral = e.SuspendingOperation.GetDeferral();
            //TODO: 保存应用程序状态并停止任何后台活动
            deferral.Complete();
        }
    }
}
