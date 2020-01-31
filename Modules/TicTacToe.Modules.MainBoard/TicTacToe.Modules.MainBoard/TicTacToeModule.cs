using TicTacToe.Modules.MainBoard.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace TicTacToe.Modules.MainBoard
{
    public class TicTacToeModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {

            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RequestNavigate("ContentRegion", "MainBoardView");
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ScoreBoardView>();
            containerRegistry.RegisterForNavigation<MainBoardView>();
        }
    }
}