using MongoDB.Driver;
using MongoDBDemo;

string connectionString = "mongodb://localhost:27017";
string databaseName = "my_base_date";
string collectionName = "My_date";

var client = new MongoClient(connectionString);//зєднання з монгодб
var db = client.GetDatabase(databaseName);//з якою бд ми хочемо спілкуватися
var collection = db.GetCollection<PersonModel>(collectionName);//з якою колекцією ми хочемо спілкуватися

var person = new PersonModel { FirstName = "Oleh", LastName = "Menjok" };

await collection.InsertOneAsync(person);
var results = await collection.FindAsync(_ => true);

foreach (var result in results.ToList())
{
    Console.WriteLine(value:$"{result.Id}: {result.FirstName} {result.LastName}"); ;
}


