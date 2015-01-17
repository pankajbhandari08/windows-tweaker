﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WindowsTweaker.AppTasks;

namespace WindowsTweaker {
    /// <summary>
    /// Interaction logic for Splash.xaml
    /// </summary>
    public partial class Splash : Window {
        public Splash() {
            InitializeComponent();
            txtAppVersion.Text = "Windows Tweaker " + Utils.GetAppVersion();
        }
    }
}
