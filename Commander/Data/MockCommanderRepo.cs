using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var Commands = new List<Command>
            {
            new Command { Id = 0, HowTo = "Boil an egg", Line = "Boil Water", Platform = "Kettle & Pan" },
            new Command { Id = 1, HowTo = "Cut Bread", Line = "Get a knife", Platform = "Kettle & Choppingboard" },
            new Command { Id = 2, HowTo = "Make cup of tea", Line = "Place  Tea in a bag", Platform = "Cup & Saucer" }
           };
            
        return Commands;
        }


        public Command GetCommandByID(int id)
        {
            return new Command { Id = 0, HowTo = "Boil an egg", Line = "Boil Water", Platform = "Kettle & Pan" };
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
