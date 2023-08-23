using Microsoft.Extensions.Options;

namespace ConfigurationInjection.Examples
{
    public class ByIOptions : IService2
    {
        readonly CustomFields customFields;
        public ByIOptions(IOptions<CustomFields> options)
        {
            this.customFields = options.Value;
        }
        public CustomFields GetConfiguration()
        {
            return customFields;
        }
    }
}
