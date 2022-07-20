using FactoryPatternExercise2;

var databaseType = DataAccessFactory.GetDataAccessType("SQLDataAccess");

databaseType.SaveData();
databaseType.LoadData();
