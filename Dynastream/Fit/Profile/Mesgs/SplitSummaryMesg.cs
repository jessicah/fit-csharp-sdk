#region Copyright
/////////////////////////////////////////////////////////////////////////////////////////////
// Copyright 2024 Garmin International, Inc.
// Licensed under the Flexible and Interoperable Data Transfer (FIT) Protocol License; you
// may not use this file except in compliance with the Flexible and Interoperable Data
// Transfer (FIT) Protocol License.
/////////////////////////////////////////////////////////////////////////////////////////////
// ****WARNING****  This file is auto-generated!  Do NOT edit this file.
// Profile Version = 21.158.0Release
// Tag = production/release/21.158.0-0-gc9428aa
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
	/// Implements the SplitSummary profile message.
	/// </summary>
	public class SplitSummaryMesg : Mesg
	{
		#region Fields
		#endregion

		/// <summary>
		/// Field Numbers for <see cref="SplitSummaryMesg"/>
		/// </summary>
		public sealed class FieldDefNum
		{
			public const byte MessageIndex = 254;
			public const byte SplitType = 0;
			public const byte NumSplits = 3;
			public const byte TotalTimerTime = 4;
			public const byte TotalDistance = 5;
			public const byte AvgSpeed = 6;
			public const byte MaxSpeed = 7;
			public const byte TotalAscent = 8;
			public const byte TotalDescent = 9;
			public const byte AvgHeartRate = 10;
			public const byte MaxHeartRate = 11;
			public const byte AvgVertSpeed = 12;
			public const byte TotalCalories = 13;
			public const byte TotalMovingTime = 77;
			public const byte Invalid = Fit.FieldNumInvalid;
		}

		#region Constructors
		public SplitSummaryMesg() : base(Profile.GetMesg(MesgNum.SplitSummary))
		{
		}

		public SplitSummaryMesg(Mesg mesg) : base(mesg)
		{
		}
		#endregion // Constructors

		#region Methods
		///<summary>
		/// Retrieves the MessageIndex field</summary>
		/// <returns>Returns nullable ushort representing the MessageIndex field</returns>
		public ushort? MessageIndex
		{
			get
			{
				Object val = GetFieldValue(254, 0, Fit.SubfieldIndexMainField);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToUInt16(val));

			}
			set
			{
				SetFieldValue(254, 0, value, Fit.SubfieldIndexMainField);
			}
		}

		///<summary>
		/// Retrieves the SplitType field</summary>
		/// <returns>Returns nullable SplitType enum representing the SplitType field</returns>
		public SplitType? SplitType
		{
			get
			{
				object obj = GetFieldValue(0, 0, Fit.SubfieldIndexMainField);
				SplitType? value = obj == null ? (SplitType?)null : (SplitType)obj;
				return value;
			}
			set
			{
				SetFieldValue(0, 0, value, Fit.SubfieldIndexMainField);
			}
		}

		///<summary>
		/// Retrieves the NumSplits field</summary>
		/// <returns>Returns nullable ushort representing the NumSplits field</returns>
		public ushort? NumSplits
		{
			get
			{
				Object val = GetFieldValue(3, 0, Fit.SubfieldIndexMainField);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToUInt16(val));

			}
			set
			{
				SetFieldValue(3, 0, value, Fit.SubfieldIndexMainField);
			}
		}

		///<summary>
		/// Retrieves the TotalTimerTime field
		/// Units: s</summary>
		/// <returns>Returns nullable float representing the TotalTimerTime field</returns>
		public float? TotalTimerTime
		{
			get
			{
				Object val = GetFieldValue(4, 0, Fit.SubfieldIndexMainField);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToSingle(val));

			}
			set
			{
				SetFieldValue(4, 0, value, Fit.SubfieldIndexMainField);
			}
		}

		///<summary>
		/// Retrieves the TotalDistance field
		/// Units: m</summary>
		/// <returns>Returns nullable float representing the TotalDistance field</returns>
		public float? TotalDistance
		{
			get
			{
				Object val = GetFieldValue(5, 0, Fit.SubfieldIndexMainField);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToSingle(val));

			}
			set
			{
				SetFieldValue(5, 0, value, Fit.SubfieldIndexMainField);
			}
		}

		///<summary>
		/// Retrieves the AvgSpeed field
		/// Units: m/s</summary>
		/// <returns>Returns nullable float representing the AvgSpeed field</returns>
		public float? AvgSpeed
		{
			get
			{
				Object val = GetFieldValue(6, 0, Fit.SubfieldIndexMainField);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToSingle(val));

			}
			set
			{
				SetFieldValue(6, 0, value, Fit.SubfieldIndexMainField);
			}
		}

		///<summary>
		/// Retrieves the MaxSpeed field
		/// Units: m/s</summary>
		/// <returns>Returns nullable float representing the MaxSpeed field</returns>
		public float? MaxSpeed
		{
			get
			{
				Object val = GetFieldValue(7, 0, Fit.SubfieldIndexMainField);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToSingle(val));

			}
			set
			{
				SetFieldValue(7, 0, value, Fit.SubfieldIndexMainField);
			}
		}

		///<summary>
		/// Retrieves the TotalAscent field
		/// Units: m</summary>
		/// <returns>Returns nullable ushort representing the TotalAscent field</returns>
		public ushort? TotalAscent
		{
			get
			{
				Object val = GetFieldValue(8, 0, Fit.SubfieldIndexMainField);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToUInt16(val));

			}
			set
			{
				SetFieldValue(8, 0, value, Fit.SubfieldIndexMainField);
			}
		}

		///<summary>
		/// Retrieves the TotalDescent field
		/// Units: m</summary>
		/// <returns>Returns nullable ushort representing the TotalDescent field</returns>
		public ushort? TotalDescent
		{
			get
			{
				Object val = GetFieldValue(9, 0, Fit.SubfieldIndexMainField);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToUInt16(val));

			}
			set
			{
				SetFieldValue(9, 0, value, Fit.SubfieldIndexMainField);
			}
		}

		///<summary>
		/// Retrieves the AvgHeartRate field
		/// Units: bpm</summary>
		/// <returns>Returns nullable byte representing the AvgHeartRate field</returns>
		public byte? AvgHeartRate
		{
			get
			{
				Object val = GetFieldValue(10, 0, Fit.SubfieldIndexMainField);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToByte(val));

			}
			set
			{
				SetFieldValue(10, 0, value, Fit.SubfieldIndexMainField);
			}
		}

		///<summary>
		/// Retrieves the MaxHeartRate field
		/// Units: bpm</summary>
		/// <returns>Returns nullable byte representing the MaxHeartRate field</returns>
		public byte? MaxHeartRate
		{
			get
			{
				Object val = GetFieldValue(11, 0, Fit.SubfieldIndexMainField);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToByte(val));

			}
			set
			{
				SetFieldValue(11, 0, value, Fit.SubfieldIndexMainField);
			}
		}

		///<summary>
		/// Retrieves the AvgVertSpeed field
		/// Units: m/s</summary>
		/// <returns>Returns nullable float representing the AvgVertSpeed field</returns>
		public float? AvgVertSpeed
		{
			get
			{
				Object val = GetFieldValue(12, 0, Fit.SubfieldIndexMainField);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToSingle(val));

			}
			set
			{
				SetFieldValue(12, 0, value, Fit.SubfieldIndexMainField);
			}
		}

		///<summary>
		/// Retrieves the TotalCalories field
		/// Units: kcal</summary>
		/// <returns>Returns nullable uint representing the TotalCalories field</returns>
		public uint? TotalCalories
		{
			get
			{
				Object val = GetFieldValue(13, 0, Fit.SubfieldIndexMainField);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToUInt32(val));

			}
			set
			{
				SetFieldValue(13, 0, value, Fit.SubfieldIndexMainField);
			}
		}

		///<summary>
		/// Retrieves the TotalMovingTime field
		/// Units: s</summary>
		/// <returns>Returns nullable float representing the TotalMovingTime field</returns>
		public float? TotalMovingTime
		{
			get
			{
				Object val = GetFieldValue(77, 0, Fit.SubfieldIndexMainField);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToSingle(val));

			}
			set
			{
				SetFieldValue(77, 0, value, Fit.SubfieldIndexMainField);
			}
		}

		#endregion // Methods
	} // Class
} // namespace
