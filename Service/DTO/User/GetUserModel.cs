﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public  class GetUserModel 
    {
        public int Id { get; set; }
        public   string  Name { get; set; }        
        public int EmployeeId { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
