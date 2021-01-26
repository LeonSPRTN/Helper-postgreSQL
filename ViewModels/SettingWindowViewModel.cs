using Helper_postgreSQL.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper_postgreSQL.ViewModels
{
    class SettingWindowViewModel : ViewModelBase
    {
        #region Заголовок окна

        private string _Title;

        /// <summary>
        /// Заголовок окна
        /// </summary>
        public string Title
        {
            get => _Title;

            set => Set(ref _Title, value);
        }
        #endregion

    }
}

