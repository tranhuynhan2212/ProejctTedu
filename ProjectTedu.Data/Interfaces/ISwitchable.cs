using ProjectTedu.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectTedu.Data.Interfaces
{
    public interface ISwitchable
    {
        Status Status { set; get; }
    }
}
