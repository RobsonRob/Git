using System;

namespace Todoo.Core
{
    public class WorkTasksControlsViewModel : Observable
    {
        public bool IsSelected { get; set; }
        public string Title {  get; set; }
        public string Description { get; set; }
        public DateTime CurrentDate { get; set; }

    }
}
