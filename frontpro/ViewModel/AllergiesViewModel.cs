using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace frontpro.Pages
{
    public class AllergyType : INotifyPropertyChanged
    {
        private bool _isSelected;

        public string Name { get; set; }

        public bool IsSelected
        {
            get => _isSelected;
            set
            {
                _isSelected = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class AllergiesViewModel : INotifyPropertyChanged
    {
        private bool _isNotSensitive;
        private string _otherAllergy;

        public ObservableCollection<AllergyType> AllergyTypes { get; set; }

        public bool IsNotSensitive
        {
            get => _isNotSensitive;
            set
            {
                _isNotSensitive = value;
                OnPropertyChanged();
            }
        }

        public string OtherAllergy
        {
            get => _otherAllergy;
            set
            {
                _otherAllergy = value;
                OnPropertyChanged();
            }
        }

        public ICommand SubmitCommand { get; }

        public AllergiesViewModel()
        {
            AllergyTypes = new ObservableCollection<AllergyType>
            {
                new AllergyType { Name = "Celery" },
                new AllergyType { Name = "Crustaceans" },
                new AllergyType { Name = "Fish" },
                new AllergyType { Name = "Milk" },
                new AllergyType { Name = "Mustard" },
                new AllergyType { Name = "Peanuts" },
                new AllergyType { Name = "Soya" },
                new AllergyType { Name = "Cereals (containing gluten)" },
                new AllergyType { Name = "Eggs" },
                new AllergyType { Name = "Lupin" },
                new AllergyType { Name = "Molluscs" },
                new AllergyType { Name = "Nuts" },
                new AllergyType { Name = "Sesame seeds" },
                new AllergyType { Name = "Sulphur dioxide (sulphites)" }
            };

            SubmitCommand = new Command(OnSubmit);
        }

        private void OnSubmit()
        {
            // Handle the submit action
            // Collect selected allergies, is not sensitive, and other allergy input
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
