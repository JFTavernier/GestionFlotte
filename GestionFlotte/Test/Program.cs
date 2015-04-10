using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using MongoDB;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using MongoDB.Bson;


namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {


            GetListCamion().RunSynchronously();

           

            var test = 1;
        }

        static async Task<List<Camion>> GetListCamion()
        {
            IMongoClient client = new MongoClient();
            IMongoDatabase db = client.GetDatabase("local");
            IMongoCollection<Camion> camions = db.GetCollection<Camion>("Camions");

            Console.WriteLine("Liste des camions présent dans la collection ...");
            var listCamion = await db.GetCollection<Camion>("camions")
                .Find(x => x.Immatriculation != "")
                .SortBy(c => c.Immatriculation)
                .ToListAsync();

            foreach (Camion camion in listCamion)
            {
                Console.WriteLine(camion.Immatriculation);
            }

            return listCamion;
        }

       
    }
}
