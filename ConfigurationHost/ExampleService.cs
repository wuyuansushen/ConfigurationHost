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
        public bool ranBool { get; set; }

        public ExampleService()
        { 
            Random i = new();
            var num = i.Next(1, 3);
            if (num < 2)
                ranBool = true;
            else
                ranBool = false;
        }

        #region nonNamed
        /*private readonly TransientFaultHandlingOptions _transientFaultHandlingOptions;

        public ExampleService(IOptionsMonitor<TransientFaultHandlingOptions> options)
            {
            _transientFaultHandlingOptions = options.CurrentValue;
        }

        public void DisplayValues()
        {
            Console.WriteLine(_transientFaultHandlingOptions.Enabled);
            Console.WriteLine(_transientFaultHandlingOptions.AutoRetryDelay);
        }*/
        #endregion

    }
}
