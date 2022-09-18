using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Business
{
    public class B_InputOutput
    {
        public List<InputOutputEntity>InputOutputsList()
        {
            using (var db = new InventaryContext())
            {
                return db.InOuts.ToList();
            }
        }

        public void CreateInputOutput(InputOutputEntity inputOutput)
        {
            using(var db = new InventaryContext())
            {
                db.InOuts.Add(inputOutput);
                db.SaveChanges();
            }
        }

        public void UpdateInputOutput(InputOutputEntity inputOutput)
        {
            using( var db = new InventaryContext())
            {
                db.InOuts.Update(inputOutput);
                db.SaveChanges();
            }
        }

        public void RemoveInputOutput(InputOutputEntity inputOutput)
        {
            using(var db = new InventaryContext())
            {
                db.InOuts.Remove(inputOutput);
            }
        }

    }
}
