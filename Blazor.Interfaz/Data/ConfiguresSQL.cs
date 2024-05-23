namespace Blazor.Interfaz.Data
{
    public class ConfiguresSQL
    {
        public ConfiguresSQL(string connectionString) => ConnectionString = connectionString;

        public string ConnectionString { get; }
    }
}
