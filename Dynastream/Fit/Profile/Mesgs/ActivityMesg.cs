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
	/// Implements the Activity profile message.
	/// </summary>
	public class ActivityMesg : Mesg
	{
		#region Fields
		#endregion

		/// <summary>
		/// Field Numbers for <see cref="ActivityMesg"/>
		/// </summary>
		public sealed class FieldDefNum
		{
			public const byte Timestamp = 253;
			public const byte TotalTimerTime = 0;
			public const byte NumSessions = 1;
			public const byte Type = 2;
			public const byte Event = 3;
			public const byte EventType = 4;
			public const byte LocalTimestamp = 5;
			public const byte EventGroup = 6;
			public const byte Invalid = Fit.FieldNumInvalid;
		}

		#region Constructors
		public ActivityMesg() : base(Profile.GetMesg(MesgNum.Activity))
		{
		}

		public ActivityMesg(Mesg mesg) : base(mesg)
		{
		}
		#endregion // Constructors

		#region Methods
		///<summary>
		/// Retrieves the Timestamp field</summary>
		/// <returns>Returns DateTime representing the Timestamp field</returns>
		public DateTime Timestamp
		{
			get
			{
				Object val = GetFieldValue(253, 0, Fit.SubfieldIndexMainField);
				if (val == null)
				{
					return null;
				}

				return TimestampToDateTime(Convert.ToUInt32(val));

			}
			set
			{
				SetFieldValue(253, 0, value.GetTimeStamp(), Fit.SubfieldIndexMainField);
			}
		}

		///<summary>
		/// Retrieves the TotalTimerTime field
		/// Units: s
		/// Comment: Exclude pauses</summary>
		/// <returns>Returns nullable float representing the TotalTimerTime field</returns>
		public float? TotalTimerTime
		{
			get
			{
				Object val = GetFieldValue(0, 0, Fit.SubfieldIndexMainField);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToSingle(val));

			}
			set
			{
				SetFieldValue(0, 0, value, Fit.SubfieldIndexMainField);
			}
		}

		///<summary>
		/// Retrieves the NumSessions field</summary>
		/// <returns>Returns nullable ushort representing the NumSessions field</returns>
		public ushort? NumSessions
		{
			get
			{
				Object val = GetFieldValue(1, 0, Fit.SubfieldIndexMainField);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToUInt16(val));

			}
			set
			{
				SetFieldValue(1, 0, value, Fit.SubfieldIndexMainField);
			}
		}

		///<summary>
		/// Retrieves the Type field</summary>
		/// <returns>Returns nullable Activity enum representing the Type field</returns>
		public Activity? Type
		{
			get
			{
				object obj = GetFieldValue(2, 0, Fit.SubfieldIndexMainField);
				Activity? value = obj == null ? (Activity?)null : (Activity)obj;
				return value;
			}
			set
			{
				SetFieldValue(2, 0, value, Fit.SubfieldIndexMainField);
			}
		}

		///<summary>
		/// Retrieves the Event field</summary>
		/// <returns>Returns nullable Event enum representing the Event field</returns>
		public Event? Event
		{
			get
			{
				object obj = GetFieldValue(3, 0, Fit.SubfieldIndexMainField);
				Event? value = obj == null ? (Event?)null : (Event)obj;
				return value;
			}
			set
			{
				SetFieldValue(3, 0, value, Fit.SubfieldIndexMainField);
			}
		}

		///<summary>
		/// Retrieves the EventType field</summary>
		/// <returns>Returns nullable EventType enum representing the EventType field</returns>
		public EventType? EventType
		{
			get
			{
				object obj = GetFieldValue(4, 0, Fit.SubfieldIndexMainField);
				EventType? value = obj == null ? (EventType?)null : (EventType)obj;
				return value;
			}
			set
			{
				SetFieldValue(4, 0, value, Fit.SubfieldIndexMainField);
			}
		}

		///<summary>
		/// Retrieves the LocalTimestamp field
		/// Comment: timestamp epoch expressed in local time, used to convert activity timestamps to local time</summary>
		/// <returns>Returns nullable uint representing the LocalTimestamp field</returns>
		public uint? LocalTimestamp
		{
			get
			{
				Object val = GetFieldValue(5, 0, Fit.SubfieldIndexMainField);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToUInt32(val));

			}
			set
			{
				SetFieldValue(5, 0, value, Fit.SubfieldIndexMainField);
			}
		}

		///<summary>
		/// Retrieves the EventGroup field</summary>
		/// <returns>Returns nullable byte representing the EventGroup field</returns>
		public byte? EventGroup
		{
			get
			{
				Object val = GetFieldValue(6, 0, Fit.SubfieldIndexMainField);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToByte(val));

			}
			set
			{
				SetFieldValue(6, 0, value, Fit.SubfieldIndexMainField);
			}
		}

		#endregion // Methods
	} // Class
} // namespace
