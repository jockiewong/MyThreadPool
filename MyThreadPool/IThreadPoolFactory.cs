﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyThreadPool
{
    public interface IThreadPoolFactory
    {
        IThreadPool CreatePool();
    }
}
