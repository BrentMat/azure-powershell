// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20230301
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.Extensions;

    /// <summary>Response that identifies a Job Run.</summary>
    [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.DoNotFormat]
    public partial class JobRunResourceId :
        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20230301.IJobRunResourceId,
        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20230301.IJobRunResourceIdInternal
    {

        /// <summary>Backing field for <see cref="JobRunResourceId1" /> property.</summary>
        private string _jobRunResourceId1;

        /// <summary>Fully qualified resource id of the Job Run.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.PropertyOrigin.Owned)]
        public string JobRunResourceId1 { get => this._jobRunResourceId1; }

        /// <summary>Internal Acessors for JobRunResourceId1</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20230301.IJobRunResourceIdInternal.JobRunResourceId1 { get => this._jobRunResourceId1; set { {_jobRunResourceId1 = value;} } }

        /// <summary>Creates an new <see cref="JobRunResourceId" /> instance.</summary>
        public JobRunResourceId()
        {

        }
    }
    /// Response that identifies a Job Run.
    public partial interface IJobRunResourceId :
        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.IJsonSerializable
    {
        /// <summary>Fully qualified resource id of the Job Run.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Fully qualified resource id of the Job Run.",
        SerializedName = @"jobRunResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string JobRunResourceId1 { get;  }

    }
    /// Response that identifies a Job Run.
    internal partial interface IJobRunResourceIdInternal

    {
        /// <summary>Fully qualified resource id of the Job Run.</summary>
        string JobRunResourceId1 { get; set; }

    }
}