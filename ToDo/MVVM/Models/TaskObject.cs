using Newtonsoft.Json;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Media;

namespace ToDo.MVVM.Models
{
    public class TaskObject : INotifyPropertyChanged
    {
        private DateTime startTime = DateTime.Now.Date + new TimeSpan(0, 0, 0);
        private DateTime endTime = DateTime.Now.Date + new TimeSpan(0, 0, 0);

        private string name;
        private SolidColorBrush colorTag;

        public DateTime StartDate 
        {
            get => startTime;
            set
            {
                if (startTime != value)
                {
                    startTime = value;
                    //OnPropertyChanged();
                }
            }
        }
        public DateTime EndDate 
        {
            get => endTime;
            set
            {
                if (endTime != value)
                {
                    endTime = value;
                    //OnPropertyChanged();
                }
            }
        }
        public string Name
        {
            get => name;
            set
            {
                if (name != value)
                {
                    name = value;
                    //OnPropertyChanged();
                }
            }

        }
        public SolidColorBrush ColorTag
        {
            get => colorTag;
            set
            {
                if (colorTag != value)
                {
                    colorTag = value;
                    //OnPropertyChanged();
                }
            }
        }

        public TaskObject(string name, SolidColorBrush colorTag)
        {
            Name = name;
            ColorTag = colorTag;
        }

        [JsonConstructor]
        public TaskObject(string name, SolidColorBrush colorTag, DateTime startDate, DateTime endDate)
        {
            Name = name;
            ColorTag = colorTag;
            StartDate = startDate;
            EndDate = endDate;
        }

        public void UpdateProperties()
        {
            OnPropertyChanged("StartDate");
            OnPropertyChanged("EndDate");
            OnPropertyChanged("Name");
            OnPropertyChanged("ColorTag");
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
