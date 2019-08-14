using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;


namespace Wox.Plugin.AMIFinder
{
    /// <summary>
    /// SettingsControl.xaml 的交互逻辑
    /// </summary>
    public partial class SettingsControl : UserControl
    {
        private Settings _settings;
        private IPublicAPI _woxAPI;

        public SettingsControl(IPublicAPI woxAPI,Settings settings)
        {
            InitializeComponent();
            _settings = settings;
            _woxAPI = woxAPI;
            profileBox.Text = _settings.Profile;
            regionBox.Text = _settings.Region;
        }

        private void OnApplyBTClick(object sender, RoutedEventArgs e)
        {
            _settings.Profile = profileBox.Text;
            _settings.Region = regionBox.Text;
        }
    }
}
