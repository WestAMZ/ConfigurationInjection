namespace ConfigurationInjection.Examples
{
    public interface IService
    {
        CustomFields GetConfiguration();
    }
    //Interfaz vacia que unicamente hereda de IService para luego poder
    //inyectarlas implementando el método GetConfiguration
    public interface IService2 : IService { }

    public class CustomFields 
    {
        public string Value1 { get; set; }
        public string Value2 { get; set; }
    }
}
