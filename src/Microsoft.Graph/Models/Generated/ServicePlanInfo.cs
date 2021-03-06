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
    /// The type ServicePlanInfo.
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class ServicePlanInfo
    {
    
        /// <summary>
        /// Gets or sets servicePlanId.
        /// </summary>
        [DataMember(Name = "servicePlanId", EmitDefaultValue = false, IsRequired = false)]
        public Guid? ServicePlanId { get; set; }
    
        /// <summary>
        /// Gets or sets servicePlanName.
        /// </summary>
        [DataMember(Name = "servicePlanName", EmitDefaultValue = false, IsRequired = false)]
        public string ServicePlanName { get; set; }
    
        /// <summary>
        /// Gets or sets provisioningStatus.
        /// </summary>
        [DataMember(Name = "provisioningStatus", EmitDefaultValue = false, IsRequired = false)]
        public string ProvisioningStatus { get; set; }
    
        /// <summary>
        /// Gets or sets appliesTo.
        /// </summary>
        [DataMember(Name = "appliesTo", EmitDefaultValue = false, IsRequired = false)]
        public string AppliesTo { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }
    
    }
}
