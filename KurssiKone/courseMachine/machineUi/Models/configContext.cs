﻿using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace machineUi.Models
{

    //  Classes for db
    public class course
    {
        public Guid courseId { get; set; }
        public string name { get; set; }
        public Guid creator { get; set; }
        public Guid company { get; set; }
        public string created { get; set; }
        public string status { get; set; }
        public string information { get; set; }
        public image img { get; set; }
        public int price { get; set; }
        public string currency { get; set; }
        public int duration { get; set; }
        public string durationUnit { get; set; }
    }

    public class parent
    {
        public Guid parentId { get; set; }
        public string name { get; set; }
        public Guid creator { get; set; }
        public Guid courseId { get; set; }
        public List<child> child { get; set; }
    }

    public class child
    {
        public Guid childId { get; set; }
        public string name { get; set; }
        public Guid creator { get; set; }
        public Guid parentId { get; set; }
    }

    public class parameter
    {
        public Guid parameterId { get; set; }
        public Guid creator { get; set; }
        public string type { get; set; }
        public string value { get; set; }
        public Guid childId { get; set; }
        public int order { get; set; }
        public image image { get; set; }
        public video video { get; set; }
    }

    public class image
    {
        public Guid imgId { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public string created { get; set; }
    }

    public class video
    {
        public Guid videoId { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public string created { get; set; }
    }

    public partial class context: DbContext
    {
        public context()
            :base("name=context")
        {
        }
        public virtual DbSet<course> Course { get; set; }
        public virtual DbSet<parent> parent { get; set; }
        public virtual DbSet<child> child { get; set; }
        public virtual DbSet<parameter> parameter { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
        }

    }
    
}