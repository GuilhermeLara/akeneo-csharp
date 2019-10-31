﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Akeneo.Model
{
    public class ReferenceEntityRecordValue
    {
        /// <summary>
		/// The code of a locale when the attribute is localizable
		/// </summary>
		public string Locale { get; set; }

        /// <summary>
        /// The code of a channel when the attribute is scopable
        /// </summary>
        public string Scope { get; set; }

        /// <summary>
        /// The value stored for this attribute for this locale (if attribute is localizable) and this channel (if the attribute is scopable). Its type and format depends on the attribute type.
        /// </summary>
        [JsonConverter(typeof(ReferenceEntityRecordValue))]
        public object Data { get; set; }
    }
}
