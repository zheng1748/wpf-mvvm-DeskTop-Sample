﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ZFS.Model.Entity
{
    [Serializable]
    public class Authorithitem : BaseEntity
    {
        public string AuthorityName { get; set; }

        public string AuthorityValue { get; set; }
    }
}
