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
			public const byte MessageIndex = 254;
			public const byte SplitType = 0;
			public const byte TotalElapsedTime = 1;
			public const byte TotalTimerTime = 2;
			public const byte TotalDistance = 3;
			public const byte AvgSpeed = 4;
			public const byte StartTime = 9;
			public const byte TotalAscent = 13;
			public const byte TotalDescent = 14;
			public const byte StartPositionLat = 21;
			public const byte StartPositionLong = 22;
			public const byte EndPositionLat = 23;
			public const byte EndPositionLong = 24;
			public const byte MaxSpeed = 25;
			public const byte AvgVertSpeed = 26;
			public const byte EndTime = 27;
			public const byte TotalCalories = 28;
			public const byte StartElevation = 74;
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
		/// Retrieves the TotalElapsedTime field
		/// Units: s</summary>
		/// <returns>Returns nullable float representing the TotalElapsedTime field</returns>
		public float? TotalElapsedTime
		{
			get
			{
				Object val = GetFieldValue(1, 0, Fit.SubfieldIndexMainField);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToSingle(val));

			}
			set
			{
				SetFieldValue(1, 0, value, Fit.SubfieldIndexMainField);
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
				Object val = GetFieldValue(2, 0, Fit.SubfieldIndexMainField);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToSingle(val));

			}
			set
			{
				SetFieldValue(2, 0, value, Fit.SubfieldIndexMainField);
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
				Object val = GetFieldValue(3, 0, Fit.SubfieldIndexMainField);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToSingle(val));

			}
			set
			{
				SetFieldValue(3, 0, value, Fit.SubfieldIndexMainField);
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
		/// Retrieves the StartTime field</summary>
		/// <returns>Returns DateTime representing the StartTime field</returns>
		public DateTime StartTime
		{
			get
			{
				Object val = GetFieldValue(9, 0, Fit.SubfieldIndexMainField);
				if (val == null)
				{
					return null;
				}

				return TimestampToDateTime(Convert.ToUInt32(val));

			}
			set
			{
				SetFieldValue(9, 0, value.GetTimeStamp(), Fit.SubfieldIndexMainField);
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
				Object val = GetFieldValue(13, 0, Fit.SubfieldIndexMainField);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToUInt16(val));

			}
			set
			{
				SetFieldValue(13, 0, value, Fit.SubfieldIndexMainField);
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
				Object val = GetFieldValue(14, 0, Fit.SubfieldIndexMainField);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToUInt16(val));

			}
			set
			{
				SetFieldValue(14, 0, value, Fit.SubfieldIndexMainField);
			}
		}

		///<summary>
		/// Retrieves the StartPositionLat field
		/// Units: semicircles</summary>
		/// <returns>Returns nullable int representing the StartPositionLat field</returns>
		public int? StartPositionLat
		{
			get
			{
				Object val = GetFieldValue(21, 0, Fit.SubfieldIndexMainField);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToInt32(val));

			}
			set
			{
				SetFieldValue(21, 0, value, Fit.SubfieldIndexMainField);
			}
		}

		///<summary>
		/// Retrieves the StartPositionLong field
		/// Units: semicircles</summary>
		/// <returns>Returns nullable int representing the StartPositionLong field</returns>
		public int? StartPositionLong
		{
			get
			{
				Object val = GetFieldValue(22, 0, Fit.SubfieldIndexMainField);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToInt32(val));

			}
			set
			{
				SetFieldValue(22, 0, value, Fit.SubfieldIndexMainField);
			}
		}

		///<summary>
		/// Retrieves the EndPositionLat field
		/// Units: semicircles</summary>
		/// <returns>Returns nullable int representing the EndPositionLat field</returns>
		public int? EndPositionLat
		{
			get
			{
				Object val = GetFieldValue(23, 0, Fit.SubfieldIndexMainField);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToInt32(val));

			}
			set
			{
				SetFieldValue(23, 0, value, Fit.SubfieldIndexMainField);
			}
		}

		///<summary>
		/// Retrieves the EndPositionLong field
		/// Units: semicircles</summary>
		/// <returns>Returns nullable int representing the EndPositionLong field</returns>
		public int? EndPositionLong
		{
			get
			{
				Object val = GetFieldValue(24, 0, Fit.SubfieldIndexMainField);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToInt32(val));

			}
			set
			{
				SetFieldValue(24, 0, value, Fit.SubfieldIndexMainField);
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
				Object val = GetFieldValue(25, 0, Fit.SubfieldIndexMainField);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToSingle(val));

			}
			set
			{
				SetFieldValue(25, 0, value, Fit.SubfieldIndexMainField);
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
				Object val = GetFieldValue(26, 0, Fit.SubfieldIndexMainField);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToSingle(val));

			}
			set
			{
				SetFieldValue(26, 0, value, Fit.SubfieldIndexMainField);
			}
		}

		///<summary>
		/// Retrieves the EndTime field</summary>
		/// <returns>Returns DateTime representing the EndTime field</returns>
		public DateTime EndTime
		{
			get
			{
				Object val = GetFieldValue(27, 0, Fit.SubfieldIndexMainField);
				if (val == null)
				{
					return null;
				}

				return TimestampToDateTime(Convert.ToUInt32(val));

			}
			set
			{
				SetFieldValue(27, 0, value.GetTimeStamp(), Fit.SubfieldIndexMainField);
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
				Object val = GetFieldValue(28, 0, Fit.SubfieldIndexMainField);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToUInt32(val));

			}
			set
			{
				SetFieldValue(28, 0, value, Fit.SubfieldIndexMainField);
			}
		}

		///<summary>
		/// Retrieves the StartElevation field
		/// Units: m</summary>
		/// <returns>Returns nullable float representing the StartElevation field</returns>
		public float? StartElevation
		{
			get
			{
				Object val = GetFieldValue(74, 0, Fit.SubfieldIndexMainField);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToSingle(val));

			}
			set
			{
				SetFieldValue(74, 0, value, Fit.SubfieldIndexMainField);
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
				Object val = GetFieldValue(110, 0, Fit.SubfieldIndexMainField);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToSingle(val));

			}
			set
			{
				SetFieldValue(110, 0, value, Fit.SubfieldIndexMainField);
			}
		}

		#endregion // Methods
	} // Class
} // namespace
