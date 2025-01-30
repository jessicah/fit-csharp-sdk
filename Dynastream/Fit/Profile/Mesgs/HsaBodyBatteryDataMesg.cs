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
	/// Implements the HsaBodyBatteryData profile message.
	/// </summary>
	public class HsaBodyBatteryDataMesg : Mesg
	{
		#region Fields
		#endregion

		/// <summary>
		/// Field Numbers for <see cref="HsaBodyBatteryDataMesg"/>
		/// </summary>
		public sealed class FieldDefNum
		{
			public const byte Timestamp = 253;
			public const byte ProcessingInterval = 0;
			public const byte Level = 1;
			public const byte Charged = 2;
			public const byte Uncharged = 3;
			public const byte Invalid = Fit.FieldNumInvalid;
		}

		#region Constructors
		public HsaBodyBatteryDataMesg() : base(Profile.GetMesg(MesgNum.HsaBodyBatteryData))
		{
		}

		public HsaBodyBatteryDataMesg(Mesg mesg) : base(mesg)
		{
		}
		#endregion // Constructors

		#region Methods
		///<summary>
		/// Retrieves the Timestamp field
		/// Units: s</summary>
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
		/// Retrieves the ProcessingInterval field
		/// Units: s
		/// Comment: Processing interval length in seconds</summary>
		/// <returns>Returns nullable ushort representing the ProcessingInterval field</returns>
		public ushort? ProcessingInterval
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


		/// <summary>
		///
		/// </summary>
		/// <returns>returns number of elements in field Level</returns>
		public int GetNumLevel()
		{
			return GetNumFieldValues(1, Fit.SubfieldIndexMainField);
		}

		///<summary>
		/// Retrieves the Level field
		/// Units: percent
		/// Comment: Body battery level: [0,100] Blank: -16</summary>
		/// <param name="index">0 based index of Level element to retrieve</param>
		/// <returns>Returns nullable sbyte representing the Level field</returns>
		public sbyte? GetLevel(int index)
		{
			Object val = GetFieldValue(1, index, Fit.SubfieldIndexMainField);
			if (val == null)
			{
				return null;
			}

			return (Convert.ToSByte(val));

		}

		/// <summary>
		/// Set Level field
		/// Units: percent
		/// Comment: Body battery level: [0,100] Blank: -16</summary>
		/// <param name="index">0 based index of level</param>
		/// <param name="level_">Nullable field value to be set</param>
		public void SetLevel(int index, sbyte? level_)
		{
			SetFieldValue(1, index, level_, Fit.SubfieldIndexMainField);
		}


		/// <summary>
		///
		/// </summary>
		/// <returns>returns number of elements in field Charged</returns>
		public int GetNumCharged()
		{
			return GetNumFieldValues(2, Fit.SubfieldIndexMainField);
		}

		///<summary>
		/// Retrieves the Charged field
		/// Comment: Body battery charged value</summary>
		/// <param name="index">0 based index of Charged element to retrieve</param>
		/// <returns>Returns nullable short representing the Charged field</returns>
		public short? GetCharged(int index)
		{
			Object val = GetFieldValue(2, index, Fit.SubfieldIndexMainField);
			if (val == null)
			{
				return null;
			}

			return (Convert.ToInt16(val));

		}

		/// <summary>
		/// Set Charged field
		/// Comment: Body battery charged value</summary>
		/// <param name="index">0 based index of charged</param>
		/// <param name="charged_">Nullable field value to be set</param>
		public void SetCharged(int index, short? charged_)
		{
			SetFieldValue(2, index, charged_, Fit.SubfieldIndexMainField);
		}


		/// <summary>
		///
		/// </summary>
		/// <returns>returns number of elements in field Uncharged</returns>
		public int GetNumUncharged()
		{
			return GetNumFieldValues(3, Fit.SubfieldIndexMainField);
		}

		///<summary>
		/// Retrieves the Uncharged field
		/// Comment: Body battery uncharged value</summary>
		/// <param name="index">0 based index of Uncharged element to retrieve</param>
		/// <returns>Returns nullable short representing the Uncharged field</returns>
		public short? GetUncharged(int index)
		{
			Object val = GetFieldValue(3, index, Fit.SubfieldIndexMainField);
			if (val == null)
			{
				return null;
			}

			return (Convert.ToInt16(val));

		}

		/// <summary>
		/// Set Uncharged field
		/// Comment: Body battery uncharged value</summary>
		/// <param name="index">0 based index of uncharged</param>
		/// <param name="uncharged_">Nullable field value to be set</param>
		public void SetUncharged(int index, short? uncharged_)
		{
			SetFieldValue(3, index, uncharged_, Fit.SubfieldIndexMainField);
		}

		#endregion // Methods
	} // Class
} // namespace
