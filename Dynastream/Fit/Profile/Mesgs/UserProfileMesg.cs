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
    /// Implements the UserProfile profile message.
    /// </summary>
    public class UserProfileMesg : Mesg
    {
        #region Fields
        #endregion

        /// <summary>
        /// Field Numbers for <see cref="UserProfileMesg"/>
        /// </summary>
        public sealed class FieldDefNum
        {
            public const byte MessageIndex = 254;
            public const byte FriendlyName = 0;
            public const byte Gender = 1;
            public const byte Age = 2;
            public const byte Height = 3;
            public const byte Weight = 4;
            public const byte Language = 5;
            public const byte ElevSetting = 6;
            public const byte WeightSetting = 7;
            public const byte RestingHeartRate = 8;
            public const byte DefaultMaxRunningHeartRate = 9;
            public const byte DefaultMaxBikingHeartRate = 10;
            public const byte DefaultMaxHeartRate = 11;
            public const byte HrSetting = 12;
            public const byte SpeedSetting = 13;
            public const byte DistSetting = 14;
            public const byte PowerSetting = 16;
            public const byte ActivityClass = 17;
            public const byte PositionSetting = 18;
            public const byte TemperatureSetting = 21;
            public const byte LocalId = 22;
            public const byte GlobalId = 23;
            public const byte WakeTime = 28;
            public const byte SleepTime = 29;
            public const byte HeightSetting = 30;
            public const byte UserRunningStepLength = 31;
            public const byte UserWalkingStepLength = 32;
            public const byte DepthSetting = 47;
            public const byte DiveCount = 49;
            public const byte Invalid = Fit.FieldNumInvalid;
        }

        #region Constructors
        public UserProfileMesg() : base(Profile.GetMesg(MesgNum.UserProfile))
        {
        }

        public UserProfileMesg(Mesg mesg) : base(mesg)
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
        /// Retrieves the FriendlyName field
        /// Comment: Used for Morning Report greeting</summary>
        /// <returns>Returns byte[] representing the FriendlyName field</returns>
        public byte[] GetFriendlyName()
        {
            byte[] data = (byte[])GetFieldValue(0, 0, Fit.SubfieldIndexMainField);
            return data.Take(data.Length - 1).ToArray();
        }

        ///<summary>
        /// Retrieves the FriendlyName field
        /// Comment: Used for Morning Report greeting</summary>
        /// <returns>Returns String representing the FriendlyName field</returns>
        public String GetFriendlyNameAsString()
        {
            byte[] data = (byte[])GetFieldValue(0, 0, Fit.SubfieldIndexMainField);
            return data != null ? Encoding.UTF8.GetString(data, 0, data.Length - 1) : null;
        }

        ///<summary>
        /// Set FriendlyName field
        /// Comment: Used for Morning Report greeting</summary>
        /// <param name="friendlyName_"> field value to be set</param>
        public void SetFriendlyName(String friendlyName_)
        {
            byte[] data = Encoding.UTF8.GetBytes(friendlyName_);
            byte[] zdata = new byte[data.Length + 1];
            data.CopyTo(zdata, 0);
            SetFieldValue(0, 0, zdata, Fit.SubfieldIndexMainField);
        }

        
        /// <summary>
        /// Set FriendlyName field
        /// Comment: Used for Morning Report greeting</summary>
        /// <param name="friendlyName_">field value to be set</param>
        public void SetFriendlyName(byte[] friendlyName_)
        {
            SetFieldValue(0, 0, friendlyName_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Gender field</summary>
        /// <returns>Returns nullable Gender enum representing the Gender field</returns>
        public Gender? GetGender()
        {
            object obj = GetFieldValue(1, 0, Fit.SubfieldIndexMainField);
            Gender? value = obj == null ? (Gender?)null : (Gender)obj;
            return value;
        }

        /// <summary>
        /// Set Gender field</summary>
        /// <param name="gender_">Nullable field value to be set</param>
        public void SetGender(Gender? gender_)
        {
            SetFieldValue(1, 0, gender_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Age field
        /// Units: years</summary>
        /// <returns>Returns nullable byte representing the Age field</returns>
        public byte? GetAge()
        {
            Object val = GetFieldValue(2, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToByte(val));
            
        }

        /// <summary>
        /// Set Age field
        /// Units: years</summary>
        /// <param name="age_">Nullable field value to be set</param>
        public void SetAge(byte? age_)
        {
            SetFieldValue(2, 0, age_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Height field
        /// Units: m</summary>
        /// <returns>Returns nullable float representing the Height field</returns>
        public float? GetHeight()
        {
            Object val = GetFieldValue(3, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set Height field
        /// Units: m</summary>
        /// <param name="height_">Nullable field value to be set</param>
        public void SetHeight(float? height_)
        {
            SetFieldValue(3, 0, height_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Weight field
        /// Units: kg</summary>
        /// <returns>Returns nullable float representing the Weight field</returns>
        public float? GetWeight()
        {
            Object val = GetFieldValue(4, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set Weight field
        /// Units: kg</summary>
        /// <param name="weight_">Nullable field value to be set</param>
        public void SetWeight(float? weight_)
        {
            SetFieldValue(4, 0, weight_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Language field</summary>
        /// <returns>Returns nullable Language enum representing the Language field</returns>
        public Language? GetLanguage()
        {
            object obj = GetFieldValue(5, 0, Fit.SubfieldIndexMainField);
            Language? value = obj == null ? (Language?)null : (Language)obj;
            return value;
        }

        /// <summary>
        /// Set Language field</summary>
        /// <param name="language_">Nullable field value to be set</param>
        public void SetLanguage(Language? language_)
        {
            SetFieldValue(5, 0, language_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the ElevSetting field</summary>
        /// <returns>Returns nullable DisplayMeasure enum representing the ElevSetting field</returns>
        public DisplayMeasure? GetElevSetting()
        {
            object obj = GetFieldValue(6, 0, Fit.SubfieldIndexMainField);
            DisplayMeasure? value = obj == null ? (DisplayMeasure?)null : (DisplayMeasure)obj;
            return value;
        }

        /// <summary>
        /// Set ElevSetting field</summary>
        /// <param name="elevSetting_">Nullable field value to be set</param>
        public void SetElevSetting(DisplayMeasure? elevSetting_)
        {
            SetFieldValue(6, 0, elevSetting_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the WeightSetting field</summary>
        /// <returns>Returns nullable DisplayMeasure enum representing the WeightSetting field</returns>
        public DisplayMeasure? GetWeightSetting()
        {
            object obj = GetFieldValue(7, 0, Fit.SubfieldIndexMainField);
            DisplayMeasure? value = obj == null ? (DisplayMeasure?)null : (DisplayMeasure)obj;
            return value;
        }

        /// <summary>
        /// Set WeightSetting field</summary>
        /// <param name="weightSetting_">Nullable field value to be set</param>
        public void SetWeightSetting(DisplayMeasure? weightSetting_)
        {
            SetFieldValue(7, 0, weightSetting_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the RestingHeartRate field
        /// Units: bpm</summary>
        /// <returns>Returns nullable byte representing the RestingHeartRate field</returns>
        public byte? GetRestingHeartRate()
        {
            Object val = GetFieldValue(8, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToByte(val));
            
        }

        /// <summary>
        /// Set RestingHeartRate field
        /// Units: bpm</summary>
        /// <param name="restingHeartRate_">Nullable field value to be set</param>
        public void SetRestingHeartRate(byte? restingHeartRate_)
        {
            SetFieldValue(8, 0, restingHeartRate_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the DefaultMaxRunningHeartRate field
        /// Units: bpm</summary>
        /// <returns>Returns nullable byte representing the DefaultMaxRunningHeartRate field</returns>
        public byte? GetDefaultMaxRunningHeartRate()
        {
            Object val = GetFieldValue(9, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToByte(val));
            
        }

        /// <summary>
        /// Set DefaultMaxRunningHeartRate field
        /// Units: bpm</summary>
        /// <param name="defaultMaxRunningHeartRate_">Nullable field value to be set</param>
        public void SetDefaultMaxRunningHeartRate(byte? defaultMaxRunningHeartRate_)
        {
            SetFieldValue(9, 0, defaultMaxRunningHeartRate_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the DefaultMaxBikingHeartRate field
        /// Units: bpm</summary>
        /// <returns>Returns nullable byte representing the DefaultMaxBikingHeartRate field</returns>
        public byte? GetDefaultMaxBikingHeartRate()
        {
            Object val = GetFieldValue(10, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToByte(val));
            
        }

        /// <summary>
        /// Set DefaultMaxBikingHeartRate field
        /// Units: bpm</summary>
        /// <param name="defaultMaxBikingHeartRate_">Nullable field value to be set</param>
        public void SetDefaultMaxBikingHeartRate(byte? defaultMaxBikingHeartRate_)
        {
            SetFieldValue(10, 0, defaultMaxBikingHeartRate_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the DefaultMaxHeartRate field
        /// Units: bpm</summary>
        /// <returns>Returns nullable byte representing the DefaultMaxHeartRate field</returns>
        public byte? GetDefaultMaxHeartRate()
        {
            Object val = GetFieldValue(11, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToByte(val));
            
        }

        /// <summary>
        /// Set DefaultMaxHeartRate field
        /// Units: bpm</summary>
        /// <param name="defaultMaxHeartRate_">Nullable field value to be set</param>
        public void SetDefaultMaxHeartRate(byte? defaultMaxHeartRate_)
        {
            SetFieldValue(11, 0, defaultMaxHeartRate_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the HrSetting field</summary>
        /// <returns>Returns nullable DisplayHeart enum representing the HrSetting field</returns>
        public DisplayHeart? GetHrSetting()
        {
            object obj = GetFieldValue(12, 0, Fit.SubfieldIndexMainField);
            DisplayHeart? value = obj == null ? (DisplayHeart?)null : (DisplayHeart)obj;
            return value;
        }

        /// <summary>
        /// Set HrSetting field</summary>
        /// <param name="hrSetting_">Nullable field value to be set</param>
        public void SetHrSetting(DisplayHeart? hrSetting_)
        {
            SetFieldValue(12, 0, hrSetting_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the SpeedSetting field</summary>
        /// <returns>Returns nullable DisplayMeasure enum representing the SpeedSetting field</returns>
        public DisplayMeasure? GetSpeedSetting()
        {
            object obj = GetFieldValue(13, 0, Fit.SubfieldIndexMainField);
            DisplayMeasure? value = obj == null ? (DisplayMeasure?)null : (DisplayMeasure)obj;
            return value;
        }

        /// <summary>
        /// Set SpeedSetting field</summary>
        /// <param name="speedSetting_">Nullable field value to be set</param>
        public void SetSpeedSetting(DisplayMeasure? speedSetting_)
        {
            SetFieldValue(13, 0, speedSetting_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the DistSetting field</summary>
        /// <returns>Returns nullable DisplayMeasure enum representing the DistSetting field</returns>
        public DisplayMeasure? GetDistSetting()
        {
            object obj = GetFieldValue(14, 0, Fit.SubfieldIndexMainField);
            DisplayMeasure? value = obj == null ? (DisplayMeasure?)null : (DisplayMeasure)obj;
            return value;
        }

        /// <summary>
        /// Set DistSetting field</summary>
        /// <param name="distSetting_">Nullable field value to be set</param>
        public void SetDistSetting(DisplayMeasure? distSetting_)
        {
            SetFieldValue(14, 0, distSetting_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the PowerSetting field</summary>
        /// <returns>Returns nullable DisplayPower enum representing the PowerSetting field</returns>
        public DisplayPower? GetPowerSetting()
        {
            object obj = GetFieldValue(16, 0, Fit.SubfieldIndexMainField);
            DisplayPower? value = obj == null ? (DisplayPower?)null : (DisplayPower)obj;
            return value;
        }

        /// <summary>
        /// Set PowerSetting field</summary>
        /// <param name="powerSetting_">Nullable field value to be set</param>
        public void SetPowerSetting(DisplayPower? powerSetting_)
        {
            SetFieldValue(16, 0, powerSetting_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the ActivityClass field</summary>
        /// <returns>Returns nullable ActivityClass enum representing the ActivityClass field</returns>
        public ActivityClass? GetActivityClass()
        {
            object obj = GetFieldValue(17, 0, Fit.SubfieldIndexMainField);
            ActivityClass? value = obj == null ? (ActivityClass?)null : (ActivityClass)obj;
            return value;
        }

        /// <summary>
        /// Set ActivityClass field</summary>
        /// <param name="activityClass_">Nullable field value to be set</param>
        public void SetActivityClass(ActivityClass? activityClass_)
        {
            SetFieldValue(17, 0, activityClass_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the PositionSetting field</summary>
        /// <returns>Returns nullable DisplayPosition enum representing the PositionSetting field</returns>
        public DisplayPosition? GetPositionSetting()
        {
            object obj = GetFieldValue(18, 0, Fit.SubfieldIndexMainField);
            DisplayPosition? value = obj == null ? (DisplayPosition?)null : (DisplayPosition)obj;
            return value;
        }

        /// <summary>
        /// Set PositionSetting field</summary>
        /// <param name="positionSetting_">Nullable field value to be set</param>
        public void SetPositionSetting(DisplayPosition? positionSetting_)
        {
            SetFieldValue(18, 0, positionSetting_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the TemperatureSetting field</summary>
        /// <returns>Returns nullable DisplayMeasure enum representing the TemperatureSetting field</returns>
        public DisplayMeasure? GetTemperatureSetting()
        {
            object obj = GetFieldValue(21, 0, Fit.SubfieldIndexMainField);
            DisplayMeasure? value = obj == null ? (DisplayMeasure?)null : (DisplayMeasure)obj;
            return value;
        }

        /// <summary>
        /// Set TemperatureSetting field</summary>
        /// <param name="temperatureSetting_">Nullable field value to be set</param>
        public void SetTemperatureSetting(DisplayMeasure? temperatureSetting_)
        {
            SetFieldValue(21, 0, temperatureSetting_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the LocalId field</summary>
        /// <returns>Returns nullable ushort representing the LocalId field</returns>
        public ushort? GetLocalId()
        {
            Object val = GetFieldValue(22, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt16(val));
            
        }

        /// <summary>
        /// Set LocalId field</summary>
        /// <param name="localId_">Nullable field value to be set</param>
        public void SetLocalId(ushort? localId_)
        {
            SetFieldValue(22, 0, localId_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field GlobalId</returns>
        public int GetNumGlobalId()
        {
            return GetNumFieldValues(23, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the GlobalId field</summary>
        /// <param name="index">0 based index of GlobalId element to retrieve</param>
        /// <returns>Returns nullable byte representing the GlobalId field</returns>
        public byte? GetGlobalId(int index)
        {
            Object val = GetFieldValue(23, index, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToByte(val));
            
        }

        /// <summary>
        /// Set GlobalId field</summary>
        /// <param name="index">0 based index of global_id</param>
        /// <param name="globalId_">Nullable field value to be set</param>
        public void SetGlobalId(int index, byte? globalId_)
        {
            SetFieldValue(23, index, globalId_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the WakeTime field
        /// Comment: Typical wake time</summary>
        /// <returns>Returns nullable uint representing the WakeTime field</returns>
        public uint? GetWakeTime()
        {
            Object val = GetFieldValue(28, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt32(val));
            
        }

        /// <summary>
        /// Set WakeTime field
        /// Comment: Typical wake time</summary>
        /// <param name="wakeTime_">Nullable field value to be set</param>
        public void SetWakeTime(uint? wakeTime_)
        {
            SetFieldValue(28, 0, wakeTime_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the SleepTime field
        /// Comment: Typical bed time</summary>
        /// <returns>Returns nullable uint representing the SleepTime field</returns>
        public uint? GetSleepTime()
        {
            Object val = GetFieldValue(29, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt32(val));
            
        }

        /// <summary>
        /// Set SleepTime field
        /// Comment: Typical bed time</summary>
        /// <param name="sleepTime_">Nullable field value to be set</param>
        public void SetSleepTime(uint? sleepTime_)
        {
            SetFieldValue(29, 0, sleepTime_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the HeightSetting field</summary>
        /// <returns>Returns nullable DisplayMeasure enum representing the HeightSetting field</returns>
        public DisplayMeasure? GetHeightSetting()
        {
            object obj = GetFieldValue(30, 0, Fit.SubfieldIndexMainField);
            DisplayMeasure? value = obj == null ? (DisplayMeasure?)null : (DisplayMeasure)obj;
            return value;
        }

        /// <summary>
        /// Set HeightSetting field</summary>
        /// <param name="heightSetting_">Nullable field value to be set</param>
        public void SetHeightSetting(DisplayMeasure? heightSetting_)
        {
            SetFieldValue(30, 0, heightSetting_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the UserRunningStepLength field
        /// Units: m
        /// Comment: User defined running step length set to 0 for auto length</summary>
        /// <returns>Returns nullable float representing the UserRunningStepLength field</returns>
        public float? GetUserRunningStepLength()
        {
            Object val = GetFieldValue(31, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set UserRunningStepLength field
        /// Units: m
        /// Comment: User defined running step length set to 0 for auto length</summary>
        /// <param name="userRunningStepLength_">Nullable field value to be set</param>
        public void SetUserRunningStepLength(float? userRunningStepLength_)
        {
            SetFieldValue(31, 0, userRunningStepLength_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the UserWalkingStepLength field
        /// Units: m
        /// Comment: User defined walking step length set to 0 for auto length</summary>
        /// <returns>Returns nullable float representing the UserWalkingStepLength field</returns>
        public float? GetUserWalkingStepLength()
        {
            Object val = GetFieldValue(32, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set UserWalkingStepLength field
        /// Units: m
        /// Comment: User defined walking step length set to 0 for auto length</summary>
        /// <param name="userWalkingStepLength_">Nullable field value to be set</param>
        public void SetUserWalkingStepLength(float? userWalkingStepLength_)
        {
            SetFieldValue(32, 0, userWalkingStepLength_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the DepthSetting field</summary>
        /// <returns>Returns nullable DisplayMeasure enum representing the DepthSetting field</returns>
        public DisplayMeasure? GetDepthSetting()
        {
            object obj = GetFieldValue(47, 0, Fit.SubfieldIndexMainField);
            DisplayMeasure? value = obj == null ? (DisplayMeasure?)null : (DisplayMeasure)obj;
            return value;
        }

        /// <summary>
        /// Set DepthSetting field</summary>
        /// <param name="depthSetting_">Nullable field value to be set</param>
        public void SetDepthSetting(DisplayMeasure? depthSetting_)
        {
            SetFieldValue(47, 0, depthSetting_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the DiveCount field</summary>
        /// <returns>Returns nullable uint representing the DiveCount field</returns>
        public uint? GetDiveCount()
        {
            Object val = GetFieldValue(49, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt32(val));
            
        }

        /// <summary>
        /// Set DiveCount field</summary>
        /// <param name="diveCount_">Nullable field value to be set</param>
        public void SetDiveCount(uint? diveCount_)
        {
            SetFieldValue(49, 0, diveCount_, Fit.SubfieldIndexMainField);
        }
        
        #endregion // Methods
    } // Class
} // namespace
