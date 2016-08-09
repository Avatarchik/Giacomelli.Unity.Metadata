﻿using System;

namespace Giacomelli.Unity.Metadata.Domain
{
    public abstract class FileMetadataBase
    {
        #region Properties
        public int FileId { get; set; }
        public string FullName { get; set; }
        public string Name
        {
            get
            {
                if (String.IsNullOrEmpty(FullName))
                {
                    return FullName;
                }

                var parts = FullName.Split('.');
                return parts[parts.Length - 1];
            }
        }

        public string Guid { get; set; }
        #endregion
    }
}

