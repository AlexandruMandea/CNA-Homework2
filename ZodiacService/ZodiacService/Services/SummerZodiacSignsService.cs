using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZodiacService.Protos;

namespace ZodiacService.Services
{
    public class SummerZodiacSignsService : ZodiacSignTellerSummer.ZodiacSignTellerSummerBase
    {
        private readonly ILogger<SummerZodiacSignsService> _logger;
        public SummerZodiacSignsService(ILogger<SummerZodiacSignsService> logger)
        {
            _logger = logger;
        }

        /*public override Task<ZodiacSignSummer> SayZodiacSignSummer(DateRequestSummer request, ServerCallContext context)
        {
            return Task.FromResult(new ZodiacSignSummer
            {

            });
        }*/
    }
}
