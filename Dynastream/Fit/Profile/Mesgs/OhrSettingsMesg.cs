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
	/// Implements the OhrSettings profile message.
	/// </summary>
	public class OhrSettingsMesg : Mesg
	{
		#region Fields
		#endregion

		/// <summary>
		/// Field Numbers for <see cref="OhrSettingsMesg"/>
		/// </summary>
		public sealed class FieldDefNum
		{
			public const byte Timestamp = 253;
			public const byte Enabled = 0;
			public const byte Invalid = Fit.FieldNumInvalid;
		}

		#region Constructors
		public OhrSettingsMesg() : base(Profile.GetMesg(MesgNum.OhrSettings))
		{
		}

		public OhrSettingsMesg(Mesg mesg) : base(mesg)
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
		/// Retrieves the Enabled field</summary>
		/// <returns>Returns nullable Switch enum representing the Enabled field</returns>
		public Switch? Enabled
		{
			get
			{
				object obj = GetFieldValue(0, 0, Fit.SubfieldIndexMainField);
				Switch? value = obj == null ? (Switch?)null : (Switch)obj;
				return value;
			}
			set
			{
				SetFieldValue(0, 0, value, Fit.SubfieldIndexMainField);
			}
		}

		#endregion // Methods
	} // Class
} // namespace
