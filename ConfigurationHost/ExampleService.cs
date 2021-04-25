using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;

namespace ConfigurationHost
{
    public class ExampleService
    {
        private readonly TransientFaultHandlingOptions _transientFaultHandlingOptions;

        public ExampleService(IOptionsSnapshot<TransientFaultHandlingOptions> options)
            {
            _transientFaultHandlingOptions = options.Value;
        }

        public void DisplayValues()
        {
            Console.WriteLine(_transientFaultHandlingOptions.Enabled);
            Console.WriteLine(_transientFaultHandlingOptions.AutoRetryDelay);
        }

    }
}
