﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Dapper;
using Dapper.Contrib.Extensions;

namespace Lab_StackOverflow.Models
{
    [Table("answer")]
    public class Answer
    {
        [Key]
        public int id { get; set; }
        public string username { get; set; }
        public string detail { get; set; }
        public int questionId { get; set; }
        public DateTime posted { get; set; }
        public int upvotes { get; set; }
    }
}
