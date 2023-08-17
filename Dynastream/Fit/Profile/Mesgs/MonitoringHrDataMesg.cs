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
    /// Implements the MonitoringHrData profile message.
    /// </summary>
    public class MonitoringHrDataMesg : Mesg
    {
        #region Fields
        #endregion

        /// <summary>
        /// Field Numbers for <see cref="MonitoringHrDataMesg"/>
        /// </summary>
        public sealed class FieldDefNum
        {
            public const byte Timestamp = 253;
            public const byte RestingHeartRate = 0;
            public const byte CurrentDayRestingHeartRate = 1;
            public const byte Invalid = Fit.FieldNumInvalid;
        }

        #region Constructors
        public MonitoringHrDataMesg() : base(Profile.GetMesg(MesgNum.MonitoringHrData))
        {
        }

        public MonitoringHrDataMesg(Mesg mesg) : base(mesg)
        {
        }
        #endregion // Constructors

        #region Methods
        ///<summary>
        /// Retrieves the Timestamp field
        /// Units: s
        /// Comment: Must align to logging interval, for example, time must be 00:00:00 for daily log.</summary>
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
        /// Units: s
        /// Comment: Must align to logging interval, for example, time must be 00:00:00 for daily log.</summary>
        /// <param name="timestamp_">Nullable field value to be set</param>
        public void SetTimestamp(DateTime timestamp_)
        {
            SetFieldValue(253, 0, timestamp_.GetTimeStamp(), Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the RestingHeartRate field
        /// Units: bpm
        /// Comment: 7-day rolling average</summary>
        /// <returns>Returns nullable byte representing the RestingHeartRate field</returns>
        public byte? GetRestingHeartRate()
        {
            Object val = GetFieldValue(0, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToByte(val));
            
        }

        /// <summary>
        /// Set RestingHeartRate field
        /// Units: bpm
        /// Comment: 7-day rolling average</summary>
        /// <param name="restingHeartRate_">Nullable field value to be set</param>
        public void SetRestingHeartRate(byte? restingHeartRate_)
        {
            SetFieldValue(0, 0, restingHeartRate_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the CurrentDayRestingHeartRate field
        /// Units: bpm
        /// Comment: RHR for today only. (Feeds into 7-day average)</summary>
        /// <returns>Returns nullable byte representing the CurrentDayRestingHeartRate field</returns>
        public byte? GetCurrentDayRestingHeartRate()
        {
            Object val = GetFieldValue(1, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToByte(val));
            
        }

        /// <summary>
        /// Set CurrentDayRestingHeartRate field
        /// Units: bpm
        /// Comment: RHR for today only. (Feeds into 7-day average)</summary>
        /// <param name="currentDayRestingHeartRate_">Nullable field value to be set</param>
        public void SetCurrentDayRestingHeartRate(byte? currentDayRestingHeartRate_)
        {
            SetFieldValue(1, 0, currentDayRestingHeartRate_, Fit.SubfieldIndexMainField);
        }
        
        #endregion // Methods
    } // Class
} // namespace
