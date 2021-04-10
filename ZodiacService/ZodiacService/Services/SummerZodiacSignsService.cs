using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZodiacService.Protos;

namespace ZodiacService.Services
{
    public class SummerZodiacSignsService : ZodiacSignTeller.ZodiacSignTellerBase
    {
        private readonly ILogger<SummerZodiacSignsService> _logger;
        public SummerZodiacSignsService(ILogger<SummerZodiacSignsService> logger)
        {
            _logger = logger;
        }

        /*public override Task<ZodiacSign> SayZodiacSign(DateRequest request, ServerCallContext context)
        {
            return Task.FromResult(new ZodiacSign
            {

            });
        }*/
    }
}
