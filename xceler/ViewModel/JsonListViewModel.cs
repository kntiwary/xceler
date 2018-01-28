using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using Newtonsoft.Json;
using xceler.Model;

namespace xceler.ViewModel
{
    public class JsonListViewModel : INotifyPropertyChanged
    {
        public JsonListViewModel()
        {
            InitializeDataAsynch().ConfigureAwait(true);
        }

        private async Task InitializeDataAsynch()
        { 
            var item = await App.webDataMngr.GetTasksLive("GPs", "");
            GPs = new List<GP>();
            GPs = JsonConvert.DeserializeObject<List<GP>>(item);
            GPUiList = new ObservableCollection<GP>(GPs);
        }
        ObservableCollection<GP> gPUiList;

        public ObservableCollection<GP> GPUiList
        {
            get
            {
                return gPUiList;
            }

            set
            {
                gPUiList = value;
                OnPropertyChanged("GPUiList");
            }
        }

        public List<GP> GPs { get; set; }
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
