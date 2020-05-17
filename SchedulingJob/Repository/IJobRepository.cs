using System;
using System.Collections.Generic;
using System.Text;

namespace SchedulingJob.Repository
{
    interface IJobRepository
    {
       public List<Job> Obter();
    }
}
