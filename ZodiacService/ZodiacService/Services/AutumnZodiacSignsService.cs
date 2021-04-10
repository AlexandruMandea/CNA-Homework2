using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZodiacService.Protos;

namespace ZodiacService.Services
{
    public class AutumnZodiacSignsService : ZodiacSignTellerAutumn.ZodiacSignTellerAutumnBase
    {
        private readonly ILogger<AutumnZodiacSignsService> _logger;
        public AutumnZodiacSignsService(ILogger<AutumnZodiacSignsService> logger)
        {
            _logger = logger;
        }

        /*public override Task<ZodiacSignAutumn> SayZodiacSignAutumn(DateRequestAutumn request, ServerCallContext context)
        {
            return Task.FromResult(new ZodiacSignAutumn
            {

            });
        }*/
    }
}
