using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;

namespace ConfigurationHost
{
    public class Service
    {
        private readonly Features _personalize;
        private readonly Features _weatherStation;
        public Service(IOptionsSnapshot<Features> options)
        {
            _personalize = options.Get("A");
            _weatherStation = options.Get("B");
        }
    }
}
