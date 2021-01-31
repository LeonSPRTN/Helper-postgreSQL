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

    }
}

