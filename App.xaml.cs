using System.Windows;
using DirectoryFileCount.Managers;

namespace DirectoryFileCount
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            StationManager.Initialize();
        }
    }
}
