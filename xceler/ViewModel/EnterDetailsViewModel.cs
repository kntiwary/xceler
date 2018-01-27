using System;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using xceler.Model;
using Newtonsoft.Json;

namespace xceler.ViewModel
{
    public class EnterDetailsViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Country> countryContent;
        private int countrySelectedIndex = 5;
        public string SelectedCountryName { get; set; }
        public Country selectedCountry { get; set; }
        int dateSelectedIndex;
        public DateTime CurrentDate = System.DateTime.Now;
        public ICommand Submit { get; set; }
        bool isMale = false;

       

        User userDetails;

       

        public EnterDetailsViewModel()
        {
            UserDetails = new User();
            //Submit = new Command<object>(OnTappedUser);
            Submit = new Command<object>(async (obj) => await OnTappedUser(obj));
            InitializeDataAsynch().ConfigureAwait(true);


        }

        public async Task<User> OnTappedUser(object obj)
        {
           // await App.database.InsertUserDetails(UserDetails);
            UserDetails.Sex = (IsMale) ? "Female" : "Male";//If True it's female
            return UserDetails;
        }

        //private void OnTappedUser(object obj)
        //{

        //}

        internal void UpdateDob(DateTime date)
        {
            UserDetails.Dob = date;
        }

        private async Task InitializeDataAsynch()
        {
            var item = await App.webDataMngr.GetTasksLive("Countries", "");
            Countries = new List<Country>();
            Countries = JsonConvert.DeserializeObject<List<Country>>(item);
            CountryContent = new ObservableCollection<Country>(Countries);
        }
        public List<Country> Countries { get; set; }
        public ObservableCollection<Country> CountryContent
        {
            get { return countryContent; }
            set
            {
                if (countryContent != value)
                {
                    countryContent = value;
                    OnPropertyChanged("CountryContent");
                }
            }
        }
        public int CountrySelectedIndex
        {
            get
            {
                return countrySelectedIndex;
            }

            set
            {
                countrySelectedIndex = value;
                OnPropertyChanged("CountrySelectedIndex");
                selectedCountry = CountryContent[countrySelectedIndex];
                SelectedCountryName = selectedCountry.Name;
                UserDetails.Country = SelectedCountryName;
                //getStatesAsync(selectedCountry).ConfigureAwait(true);
            }
        }

        public bool IsMale
        {
            get
            {
                return isMale;
            }

            set
            {
                isMale = value;
                OnPropertyChanged("IsMale");
                UserDetails.Sex = (IsMale) ? "Female" : "Male";//If True it's female
            }
        }

        public int DateSelectedIndex
        {
            get
            {
                return dateSelectedIndex;
            }

            set
            {
                dateSelectedIndex = value;
                OnPropertyChanged("DateSelectedIndex");
            }
        }

        public User UserDetails
        {
            get
            {
                return userDetails;
            }

            set
            {
                userDetails = value;
                OnPropertyChanged("UserDetails");
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
