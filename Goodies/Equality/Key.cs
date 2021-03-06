﻿using System;

namespace BusterWood.Equality
{

    struct Key
    {
        public Type Type { get; }
        public string[] Properties { get; }
        public StringComparer StringComparer { get; }

        public Key(Type type, string[] props) : this(type, props, null)
        { }

        public Key(Type type, string[] props, StringComparer stringComparer)
        {
            Type = type;
            Properties = props;
            StringComparer = stringComparer;
        }

        public override string ToString()
        {
            return Type.Name + "_" + string.Join("_", Properties);
        }
    }
}
