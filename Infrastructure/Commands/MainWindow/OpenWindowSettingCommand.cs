using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Helper_postgreSQL.Infrastructure.Commands.Base;
using Helper_postgreSQL.Views;

namespace Helper_postgreSQL.Infrastructure.Commands
{
    class OpenWindowSettingCommand : CommandBase
    {
        public override bool CanExecute(object parameter) => true;

        public override void Execute(object parameter)
        {
            SettingWindow settingWindow = new SettingWindow();
            settingWindow.Show();
        }
    }
}
