﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestCovidApi
{
#if DEBUG
    public class RedisTests : Tests
    {
        public override string AppSettings { get; set; } = "redis-appsettings.json";
    }
#endif
}
