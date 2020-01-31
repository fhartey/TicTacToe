using System.Windows.Controls;
using TicTacToe.Modules.MainBoard.ViewModels;

namespace TicTacToe.Modules.MainBoard.Views
{
    /// <summary>
    /// Interaction logic for ScoreBoardView
    /// </summary>
    public partial class ScoreBoardView : UserControl
    {
        public ScoreBoardView()
        {
            InitializeComponent();
            DataContext = new ScoreBoardViewModel();
        }
    }
}
