#region Copyright
/////////////////////////////////////////////////////////////////////////////////////////////
// Copyright 2023 Garmin International, Inc.
// Licensed under the Flexible and Interoperable Data Transfer (FIT) Protocol License; you
// may not use this file except in compliance with the Flexible and Interoperable Data
// Transfer (FIT) Protocol License.
/////////////////////////////////////////////////////////////////////////////////////////////
// ****WARNING****  This file is auto-generated!  Do NOT edit this file.
// Profile Version = 21.120Release
// Tag = production/release/21.120.00-0-g2d77811
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
    /// Implements the Software profile message.
    /// </summary>
    public class SoftwareMesg : Mesg
    {
        #region Fields
        #endregion

        /// <summary>
        /// Field Numbers for <see cref="SoftwareMesg"/>
        /// </summary>
        public sealed class FieldDefNum
        {
            public const byte MessageIndex = 254;
            public const byte Version = 3;
            public const byte PartNumber = 5;
            public const byte Invalid = Fit.FieldNumInvalid;
        }

        #region Constructors
        public SoftwareMesg() : base(Profile.GetMesg(MesgNum.Software))
        {
        }

        public SoftwareMesg(Mesg mesg) : base(mesg)
        {
        }
        #endregion // Constructors

        #region Methods
        ///<summary>
        /// Retrieves the MessageIndex field</summary>
        /// <returns>Returns nullable ushort representing the MessageIndex field</returns>
        public ushort? GetMessageIndex()
        {
            Object val = GetFieldValue(254, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt16(val));
            
        }

        /// <summary>
        /// Set MessageIndex field</summary>
        /// <param name="messageIndex_">Nullable field value to be set</param>
        public void SetMessageIndex(ushort? messageIndex_)
        {
            SetFieldValue(254, 0, messageIndex_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Version field</summary>
        /// <returns>Returns nullable float representing the Version field</returns>
        public float? GetVersion()
        {
            Object val = GetFieldValue(3, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set Version field</summary>
        /// <param name="version_">Nullable field value to be set</param>
        public void SetVersion(float? version_)
        {
            SetFieldValue(3, 0, version_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the PartNumber field</summary>
        /// <returns>Returns byte[] representing the PartNumber field</returns>
        public byte[] GetPartNumber()
        {
            byte[] data = (byte[])GetFieldValue(5, 0, Fit.SubfieldIndexMainField);
            return data.Take(data.Length - 1).ToArray();
        }

        ///<summary>
        /// Retrieves the PartNumber field</summary>
        /// <returns>Returns String representing the PartNumber field</returns>
        public String GetPartNumberAsString()
        {
            byte[] data = (byte[])GetFieldValue(5, 0, Fit.SubfieldIndexMainField);
            return data != null ? Encoding.UTF8.GetString(data, 0, data.Length - 1) : null;
        }

        ///<summary>
        /// Set PartNumber field</summary>
        /// <param name="partNumber_"> field value to be set</param>
        public void SetPartNumber(String partNumber_)
        {
            byte[] data = Encoding.UTF8.GetBytes(partNumber_);
            byte[] zdata = new byte[data.Length + 1];
            data.CopyTo(zdata, 0);
            SetFieldValue(5, 0, zdata, Fit.SubfieldIndexMainField);
        }

        
        /// <summary>
        /// Set PartNumber field</summary>
        /// <param name="partNumber_">field value to be set</param>
        public void SetPartNumber(byte[] partNumber_)
        {
            SetFieldValue(5, 0, partNumber_, Fit.SubfieldIndexMainField);
        }
        
        #endregion // Methods
    } // Class
} // namespace
