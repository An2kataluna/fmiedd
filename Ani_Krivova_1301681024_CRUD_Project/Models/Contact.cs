﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ani_Krivova_1301681024_CRUD_Project.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public int ParentUserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}