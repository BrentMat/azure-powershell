// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.NetApp.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Restore payload for single file backup restore
    /// </summary>
    public partial class BackupRestoreFiles
    {
        /// <summary>
        /// Initializes a new instance of the BackupRestoreFiles class.
        /// </summary>
        public BackupRestoreFiles()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BackupRestoreFiles class.
        /// </summary>
        /// <param name="fileList">List of files to be restored</param>
        /// <param name="destinationVolumeId">Resource Id of the destination
        /// volume on which the files need to be restored</param>
        /// <param name="restoreFilePath">Destination folder where the files
        /// will be restored. The path name should start with a forward slash.
        /// If it is omitted from request then restore is done at the root
        /// folder of the destination volume by default</param>
        public BackupRestoreFiles(IList<string> fileList, string destinationVolumeId, string restoreFilePath = default(string))
        {
            FileList = fileList;
            RestoreFilePath = restoreFilePath;
            DestinationVolumeId = destinationVolumeId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of files to be restored
        /// </summary>
        [JsonProperty(PropertyName = "fileList")]
        public IList<string> FileList { get; set; }

        /// <summary>
        /// Gets or sets destination folder where the files will be restored.
        /// The path name should start with a forward slash. If it is omitted
        /// from request then restore is done at the root folder of the
        /// destination volume by default
        /// </summary>
        [JsonProperty(PropertyName = "restoreFilePath")]
        public string RestoreFilePath { get; set; }

        /// <summary>
        /// Gets or sets resource Id of the destination volume on which the
        /// files need to be restored
        /// </summary>
        [JsonProperty(PropertyName = "destinationVolumeId")]
        public string DestinationVolumeId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (FileList == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "FileList");
            }
            if (DestinationVolumeId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DestinationVolumeId");
            }
            if (FileList != null)
            {
                if (FileList.Count > 8)
                {
                    throw new ValidationException(ValidationRules.MaxItems, "FileList", 8);
                }
                if (FileList.Count < 1)
                {
                    throw new ValidationException(ValidationRules.MinItems, "FileList", 1);
                }
            }
            if (RestoreFilePath != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(RestoreFilePath, "^\\/.*$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "RestoreFilePath", "^\\/.*$");
                }
            }
        }
    }
}
