using Akeneo.Model;
using Akeneo.Model.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Akeneo.Extensions
{
    public static class ReferenceEntityAttributeOptionsExtension
    {
        public static KeyValuePair<string, List<ReferenceEntityRecordValue>> CreateSimpleValue(this AttributeOption option, string locale = null, string scope = null)
        {
            return new KeyValuePair<string, List<ReferenceEntityRecordValue>>(option.Attribute, new List<ReferenceEntityRecordValue>
            {
                new ReferenceEntityRecordValue
                {
                    Locale = locale,
                    Data = option.Code,
                    Scope = scope
                }
            });
        }

        public static KeyValuePair<string, List<ReferenceEntityRecordValue>> CreateMultiValue(this AttributeOption option, string locale = null, string scope = null)
        {
            return new KeyValuePair<string, List<ReferenceEntityRecordValue>>(option.Attribute, new List<ReferenceEntityRecordValue>
            {
                new ReferenceEntityRecordValue
                {
                    Locale = locale,
                    Data = new List<string>{option.Code},
                    Scope = scope
                }
            });
        }

        public static KeyValuePair<string, List<ReferenceEntityRecordValue>> CreateMultiValues(this IEnumerable<AttributeOption> option, string locale = null, string scope = null)
        {
            var optionGrps = option
                .GroupBy(o => o.Attribute, o => o.Code)
                .ToList();

            if (optionGrps.Count != 1)
            {
                throw new NotSupportedException("Can only create Values for same type of option");
            }

            var optionGrp = optionGrps.First();
            return new KeyValuePair<string, List<ReferenceEntityRecordValue>>(optionGrp.Key, new List<ReferenceEntityRecordValue>{ new ReferenceEntityRecordValue
            {
                Data = optionGrp.ToList(),
                Locale = locale,
                Scope = scope
            } });
        }

        public static KeyValuePair<string, List<ReferenceEntityRecordValue>> CreateValue(this KeyValuePair<string, List<ReferenceEntityRecordValue>> kvp, string data, string locale = null, string scope = null)
        {
            kvp.Value.Add(new ReferenceEntityRecordValue
            {
                Locale = locale,
                Scope = scope,
                Data = data
            });
            return kvp;
        }
    }
}
