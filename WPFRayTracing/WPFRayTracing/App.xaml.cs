﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WPFRayTracing
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {

        public World MyWorld { set; get; }

        App()
        {
            MyWorld = new World();
            MyWorld.Build();
        }
    }
}
