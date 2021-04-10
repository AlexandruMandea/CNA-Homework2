using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZodiacService.Protos;
using ZodiacService.Utilities;

namespace ZodiacService.Services
{
    public class AutumnZodiacSignsService : ZodiacSignTellerAutumn.ZodiacSignTellerAutumnBase
    {
        private readonly ILogger<AutumnZodiacSignsService> _logger;
        public AutumnZodiacSignsService(ILogger<AutumnZodiacSignsService> logger)
        {
            _logger = logger;
        }

        public override Task<ZodiacSignAutumn> SayZodiacSign(DateRequestAutumn request, ServerCallContext context)
        {
            return Task.FromResult(new ZodiacSignAutumn
            {
                ZodiacSign = Utility.GetZodiacSign(request.Date, @"D:\Proiecte\cloud\cna_hmk2\ZodiacService\ZodiacService\Resources\time_intervals.xml")
            });
        }
    }
}
