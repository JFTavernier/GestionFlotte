using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Camion : MongoEntity
    {
        [BsonElement("immatriculation")]
        public string Immatriculation { get; set; }

        [BsonElement("etat")]
        [BsonDefaultValue("ok")]
        public string Etat { get; set; }
    }
}
