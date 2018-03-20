using SportsBetting.DbModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SportsBetting.Data
{
    public class SportsBettingContext : DbContext
    {
        public SportsBettingContext() : base("SportsBettingDb")
        {
        }

        public virtual IDbSet<Event> Events { get; set; }
    }
}