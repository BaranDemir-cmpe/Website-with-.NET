using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebProgramming_Homework.Models
{
    public class Context:DbContext
    {
        public DbSet<Information> Informations { get; set; }
    }
}