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
    /// Implements the DiveSummary profile message.
    /// </summary>
    public class DiveSummaryMesg : Mesg
    {
        #region Fields
        #endregion

        /// <summary>
        /// Field Numbers for <see cref="DiveSummaryMesg"/>
        /// </summary>
        public sealed class FieldDefNum
        {
            public const byte Timestamp = 253;
            public const byte ReferenceMesg = 0;
            public const byte ReferenceIndex = 1;
            public const byte AvgDepth = 2;
            public const byte MaxDepth = 3;
            public const byte SurfaceInterval = 4;
            public const byte StartCns = 5;
            public const byte EndCns = 6;
            public const byte StartN2 = 7;
            public const byte EndN2 = 8;
            public const byte O2Toxicity = 9;
            public const byte DiveNumber = 10;
            public const byte BottomTime = 11;
            public const byte AvgPressureSac = 12;
            public const byte AvgVolumeSac = 13;
            public const byte AvgRmv = 14;
            public const byte DescentTime = 15;
            public const byte AscentTime = 16;
            public const byte AvgAscentRate = 17;
            public const byte AvgDescentRate = 22;
            public const byte MaxAscentRate = 23;
            public const byte MaxDescentRate = 24;
            public const byte HangTime = 25;
            public const byte Invalid = Fit.FieldNumInvalid;
        }

        #region Constructors
        public DiveSummaryMesg() : base(Profile.GetMesg(MesgNum.DiveSummary))
        {
        }

        public DiveSummaryMesg(Mesg mesg) : base(mesg)
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
        /// Retrieves the ReferenceMesg field</summary>
        /// <returns>Returns nullable ushort representing the ReferenceMesg field</returns>
        public ushort? GetReferenceMesg()
        {
            Object val = GetFieldValue(0, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt16(val));
            
        }

        /// <summary>
        /// Set ReferenceMesg field</summary>
        /// <param name="referenceMesg_">Nullable field value to be set</param>
        public void SetReferenceMesg(ushort? referenceMesg_)
        {
            SetFieldValue(0, 0, referenceMesg_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the ReferenceIndex field</summary>
        /// <returns>Returns nullable ushort representing the ReferenceIndex field</returns>
        public ushort? GetReferenceIndex()
        {
            Object val = GetFieldValue(1, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt16(val));
            
        }

        /// <summary>
        /// Set ReferenceIndex field</summary>
        /// <param name="referenceIndex_">Nullable field value to be set</param>
        public void SetReferenceIndex(ushort? referenceIndex_)
        {
            SetFieldValue(1, 0, referenceIndex_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the AvgDepth field
        /// Units: m
        /// Comment: 0 if above water</summary>
        /// <returns>Returns nullable float representing the AvgDepth field</returns>
        public float? GetAvgDepth()
        {
            Object val = GetFieldValue(2, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set AvgDepth field
        /// Units: m
        /// Comment: 0 if above water</summary>
        /// <param name="avgDepth_">Nullable field value to be set</param>
        public void SetAvgDepth(float? avgDepth_)
        {
            SetFieldValue(2, 0, avgDepth_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the MaxDepth field
        /// Units: m
        /// Comment: 0 if above water</summary>
        /// <returns>Returns nullable float representing the MaxDepth field</returns>
        public float? GetMaxDepth()
        {
            Object val = GetFieldValue(3, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set MaxDepth field
        /// Units: m
        /// Comment: 0 if above water</summary>
        /// <param name="maxDepth_">Nullable field value to be set</param>
        public void SetMaxDepth(float? maxDepth_)
        {
            SetFieldValue(3, 0, maxDepth_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the SurfaceInterval field
        /// Units: s
        /// Comment: Time since end of last dive</summary>
        /// <returns>Returns nullable uint representing the SurfaceInterval field</returns>
        public uint? GetSurfaceInterval()
        {
            Object val = GetFieldValue(4, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt32(val));
            
        }

        /// <summary>
        /// Set SurfaceInterval field
        /// Units: s
        /// Comment: Time since end of last dive</summary>
        /// <param name="surfaceInterval_">Nullable field value to be set</param>
        public void SetSurfaceInterval(uint? surfaceInterval_)
        {
            SetFieldValue(4, 0, surfaceInterval_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the StartCns field
        /// Units: percent</summary>
        /// <returns>Returns nullable byte representing the StartCns field</returns>
        public byte? GetStartCns()
        {
            Object val = GetFieldValue(5, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToByte(val));
            
        }

        /// <summary>
        /// Set StartCns field
        /// Units: percent</summary>
        /// <param name="startCns_">Nullable field value to be set</param>
        public void SetStartCns(byte? startCns_)
        {
            SetFieldValue(5, 0, startCns_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the EndCns field
        /// Units: percent</summary>
        /// <returns>Returns nullable byte representing the EndCns field</returns>
        public byte? GetEndCns()
        {
            Object val = GetFieldValue(6, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToByte(val));
            
        }

        /// <summary>
        /// Set EndCns field
        /// Units: percent</summary>
        /// <param name="endCns_">Nullable field value to be set</param>
        public void SetEndCns(byte? endCns_)
        {
            SetFieldValue(6, 0, endCns_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the StartN2 field
        /// Units: percent</summary>
        /// <returns>Returns nullable ushort representing the StartN2 field</returns>
        public ushort? GetStartN2()
        {
            Object val = GetFieldValue(7, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt16(val));
            
        }

        /// <summary>
        /// Set StartN2 field
        /// Units: percent</summary>
        /// <param name="startN2_">Nullable field value to be set</param>
        public void SetStartN2(ushort? startN2_)
        {
            SetFieldValue(7, 0, startN2_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the EndN2 field
        /// Units: percent</summary>
        /// <returns>Returns nullable ushort representing the EndN2 field</returns>
        public ushort? GetEndN2()
        {
            Object val = GetFieldValue(8, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt16(val));
            
        }

        /// <summary>
        /// Set EndN2 field
        /// Units: percent</summary>
        /// <param name="endN2_">Nullable field value to be set</param>
        public void SetEndN2(ushort? endN2_)
        {
            SetFieldValue(8, 0, endN2_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the O2Toxicity field
        /// Units: OTUs</summary>
        /// <returns>Returns nullable ushort representing the O2Toxicity field</returns>
        public ushort? GetO2Toxicity()
        {
            Object val = GetFieldValue(9, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt16(val));
            
        }

        /// <summary>
        /// Set O2Toxicity field
        /// Units: OTUs</summary>
        /// <param name="o2Toxicity_">Nullable field value to be set</param>
        public void SetO2Toxicity(ushort? o2Toxicity_)
        {
            SetFieldValue(9, 0, o2Toxicity_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the DiveNumber field</summary>
        /// <returns>Returns nullable uint representing the DiveNumber field</returns>
        public uint? GetDiveNumber()
        {
            Object val = GetFieldValue(10, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt32(val));
            
        }

        /// <summary>
        /// Set DiveNumber field</summary>
        /// <param name="diveNumber_">Nullable field value to be set</param>
        public void SetDiveNumber(uint? diveNumber_)
        {
            SetFieldValue(10, 0, diveNumber_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the BottomTime field
        /// Units: s</summary>
        /// <returns>Returns nullable float representing the BottomTime field</returns>
        public float? GetBottomTime()
        {
            Object val = GetFieldValue(11, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set BottomTime field
        /// Units: s</summary>
        /// <param name="bottomTime_">Nullable field value to be set</param>
        public void SetBottomTime(float? bottomTime_)
        {
            SetFieldValue(11, 0, bottomTime_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the AvgPressureSac field
        /// Units: bar/min
        /// Comment: Average pressure-based surface air consumption</summary>
        /// <returns>Returns nullable float representing the AvgPressureSac field</returns>
        public float? GetAvgPressureSac()
        {
            Object val = GetFieldValue(12, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set AvgPressureSac field
        /// Units: bar/min
        /// Comment: Average pressure-based surface air consumption</summary>
        /// <param name="avgPressureSac_">Nullable field value to be set</param>
        public void SetAvgPressureSac(float? avgPressureSac_)
        {
            SetFieldValue(12, 0, avgPressureSac_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the AvgVolumeSac field
        /// Units: L/min
        /// Comment: Average volumetric surface air consumption</summary>
        /// <returns>Returns nullable float representing the AvgVolumeSac field</returns>
        public float? GetAvgVolumeSac()
        {
            Object val = GetFieldValue(13, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set AvgVolumeSac field
        /// Units: L/min
        /// Comment: Average volumetric surface air consumption</summary>
        /// <param name="avgVolumeSac_">Nullable field value to be set</param>
        public void SetAvgVolumeSac(float? avgVolumeSac_)
        {
            SetFieldValue(13, 0, avgVolumeSac_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the AvgRmv field
        /// Units: L/min
        /// Comment: Average respiratory minute volume</summary>
        /// <returns>Returns nullable float representing the AvgRmv field</returns>
        public float? GetAvgRmv()
        {
            Object val = GetFieldValue(14, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set AvgRmv field
        /// Units: L/min
        /// Comment: Average respiratory minute volume</summary>
        /// <param name="avgRmv_">Nullable field value to be set</param>
        public void SetAvgRmv(float? avgRmv_)
        {
            SetFieldValue(14, 0, avgRmv_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the DescentTime field
        /// Units: s
        /// Comment: Time to reach deepest level stop</summary>
        /// <returns>Returns nullable float representing the DescentTime field</returns>
        public float? GetDescentTime()
        {
            Object val = GetFieldValue(15, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set DescentTime field
        /// Units: s
        /// Comment: Time to reach deepest level stop</summary>
        /// <param name="descentTime_">Nullable field value to be set</param>
        public void SetDescentTime(float? descentTime_)
        {
            SetFieldValue(15, 0, descentTime_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the AscentTime field
        /// Units: s
        /// Comment: Time after leaving bottom until reaching surface</summary>
        /// <returns>Returns nullable float representing the AscentTime field</returns>
        public float? GetAscentTime()
        {
            Object val = GetFieldValue(16, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set AscentTime field
        /// Units: s
        /// Comment: Time after leaving bottom until reaching surface</summary>
        /// <param name="ascentTime_">Nullable field value to be set</param>
        public void SetAscentTime(float? ascentTime_)
        {
            SetFieldValue(16, 0, ascentTime_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the AvgAscentRate field
        /// Units: m/s
        /// Comment: Average ascent rate, not including descents or stops</summary>
        /// <returns>Returns nullable float representing the AvgAscentRate field</returns>
        public float? GetAvgAscentRate()
        {
            Object val = GetFieldValue(17, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set AvgAscentRate field
        /// Units: m/s
        /// Comment: Average ascent rate, not including descents or stops</summary>
        /// <param name="avgAscentRate_">Nullable field value to be set</param>
        public void SetAvgAscentRate(float? avgAscentRate_)
        {
            SetFieldValue(17, 0, avgAscentRate_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the AvgDescentRate field
        /// Units: m/s
        /// Comment: Average descent rate, not including ascents or stops</summary>
        /// <returns>Returns nullable float representing the AvgDescentRate field</returns>
        public float? GetAvgDescentRate()
        {
            Object val = GetFieldValue(22, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set AvgDescentRate field
        /// Units: m/s
        /// Comment: Average descent rate, not including ascents or stops</summary>
        /// <param name="avgDescentRate_">Nullable field value to be set</param>
        public void SetAvgDescentRate(float? avgDescentRate_)
        {
            SetFieldValue(22, 0, avgDescentRate_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the MaxAscentRate field
        /// Units: m/s
        /// Comment: Maximum ascent rate</summary>
        /// <returns>Returns nullable float representing the MaxAscentRate field</returns>
        public float? GetMaxAscentRate()
        {
            Object val = GetFieldValue(23, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set MaxAscentRate field
        /// Units: m/s
        /// Comment: Maximum ascent rate</summary>
        /// <param name="maxAscentRate_">Nullable field value to be set</param>
        public void SetMaxAscentRate(float? maxAscentRate_)
        {
            SetFieldValue(23, 0, maxAscentRate_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the MaxDescentRate field
        /// Units: m/s
        /// Comment: Maximum descent rate</summary>
        /// <returns>Returns nullable float representing the MaxDescentRate field</returns>
        public float? GetMaxDescentRate()
        {
            Object val = GetFieldValue(24, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set MaxDescentRate field
        /// Units: m/s
        /// Comment: Maximum descent rate</summary>
        /// <param name="maxDescentRate_">Nullable field value to be set</param>
        public void SetMaxDescentRate(float? maxDescentRate_)
        {
            SetFieldValue(24, 0, maxDescentRate_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the HangTime field
        /// Units: s
        /// Comment: Time spent neither ascending nor descending</summary>
        /// <returns>Returns nullable float representing the HangTime field</returns>
        public float? GetHangTime()
        {
            Object val = GetFieldValue(25, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set HangTime field
        /// Units: s
        /// Comment: Time spent neither ascending nor descending</summary>
        /// <param name="hangTime_">Nullable field value to be set</param>
        public void SetHangTime(float? hangTime_)
        {
            SetFieldValue(25, 0, hangTime_, Fit.SubfieldIndexMainField);
        }
        
        #endregion // Methods
    } // Class
} // namespace
