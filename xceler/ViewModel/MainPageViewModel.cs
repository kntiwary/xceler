using System;
using System.ComponentModel;
using System.Threading.Tasks;
using xceler.Model;

namespace xceler.ViewModel
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        User user;

        public User User
        {
            get
            {
                return user;
            }

            set
            {
                user = value;
                OnPropertyChanged("User");
            }
        }

        public MainPageViewModel(User user)
        {
            User = new User();
            User = user;
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

        internal async Task SaveUser(User userdetail)
        {
            await App.database.InsertUserDetails(userdetail);
        }
    }
}
