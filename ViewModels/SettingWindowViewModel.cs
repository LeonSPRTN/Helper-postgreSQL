using Helper_postgreSQL.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper_postgreSQL.ViewModels
{
    internal class SettingWindowViewModel : ViewModelBase
    {
        #region Заголовок окна

        /// <summary>
        /// Заголовок окна
        /// </summary>
        private string _Title = "Setting";

        /// <summary>
        /// Заголовок окна
        /// </summary>
        public string Title
        {
            get => _Title;

            set => Set(ref _Title, value);
        }
        #endregion

        #region Загрузка данных


        #endregion

    }
}

