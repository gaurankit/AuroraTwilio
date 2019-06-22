using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderPoolManager.Utilities
{
    public class LogRunner
    {
        private readonly ILogger<LogRunner> _logger;

        public LogRunner(ILogger<LogRunner> logger)
        {
            _logger = logger;
        }

        public void DoAction(string name)
        {
            _logger.LogTrace("{Action}", name);
        }
    }
}