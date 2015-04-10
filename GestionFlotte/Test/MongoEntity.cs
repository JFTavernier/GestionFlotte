using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Test
{
    public class MongoEntity
    {
        [BsonId]
        public ObjectId Id { get; set; }
    }
}
