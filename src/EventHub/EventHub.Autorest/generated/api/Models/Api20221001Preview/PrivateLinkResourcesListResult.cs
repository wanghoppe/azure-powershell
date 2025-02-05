// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Extensions;

    /// <summary>Result of the List private link resources operation.</summary>
    [Microsoft.Azure.PowerShell.Cmdlets.EventHub.DoNotFormat]
    public partial class PrivateLinkResourcesListResult :
        Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.IPrivateLinkResourcesListResult,
        Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.IPrivateLinkResourcesListResultInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>A link for the next page of private link resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.IPrivateLinkResource[] _value;

        /// <summary>A collection of private link resources</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.IPrivateLinkResource[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="PrivateLinkResourcesListResult" /> instance.</summary>
        public PrivateLinkResourcesListResult()
        {

        }
    }
    /// Result of the List private link resources operation.
    public partial interface IPrivateLinkResourcesListResult :
        Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.IJsonSerializable
    {
        /// <summary>A link for the next page of private link resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A link for the next page of private link resources.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>A collection of private link resources</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A collection of private link resources",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.IPrivateLinkResource) })]
        Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.IPrivateLinkResource[] Value { get; set; }

    }
    /// Result of the List private link resources operation.
    internal partial interface IPrivateLinkResourcesListResultInternal

    {
        /// <summary>A link for the next page of private link resources.</summary>
        string NextLink { get; set; }
        /// <summary>A collection of private link resources</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.IPrivateLinkResource[] Value { get; set; }

    }
}