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
    /// The type Calendar.
    /// </summary>
    [DataContract]
    public partial class Calendar : Entity
    {
    
        /// <summary>
        /// Gets or sets name.
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false, IsRequired = false)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or sets color.
        /// </summary>
        [DataMember(Name = "color", EmitDefaultValue = false, IsRequired = false)]
        public CalendarColor? Color { get; set; }
    
        /// <summary>
        /// Gets or sets change key.
        /// </summary>
        [DataMember(Name = "changeKey", EmitDefaultValue = false, IsRequired = false)]
        public string ChangeKey { get; set; }
    
        /// <summary>
        /// Gets or sets events.
        /// </summary>
        [DataMember(Name = "events", EmitDefaultValue = false, IsRequired = false)]
        public ICalendarEventsCollectionPage Events { get; set; }
    
        /// <summary>
        /// Gets or sets calendar view.
        /// </summary>
        [DataMember(Name = "calendarView", EmitDefaultValue = false, IsRequired = false)]
        public ICalendarCalendarViewCollectionPage CalendarView { get; set; }
    
    }
}

