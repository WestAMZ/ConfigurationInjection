namespace ConfigurationInjection.Examples
{
    public class ByIConfiguration: IService
    {
        private readonly IConfiguration configuration;
        public ByIConfiguration(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public CustomFields GetConfiguration() 
        {
            return new CustomFields
            {
                Value1 = configuration.GetSection("CustomFields")["Value1"],
                Value2 = configuration["CustomFields:Value1"]
            };
        }
    }
}
