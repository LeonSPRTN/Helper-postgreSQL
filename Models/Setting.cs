using System.ComponentModel;

namespace Helper_postgreSQL.Models
{
    public class Setting : INotifyPropertyChanged
    {
        public int Id { get; set; }

        private string path_bin;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Path_bin
        {
            get { return path_bin; }
            set { path_bin = value; }
        }
    }
}
