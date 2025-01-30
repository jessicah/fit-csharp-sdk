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
	/// Implements the Connectivity profile message.
	/// </summary>
	public class ConnectivityMesg : Mesg
	{
		#region Fields
		#endregion

		/// <summary>
		/// Field Numbers for <see cref="ConnectivityMesg"/>
		/// </summary>
		public sealed class FieldDefNum
		{
			public const byte BluetoothEnabled = 0;
			public const byte BluetoothLeEnabled = 1;
			public const byte AntEnabled = 2;
			public const byte Name = 3;
			public const byte LiveTrackingEnabled = 4;
			public const byte WeatherConditionsEnabled = 5;
			public const byte WeatherAlertsEnabled = 6;
			public const byte AutoActivityUploadEnabled = 7;
			public const byte CourseDownloadEnabled = 8;
			public const byte WorkoutDownloadEnabled = 9;
			public const byte GpsEphemerisDownloadEnabled = 10;
			public const byte IncidentDetectionEnabled = 11;
			public const byte GrouptrackEnabled = 12;
			public const byte Invalid = Fit.FieldNumInvalid;
		}

		#region Constructors
		public ConnectivityMesg() : base(Profile.GetMesg(MesgNum.Connectivity))
		{
		}

		public ConnectivityMesg(Mesg mesg) : base(mesg)
		{
		}
		#endregion // Constructors

		#region Methods
		///<summary>
		/// Retrieves the BluetoothEnabled field
		/// Comment: Use Bluetooth for connectivity features</summary>
		/// <returns>Returns nullable Bool enum representing the BluetoothEnabled field</returns>
		public Bool? BluetoothEnabled
		{
			get
			{
				object obj = GetFieldValue(0, 0, Fit.SubfieldIndexMainField);
				Bool? value = obj == null ? (Bool?)null : (Bool)obj;
				return value;
			}
			set
			{
				SetFieldValue(0, 0, value, Fit.SubfieldIndexMainField);
			}
		}

		///<summary>
		/// Retrieves the BluetoothLeEnabled field
		/// Comment: Use Bluetooth Low Energy for connectivity features</summary>
		/// <returns>Returns nullable Bool enum representing the BluetoothLeEnabled field</returns>
		public Bool? BluetoothLeEnabled
		{
			get
			{
				object obj = GetFieldValue(1, 0, Fit.SubfieldIndexMainField);
				Bool? value = obj == null ? (Bool?)null : (Bool)obj;
				return value;
			}
			set
			{
				SetFieldValue(1, 0, value, Fit.SubfieldIndexMainField);
			}
		}

		///<summary>
		/// Retrieves the AntEnabled field
		/// Comment: Use ANT for connectivity features</summary>
		/// <returns>Returns nullable Bool enum representing the AntEnabled field</returns>
		public Bool? AntEnabled
		{
			get
			{
				object obj = GetFieldValue(2, 0, Fit.SubfieldIndexMainField);
				Bool? value = obj == null ? (Bool?)null : (Bool)obj;
				return value;
			}
			set
			{
				SetFieldValue(2, 0, value, Fit.SubfieldIndexMainField);
			}
		}

		///<summary>
		/// Retrieves the Name field</summary>
		/// <returns>Returns byte[] representing the Name field</returns>
		public byte[] Name
		{
			get
			{
				byte[] data = (byte[])GetFieldValue(3, 0, Fit.SubfieldIndexMainField);
				return data.Take(data.Length - 1).ToArray();
			}
			set
			{
				SetFieldValue(3, 0, value, Fit.SubfieldIndexMainField);
			}
		}

		///<summary>
		/// Retrieves the Name field</summary>
		/// <returns>Returns String representing the Name field</returns>
		public String GetNameAsString()
		{
			byte[] data = (byte[])GetFieldValue(3, 0, Fit.SubfieldIndexMainField);
			return data != null ? Encoding.UTF8.GetString(data, 0, data.Length - 1) : null;
		}

		///<summary>
		/// Set Name field</summary>
		/// <param name="name_"> field value to be set</param>
		public void SetName(String name_)
		{
			byte[] data = Encoding.UTF8.GetBytes(name_);
			byte[] zdata = new byte[data.Length + 1];
			data.CopyTo(zdata, 0);
			SetFieldValue(3, 0, zdata, Fit.SubfieldIndexMainField);
		}

		///<summary>
		/// Retrieves the LiveTrackingEnabled field</summary>
		/// <returns>Returns nullable Bool enum representing the LiveTrackingEnabled field</returns>
		public Bool? LiveTrackingEnabled
		{
			get
			{
				object obj = GetFieldValue(4, 0, Fit.SubfieldIndexMainField);
				Bool? value = obj == null ? (Bool?)null : (Bool)obj;
				return value;
			}
			set
			{
				SetFieldValue(4, 0, value, Fit.SubfieldIndexMainField);
			}
		}

		///<summary>
		/// Retrieves the WeatherConditionsEnabled field</summary>
		/// <returns>Returns nullable Bool enum representing the WeatherConditionsEnabled field</returns>
		public Bool? WeatherConditionsEnabled
		{
			get
			{
				object obj = GetFieldValue(5, 0, Fit.SubfieldIndexMainField);
				Bool? value = obj == null ? (Bool?)null : (Bool)obj;
				return value;
			}
			set
			{
				SetFieldValue(5, 0, value, Fit.SubfieldIndexMainField);
			}
		}

		///<summary>
		/// Retrieves the WeatherAlertsEnabled field</summary>
		/// <returns>Returns nullable Bool enum representing the WeatherAlertsEnabled field</returns>
		public Bool? WeatherAlertsEnabled
		{
			get
			{
				object obj = GetFieldValue(6, 0, Fit.SubfieldIndexMainField);
				Bool? value = obj == null ? (Bool?)null : (Bool)obj;
				return value;
			}
			set
			{
				SetFieldValue(6, 0, value, Fit.SubfieldIndexMainField);
			}
		}

		///<summary>
		/// Retrieves the AutoActivityUploadEnabled field</summary>
		/// <returns>Returns nullable Bool enum representing the AutoActivityUploadEnabled field</returns>
		public Bool? AutoActivityUploadEnabled
		{
			get
			{
				object obj = GetFieldValue(7, 0, Fit.SubfieldIndexMainField);
				Bool? value = obj == null ? (Bool?)null : (Bool)obj;
				return value;
			}
			set
			{
				SetFieldValue(7, 0, value, Fit.SubfieldIndexMainField);
			}
		}

		///<summary>
		/// Retrieves the CourseDownloadEnabled field</summary>
		/// <returns>Returns nullable Bool enum representing the CourseDownloadEnabled field</returns>
		public Bool? CourseDownloadEnabled
		{
			get
			{
				object obj = GetFieldValue(8, 0, Fit.SubfieldIndexMainField);
				Bool? value = obj == null ? (Bool?)null : (Bool)obj;
				return value;
			}
			set
			{
				SetFieldValue(8, 0, value, Fit.SubfieldIndexMainField);
			}
		}

		///<summary>
		/// Retrieves the WorkoutDownloadEnabled field</summary>
		/// <returns>Returns nullable Bool enum representing the WorkoutDownloadEnabled field</returns>
		public Bool? WorkoutDownloadEnabled
		{
			get
			{
				object obj = GetFieldValue(9, 0, Fit.SubfieldIndexMainField);
				Bool? value = obj == null ? (Bool?)null : (Bool)obj;
				return value;
			}
			set
			{
				SetFieldValue(9, 0, value, Fit.SubfieldIndexMainField);
			}
		}

		///<summary>
		/// Retrieves the GpsEphemerisDownloadEnabled field</summary>
		/// <returns>Returns nullable Bool enum representing the GpsEphemerisDownloadEnabled field</returns>
		public Bool? GpsEphemerisDownloadEnabled
		{
			get
			{
				object obj = GetFieldValue(10, 0, Fit.SubfieldIndexMainField);
				Bool? value = obj == null ? (Bool?)null : (Bool)obj;
				return value;
			}
			set
			{
				SetFieldValue(10, 0, value, Fit.SubfieldIndexMainField);
			}
		}

		///<summary>
		/// Retrieves the IncidentDetectionEnabled field</summary>
		/// <returns>Returns nullable Bool enum representing the IncidentDetectionEnabled field</returns>
		public Bool? IncidentDetectionEnabled
		{
			get
			{
				object obj = GetFieldValue(11, 0, Fit.SubfieldIndexMainField);
				Bool? value = obj == null ? (Bool?)null : (Bool)obj;
				return value;
			}
			set
			{
				SetFieldValue(11, 0, value, Fit.SubfieldIndexMainField);
			}
		}

		///<summary>
		/// Retrieves the GrouptrackEnabled field</summary>
		/// <returns>Returns nullable Bool enum representing the GrouptrackEnabled field</returns>
		public Bool? GrouptrackEnabled
		{
			get
			{
				object obj = GetFieldValue(12, 0, Fit.SubfieldIndexMainField);
				Bool? value = obj == null ? (Bool?)null : (Bool)obj;
				return value;
			}
			set
			{
				SetFieldValue(12, 0, value, Fit.SubfieldIndexMainField);
			}
		}

		#endregion // Methods
	} // Class
} // namespace
