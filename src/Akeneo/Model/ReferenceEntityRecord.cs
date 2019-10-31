using System;
using System.Collections.Generic;
using System.Text;

namespace Akeneo.Model
{
    public class ReferenceEntityRecord
    {
        public string Code { get; set; }
        public Dictionary<string,List<ReferenceEntityRecordValue>> Values { get; set; }
        public ReferenceEntityRecord()
        {
            Values = new Dictionary<string, List<ReferenceEntityRecordValue>>();
        }
    }
}
