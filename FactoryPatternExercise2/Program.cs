using FactoryPatternExercise2;

var databaseType = DataAccessFactory.GetDataAccessType("SQLDataAccess");

databaseType.SaveData();
var products = databaseType.LoadData();

foreach (var item in products)
{
    Console.WriteLine(item.Name);
    Console.WriteLine(item.Price);
    Console.WriteLine();
}
