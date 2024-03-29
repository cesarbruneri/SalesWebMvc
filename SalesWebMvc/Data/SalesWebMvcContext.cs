﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Models;

namespace SalesWebMvc.Models
{
    public class SalesWebMvcContext : DbContext
    {
        public SalesWebMvcContext (DbContextOptions<SalesWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<DepartmentModel> Department { get; set; }
        public DbSet<SellerModel> Seller { get; set; }
        public DbSet<SalesRecordModel> SalesRecord { get; set; }
    }
}
