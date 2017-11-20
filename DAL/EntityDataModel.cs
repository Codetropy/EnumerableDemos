namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class EntityDataModel : DbContext
    {
        // Your context has been configured to use a 'EntityDataModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'DAL.EntityDataModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'EntityDataModel' 
        // connection string in the application configuration file.
        public EntityDataModel ()
            : base("name=EntityDataModel")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<User> Users { get; set; }

        // Note: MyEntity uses below class and not an entity mapped dbmodel
        //public virtual DbSet<MyEntity> Entities { get; set; }
    }



    // Note: Any non-mapped classes can be added here
    // 
    //public class MyEntity
    //{
    //    public int MyEntityId { get; set; }
    //    public string MyEntityName { get; set; }
    //    public string MyEntityEmail { get; set; }

    //}
}