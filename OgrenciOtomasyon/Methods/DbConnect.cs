using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class DbConnect:DbContext
    {

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
    }
    public DbConnect() : base("Data Source=.;Initial Catalog = MIMCE; Persist Security Info=True;User ID=sa ;Password=1234") { }

    public DbSet<Ogrenciler> Ogrencilers { get; set; }
    public DbSet<Okullar> Okullars { get; set; }
    public DbSet<Bolumler> Bolumlers { get; set; }
    public DbSet<Egitimler> Egitimlers { get; set; }





}

