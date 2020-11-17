using System;
using System.Collections.Generic;
using WorkForce.Models;

namespace WorkForce.Collections
{
    public class JobList : List<Job>
    {
        public new void Add(Job item)
        {
            item.Completed += RemoveCompletedJob;
            UpdateRequired += item.Update;
            base.Add(item);
        }

        private void RemoveCompletedJob(object sender, EventArgs e)
        {
            if (sender is Job job)
            {
                job.Completed -= RemoveCompletedJob;
                UpdateRequired -= job.Update;
                Remove(job);
            }
        }

        private event Action UpdateRequired;

        public void RequireUpdate() => UpdateRequired?.Invoke();
    }
}
