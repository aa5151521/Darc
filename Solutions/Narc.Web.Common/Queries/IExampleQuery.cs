﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Narc.Web.Common.Queries
{
    public interface IExampleQuery
    {
        List<string> GetQueries();
    }
}