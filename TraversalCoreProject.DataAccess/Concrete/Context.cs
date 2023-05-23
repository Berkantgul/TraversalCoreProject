using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalCoreProject.Entity.Concrete;

namespace TraversalCoreProject.DataAccess.Concrete
{
	public class Context : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=LAPTOP-UROTH5AA;initial catalog=TraversalCoreDb;integrated Security=true");
		}

		public DbSet<Contact> Contacts { get; set; }
		public DbSet<Destination> Destinations { get; set; }
		public DbSet<FirstAbout> FirstAbouts { get; set; }
		public DbSet<FirstFeature> FirstFeatures { get; set; }
		public DbSet<Guide> Guides { get; set; }
		public DbSet<Newsletter> Newsletters { get; set; }
		public DbSet<SecondAbout> SecondAbouts { get; set; }
		public DbSet<SecondFeature> SecondFeatures { get; set; }
		public DbSet<SubAbout> SubAbouts { get; set; }
		public DbSet<Testimaniol> Testimaniols { get; set; }
	}
}
