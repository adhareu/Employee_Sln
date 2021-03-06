﻿using System;
using System.Data.Entity;

namespace Asset.Infrastructure
{
    /// <summary>
    /// Interface Database Factory
    /// Manage Db Context
    /// Author: Asif Iqbal
    /// </summary>
    public interface IDatabaseFactory : IDisposable
    {
        DbContext Get();
        
    }
}
