﻿using System;
using System.Collections.Generic;
using SQLite;
using SQLiteNetExtensions.Attributes; 
namespace Chitic_Valentina_lab10.Models
{
 public class Product
 {
 [PrimaryKey, AutoIncrement]
 public int ID { get; set; }
 public string Description { get; set; }
 [OneToMany]
 public List<ListProduct> ListProducts { get; set; }
 }
}
