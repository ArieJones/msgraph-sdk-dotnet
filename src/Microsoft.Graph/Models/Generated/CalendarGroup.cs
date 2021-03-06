// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Calendar Group.
    /// </summary>
    [DataContract]
    public partial class CalendarGroup : Entity
    {
    
        /// <summary>
        /// Gets or sets name.
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false, IsRequired = false)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or sets class id.
        /// </summary>
        [DataMember(Name = "classId", EmitDefaultValue = false, IsRequired = false)]
        public Guid? ClassId { get; set; }
    
        /// <summary>
        /// Gets or sets change key.
        /// </summary>
        [DataMember(Name = "changeKey", EmitDefaultValue = false, IsRequired = false)]
        public string ChangeKey { get; set; }
    
        /// <summary>
        /// Gets or sets calendars.
        /// </summary>
        [DataMember(Name = "calendars", EmitDefaultValue = false, IsRequired = false)]
        public ICalendarGroupCalendarsCollectionPage Calendars { get; set; }
    
    }
}

