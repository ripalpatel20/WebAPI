using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{ /// <summary>
/// User first name
/// </summary>
    public class Person
    {
        /// <summary>
        /// return id
        /// </summary>
        public int id { get; set; } = 0;
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";

    }
}