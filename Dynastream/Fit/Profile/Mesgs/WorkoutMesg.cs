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
    /// Implements the Workout profile message.
    /// </summary>
    public class WorkoutMesg : Mesg
    {
        #region Fields
        #endregion

        /// <summary>
        /// Field Numbers for <see cref="WorkoutMesg"/>
        /// </summary>
        public sealed class FieldDefNum
        {
            public const byte MessageIndex = 254;
            public const byte Sport = 4;
            public const byte Capabilities = 5;
            public const byte NumValidSteps = 6;
            public const byte WktName = 8;
            public const byte SubSport = 11;
            public const byte PoolLength = 14;
            public const byte PoolLengthUnit = 15;
            public const byte Invalid = Fit.FieldNumInvalid;
        }

        #region Constructors
        public WorkoutMesg() : base(Profile.GetMesg(MesgNum.Workout))
        {
        }

        public WorkoutMesg(Mesg mesg) : base(mesg)
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
        /// Retrieves the Sport field</summary>
        /// <returns>Returns nullable Sport enum representing the Sport field</returns>
        public Sport? GetSport()
        {
            object obj = GetFieldValue(4, 0, Fit.SubfieldIndexMainField);
            Sport? value = obj == null ? (Sport?)null : (Sport)obj;
            return value;
        }

        /// <summary>
        /// Set Sport field</summary>
        /// <param name="sport_">Nullable field value to be set</param>
        public void SetSport(Sport? sport_)
        {
            SetFieldValue(4, 0, sport_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Capabilities field</summary>
        /// <returns>Returns nullable uint representing the Capabilities field</returns>
        public uint? GetCapabilities()
        {
            Object val = GetFieldValue(5, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt32(val));
            
        }

        /// <summary>
        /// Set Capabilities field</summary>
        /// <param name="capabilities_">Nullable field value to be set</param>
        public void SetCapabilities(uint? capabilities_)
        {
            SetFieldValue(5, 0, capabilities_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the NumValidSteps field
        /// Comment: number of valid steps</summary>
        /// <returns>Returns nullable ushort representing the NumValidSteps field</returns>
        public ushort? GetNumValidSteps()
        {
            Object val = GetFieldValue(6, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt16(val));
            
        }

        /// <summary>
        /// Set NumValidSteps field
        /// Comment: number of valid steps</summary>
        /// <param name="numValidSteps_">Nullable field value to be set</param>
        public void SetNumValidSteps(ushort? numValidSteps_)
        {
            SetFieldValue(6, 0, numValidSteps_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the WktName field</summary>
        /// <returns>Returns byte[] representing the WktName field</returns>
        public byte[] GetWktName()
        {
            byte[] data = (byte[])GetFieldValue(8, 0, Fit.SubfieldIndexMainField);
            return data.Take(data.Length - 1).ToArray();
        }

        ///<summary>
        /// Retrieves the WktName field</summary>
        /// <returns>Returns String representing the WktName field</returns>
        public String GetWktNameAsString()
        {
            byte[] data = (byte[])GetFieldValue(8, 0, Fit.SubfieldIndexMainField);
            return data != null ? Encoding.UTF8.GetString(data, 0, data.Length - 1) : null;
        }

        ///<summary>
        /// Set WktName field</summary>
        /// <param name="wktName_"> field value to be set</param>
        public void SetWktName(String wktName_)
        {
            byte[] data = Encoding.UTF8.GetBytes(wktName_);
            byte[] zdata = new byte[data.Length + 1];
            data.CopyTo(zdata, 0);
            SetFieldValue(8, 0, zdata, Fit.SubfieldIndexMainField);
        }

        
        /// <summary>
        /// Set WktName field</summary>
        /// <param name="wktName_">field value to be set</param>
        public void SetWktName(byte[] wktName_)
        {
            SetFieldValue(8, 0, wktName_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the SubSport field</summary>
        /// <returns>Returns nullable SubSport enum representing the SubSport field</returns>
        public SubSport? GetSubSport()
        {
            object obj = GetFieldValue(11, 0, Fit.SubfieldIndexMainField);
            SubSport? value = obj == null ? (SubSport?)null : (SubSport)obj;
            return value;
        }

        /// <summary>
        /// Set SubSport field</summary>
        /// <param name="subSport_">Nullable field value to be set</param>
        public void SetSubSport(SubSport? subSport_)
        {
            SetFieldValue(11, 0, subSport_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the PoolLength field
        /// Units: m</summary>
        /// <returns>Returns nullable float representing the PoolLength field</returns>
        public float? GetPoolLength()
        {
            Object val = GetFieldValue(14, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set PoolLength field
        /// Units: m</summary>
        /// <param name="poolLength_">Nullable field value to be set</param>
        public void SetPoolLength(float? poolLength_)
        {
            SetFieldValue(14, 0, poolLength_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the PoolLengthUnit field</summary>
        /// <returns>Returns nullable DisplayMeasure enum representing the PoolLengthUnit field</returns>
        public DisplayMeasure? GetPoolLengthUnit()
        {
            object obj = GetFieldValue(15, 0, Fit.SubfieldIndexMainField);
            DisplayMeasure? value = obj == null ? (DisplayMeasure?)null : (DisplayMeasure)obj;
            return value;
        }

        /// <summary>
        /// Set PoolLengthUnit field</summary>
        /// <param name="poolLengthUnit_">Nullable field value to be set</param>
        public void SetPoolLengthUnit(DisplayMeasure? poolLengthUnit_)
        {
            SetFieldValue(15, 0, poolLengthUnit_, Fit.SubfieldIndexMainField);
        }
        
        #endregion // Methods
    } // Class
} // namespace
