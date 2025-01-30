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
	/// Implements the VideoClip profile message.
	/// </summary>
	public class VideoClipMesg : Mesg
	{
		#region Fields
		#endregion

		/// <summary>
		/// Field Numbers for <see cref="VideoClipMesg"/>
		/// </summary>
		public sealed class FieldDefNum
		{
			public const byte ClipNumber = 0;
			public const byte StartTimestamp = 1;
			public const byte StartTimestampMs = 2;
			public const byte EndTimestamp = 3;
			public const byte EndTimestampMs = 4;
			public const byte ClipStart = 6;
			public const byte ClipEnd = 7;
			public const byte Invalid = Fit.FieldNumInvalid;
		}

		#region Constructors
		public VideoClipMesg() : base(Profile.GetMesg(MesgNum.VideoClip))
		{
		}

		public VideoClipMesg(Mesg mesg) : base(mesg)
		{
		}
		#endregion // Constructors

		#region Methods
		///<summary>
		/// Retrieves the ClipNumber field</summary>
		/// <returns>Returns nullable ushort representing the ClipNumber field</returns>
		public ushort? ClipNumber
		{
			get
			{
				Object val = GetFieldValue(0, 0, Fit.SubfieldIndexMainField);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToUInt16(val));

			}
			set
			{
				SetFieldValue(0, 0, value, Fit.SubfieldIndexMainField);
			}
		}

		///<summary>
		/// Retrieves the StartTimestamp field</summary>
		/// <returns>Returns DateTime representing the StartTimestamp field</returns>
		public DateTime StartTimestamp
		{
			get
			{
				Object val = GetFieldValue(1, 0, Fit.SubfieldIndexMainField);
				if (val == null)
				{
					return null;
				}

				return TimestampToDateTime(Convert.ToUInt32(val));

			}
			set
			{
				SetFieldValue(1, 0, value.GetTimeStamp(), Fit.SubfieldIndexMainField);
			}
		}

		///<summary>
		/// Retrieves the StartTimestampMs field</summary>
		/// <returns>Returns nullable ushort representing the StartTimestampMs field</returns>
		public ushort? StartTimestampMs
		{
			get
			{
				Object val = GetFieldValue(2, 0, Fit.SubfieldIndexMainField);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToUInt16(val));

			}
			set
			{
				SetFieldValue(2, 0, value, Fit.SubfieldIndexMainField);
			}
		}

		///<summary>
		/// Retrieves the EndTimestamp field</summary>
		/// <returns>Returns DateTime representing the EndTimestamp field</returns>
		public DateTime EndTimestamp
		{
			get
			{
				Object val = GetFieldValue(3, 0, Fit.SubfieldIndexMainField);
				if (val == null)
				{
					return null;
				}

				return TimestampToDateTime(Convert.ToUInt32(val));

			}
			set
			{
				SetFieldValue(3, 0, value.GetTimeStamp(), Fit.SubfieldIndexMainField);
			}
		}

		///<summary>
		/// Retrieves the EndTimestampMs field</summary>
		/// <returns>Returns nullable ushort representing the EndTimestampMs field</returns>
		public ushort? EndTimestampMs
		{
			get
			{
				Object val = GetFieldValue(4, 0, Fit.SubfieldIndexMainField);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToUInt16(val));

			}
			set
			{
				SetFieldValue(4, 0, value, Fit.SubfieldIndexMainField);
			}
		}

		///<summary>
		/// Retrieves the ClipStart field
		/// Units: ms
		/// Comment: Start of clip in video time</summary>
		/// <returns>Returns nullable uint representing the ClipStart field</returns>
		public uint? ClipStart
		{
			get
			{
				Object val = GetFieldValue(6, 0, Fit.SubfieldIndexMainField);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToUInt32(val));

			}
			set
			{
				SetFieldValue(6, 0, value, Fit.SubfieldIndexMainField);
			}
		}

		///<summary>
		/// Retrieves the ClipEnd field
		/// Units: ms
		/// Comment: End of clip in video time</summary>
		/// <returns>Returns nullable uint representing the ClipEnd field</returns>
		public uint? ClipEnd
		{
			get
			{
				Object val = GetFieldValue(7, 0, Fit.SubfieldIndexMainField);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToUInt32(val));

			}
			set
			{
				SetFieldValue(7, 0, value, Fit.SubfieldIndexMainField);
			}
		}

		#endregion // Methods
	} // Class
} // namespace
