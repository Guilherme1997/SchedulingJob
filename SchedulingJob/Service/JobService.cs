using SchedulingJob.Repository;
using System.Collections.Generic;
using System.Linq;

namespace SchedulingJob.Service
{
    class JobService : IJobService
    {
        public IEnumerable<Job> OrganizarJobs()
        {
            JobRepository jobRepository = new JobRepository();

            var jobs = jobRepository.Obter();

            var sequenciaJobsExecutados = jobs.Where(x => x.TempoEstimado <= (int)TempoExecucaoJobEnum.TempoMaximo
            && (x.DataConclusao >= x.InicioExecucaoJob && x.DataConclusao <= x.FimExecucaoJob)).OrderBy(x=>x.DataConclusao);

            return sequenciaJobsExecutados;
        }
    }
}
