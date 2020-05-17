using System;
using System.Collections.Generic;
using System.Text;

namespace SchedulingJob
{
    public class Job
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        public DateTime DataConclusao { get; set; }

        public int TempoEstimado { get; set; }

        public DateTime InicioExecucaoJob { get; set; } = new DateTime(2019, 11, 10, 09, 00, 00);

        public DateTime FimExecucaoJob { get; set; } = new DateTime(2019, 11, 11, 12, 00, 00);

    }
}
