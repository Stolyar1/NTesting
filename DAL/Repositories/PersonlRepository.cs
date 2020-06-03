using DAL.Abstract;
using DAL.Context.dbContext;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories
{
    public class PersonlRepository : Repository<Personal, u0554110_rhiContext>
    {
        public PersonlRepository(u0554110_rhiContext context) : base(context)
        {

        }
        // We can add new methods specific to the movie repository here in the future
    }
}
