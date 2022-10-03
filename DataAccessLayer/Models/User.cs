﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public  class User : BaseModel
    {
        public   string  Name { get; set; }
        public   string  UserName { get; set; }
        public string Password { get; set; }
        public DateTime CreatedDate { get; set; }
        public int EmployeeId { get; set; }
    }
}
