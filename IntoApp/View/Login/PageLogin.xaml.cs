﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GalaSoft.MvvmLight.Views;
using IntoApp.API;
using IntoApp.Common.Enum;
using IntoApp.utils;
using IntoApp.ViewModel;
using MyMessageBox.Controls;

namespace IntoApp.View.Login
{
    /// <summary>
    /// PageLogin.xaml 的交互逻辑
    /// </summary>
    public partial class PageLogin : Page
    {
        public PageLogin()
        {
            InitializeComponent();
        }
    }
}
