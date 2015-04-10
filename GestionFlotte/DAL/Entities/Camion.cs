using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    [BsonIgnoreExtraElements]
    public class Camion : MongoEntity
    {
        [BsonElement("immatriculation")]
        public string Immatriculation { get; set; }

        [BsonElement("etat")]
        public string Etat { get; set; }

        public void test()
        {
            
        }
    }
}
