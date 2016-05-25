﻿using System;
using System.Collections.Generic;

namespace Magpie.Library.Parsers
{
    internal abstract class ParseModel
    {
        public IList<BindingProperty> Properties { get; } = new List<BindingProperty>();
        public Type Type { get; set; }
    }
}