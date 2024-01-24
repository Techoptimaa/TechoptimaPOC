using Microsoft.Extensions.Configuration;

namespace EmailOrSMSLib
{
    public class ConfigurationHelper
    {
        private static IConfiguration? _config;
        public static void Initialize(IConfiguration configuration)
        {
            _config = configuration;
        }
    }
}
