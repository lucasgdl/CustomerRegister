using Data.Configs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserForm.Entities;
using UserForm.ValueObjects;

namespace Data.Contexts
{
    public partial class QContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Address> Addresses { get; set; }

        public void CustomerConfigurations(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerConfig<Customer>());
            modelBuilder.ApplyConfiguration(new AddressConfig<Address>());
        }
    }
}
