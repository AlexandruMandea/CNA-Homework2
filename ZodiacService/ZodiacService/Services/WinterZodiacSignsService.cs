using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZodiacService.Protos;

namespace ZodiacService.Services
{
    public class WinterZodiacSignsService : ZodiacSignTellerWinter.ZodiacSignTellerWinterBase
    {
        private readonly ILogger<WinterZodiacSignsService> _logger;
        public WinterZodiacSignsService(ILogger<WinterZodiacSignsService> logger)
        {
            _logger = logger;
        }

        /*public override Task<ZodiacSignWinter> SayZodiacSignWinter(DateRequestWinter request, ServerCallContext context)
        {
            return Task.FromResult(new ZodiacSignWinter
            {

            });
        }*/
    }
}
