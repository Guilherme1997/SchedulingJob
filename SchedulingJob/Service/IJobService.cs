using System;
using System.Collections.Generic;
using System.Text;

namespace SchedulingJob.Service
{
    interface IJobService
    {
        IEnumerable<Job> OrganizarJobs();
    }
}
