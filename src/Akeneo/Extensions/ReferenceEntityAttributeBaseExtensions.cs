using Akeneo.Model;
using refr= Akeneo.Model.ReferenceEntityAttributes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Akeneo.Model.ReferenceEntityAttributes;

namespace Akeneo.Extensions
{
    public static class ReferenceEntityAttributeBaseExtensions
    {
        public static KeyValuePair<string, List<ReferenceEntityRecordValue>> CreateValues(this refr.AttributeBase attribute, params ReferenceEntityRecordValue [] productValues)
        {
            return new KeyValuePair<string, List<ReferenceEntityRecordValue >>(attribute.Code, productValues.ToList());
        }

        public static KeyValuePair<string, List<ReferenceEntityRecordValue >> CreateValue(this SimpleSelectAttribute attribute, string data, string locale = null, string scope = null)
        {
            return attribute.CreateValue((object)data, locale, scope);
        }

        public static KeyValuePair<string, List<ReferenceEntityRecordValue >> CreateValue(this MultiSelectAttribute attribute, string data, string locale = null, string scope = null)
        {
            return attribute.CreateValue(new List<string> { data }, locale, scope);
        }

        public static KeyValuePair<string, List<ReferenceEntityRecordValue >> CreateValue(this MultiSelectAttribute attribute, IEnumerable<string> data, string locale = null, string scope = null)
        {
            return attribute.CreateValue((object)data, locale, scope);
        }

        //public static KeyValuePair<string, List<ReferenceEntityRecordValue >> CreateValue(this NumberAttribute attribute, float data, string locale = null, string scope = null)
        //{
        //    return attribute.CreateValue((object)data, locale, scope);
        //}

        //public static KeyValuePair<string, List<ReferenceEntityRecordValue >> CreateValue(this NumberAttribute attribute, int data, string locale = null, string scope = null)
        //{
        //    return attribute.CreateValue((object)data, locale, scope);
        //}

        //public static KeyValuePair<string, List<ReferenceEntityRecordValue >> CreateValue(this NumberAttribute attribute, decimal data, string locale = null, string scope = null)
        //{
        //    return attribute.CreateValue((object)data, locale, scope);
        //}

        //public static KeyValuePair<string, List<ReferenceEntityRecordValue >> CreateValue(this NumberAttribute attribute, double data, string locale = null, string scope = null)
        //{
        //    return attribute.CreateValue((object)data, locale, scope);
        //}

        public static KeyValuePair<string, List<ReferenceEntityRecordValue >> CreateValue(this TextAttribute attribute, string data, string locale = null, string scope = null)
        {
            return attribute.CreateValue((object)data, locale, scope);
        }

        public static KeyValuePair<string, List<ReferenceEntityRecordValue >> CreateValue(this TextAreaAttribute attribute, string data, string locale = null, string scope = null)
        {
            return attribute.CreateValue((object)data, locale, scope);
        }

        //public static KeyValuePair<string, List<ReferenceEntityRecordValue >> CreateValue(this DateAttribute attribute, DateTime data, string locale = null, string scope = null)
        //{
        //    return attribute.CreateValue((object)data, locale, scope);
        //}

        //public static KeyValuePair<string, List<ReferenceEntityRecordValue >> CreateValue(this PriceAttribute attribute, float amount, string currency, string locale = null, string scope = null)
        //{
        //    return attribute.CreateValue(new PriceReferenceEntityRecordValue  { Amount = amount, Currency = currency }, locale, scope);
        //}

        //public static KeyValuePair<string, List<ReferenceEntityRecordValue >> CreateValue(this PriceAttribute attribute, PriceReferenceEntityRecordValue  data, string locale = null, string scope = null)
        //{
        //    return attribute.CreateValue(new List<PriceReferenceEntityRecordValue > { data }, locale, scope);
        //}

        //public static KeyValuePair<string, List<ReferenceEntityRecordValue >> CreateValue(this PriceAttribute attribute, IEnumerable<PriceReferenceEntityRecordValue > data, string locale = null, string scope = null)
        //{
        //    return attribute.CreateValue((object)data, locale, scope);
        //}

        private static KeyValuePair<string, List<ReferenceEntityRecordValue >> CreateValue(this refr.AttributeBase attribute, object data, string locale = null, string scope = null)
        {
            return new KeyValuePair<string, List<ReferenceEntityRecordValue >>(attribute.Code, new List<ReferenceEntityRecordValue >{new ReferenceEntityRecordValue 
            {
                Data = data,
                Locale = locale,
                Scope = scope
            }});
        }

        public static KeyValuePair<string, List<ReferenceEntityRecordValue >> CreateValue(this KeyValuePair<string, List<ReferenceEntityRecordValue >> kvp, object data, string locale = null, string scope = null)
        {
            kvp.Value.Add(new ReferenceEntityRecordValue  { Data = data, Locale = locale, Scope = scope });
            return kvp;
        }
    }
}
