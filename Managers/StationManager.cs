﻿using System;
using System.Windows;
using DirectoryFileCount.Models;

namespace DirectoryFileCount.Managers
{
    public static class StationManager
    {
        public static User CurrentUser { get; set; }

        public static void Initialize()
        {
            
        }

        internal static void CloseApp()
        {
            MessageBox.Show("ShutDown");
            Environment.Exit(1);
        }
    }
}
