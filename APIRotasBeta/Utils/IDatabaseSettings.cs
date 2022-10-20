namespace APIRotasBeta.Utils
{
    public interface IDatabaseSettings
    {
        string CachorroCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
