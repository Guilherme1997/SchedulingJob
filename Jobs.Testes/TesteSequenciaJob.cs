using System;
using System.Collections.Generic;
using Xunit;
using SchedulingJob.Service;
using System.Linq;
using FluentAssertions;

namespace Jobs.Testes
{
    public class TesteSquenciaJob
    {
        [Fact]
        public void TesteSequenciarJobs()
        {
            var idJob = JobService.OrganizarJobs().Select(x => x.Id);

            idJob.Should().Equal(TesteSquenciaJob.ObterJobsEsperados(), $"A ordem dos Jobs não correspondem com o esperado");
        }

        public static List<int> ObterJobsEsperados()
        {
            return new List<int> { 1, 2, 2 };
        }
    }
}
