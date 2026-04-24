using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersionRetriever.cli
{
    public class CliParameter
    {
        private IEnumerable<string> _switches;
        private bool _optional;
        private Type _parameterType;
        private object _parameterValue;
        private bool _multiple;
        private bool _single;

        public string Name { get; }
        public bool Parsed { get; private set; }
        public string ErrorMessage { get; private set; }

        /// <summary>
        /// Constructor for command line parameter.
        /// </summary>
        /// <param name="name">Name of the parameter.</param>
        /// <param name="switches">All the accepted switches, for example --help, -h.</param>
        /// <param name="optional">Is this parameter optional or not.</param>
        /// <param name="parameterType">The type of data the parameter contains.</param>
        /// <param name="multiple">Can this parameter have multiple values or not.</param>
        /// <param name="single">If true then this parameter does not have a value just works alone.</param>
        public CliParameter(string name, IEnumerable<string> switches, bool optional, Type parameterType, bool multiple, bool single = false)
        {
            // Check params.
            Name = name ?? throw new ArgumentNullException(nameof(name), "Parameter name cannot be null.");
            _switches = switches ?? throw new ArgumentNullException(nameof(switches), "Switches cannot be null.");
            _parameterType = parameterType ?? throw new ArgumentNullException(nameof(parameterType), "Parameter type cannot be null.");

            if (multiple && single)
            {
                throw new ArgumentException("CliParameter cannot be multiple value and single at the same time.");
            }

            _optional = optional;
            _multiple = multiple;
            _single = single;

            Parsed = false;
            ErrorMessage = string.Empty;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool ReadParameter(string[] args)
        {
            bool retVal = true;

            // Find the stuff.
            foreach(string swtch in _switches)
            {
                string arg = args.FirstOrDefault(x => x.StartsWith(swtch));
                if (arg != null)
                {
                    // If the parameter is single and matches completely to the argument.
                    if (_single && arg == swtch)
                    {
                        Parsed = true;
                        retVal = true;
                        break;
                    }
                    else if(_single) // Single but did not match completely.
                    {
                        continue;
                    }

                    string[] pieces = arg.Split('=');

                    // There should be two parts, the first should match the current switch and the actual parameter cannot be empty.
                    if (pieces.Length == 2 && pieces[0] == swtch && !string.IsNullOrWhiteSpace(pieces[1]))
                    {
                        // If this parameter can have multiple values in it.
                        if (_multiple)
                        {
                            string[] pcs = pieces[1].Split(',');
                            if (pcs.Length > 0)
                            {
                                IList<object> list = new List<object>();
                                try
                                {
                                    // Add pieces.
                                    foreach (string pc in pcs)
                                    {
                                        list.Add(Convert.ChangeType(pc, _parameterType));
                                    }
                                    
                                    _parameterValue = list;
                                }

                                // Use exception filters to catch possible exceptions.
                                catch (Exception ex) when (ex is InvalidCastException || ex is FormatException || ex is OverflowException || ex is ArgumentNullException)
                                {
                                    ErrorMessage = $"Could not parse parameter. Problems with type conversion.{Environment.NewLine}{ex.Message}{ex.InnerException?.Message}";
                                    return false;
                                }
                            }
                        }
                        else
                        {
                            // Try to convert.
                            try
                            {
                                _parameterValue = Convert.ChangeType(pieces[1], _parameterType);
                            }

                            // Use exception filters to catch possible exceptions.
                            catch (Exception ex) when (ex is InvalidCastException || ex is FormatException || ex is OverflowException || ex is ArgumentNullException)
                            {
                                ErrorMessage = $"Could not parse parameter. Problems with type conversion.{Environment.NewLine}{ex.Message}{ex.InnerException?.Message}";
                                return false;
                            }
                        }

                        Parsed = true;
                    }

                    // Found a match for the switch.
                    break;
                }
            }

            // If the parameter was mandatory and it is not properly parsed, then this is an error.
            if (!_optional && !Parsed)
            {
                ErrorMessage = $"Could not parse mandatory parameters.";
                return false;
            }

            return retVal;
        }

        /// <summary>
        /// Get parsed parameter value.
        /// </summary>
        /// <typeparam name="T">The type of the parameter.</typeparam>
        /// <returns>Parameter converted to given type.</returns>
        public T GetParameterValue<T>()
        {
            // Single value.
            if (!_multiple)
            {
                if (typeof(T) == _parameterType)
                {
                    return (T)_parameterValue;
                }
                else
                {
                    throw new InvalidOperationException("Parameter type and wanted type does not match.");
                }
            }
            else
            {
                throw new InvalidOperationException("Multiple parameter values should be retrieved with GetMultipleParameterValue-function.");
            }
        }

        /// <summary>
        /// Get parsed parameter values.
        /// </summary>
        /// <typeparam name="T">Return type.</typeparam>
        /// <typeparam name="U">Type of the items.</typeparam>
        /// <returns></returns>
        public T GetMultipleParameterValue<T, U>()
        {
            if (_multiple)
            {
                List<U> juu = new List<U>();
                foreach (object val in (IEnumerable<object>)_parameterValue)
                {
                    juu.Add((U)val);
                }

                return (T)juu.AsEnumerable();
            }
            else
            {
                throw new InvalidOperationException("Single parameter value should be retrieved with GetParameterValue-function.");
            }
        }
    }
}
