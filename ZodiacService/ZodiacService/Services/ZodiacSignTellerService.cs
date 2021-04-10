using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZodiacService.Protos;

namespace ZodiacService.Services
{
    public class ZodiacSignTellerService : ZodiacSignTeller.ZodiacSignTellerBase
    {
        private readonly ILogger<ZodiacSignTellerService> _logger;
        public ZodiacSignTellerService(ILogger<ZodiacSignTellerService> logger)
        {
            _logger = logger;
        }

        public override Task<ZodiacSign> SayZodiacSign(DateRequest request, ServerCallContext context)
        {
            return Task.FromResult(new ZodiacSign
            {
                
            });
        }
    }
}
