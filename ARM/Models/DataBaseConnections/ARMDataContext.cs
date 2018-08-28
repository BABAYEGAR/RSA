using ARM.Models.Application;
using Microsoft.EntityFrameworkCore;

namespace ARM.Models.DataBaseConnections
{
    public class ARMDataContext : DbContext
    {
        // Your context has been configured to use a 'VmsDataContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // ' Imager.DataManager.DataBaseConnections.VMSConnections' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ImageDataContext' 
        // connection string in the application configuration file.
        public ARMDataContext(DbContextOptions<ARMDataContext> options)
            : base(options)
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.
        public virtual DbSet<CustomerData> CustomerDatas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=ONAPP-248452\SQLEXPRESS01;Database=ARM;Trusted_Connection=True;");
            optionsBuilder.UseSqlServer(@"Server=199.195.118.248;Database=ARM;User Id=GraceLand;Password=GraceLand2018#;MultipleActiveResultSets=true;");
        }
    }
}