using TicTacToe.Views;
using Prism.Ioc;
using System.Windows;
using Prism.Modularity;
using Prism.Unity;
using TicTacToe.Modules.MainBoard;

namespace TicTacToe
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<TicTacToeModule>();
        }
    }
}
