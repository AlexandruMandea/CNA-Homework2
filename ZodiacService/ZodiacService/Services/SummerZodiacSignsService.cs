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
    public class SummerZodiacSignsService : ZodiacSignTellerSummer.ZodiacSignTellerSummerBase
    {
        private readonly ILogger<SummerZodiacSignsService> _logger;
        public SummerZodiacSignsService(ILogger<SummerZodiacSignsService> logger)
        {
            _logger = logger;
        }

        public override Task<ZodiacSignSummer> SayZodiacSign(DateRequestSummer request, ServerCallContext context)
        {
            return Task.FromResult(new ZodiacSignSummer
            {
                ZodiacSign = Utility.GetZodiacSign(request.Date, @"D:\Proiecte\cloud\cna_hmk2\ZodiacService\ZodiacService\Resources\time_intervals_summer.xml")
            });
        }
    }
}
