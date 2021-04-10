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
    public class SpringZodiacSignsService : ZodiacSignTellerSpring.ZodiacSignTellerSpringBase
    {
        private readonly ILogger<SpringZodiacSignsService> _logger;
        public SpringZodiacSignsService(ILogger<SpringZodiacSignsService> logger)
        {
            _logger = logger;
        }

        public override Task<ZodiacSignSpring> SayZodiacSign(DateRequestSpring request, ServerCallContext context)
        {
            return Task.FromResult(new ZodiacSignSpring
            {
                ZodiacSign = Utility.GetZodiacSign(request.Date, @"D:\Proiecte\cloud\cna_hmk2\ZodiacService\ZodiacService\Resources\time_intervals_spring.xml")
            });
        }
    }
}
