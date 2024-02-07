using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Models
{
    public partial class User
    {
        public ObjectId _id { get; set; }
        public string? Login { get; set; }
        public string? Password { get; set; }
        [BsonIgnoreIfDefault]
        public Unit Unit { get; set; }
    }
}
