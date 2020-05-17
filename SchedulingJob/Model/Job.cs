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
    }
}
