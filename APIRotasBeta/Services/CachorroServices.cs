using APIRotasBeta.Models;
using APIRotasBeta.Utils;
using MongoDB.Driver;
using System.Collections.Generic;

namespace APIRotasBeta.Services
{
    public class CachorroServices
    {
        private readonly IMongoCollection<Cachorro> _cachorros;

        public CachorroServices(IDatabaseSettings settings)
        {
            var cachorro = new MongoClient(settings.ConnectionString);
            var database = cachorro.GetDatabase(settings.DatabaseName);
            _cachorros = database.GetCollection<Cachorro>(settings.CachorroCollectionName);
        }

        public Cachorro Create(Cachorro cachorro)
        {
            _cachorros.InsertOne(cachorro);
            return cachorro;
        }

        public List<Cachorro> Get() => _cachorros.Find<Cachorro>(cachorro => true).ToList();

        public Cachorro Get(string nome) => _cachorros.Find<Cachorro>(cachorro => cachorro.Nome == nome).FirstOrDefault();

        public void Update(string nome, Cachorro cachorroIn)
        {
            _cachorros.ReplaceOne(cachorro => cachorro.Nome == nome, cachorroIn);
        }

        public void Remove(Cachorro cachorroIn) => _cachorros.DeleteOne(cachorro => cachorro.Nome == cachorroIn.Nome);
    }
}
