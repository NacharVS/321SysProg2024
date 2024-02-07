using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Models
{
    public class DBConnection
    {
        public static string connectionString = "mongodb://localhost";

        private static IMongoDatabase ConnectToDatabase(string databaseName)
        {
            var client = new MongoClient(connectionString);
            return client.GetDatabase(databaseName);
        }
        public static void Post<T>(string databaseName, string collectionName, T record)
        {
            var database = DBConnection.ConnectToDatabase(databaseName);
            var collection = database.GetCollection<T>(collectionName);
            collection.InsertOne(record);
        }
        public static List<T> Get<T>(string databaseName, string collectionName)
        {
            var database = DBConnection.ConnectToDatabase(databaseName);
            var collection = database.GetCollection<T>(collectionName);
            var filter = Builders<T>.Filter.Empty;
            var result = collection.Find(filter).ToList();

            return result;
        }
        public static void Put<T>(string databaseName, string collectionName, ObjectId id, T record)
        {
            var database = DBConnection.ConnectToDatabase(databaseName);
            var collection = database.GetCollection<T>(collectionName);
            var filter = Builders<T>.Filter.Eq("_id", id);
            var result = collection.ReplaceOne(filter, record);
        }
        public static void Delete<T>(string databaseName, string collectionName, string id)
        {
            var database = DBConnection.ConnectToDatabase(databaseName);
            var collection = database.GetCollection<T>(collectionName);

            var filter = Builders<T>.Filter.Eq("_id", id);
            collection.DeleteOne(filter);
        }
    }
}
