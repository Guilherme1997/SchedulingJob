using SchedulingJob.Service;
using System;

namespace SchedulingJobApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            foreach (var job in JobService.OrganizarJobs())
            {
                Console.WriteLine(job.Id);
            }

            Console.ReadLine();
        }
    }
}
