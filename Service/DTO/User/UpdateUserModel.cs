﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO.User
{
    public class UpdateUserModel
    {    public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int EmployeeId { get; set; }
        public DateTime CreateDate { get; set; }

    }
}