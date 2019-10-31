using System;
using System.Collections.Generic;
using System.Text;

namespace Akeneo.Model.ReferenceEntityAttributes
{
    public class AttributeBase : ModelBase
    {
        /// <summary>
		/// Attribute code
		/// </summary>
		public string Code { get; set; }

        /// <summary>
        /// Attribute labels for each locale. Key: LocaleCode, Value: Value for Locale
        /// </summary>
        public Dictionary<string, string> Labels { get; set; }

        /// <summary>
		/// Whether the attribute is localizable, i.e. can have one value by local
		/// </summary>
		public bool Localizable { get; set; }

        /// <summary>
        /// Whether the attribute is scopable, i.e. can have one value by channel
        /// </summary>
        public bool Scopable { get; set; }

        public bool RequiredForCompleteness { get; set; }
    }
    public abstract class TypedAttributeBase : AttributeBase
    {
        /// <summary>
        /// Attribute type
        /// </summary>
        public abstract string Type { get; }
    }
}
