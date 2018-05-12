using BindingDemo.Observable;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace BindingDemo.Models
{
    class FormModel : ObservableObject
    {

        public FormModel()
        {
            CurrentPerson = new PersonModel();
            People = new ObservableCollection<PersonModel>();
            AddCommand = new Command(ExecuteAddCommand);
        }

        public ICommand AddCommand { get; set; }

        private PersonModel _currentPerson;

        public PersonModel CurrentPerson
        {
            get { return _currentPerson; }
            set
            {
                _currentPerson = value;
                NotifyPropertyChanged(nameof(CurrentPerson));
            }
        }

        public ObservableCollection<PersonModel> People { get; set; }

        private void ExecuteAddCommand(object obj)
        {
            People.Add(CurrentPerson);
            CurrentPerson = new PersonModel();
        }
    }

}
