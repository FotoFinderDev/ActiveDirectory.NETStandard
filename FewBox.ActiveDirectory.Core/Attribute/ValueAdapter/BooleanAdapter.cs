﻿using System;
using System.DirectoryServices;

namespace ActiveDirectory.NETStandard.Attribute.ValueAdapter
{
    class BooleanAdapter : Adapter<bool>
    {
        public BooleanAdapter(DirectoryEntry directoryEntry, string attributeName) :
            base(directoryEntry, attributeName)
        {
        }

        protected override bool GetAttributeValue()
        {
            if (this.ValueObject == null)
            {
                return false;
            }
            return Boolean.Parse(this.ValueObject.ToString());
        }
    }
}
