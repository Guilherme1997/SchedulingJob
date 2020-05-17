using SchedulingJob.Service;
using System;

namespace SchedulingJob
{
    class Program
    {
        static void Main(string[] args)
        {
            JobService jobs = new JobService();

            foreach (var job in jobs.OrganizarJobs())
            {
                Console.WriteLine(job.Id);
            }

            Console.ReadLine();
        }
    }
}
