namespace APIRotasBeta.Utils
{
    public class DatabaseSettings : IDatabaseSettings
    {
        public string CachorroCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
