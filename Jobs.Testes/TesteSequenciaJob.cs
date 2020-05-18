using System;
using System.Collections.Generic;
using Xunit;
using SchedulingJob.Service;
using System.Linq;

namespace Jobs.Testes
{
    public class TesteSquenciaJob
    {
        [Fact]
        public void TesteSequenciarJobs()
        {
            var idJob = JobService.OrganizarJobs().Select(x => x.Id);

            Assert.Equal(idJob, new List<int> { 1, 3, 2 });
        }
    }
}
