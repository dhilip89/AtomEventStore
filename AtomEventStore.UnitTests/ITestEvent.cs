﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grean.AtomEventStore.UnitTests
{
    public interface ITestEvent
    {
        ITestEventVisitor Accept(ITestEventVisitor visitor);
    }
}
