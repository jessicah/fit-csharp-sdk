#region Copyright
/////////////////////////////////////////////////////////////////////////////////////////////
// Copyright 2023 Garmin International, Inc.
// Licensed under the Flexible and Interoperable Data Transfer (FIT) Protocol License; you
// may not use this file except in compliance with the Flexible and Interoperable Data
// Transfer (FIT) Protocol License.
/////////////////////////////////////////////////////////////////////////////////////////////
// ****WARNING****  This file is auto-generated!  Do NOT edit this file.
// Profile Version = 21.126.0Release
// Tag = production/release/21.126.0-0-g0576dfe
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
    /// Implements the Spo2Data profile message.
    /// </summary>
    public class Spo2DataMesg : Mesg
    {
        #region Fields
        #endregion

        /// <summary>
        /// Field Numbers for <see cref="Spo2DataMesg"/>
        /// </summary>
        public sealed class FieldDefNum
        {
            public const byte Timestamp = 253;
            public const byte ReadingSpo2 = 0;
            public const byte ReadingConfidence = 1;
            public const byte Mode = 2;
            public const byte Invalid = Fit.FieldNumInvalid;
        }

        #region Constructors
        public Spo2DataMesg() : base(Profile.GetMesg(MesgNum.Spo2Data))
        {
        }

        public Spo2DataMesg(Mesg mesg) : base(mesg)
        {
        }
        #endregion // Constructors

        #region Methods
        ///<summary>
        /// Retrieves the Timestamp field
        /// Units: s</summary>
        /// <returns>Returns DateTime representing the Timestamp field</returns>
        public DateTime GetTimestamp()
        {
            Object val = GetFieldValue(253, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return TimestampToDateTime(Convert.ToUInt32(val));
            
        }

        /// <summary>
        /// Set Timestamp field
        /// Units: s</summary>
        /// <param name="timestamp_">Nullable field value to be set</param>
        public void SetTimestamp(DateTime timestamp_)
        {
            SetFieldValue(253, 0, timestamp_.GetTimeStamp(), Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the ReadingSpo2 field
        /// Units: percent</summary>
        /// <returns>Returns nullable byte representing the ReadingSpo2 field</returns>
        public byte? GetReadingSpo2()
        {
            Object val = GetFieldValue(0, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToByte(val));
            
        }

        /// <summary>
        /// Set ReadingSpo2 field
        /// Units: percent</summary>
        /// <param name="readingSpo2_">Nullable field value to be set</param>
        public void SetReadingSpo2(byte? readingSpo2_)
        {
            SetFieldValue(0, 0, readingSpo2_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the ReadingConfidence field</summary>
        /// <returns>Returns nullable byte representing the ReadingConfidence field</returns>
        public byte? GetReadingConfidence()
        {
            Object val = GetFieldValue(1, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToByte(val));
            
        }

        /// <summary>
        /// Set ReadingConfidence field</summary>
        /// <param name="readingConfidence_">Nullable field value to be set</param>
        public void SetReadingConfidence(byte? readingConfidence_)
        {
            SetFieldValue(1, 0, readingConfidence_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Mode field
        /// Comment: Mode when data was captured</summary>
        /// <returns>Returns nullable Spo2MeasurementType enum representing the Mode field</returns>
        public Spo2MeasurementType? GetMode()
        {
            object obj = GetFieldValue(2, 0, Fit.SubfieldIndexMainField);
            Spo2MeasurementType? value = obj == null ? (Spo2MeasurementType?)null : (Spo2MeasurementType)obj;
            return value;
        }

        /// <summary>
        /// Set Mode field
        /// Comment: Mode when data was captured</summary>
        /// <param name="mode_">Nullable field value to be set</param>
        public void SetMode(Spo2MeasurementType? mode_)
        {
            SetFieldValue(2, 0, mode_, Fit.SubfieldIndexMainField);
        }
        
        #endregion // Methods
    } // Class
} // namespace
