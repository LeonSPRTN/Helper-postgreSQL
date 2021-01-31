using System.Windows;
using System.Windows.Input;
using Helper_postgreSQL.Infrastructure.Commands;
using Helper_postgreSQL.ViewModels.Base;

namespace Helper_postgreSQL.ViewModels
{
    internal class MainWindowViewModel: ViewModelBase
    {
        #region Заголовок окна

        /// <summary>Заголовок окна</summary>
        private string _Title = "Helper postgres";

        /// <summary>Заголовок окна</summary>
        public string Title
        {
            get => _Title;

            set => Set(ref _Title, value);
        }
        #endregion

        #region Команды

        #region MyRegion CloseApplicationCommand

        public ICommand CloseApplicationCommand { get; }

        private bool CanCloseApplicationCommandExecute(object p) => true;

        private void OnCloseApplicationCommandExecuted(object p)
        {
            Application.Current.Shutdown();
        }



        #endregion

        #endregion

        public MainWindowViewModel()
        {
            #region Команды

            CloseApplicationCommand =
                new MVVMCommand(OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecute);

            #endregion
        }

    }
}

