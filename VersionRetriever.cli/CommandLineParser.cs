using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersionRetriever.cli
{
    public class CommandLineParser
    {
        private IDictionary<string, CliParameter> _parameters;
        public string ErrorMessage { get; private set; }

        public CommandLineParser()
        {
            _parameters = new Dictionary<string, CliParameter>();

            ErrorMessage = string.Empty;
        }

        /// <summary>
        /// Add new command line parameter to parser.
        /// </summary>
        /// <param name="parameter"></param>
        public void AddParameter(CliParameter parameter)
        {
            if (!_parameters.ContainsKey(parameter.Name))
            {
                _parameters.Add(parameter.Name, parameter);
            }
        }

        public bool ParseCommandLine(string[] args)
        {
            foreach(CliParameter param in _parameters.Values)
            {
                // No parsed -> parse.
                if (!param.Parsed)
                {
                    // If returns false, then there were errors (probably mandatory parameter but something funky with it).
                    if (!param.ReadParameter(args))
                    {
                        ErrorMessage = param.ErrorMessage;
                        return false;
                    }
                }
                else // Already parse, maybe we should write an error?
                {

                }
            }

            return true;
        }

        public CliParameter GetParameter(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name), "Parameter name cannot be null.");
            }

            _parameters.TryGetValue(name, out CliParameter param);
            return param;
        }
    }
}
