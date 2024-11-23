using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Todoo.Core
{
    public class WorksTasksPagesViewModel : Observable
    {
        public ObservableCollection<WorkTasksControlsViewModel> WorkTaskList { get; set; } = new ObservableCollection<WorkTasksControlsViewModel>();
        
        public string NewTitle {  get; set; }
        public string NewDescription { get; set; }

        public string NewHello { get; set; }

        public ICommand AddNewTask {  get; set; }
        public ICommand DeleteNewTask {  get; set; }
        
        public WorksTasksPagesViewModel()
        {
            AddNewTask = new RelayCommand(NewTask);
            DeleteNewTask = new RelayCommand(DeleteTask);
        }

        public void NewTask()
        {
            var newTask = new WorkTasksControlsViewModel()
            {
                Title = NewTitle,
                Description = NewDescription,
                CurrentDate = DateTime.Now,
            };
            WorkTaskList.Add(newTask);

            OnPropertyChanged(nameof(NewTitle));
            OnPropertyChanged(nameof(NewDescription));
        }

        public void DeleteTask()
        {
            var select = WorkTaskList.Where(x => x.IsSelected).ToList();

            foreach(var task in select)
            {
                WorkTaskList.Remove(task);
            }
        }
    }
}
