﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime;
using System.Text;

namespace Domain.Entities
{
    public class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }

        private DateTime? _createAt;

        public DateTime? CreateAt
        {
            get { return _createAt; }
            set { _createAt = (value == null ? DateTime.UtcNow : value); }
        }

        public DateTime? UpdateAt { get; set; }
    }   
}
