#region Copyright
/////////////////////////////////////////////////////////////////////////////////////////////
// Copyright 2024 Garmin International, Inc.
// Licensed under the Flexible and Interoperable Data Transfer (FIT) Protocol License; you
// may not use this file except in compliance with the Flexible and Interoperable Data
// Transfer (FIT) Protocol License.
/////////////////////////////////////////////////////////////////////////////////////////////
// ****WARNING****  This file is auto-generated!  Do NOT edit this file.
// Profile Version = 21.139.2Release
// Tag = production/release/21.139.2-0-g9eaea05
/////////////////////////////////////////////////////////////////////////////////////////////

#endregion

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.IO;
using System.Linq;

namespace Dynastream.Fit
{
    /// <summary>
    /// Implements the FileCreator profile message.
    /// </summary>
    public class FileCreatorMesg : Mesg
    {
        #region Fields
        #endregion

        /// <summary>
        /// Field Numbers for <see cref="FileCreatorMesg"/>
        /// </summary>
        public sealed class FieldDefNum
        {
            public const byte SoftwareVersion = 0;
            public const byte HardwareVersion = 1;
            public const byte Invalid = Fit.FieldNumInvalid;
        }

        #region Constructors
        public FileCreatorMesg() : base(Profile.GetMesg(MesgNum.FileCreator))
        {
        }

        public FileCreatorMesg(Mesg mesg) : base(mesg)
        {
        }
        #endregion // Constructors

        #region Methods
        ///<summary>
        /// Retrieves the SoftwareVersion field</summary>
        /// <returns>Returns nullable ushort representing the SoftwareVersion field</returns>
        public ushort? GetSoftwareVersion()
        {
            Object val = GetFieldValue(0, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt16(val));
            
        }

        /// <summary>
        /// Set SoftwareVersion field</summary>
        /// <param name="softwareVersion_">Nullable field value to be set</param>
        public void SetSoftwareVersion(ushort? softwareVersion_)
        {
            SetFieldValue(0, 0, softwareVersion_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the HardwareVersion field</summary>
        /// <returns>Returns nullable byte representing the HardwareVersion field</returns>
        public byte? GetHardwareVersion()
        {
            Object val = GetFieldValue(1, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToByte(val));
            
        }

        /// <summary>
        /// Set HardwareVersion field</summary>
        /// <param name="hardwareVersion_">Nullable field value to be set</param>
        public void SetHardwareVersion(byte? hardwareVersion_)
        {
            SetFieldValue(1, 0, hardwareVersion_, Fit.SubfieldIndexMainField);
        }
        
        #endregion // Methods
    } // Class
} // namespace
