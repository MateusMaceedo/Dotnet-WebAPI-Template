﻿using System;

namespace Template_Modelo.Domain.Models
{
    public abstract class EntityBase
    {
        public string Id { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
