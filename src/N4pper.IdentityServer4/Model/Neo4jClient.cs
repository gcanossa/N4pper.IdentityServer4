﻿using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace N4pper.IdentityServer4.Model
{
    public class Neo4jClient : Client, IGraphEntity
    {
        public long? EntityId { get; set; }
    }
}
