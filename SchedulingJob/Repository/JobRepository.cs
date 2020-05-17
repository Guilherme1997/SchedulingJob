using System;
using System.Collections.Generic;

namespace SchedulingJob.Repository
{
    public class JobRepository : IJobRepository
    {
        public List<Job> Obter()
        {
            var PrimeiroJob = new Job { Id = 1, Descricao = "Importação de arquivos de fundos", DataConclusao = new DateTime(2019, 11, 10, 12, 00, 00), TempoEstimado = 2 };

            var SegundoJob = new Job { Id = 2, Descricao = "Importação de dados da Base Legada", DataConclusao = new DateTime(2019, 11, 11, 12, 00, 00), TempoEstimado = 4 };

            var TerceiroJob = new Job { Id = 3, Descricao = "Importação de dados de integração", DataConclusao = new DateTime(2019, 11, 11, 08, 00, 00), TempoEstimado = 6 };



            List<Job> jobs = new List<Job>();

            jobs.Add(PrimeiroJob);

            jobs.Add(SegundoJob);

            jobs.Add(TerceiroJob);


            return jobs;
        }
    }
}
