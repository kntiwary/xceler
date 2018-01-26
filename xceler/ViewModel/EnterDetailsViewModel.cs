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
        private int countrySelectedIndex;
        public string SelectedCountryName { get; set; }
        public Country selectedCountry { get; set; }


        public EnterDetailsViewModel()
        {
            InitializeDataAsynch().ConfigureAwait(true);
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
                //getStatesAsync(selectedCountry).ConfigureAwait(true);
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
