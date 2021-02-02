
using System.Windows;
using Helper_postgreSQL.Infrastructure.Commands.Base;

namespace Helper_postgreSQL.Infrastructure.Commands
{
    internal class CloseApplicationCommand : CommandBase
    {
        public override bool CanExecute(object parameter) => true;

        public override void Execute(object parameter) => Application.Current.Shutdown();
    }
}
