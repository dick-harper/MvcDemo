﻿using System;

namespace MvcDemo.Domain
{
    public class User  : Entity
    {
        public bool Active { get; set; }
        public DateTime Created { get; set; }
        public string UserName { get; set; }
        public Contact Contact { get; set; }
       
    }
}