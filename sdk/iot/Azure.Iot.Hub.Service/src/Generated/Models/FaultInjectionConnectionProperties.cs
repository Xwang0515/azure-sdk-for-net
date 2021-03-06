// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Iot.Hub.Service.Models
{
    /// <summary> The FaultInjectionConnectionProperties. </summary>
    internal partial class FaultInjectionConnectionProperties
    {
        /// <summary> Initializes a new instance of FaultInjectionConnectionProperties. </summary>
        public FaultInjectionConnectionProperties()
        {
        }

        /// <summary> Initializes a new instance of FaultInjectionConnectionProperties. </summary>
        /// <param name="action"> The action to perform. </param>
        /// <param name="blockDurationInMinutes"> . </param>
        internal FaultInjectionConnectionProperties(FaultInjectionConnectionPropertiesAction? action, int? blockDurationInMinutes)
        {
            Action = action;
            BlockDurationInMinutes = blockDurationInMinutes;
        }
        public int? BlockDurationInMinutes { get; set; }
    }
}
