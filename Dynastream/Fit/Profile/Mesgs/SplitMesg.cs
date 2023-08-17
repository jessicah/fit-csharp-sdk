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
    /// Implements the Split profile message.
    /// </summary>
    public class SplitMesg : Mesg
    {
        #region Fields
        #endregion

        /// <summary>
        /// Field Numbers for <see cref="SplitMesg"/>
        /// </summary>
        public sealed class FieldDefNum
        {
            public const byte SplitType = 0;
            public const byte TotalElapsedTime = 1;
            public const byte TotalTimerTime = 2;
            public const byte TotalDistance = 3;
            public const byte StartTime = 9;
            public const byte TotalMovingTime = 110;
            public const byte Invalid = Fit.FieldNumInvalid;
        }

        #region Constructors
        public SplitMesg() : base(Profile.GetMesg(MesgNum.Split))
        {
        }

        public SplitMesg(Mesg mesg) : base(mesg)
        {
        }
        #endregion // Constructors

        #region Methods
        ///<summary>
        /// Retrieves the SplitType field</summary>
        /// <returns>Returns nullable SplitType enum representing the SplitType field</returns>
        public SplitType? GetSplitType()
        {
            object obj = GetFieldValue(0, 0, Fit.SubfieldIndexMainField);
            SplitType? value = obj == null ? (SplitType?)null : (SplitType)obj;
            return value;
        }

        /// <summary>
        /// Set SplitType field</summary>
        /// <param name="splitType_">Nullable field value to be set</param>
        public void SetSplitType(SplitType? splitType_)
        {
            SetFieldValue(0, 0, splitType_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the TotalElapsedTime field
        /// Units: s</summary>
        /// <returns>Returns nullable float representing the TotalElapsedTime field</returns>
        public float? GetTotalElapsedTime()
        {
            Object val = GetFieldValue(1, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set TotalElapsedTime field
        /// Units: s</summary>
        /// <param name="totalElapsedTime_">Nullable field value to be set</param>
        public void SetTotalElapsedTime(float? totalElapsedTime_)
        {
            SetFieldValue(1, 0, totalElapsedTime_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the TotalTimerTime field
        /// Units: s</summary>
        /// <returns>Returns nullable float representing the TotalTimerTime field</returns>
        public float? GetTotalTimerTime()
        {
            Object val = GetFieldValue(2, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set TotalTimerTime field
        /// Units: s</summary>
        /// <param name="totalTimerTime_">Nullable field value to be set</param>
        public void SetTotalTimerTime(float? totalTimerTime_)
        {
            SetFieldValue(2, 0, totalTimerTime_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the TotalDistance field
        /// Units: m</summary>
        /// <returns>Returns nullable float representing the TotalDistance field</returns>
        public float? GetTotalDistance()
        {
            Object val = GetFieldValue(3, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set TotalDistance field
        /// Units: m</summary>
        /// <param name="totalDistance_">Nullable field value to be set</param>
        public void SetTotalDistance(float? totalDistance_)
        {
            SetFieldValue(3, 0, totalDistance_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the StartTime field</summary>
        /// <returns>Returns DateTime representing the StartTime field</returns>
        public DateTime GetStartTime()
        {
            Object val = GetFieldValue(9, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return TimestampToDateTime(Convert.ToUInt32(val));
            
        }

        /// <summary>
        /// Set StartTime field</summary>
        /// <param name="startTime_">Nullable field value to be set</param>
        public void SetStartTime(DateTime startTime_)
        {
            SetFieldValue(9, 0, startTime_.GetTimeStamp(), Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the TotalMovingTime field
        /// Units: s</summary>
        /// <returns>Returns nullable float representing the TotalMovingTime field</returns>
        public float? GetTotalMovingTime()
        {
            Object val = GetFieldValue(110, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set TotalMovingTime field
        /// Units: s</summary>
        /// <param name="totalMovingTime_">Nullable field value to be set</param>
        public void SetTotalMovingTime(float? totalMovingTime_)
        {
            SetFieldValue(110, 0, totalMovingTime_, Fit.SubfieldIndexMainField);
        }
        
        #endregion // Methods
    } // Class
} // namespace
