using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using T1808A_UWP_SQLite.Entities;
using T1808A_UWP_SQLite.Models;
using T1808A_UWP_SQLite.Utils;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace T1808A_UWP_SQLite
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private StudentModel studentModel;
        public MainPage()
        {
            this.InitializeComponent();
            this.studentModel = new StudentModel();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            Student student = new Student()
            {
                Name = "XuanHungTocDo"
            };
            studentModel.Insert(student);
        }
    }
}
