#region Copyright
/////////////////////////////////////////////////////////////////////////////////////////////
// Copyright 2024 Garmin International, Inc.
// Licensed under the Flexible and Interoperable Data Transfer (FIT) Protocol License; you
// may not use this file except in compliance with the Flexible and Interoperable Data
// Transfer (FIT) Protocol License.
/////////////////////////////////////////////////////////////////////////////////////////////
// ****WARNING****  This file is auto-generated!  Do NOT edit this file.
// Profile Version = 21.133.0Release
// Tag = production/release/21.133.0-0-g6002091
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
    /// Implements the MaxMetData profile message.
    /// </summary>
    public class MaxMetDataMesg : Mesg
    {
        #region Fields
        #endregion

        /// <summary>
        /// Field Numbers for <see cref="MaxMetDataMesg"/>
        /// </summary>
        public sealed class FieldDefNum
        {
            public const byte UpdateTime = 0;
            public const byte Vo2Max = 2;
            public const byte Sport = 5;
            public const byte SubSport = 6;
            public const byte MaxMetCategory = 8;
            public const byte CalibratedData = 9;
            public const byte HrSource = 12;
            public const byte SpeedSource = 13;
            public const byte Invalid = Fit.FieldNumInvalid;
        }

        #region Constructors
        public MaxMetDataMesg() : base(Profile.GetMesg(MesgNum.MaxMetData))
        {
        }

        public MaxMetDataMesg(Mesg mesg) : base(mesg)
        {
        }
        #endregion // Constructors

        #region Methods
        ///<summary>
        /// Retrieves the UpdateTime field
        /// Comment: Time maxMET and vo2 were calculated</summary>
        /// <returns>Returns DateTime representing the UpdateTime field</returns>
        public DateTime GetUpdateTime()
        {
            Object val = GetFieldValue(0, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return TimestampToDateTime(Convert.ToUInt32(val));
            
        }

        /// <summary>
        /// Set UpdateTime field
        /// Comment: Time maxMET and vo2 were calculated</summary>
        /// <param name="updateTime_">Nullable field value to be set</param>
        public void SetUpdateTime(DateTime updateTime_)
        {
            SetFieldValue(0, 0, updateTime_.GetTimeStamp(), Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Vo2Max field
        /// Units: mL/kg/min</summary>
        /// <returns>Returns nullable float representing the Vo2Max field</returns>
        public float? GetVo2Max()
        {
            Object val = GetFieldValue(2, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set Vo2Max field
        /// Units: mL/kg/min</summary>
        /// <param name="vo2Max_">Nullable field value to be set</param>
        public void SetVo2Max(float? vo2Max_)
        {
            SetFieldValue(2, 0, vo2Max_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Sport field</summary>
        /// <returns>Returns nullable Sport enum representing the Sport field</returns>
        public Sport? GetSport()
        {
            object obj = GetFieldValue(5, 0, Fit.SubfieldIndexMainField);
            Sport? value = obj == null ? (Sport?)null : (Sport)obj;
            return value;
        }

        /// <summary>
        /// Set Sport field</summary>
        /// <param name="sport_">Nullable field value to be set</param>
        public void SetSport(Sport? sport_)
        {
            SetFieldValue(5, 0, sport_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the SubSport field</summary>
        /// <returns>Returns nullable SubSport enum representing the SubSport field</returns>
        public SubSport? GetSubSport()
        {
            object obj = GetFieldValue(6, 0, Fit.SubfieldIndexMainField);
            SubSport? value = obj == null ? (SubSport?)null : (SubSport)obj;
            return value;
        }

        /// <summary>
        /// Set SubSport field</summary>
        /// <param name="subSport_">Nullable field value to be set</param>
        public void SetSubSport(SubSport? subSport_)
        {
            SetFieldValue(6, 0, subSport_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the MaxMetCategory field</summary>
        /// <returns>Returns nullable MaxMetCategory enum representing the MaxMetCategory field</returns>
        public MaxMetCategory? GetMaxMetCategory()
        {
            object obj = GetFieldValue(8, 0, Fit.SubfieldIndexMainField);
            MaxMetCategory? value = obj == null ? (MaxMetCategory?)null : (MaxMetCategory)obj;
            return value;
        }

        /// <summary>
        /// Set MaxMetCategory field</summary>
        /// <param name="maxMetCategory_">Nullable field value to be set</param>
        public void SetMaxMetCategory(MaxMetCategory? maxMetCategory_)
        {
            SetFieldValue(8, 0, maxMetCategory_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the CalibratedData field
        /// Comment: Indicates if calibrated data was used in the calculation</summary>
        /// <returns>Returns nullable Bool enum representing the CalibratedData field</returns>
        public Bool? GetCalibratedData()
        {
            object obj = GetFieldValue(9, 0, Fit.SubfieldIndexMainField);
            Bool? value = obj == null ? (Bool?)null : (Bool)obj;
            return value;
        }

        /// <summary>
        /// Set CalibratedData field
        /// Comment: Indicates if calibrated data was used in the calculation</summary>
        /// <param name="calibratedData_">Nullable field value to be set</param>
        public void SetCalibratedData(Bool? calibratedData_)
        {
            SetFieldValue(9, 0, calibratedData_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the HrSource field
        /// Comment: Indicates if the estimate was obtained using a chest strap or wrist heart rate</summary>
        /// <returns>Returns nullable MaxMetHeartRateSource enum representing the HrSource field</returns>
        public MaxMetHeartRateSource? GetHrSource()
        {
            object obj = GetFieldValue(12, 0, Fit.SubfieldIndexMainField);
            MaxMetHeartRateSource? value = obj == null ? (MaxMetHeartRateSource?)null : (MaxMetHeartRateSource)obj;
            return value;
        }

        /// <summary>
        /// Set HrSource field
        /// Comment: Indicates if the estimate was obtained using a chest strap or wrist heart rate</summary>
        /// <param name="hrSource_">Nullable field value to be set</param>
        public void SetHrSource(MaxMetHeartRateSource? hrSource_)
        {
            SetFieldValue(12, 0, hrSource_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the SpeedSource field
        /// Comment: Indidcates if the estimate was obtained using onboard GPS or connected GPS</summary>
        /// <returns>Returns nullable MaxMetSpeedSource enum representing the SpeedSource field</returns>
        public MaxMetSpeedSource? GetSpeedSource()
        {
            object obj = GetFieldValue(13, 0, Fit.SubfieldIndexMainField);
            MaxMetSpeedSource? value = obj == null ? (MaxMetSpeedSource?)null : (MaxMetSpeedSource)obj;
            return value;
        }

        /// <summary>
        /// Set SpeedSource field
        /// Comment: Indidcates if the estimate was obtained using onboard GPS or connected GPS</summary>
        /// <param name="speedSource_">Nullable field value to be set</param>
        public void SetSpeedSource(MaxMetSpeedSource? speedSource_)
        {
            SetFieldValue(13, 0, speedSource_, Fit.SubfieldIndexMainField);
        }
        
        #endregion // Methods
    } // Class
} // namespace
