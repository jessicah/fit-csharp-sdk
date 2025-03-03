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
	/// Implements the NmeaSentence profile message.
	/// </summary>
	public class NmeaSentenceMesg : Mesg
	{
		#region Fields
		#endregion

		/// <summary>
		/// Field Numbers for <see cref="NmeaSentenceMesg"/>
		/// </summary>
		public sealed class FieldDefNum
		{
			public const byte Timestamp = 253;
			public const byte TimestampMs = 0;
			public const byte Sentence = 1;
			public const byte Invalid = Fit.FieldNumInvalid;
		}

		#region Constructors
		public NmeaSentenceMesg() : base(Profile.GetMesg(MesgNum.NmeaSentence))
		{
		}

		public NmeaSentenceMesg(Mesg mesg) : base(mesg)
		{
		}
		#endregion // Constructors

		#region Methods
		///<summary>
		/// Retrieves the Timestamp field
		/// Units: s
		/// Comment: Timestamp message was output</summary>
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
		/// Retrieves the TimestampMs field
		/// Units: ms
		/// Comment: Fractional part of timestamp, added to timestamp</summary>
		/// <returns>Returns nullable ushort representing the TimestampMs field</returns>
		public ushort? TimestampMs
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
		/// Retrieves the Sentence field
		/// Comment: NMEA sentence</summary>
		/// <returns>Returns byte[] representing the Sentence field</returns>
		public byte[] Sentence
		{
			get
			{
				byte[] data = (byte[])GetFieldValue(1, 0, Fit.SubfieldIndexMainField);
				return data.Take(data.Length - 1).ToArray();
			}
			set
			{
				SetFieldValue(1, 0, value, Fit.SubfieldIndexMainField);
			}
		}

		///<summary>
		/// Retrieves the Sentence field
		/// Comment: NMEA sentence</summary>
		/// <returns>Returns String representing the Sentence field</returns>
		public String GetSentenceAsString()
		{
			byte[] data = (byte[])GetFieldValue(1, 0, Fit.SubfieldIndexMainField);
			return data != null ? Encoding.UTF8.GetString(data, 0, data.Length - 1) : null;
		}

		///<summary>
		/// Set Sentence field
		/// Comment: NMEA sentence</summary>
		/// <param name="sentence_"> field value to be set</param>
		public void SetSentence(String sentence_)
		{
			byte[] data = Encoding.UTF8.GetBytes(sentence_);
			byte[] zdata = new byte[data.Length + 1];
			data.CopyTo(zdata, 0);
			SetFieldValue(1, 0, zdata, Fit.SubfieldIndexMainField);
		}

		#endregion // Methods
	} // Class
} // namespace
