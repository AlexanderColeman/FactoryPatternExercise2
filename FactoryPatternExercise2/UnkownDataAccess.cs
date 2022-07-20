using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class UnkownDataAccess : IDataAccess
    {
        public void LoadData()
        {
            Console.WriteLine("I am reading data from UnkownDataAccess database"); 
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data from UnkownDataAccess database");
        }
    }
}
