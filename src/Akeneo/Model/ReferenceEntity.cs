using System;
using System.Collections.Generic;
using System.Text;

namespace Akeneo.Model
{
    class ReferenceEntity
    {
        public string Code { get; set; }
        public Dictionary<string,Dictionary<string,string>> Labels { get; set; }
        public List<ReferenceEntityAttributes.TypedAttributeBase> Attributes { get; set; }
    }
}
