using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using DevExpressApp.Views;

namespace DevExpressApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ShowBarCode(null, null); // Default view
        }

        private void ResetButtons()
        {
            BtnBarCode.IsChecked = false;
            BtnTimePicker.IsChecked = false;
            BtnToggleSwitch.IsChecked = false;
            BtnTrackBar.IsChecked = false;
            BtnGridDemo.IsChecked = false;
            BtnSimpleButtonDemo.IsChecked = false;
        }

        private void ShowBarCode(object sender, RoutedEventArgs e)
        {
            ResetButtons();
            BtnBarCode.IsChecked = true;
            MainContent.Content = new BarCodeView();
        }

        private void ShowTimePicker(object sender, RoutedEventArgs e)
        {
            ResetButtons();
            BtnTimePicker.IsChecked = true;
            MainContent.Content = new TimePickerView();
        }

        private void ShowToggleSwitch(object sender, RoutedEventArgs e)
        {
            ResetButtons();
            BtnToggleSwitch.IsChecked = true;
            MainContent.Content = new ToggleSwitchView();
        }

        private void ShowTrackBar(object sender, RoutedEventArgs e)
        {
            ResetButtons();
            BtnTrackBar.IsChecked = true;
            MainContent.Content = new TrackBarView();
        }
        private void ShowGrid(object sender, RoutedEventArgs e)
        {
            ResetButtons();
            BtnGridDemo.IsChecked = true;
            MainContent.Content = new GridDemoView();
        }
        private void ShowButton(object sender, RoutedEventArgs e)
        {
            ResetButtons();
            BtnSimpleButtonDemo.IsChecked = true;
            MainContent.Content = new ButtonView();
        }


    }
}
