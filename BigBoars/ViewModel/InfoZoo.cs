using BigBoars.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBoars.ViewModel
{
    public class InfoZoo : BaseViewModel
    {
        ObservableCollection<Boars> _boars = new ObservableCollection<Boars>();

        public InfoZoo()
        {
            UpdateList();
        }


        public ObservableCollection<Boars> ZooList
        {
            get => _boars;
            set
            {
                _boars = value;
                OnPropertyChanged(nameof(Boars));
            }
        }

        public void UpdateList()
        {
            using (BigBoarsBDEntities db = new BigBoarsBDEntities())
            {
                ZooList.Clear();
                foreach (var item in db.Boars)
                {
                    ZooList.Add(item);
                }
            }
        }

        public RelayCommand Update
        {
            get
            {
                using (BigBoarsBDEntities db = new BigBoarsBDEntities())
                {

                    return new RelayCommand(obj =>
                    {
                        UpdateList();
                    }
                );
                }
            }
        }
    }
}
