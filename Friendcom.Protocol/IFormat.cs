﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Friendcom.Protocol
{
    public interface IFormat<T>
    {
        string GetString(object ower, T[] data);
    }
}
