﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectTedu.Data.Interfaces
{
    public interface IHasOwner<T>
    {
        T OwnerId { get; set; }

    }
}
