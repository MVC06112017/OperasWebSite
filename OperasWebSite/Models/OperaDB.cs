﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OperasWebSite.Models
{
    public class OperaDB : DbContext
    {
        public DbSet<Opera> Operas { get; set; }
    }
}