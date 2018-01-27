using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using xceler.Model;

namespace xceler.ViewModel
{
    public class ViewLocalDetailVeiwModel : INotifyPropertyChanged
    {
        
        public ViewLocalDetailVeiwModel()
        {
            InitializeDataAsynch().ConfigureAwait(true);
        }

        private async Task InitializeDataAsynch()
        {
            var list = await App.database.GetUserDetailsAsync();
            UserList = new ObservableCollection<User>(list);
        }
        ObservableCollection<User> userList;

        public ObservableCollection<User> UserList
        {
            get
            {
                return userList;
            }

            set
            {
                userList = value;
                OnPropertyChanged("UserList");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            var changed = PropertyChanged;
            if (changed != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
