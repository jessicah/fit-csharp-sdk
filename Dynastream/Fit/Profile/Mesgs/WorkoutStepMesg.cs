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
	/// Implements the WorkoutStep profile message.
	/// </summary>
	public class WorkoutStepMesg : Mesg
	{
		#region Fields
		static class DurationValueSubfield
		{
			public static ushort DurationTime = 0;
			public static ushort DurationDistance = 1;
			public static ushort DurationHr = 2;
			public static ushort DurationCalories = 3;
			public static ushort DurationStep = 4;
			public static ushort DurationPower = 5;
			public static ushort DurationReps = 6;
			public static ushort Subfields = 7;
			public static ushort Active = Fit.SubfieldIndexActiveSubfield;
			public static ushort MainField = Fit.SubfieldIndexMainField;
		}
		static class TargetValueSubfield
		{
			public static ushort TargetSpeedZone = 0;
			public static ushort TargetHrZone = 1;
			public static ushort TargetCadenceZone = 2;
			public static ushort TargetPowerZone = 3;
			public static ushort RepeatSteps = 4;
			public static ushort RepeatTime = 5;
			public static ushort RepeatDistance = 6;
			public static ushort RepeatCalories = 7;
			public static ushort RepeatHr = 8;
			public static ushort RepeatPower = 9;
			public static ushort TargetStrokeType = 10;
			public static ushort Subfields = 11;
			public static ushort Active = Fit.SubfieldIndexActiveSubfield;
			public static ushort MainField = Fit.SubfieldIndexMainField;
		}
		static class CustomTargetValueLowSubfield
		{
			public static ushort CustomTargetSpeedLow = 0;
			public static ushort CustomTargetHeartRateLow = 1;
			public static ushort CustomTargetCadenceLow = 2;
			public static ushort CustomTargetPowerLow = 3;
			public static ushort Subfields = 4;
			public static ushort Active = Fit.SubfieldIndexActiveSubfield;
			public static ushort MainField = Fit.SubfieldIndexMainField;
		}
		static class CustomTargetValueHighSubfield
		{
			public static ushort CustomTargetSpeedHigh = 0;
			public static ushort CustomTargetHeartRateHigh = 1;
			public static ushort CustomTargetCadenceHigh = 2;
			public static ushort CustomTargetPowerHigh = 3;
			public static ushort Subfields = 4;
			public static ushort Active = Fit.SubfieldIndexActiveSubfield;
			public static ushort MainField = Fit.SubfieldIndexMainField;
		}
		static class SecondaryTargetValueSubfield
		{
			public static ushort SecondaryTargetSpeedZone = 0;
			public static ushort SecondaryTargetHrZone = 1;
			public static ushort SecondaryTargetCadenceZone = 2;
			public static ushort SecondaryTargetPowerZone = 3;
			public static ushort SecondaryTargetStrokeType = 4;
			public static ushort Subfields = 5;
			public static ushort Active = Fit.SubfieldIndexActiveSubfield;
			public static ushort MainField = Fit.SubfieldIndexMainField;
		}
		static class SecondaryCustomTargetValueLowSubfield
		{
			public static ushort SecondaryCustomTargetSpeedLow = 0;
			public static ushort SecondaryCustomTargetHeartRateLow = 1;
			public static ushort SecondaryCustomTargetCadenceLow = 2;
			public static ushort SecondaryCustomTargetPowerLow = 3;
			public static ushort Subfields = 4;
			public static ushort Active = Fit.SubfieldIndexActiveSubfield;
			public static ushort MainField = Fit.SubfieldIndexMainField;
		}
		static class SecondaryCustomTargetValueHighSubfield
		{
			public static ushort SecondaryCustomTargetSpeedHigh = 0;
			public static ushort SecondaryCustomTargetHeartRateHigh = 1;
			public static ushort SecondaryCustomTargetCadenceHigh = 2;
			public static ushort SecondaryCustomTargetPowerHigh = 3;
			public static ushort Subfields = 4;
			public static ushort Active = Fit.SubfieldIndexActiveSubfield;
			public static ushort MainField = Fit.SubfieldIndexMainField;
		}
		#endregion

		/// <summary>
		/// Field Numbers for <see cref="WorkoutStepMesg"/>
		/// </summary>
		public sealed class FieldDefNum
		{
			public const byte MessageIndex = 254;
			public const byte WktStepName = 0;
			public const byte DurationType = 1;
			public const byte DurationValue = 2;
			public const byte TargetType = 3;
			public const byte TargetValue = 4;
			public const byte CustomTargetValueLow = 5;
			public const byte CustomTargetValueHigh = 6;
			public const byte Intensity = 7;
			public const byte Notes = 8;
			public const byte Equipment = 9;
			public const byte ExerciseCategory = 10;
			public const byte ExerciseName = 11;
			public const byte ExerciseWeight = 12;
			public const byte WeightDisplayUnit = 13;
			public const byte SecondaryTargetType = 19;
			public const byte SecondaryTargetValue = 20;
			public const byte SecondaryCustomTargetValueLow = 21;
			public const byte SecondaryCustomTargetValueHigh = 22;
			public const byte Invalid = Fit.FieldNumInvalid;
		}

		#region Constructors
		public WorkoutStepMesg() : base(Profile.GetMesg(MesgNum.WorkoutStep))
		{
		}

		public WorkoutStepMesg(Mesg mesg) : base(mesg)
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
		/// Retrieves the WktStepName field</summary>
		/// <returns>Returns byte[] representing the WktStepName field</returns>
		public byte[] WktStepName
		{
			get
			{
				byte[] data = (byte[])GetFieldValue(0, 0, Fit.SubfieldIndexMainField);
				return data.Take(data.Length - 1).ToArray();
			}
			set
			{
				SetFieldValue(0, 0, value, Fit.SubfieldIndexMainField);
			}
		}

		///<summary>
		/// Retrieves the WktStepName field</summary>
		/// <returns>Returns String representing the WktStepName field</returns>
		public String GetWktStepNameAsString()
		{
			byte[] data = (byte[])GetFieldValue(0, 0, Fit.SubfieldIndexMainField);
			return data != null ? Encoding.UTF8.GetString(data, 0, data.Length - 1) : null;
		}

		///<summary>
		/// Set WktStepName field</summary>
		/// <param name="wktStepName_"> field value to be set</param>
		public void SetWktStepName(String wktStepName_)
		{
			byte[] data = Encoding.UTF8.GetBytes(wktStepName_);
			byte[] zdata = new byte[data.Length + 1];
			data.CopyTo(zdata, 0);
			SetFieldValue(0, 0, zdata, Fit.SubfieldIndexMainField);
		}

		///<summary>
		/// Retrieves the DurationType field</summary>
		/// <returns>Returns nullable WktStepDuration enum representing the DurationType field</returns>
		public WktStepDuration? DurationType
		{
			get
			{
				object obj = GetFieldValue(1, 0, Fit.SubfieldIndexMainField);
				WktStepDuration? value = obj == null ? (WktStepDuration?)null : (WktStepDuration)obj;
				return value;
			}
			set
			{
				SetFieldValue(1, 0, value, Fit.SubfieldIndexMainField);
			}
		}

		///<summary>
		/// Retrieves the DurationValue field</summary>
		/// <returns>Returns nullable uint representing the DurationValue field</returns>
		public uint? DurationValue
		{
			get
			{
				Object val = GetFieldValue(2, 0, Fit.SubfieldIndexMainField);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToUInt32(val));

			}
			set
			{
				SetFieldValue(2, 0, value, Fit.SubfieldIndexMainField);
			}
		}


		/// <summary>
		/// Retrieves the DurationTime subfield
		/// Units: s</summary>
		/// <returns>Nullable float representing the DurationTime subfield</returns>
		public float? DurationTime
		{
			get
			{
				Object val = GetFieldValue(2, 0, DurationValueSubfield.DurationTime);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToSingle(val));

			}
			set
			{
				SetFieldValue(2, 0, value, DurationValueSubfield.DurationTime);
			}
		}

		/// <summary>
		/// Retrieves the DurationDistance subfield
		/// Units: m</summary>
		/// <returns>Nullable float representing the DurationDistance subfield</returns>
		public float? DurationDistance
		{
			get
			{
				Object val = GetFieldValue(2, 0, DurationValueSubfield.DurationDistance);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToSingle(val));

			}
			set
			{
				SetFieldValue(2, 0, value, DurationValueSubfield.DurationDistance);
			}
		}

		/// <summary>
		/// Retrieves the DurationHr subfield
		/// Units: % or bpm</summary>
		/// <returns>Nullable uint representing the DurationHr subfield</returns>
		public uint? DurationHr
		{
			get
			{
				Object val = GetFieldValue(2, 0, DurationValueSubfield.DurationHr);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToUInt32(val));

			}
			set
			{
				SetFieldValue(2, 0, value, DurationValueSubfield.DurationHr);
			}
		}

		/// <summary>
		/// Retrieves the DurationCalories subfield
		/// Units: calories</summary>
		/// <returns>Nullable uint representing the DurationCalories subfield</returns>
		public uint? DurationCalories
		{
			get
			{
				Object val = GetFieldValue(2, 0, DurationValueSubfield.DurationCalories);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToUInt32(val));

			}
			set
			{
				SetFieldValue(2, 0, value, DurationValueSubfield.DurationCalories);
			}
		}

		/// <summary>
		/// Retrieves the DurationStep subfield
		/// Comment: message_index of step to loop back to. Steps are assumed to be in the order by message_index. custom_name and intensity members are undefined for this duration type.</summary>
		/// <returns>Nullable uint representing the DurationStep subfield</returns>
		public uint? DurationStep
		{
			get
			{
				Object val = GetFieldValue(2, 0, DurationValueSubfield.DurationStep);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToUInt32(val));

			}
			set
			{
				SetFieldValue(2, 0, value, DurationValueSubfield.DurationStep);
			}
		}

		/// <summary>
		/// Retrieves the DurationPower subfield
		/// Units: % or watts</summary>
		/// <returns>Nullable uint representing the DurationPower subfield</returns>
		public uint? DurationPower
		{
			get
			{
				Object val = GetFieldValue(2, 0, DurationValueSubfield.DurationPower);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToUInt32(val));

			}
			set
			{
				SetFieldValue(2, 0, value, DurationValueSubfield.DurationPower);
			}
		}

		/// <summary>
		/// Retrieves the DurationReps subfield</summary>
		/// <returns>Nullable uint representing the DurationReps subfield</returns>
		public uint? DurationReps
		{
			get
			{
				Object val = GetFieldValue(2, 0, DurationValueSubfield.DurationReps);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToUInt32(val));

			}
			set
			{
				SetFieldValue(2, 0, value, DurationValueSubfield.DurationReps);
			}
		}
		///<summary>
		/// Retrieves the TargetType field</summary>
		/// <returns>Returns nullable WktStepTarget enum representing the TargetType field</returns>
		public WktStepTarget? TargetType
		{
			get
			{
				object obj = GetFieldValue(3, 0, Fit.SubfieldIndexMainField);
				WktStepTarget? value = obj == null ? (WktStepTarget?)null : (WktStepTarget)obj;
				return value;
			}
			set
			{
				SetFieldValue(3, 0, value, Fit.SubfieldIndexMainField);
			}
		}

		///<summary>
		/// Retrieves the TargetValue field</summary>
		/// <returns>Returns nullable uint representing the TargetValue field</returns>
		public uint? TargetValue
		{
			get
			{
				Object val = GetFieldValue(4, 0, Fit.SubfieldIndexMainField);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToUInt32(val));

			}
			set
			{
				SetFieldValue(4, 0, value, Fit.SubfieldIndexMainField);
			}
		}


		/// <summary>
		/// Retrieves the TargetSpeedZone subfield
		/// Comment: speed zone (1-10);Custom =0;</summary>
		/// <returns>Nullable uint representing the TargetSpeedZone subfield</returns>
		public uint? TargetSpeedZone
		{
			get
			{
				Object val = GetFieldValue(4, 0, TargetValueSubfield.TargetSpeedZone);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToUInt32(val));

			}
			set
			{
				SetFieldValue(4, 0, value, TargetValueSubfield.TargetSpeedZone);
			}
		}

		/// <summary>
		/// Retrieves the TargetHrZone subfield
		/// Comment: hr zone (1-5);Custom =0;</summary>
		/// <returns>Nullable uint representing the TargetHrZone subfield</returns>
		public uint? TargetHrZone
		{
			get
			{
				Object val = GetFieldValue(4, 0, TargetValueSubfield.TargetHrZone);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToUInt32(val));

			}
			set
			{
				SetFieldValue(4, 0, value, TargetValueSubfield.TargetHrZone);
			}
		}

		/// <summary>
		/// Retrieves the TargetCadenceZone subfield
		/// Comment: Zone (1-?); Custom = 0;</summary>
		/// <returns>Nullable uint representing the TargetCadenceZone subfield</returns>
		public uint? TargetCadenceZone
		{
			get
			{
				Object val = GetFieldValue(4, 0, TargetValueSubfield.TargetCadenceZone);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToUInt32(val));

			}
			set
			{
				SetFieldValue(4, 0, value, TargetValueSubfield.TargetCadenceZone);
			}
		}

		/// <summary>
		/// Retrieves the TargetPowerZone subfield
		/// Comment: Power Zone ( 1-7); Custom = 0;</summary>
		/// <returns>Nullable uint representing the TargetPowerZone subfield</returns>
		public uint? TargetPowerZone
		{
			get
			{
				Object val = GetFieldValue(4, 0, TargetValueSubfield.TargetPowerZone);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToUInt32(val));

			}
			set
			{
				SetFieldValue(4, 0, value, TargetValueSubfield.TargetPowerZone);
			}
		}

		/// <summary>
		/// Retrieves the RepeatSteps subfield
		/// Comment: # of repetitions</summary>
		/// <returns>Nullable uint representing the RepeatSteps subfield</returns>
		public uint? RepeatSteps
		{
			get
			{
				Object val = GetFieldValue(4, 0, TargetValueSubfield.RepeatSteps);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToUInt32(val));

			}
			set
			{
				SetFieldValue(4, 0, value, TargetValueSubfield.RepeatSteps);
			}
		}

		/// <summary>
		/// Retrieves the RepeatTime subfield
		/// Units: s</summary>
		/// <returns>Nullable float representing the RepeatTime subfield</returns>
		public float? RepeatTime
		{
			get
			{
				Object val = GetFieldValue(4, 0, TargetValueSubfield.RepeatTime);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToSingle(val));

			}
			set
			{
				SetFieldValue(4, 0, value, TargetValueSubfield.RepeatTime);
			}
		}

		/// <summary>
		/// Retrieves the RepeatDistance subfield
		/// Units: m</summary>
		/// <returns>Nullable float representing the RepeatDistance subfield</returns>
		public float? RepeatDistance
		{
			get
			{
				Object val = GetFieldValue(4, 0, TargetValueSubfield.RepeatDistance);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToSingle(val));

			}
			set
			{
				SetFieldValue(4, 0, value, TargetValueSubfield.RepeatDistance);
			}
		}

		/// <summary>
		/// Retrieves the RepeatCalories subfield
		/// Units: calories</summary>
		/// <returns>Nullable uint representing the RepeatCalories subfield</returns>
		public uint? RepeatCalories
		{
			get
			{
				Object val = GetFieldValue(4, 0, TargetValueSubfield.RepeatCalories);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToUInt32(val));

			}
			set
			{
				SetFieldValue(4, 0, value, TargetValueSubfield.RepeatCalories);
			}
		}

		/// <summary>
		/// Retrieves the RepeatHr subfield
		/// Units: % or bpm</summary>
		/// <returns>Nullable uint representing the RepeatHr subfield</returns>
		public uint? RepeatHr
		{
			get
			{
				Object val = GetFieldValue(4, 0, TargetValueSubfield.RepeatHr);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToUInt32(val));

			}
			set
			{
				SetFieldValue(4, 0, value, TargetValueSubfield.RepeatHr);
			}
		}

		/// <summary>
		/// Retrieves the RepeatPower subfield
		/// Units: % or watts</summary>
		/// <returns>Nullable uint representing the RepeatPower subfield</returns>
		public uint? RepeatPower
		{
			get
			{
				Object val = GetFieldValue(4, 0, TargetValueSubfield.RepeatPower);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToUInt32(val));

			}
			set
			{
				SetFieldValue(4, 0, value, TargetValueSubfield.RepeatPower);
			}
		}

		/// <summary>
		/// Retrieves the TargetStrokeType subfield</summary>
		/// <returns>Nullable SwimStroke enum representing the TargetStrokeType subfield</returns>
		public SwimStroke? GetTargetStrokeType()
		{
			return (SwimStroke?)GetFieldValue(4, 0, TargetValueSubfield.TargetStrokeType);
		}

		/// <summary>
		///
		/// Set TargetStrokeType subfield</summary>
		/// <param name="targetStrokeType">Subfield value to be set</param>
		public void SetTargetStrokeType(byte? targetStrokeType)
		{
			SetFieldValue(4, 0, targetStrokeType, TargetValueSubfield.TargetStrokeType);
		}
		///<summary>
		/// Retrieves the CustomTargetValueLow field</summary>
		/// <returns>Returns nullable uint representing the CustomTargetValueLow field</returns>
		public uint? CustomTargetValueLow
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


		/// <summary>
		/// Retrieves the CustomTargetSpeedLow subfield
		/// Units: m/s</summary>
		/// <returns>Nullable float representing the CustomTargetSpeedLow subfield</returns>
		public float? CustomTargetSpeedLow
		{
			get
			{
				Object val = GetFieldValue(5, 0, CustomTargetValueLowSubfield.CustomTargetSpeedLow);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToSingle(val));

			}
			set
			{
				SetFieldValue(5, 0, value, CustomTargetValueLowSubfield.CustomTargetSpeedLow);
			}
		}

		/// <summary>
		/// Retrieves the CustomTargetHeartRateLow subfield
		/// Units: % or bpm</summary>
		/// <returns>Nullable uint representing the CustomTargetHeartRateLow subfield</returns>
		public uint? CustomTargetHeartRateLow
		{
			get
			{
				Object val = GetFieldValue(5, 0, CustomTargetValueLowSubfield.CustomTargetHeartRateLow);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToUInt32(val));

			}
			set
			{
				SetFieldValue(5, 0, value, CustomTargetValueLowSubfield.CustomTargetHeartRateLow);
			}
		}

		/// <summary>
		/// Retrieves the CustomTargetCadenceLow subfield
		/// Units: rpm</summary>
		/// <returns>Nullable uint representing the CustomTargetCadenceLow subfield</returns>
		public uint? CustomTargetCadenceLow
		{
			get
			{
				Object val = GetFieldValue(5, 0, CustomTargetValueLowSubfield.CustomTargetCadenceLow);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToUInt32(val));

			}
			set
			{
				SetFieldValue(5, 0, value, CustomTargetValueLowSubfield.CustomTargetCadenceLow);
			}
		}

		/// <summary>
		/// Retrieves the CustomTargetPowerLow subfield
		/// Units: % or watts</summary>
		/// <returns>Nullable uint representing the CustomTargetPowerLow subfield</returns>
		public uint? CustomTargetPowerLow
		{
			get
			{
				Object val = GetFieldValue(5, 0, CustomTargetValueLowSubfield.CustomTargetPowerLow);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToUInt32(val));

			}
			set
			{
				SetFieldValue(5, 0, value, CustomTargetValueLowSubfield.CustomTargetPowerLow);
			}
		}
		///<summary>
		/// Retrieves the CustomTargetValueHigh field</summary>
		/// <returns>Returns nullable uint representing the CustomTargetValueHigh field</returns>
		public uint? CustomTargetValueHigh
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


		/// <summary>
		/// Retrieves the CustomTargetSpeedHigh subfield
		/// Units: m/s</summary>
		/// <returns>Nullable float representing the CustomTargetSpeedHigh subfield</returns>
		public float? CustomTargetSpeedHigh
		{
			get
			{
				Object val = GetFieldValue(6, 0, CustomTargetValueHighSubfield.CustomTargetSpeedHigh);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToSingle(val));

			}
			set
			{
				SetFieldValue(6, 0, value, CustomTargetValueHighSubfield.CustomTargetSpeedHigh);
			}
		}

		/// <summary>
		/// Retrieves the CustomTargetHeartRateHigh subfield
		/// Units: % or bpm</summary>
		/// <returns>Nullable uint representing the CustomTargetHeartRateHigh subfield</returns>
		public uint? CustomTargetHeartRateHigh
		{
			get
			{
				Object val = GetFieldValue(6, 0, CustomTargetValueHighSubfield.CustomTargetHeartRateHigh);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToUInt32(val));

			}
			set
			{
				SetFieldValue(6, 0, value, CustomTargetValueHighSubfield.CustomTargetHeartRateHigh);
			}
		}

		/// <summary>
		/// Retrieves the CustomTargetCadenceHigh subfield
		/// Units: rpm</summary>
		/// <returns>Nullable uint representing the CustomTargetCadenceHigh subfield</returns>
		public uint? CustomTargetCadenceHigh
		{
			get
			{
				Object val = GetFieldValue(6, 0, CustomTargetValueHighSubfield.CustomTargetCadenceHigh);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToUInt32(val));

			}
			set
			{
				SetFieldValue(6, 0, value, CustomTargetValueHighSubfield.CustomTargetCadenceHigh);
			}
		}

		/// <summary>
		/// Retrieves the CustomTargetPowerHigh subfield
		/// Units: % or watts</summary>
		/// <returns>Nullable uint representing the CustomTargetPowerHigh subfield</returns>
		public uint? CustomTargetPowerHigh
		{
			get
			{
				Object val = GetFieldValue(6, 0, CustomTargetValueHighSubfield.CustomTargetPowerHigh);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToUInt32(val));

			}
			set
			{
				SetFieldValue(6, 0, value, CustomTargetValueHighSubfield.CustomTargetPowerHigh);
			}
		}
		///<summary>
		/// Retrieves the Intensity field</summary>
		/// <returns>Returns nullable Intensity enum representing the Intensity field</returns>
		public Intensity? Intensity
		{
			get
			{
				object obj = GetFieldValue(7, 0, Fit.SubfieldIndexMainField);
				Intensity? value = obj == null ? (Intensity?)null : (Intensity)obj;
				return value;
			}
			set
			{
				SetFieldValue(7, 0, value, Fit.SubfieldIndexMainField);
			}
		}

		///<summary>
		/// Retrieves the Notes field</summary>
		/// <returns>Returns byte[] representing the Notes field</returns>
		public byte[] Notes
		{
			get
			{
				byte[] data = (byte[])GetFieldValue(8, 0, Fit.SubfieldIndexMainField);
				return data.Take(data.Length - 1).ToArray();
			}
			set
			{
				SetFieldValue(8, 0, value, Fit.SubfieldIndexMainField);
			}
		}

		///<summary>
		/// Retrieves the Notes field</summary>
		/// <returns>Returns String representing the Notes field</returns>
		public String GetNotesAsString()
		{
			byte[] data = (byte[])GetFieldValue(8, 0, Fit.SubfieldIndexMainField);
			return data != null ? Encoding.UTF8.GetString(data, 0, data.Length - 1) : null;
		}

		///<summary>
		/// Set Notes field</summary>
		/// <param name="notes_"> field value to be set</param>
		public void SetNotes(String notes_)
		{
			byte[] data = Encoding.UTF8.GetBytes(notes_);
			byte[] zdata = new byte[data.Length + 1];
			data.CopyTo(zdata, 0);
			SetFieldValue(8, 0, zdata, Fit.SubfieldIndexMainField);
		}

		///<summary>
		/// Retrieves the Equipment field</summary>
		/// <returns>Returns nullable WorkoutEquipment enum representing the Equipment field</returns>
		public WorkoutEquipment? Equipment
		{
			get
			{
				object obj = GetFieldValue(9, 0, Fit.SubfieldIndexMainField);
				WorkoutEquipment? value = obj == null ? (WorkoutEquipment?)null : (WorkoutEquipment)obj;
				return value;
			}
			set
			{
				SetFieldValue(9, 0, value, Fit.SubfieldIndexMainField);
			}
		}

		///<summary>
		/// Retrieves the ExerciseCategory field</summary>
		/// <returns>Returns nullable ushort representing the ExerciseCategory field</returns>
		public ushort? ExerciseCategory
		{
			get
			{
				Object val = GetFieldValue(10, 0, Fit.SubfieldIndexMainField);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToUInt16(val));

			}
			set
			{
				SetFieldValue(10, 0, value, Fit.SubfieldIndexMainField);
			}
		}

		///<summary>
		/// Retrieves the ExerciseName field</summary>
		/// <returns>Returns nullable ushort representing the ExerciseName field</returns>
		public ushort? ExerciseName
		{
			get
			{
				Object val = GetFieldValue(11, 0, Fit.SubfieldIndexMainField);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToUInt16(val));

			}
			set
			{
				SetFieldValue(11, 0, value, Fit.SubfieldIndexMainField);
			}
		}

		///<summary>
		/// Retrieves the ExerciseWeight field
		/// Units: kg</summary>
		/// <returns>Returns nullable float representing the ExerciseWeight field</returns>
		public float? ExerciseWeight
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
		/// Retrieves the WeightDisplayUnit field</summary>
		/// <returns>Returns nullable ushort representing the WeightDisplayUnit field</returns>
		public ushort? WeightDisplayUnit
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
		/// Retrieves the SecondaryTargetType field</summary>
		/// <returns>Returns nullable WktStepTarget enum representing the SecondaryTargetType field</returns>
		public WktStepTarget? SecondaryTargetType
		{
			get
			{
				object obj = GetFieldValue(19, 0, Fit.SubfieldIndexMainField);
				WktStepTarget? value = obj == null ? (WktStepTarget?)null : (WktStepTarget)obj;
				return value;
			}
			set
			{
				SetFieldValue(19, 0, value, Fit.SubfieldIndexMainField);
			}
		}

		///<summary>
		/// Retrieves the SecondaryTargetValue field</summary>
		/// <returns>Returns nullable uint representing the SecondaryTargetValue field</returns>
		public uint? SecondaryTargetValue
		{
			get
			{
				Object val = GetFieldValue(20, 0, Fit.SubfieldIndexMainField);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToUInt32(val));

			}
			set
			{
				SetFieldValue(20, 0, value, Fit.SubfieldIndexMainField);
			}
		}


		/// <summary>
		/// Retrieves the SecondaryTargetSpeedZone subfield
		/// Comment: speed zone (1-10);Custom =0;</summary>
		/// <returns>Nullable uint representing the SecondaryTargetSpeedZone subfield</returns>
		public uint? SecondaryTargetSpeedZone
		{
			get
			{
				Object val = GetFieldValue(20, 0, SecondaryTargetValueSubfield.SecondaryTargetSpeedZone);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToUInt32(val));

			}
			set
			{
				SetFieldValue(20, 0, value, SecondaryTargetValueSubfield.SecondaryTargetSpeedZone);
			}
		}

		/// <summary>
		/// Retrieves the SecondaryTargetHrZone subfield
		/// Comment: hr zone (1-5);Custom =0;</summary>
		/// <returns>Nullable uint representing the SecondaryTargetHrZone subfield</returns>
		public uint? SecondaryTargetHrZone
		{
			get
			{
				Object val = GetFieldValue(20, 0, SecondaryTargetValueSubfield.SecondaryTargetHrZone);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToUInt32(val));

			}
			set
			{
				SetFieldValue(20, 0, value, SecondaryTargetValueSubfield.SecondaryTargetHrZone);
			}
		}

		/// <summary>
		/// Retrieves the SecondaryTargetCadenceZone subfield
		/// Comment: Zone (1-?); Custom = 0;</summary>
		/// <returns>Nullable uint representing the SecondaryTargetCadenceZone subfield</returns>
		public uint? SecondaryTargetCadenceZone
		{
			get
			{
				Object val = GetFieldValue(20, 0, SecondaryTargetValueSubfield.SecondaryTargetCadenceZone);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToUInt32(val));

			}
			set
			{
				SetFieldValue(20, 0, value, SecondaryTargetValueSubfield.SecondaryTargetCadenceZone);
			}
		}

		/// <summary>
		/// Retrieves the SecondaryTargetPowerZone subfield
		/// Comment: Power Zone ( 1-7); Custom = 0;</summary>
		/// <returns>Nullable uint representing the SecondaryTargetPowerZone subfield</returns>
		public uint? SecondaryTargetPowerZone
		{
			get
			{
				Object val = GetFieldValue(20, 0, SecondaryTargetValueSubfield.SecondaryTargetPowerZone);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToUInt32(val));

			}
			set
			{
				SetFieldValue(20, 0, value, SecondaryTargetValueSubfield.SecondaryTargetPowerZone);
			}
		}

		/// <summary>
		/// Retrieves the SecondaryTargetStrokeType subfield</summary>
		/// <returns>Nullable SwimStroke enum representing the SecondaryTargetStrokeType subfield</returns>
		public SwimStroke? GetSecondaryTargetStrokeType()
		{
			return (SwimStroke?)GetFieldValue(20, 0, SecondaryTargetValueSubfield.SecondaryTargetStrokeType);
		}

		/// <summary>
		///
		/// Set SecondaryTargetStrokeType subfield</summary>
		/// <param name="secondaryTargetStrokeType">Subfield value to be set</param>
		public void SetSecondaryTargetStrokeType(byte? secondaryTargetStrokeType)
		{
			SetFieldValue(20, 0, secondaryTargetStrokeType, SecondaryTargetValueSubfield.SecondaryTargetStrokeType);
		}
		///<summary>
		/// Retrieves the SecondaryCustomTargetValueLow field</summary>
		/// <returns>Returns nullable uint representing the SecondaryCustomTargetValueLow field</returns>
		public uint? SecondaryCustomTargetValueLow
		{
			get
			{
				Object val = GetFieldValue(21, 0, Fit.SubfieldIndexMainField);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToUInt32(val));

			}
			set
			{
				SetFieldValue(21, 0, value, Fit.SubfieldIndexMainField);
			}
		}


		/// <summary>
		/// Retrieves the SecondaryCustomTargetSpeedLow subfield
		/// Units: m/s</summary>
		/// <returns>Nullable float representing the SecondaryCustomTargetSpeedLow subfield</returns>
		public float? SecondaryCustomTargetSpeedLow
		{
			get
			{
				Object val = GetFieldValue(21, 0, SecondaryCustomTargetValueLowSubfield.SecondaryCustomTargetSpeedLow);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToSingle(val));

			}
			set
			{
				SetFieldValue(21, 0, value, SecondaryCustomTargetValueLowSubfield.SecondaryCustomTargetSpeedLow);
			}
		}

		/// <summary>
		/// Retrieves the SecondaryCustomTargetHeartRateLow subfield
		/// Units: % or bpm</summary>
		/// <returns>Nullable uint representing the SecondaryCustomTargetHeartRateLow subfield</returns>
		public uint? SecondaryCustomTargetHeartRateLow
		{
			get
			{
				Object val = GetFieldValue(21, 0, SecondaryCustomTargetValueLowSubfield.SecondaryCustomTargetHeartRateLow);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToUInt32(val));

			}
			set
			{
				SetFieldValue(21, 0, value, SecondaryCustomTargetValueLowSubfield.SecondaryCustomTargetHeartRateLow);
			}
		}

		/// <summary>
		/// Retrieves the SecondaryCustomTargetCadenceLow subfield
		/// Units: rpm</summary>
		/// <returns>Nullable uint representing the SecondaryCustomTargetCadenceLow subfield</returns>
		public uint? SecondaryCustomTargetCadenceLow
		{
			get
			{
				Object val = GetFieldValue(21, 0, SecondaryCustomTargetValueLowSubfield.SecondaryCustomTargetCadenceLow);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToUInt32(val));

			}
			set
			{
				SetFieldValue(21, 0, value, SecondaryCustomTargetValueLowSubfield.SecondaryCustomTargetCadenceLow);
			}
		}

		/// <summary>
		/// Retrieves the SecondaryCustomTargetPowerLow subfield
		/// Units: % or watts</summary>
		/// <returns>Nullable uint representing the SecondaryCustomTargetPowerLow subfield</returns>
		public uint? SecondaryCustomTargetPowerLow
		{
			get
			{
				Object val = GetFieldValue(21, 0, SecondaryCustomTargetValueLowSubfield.SecondaryCustomTargetPowerLow);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToUInt32(val));

			}
			set
			{
				SetFieldValue(21, 0, value, SecondaryCustomTargetValueLowSubfield.SecondaryCustomTargetPowerLow);
			}
		}
		///<summary>
		/// Retrieves the SecondaryCustomTargetValueHigh field</summary>
		/// <returns>Returns nullable uint representing the SecondaryCustomTargetValueHigh field</returns>
		public uint? SecondaryCustomTargetValueHigh
		{
			get
			{
				Object val = GetFieldValue(22, 0, Fit.SubfieldIndexMainField);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToUInt32(val));

			}
			set
			{
				SetFieldValue(22, 0, value, Fit.SubfieldIndexMainField);
			}
		}


		/// <summary>
		/// Retrieves the SecondaryCustomTargetSpeedHigh subfield
		/// Units: m/s</summary>
		/// <returns>Nullable float representing the SecondaryCustomTargetSpeedHigh subfield</returns>
		public float? SecondaryCustomTargetSpeedHigh
		{
			get
			{
				Object val = GetFieldValue(22, 0, SecondaryCustomTargetValueHighSubfield.SecondaryCustomTargetSpeedHigh);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToSingle(val));

			}
			set
			{
				SetFieldValue(22, 0, value, SecondaryCustomTargetValueHighSubfield.SecondaryCustomTargetSpeedHigh);
			}
		}

		/// <summary>
		/// Retrieves the SecondaryCustomTargetHeartRateHigh subfield
		/// Units: % or bpm</summary>
		/// <returns>Nullable uint representing the SecondaryCustomTargetHeartRateHigh subfield</returns>
		public uint? SecondaryCustomTargetHeartRateHigh
		{
			get
			{
				Object val = GetFieldValue(22, 0, SecondaryCustomTargetValueHighSubfield.SecondaryCustomTargetHeartRateHigh);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToUInt32(val));

			}
			set
			{
				SetFieldValue(22, 0, value, SecondaryCustomTargetValueHighSubfield.SecondaryCustomTargetHeartRateHigh);
			}
		}

		/// <summary>
		/// Retrieves the SecondaryCustomTargetCadenceHigh subfield
		/// Units: rpm</summary>
		/// <returns>Nullable uint representing the SecondaryCustomTargetCadenceHigh subfield</returns>
		public uint? SecondaryCustomTargetCadenceHigh
		{
			get
			{
				Object val = GetFieldValue(22, 0, SecondaryCustomTargetValueHighSubfield.SecondaryCustomTargetCadenceHigh);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToUInt32(val));

			}
			set
			{
				SetFieldValue(22, 0, value, SecondaryCustomTargetValueHighSubfield.SecondaryCustomTargetCadenceHigh);
			}
		}

		/// <summary>
		/// Retrieves the SecondaryCustomTargetPowerHigh subfield
		/// Units: % or watts</summary>
		/// <returns>Nullable uint representing the SecondaryCustomTargetPowerHigh subfield</returns>
		public uint? SecondaryCustomTargetPowerHigh
		{
			get
			{
				Object val = GetFieldValue(22, 0, SecondaryCustomTargetValueHighSubfield.SecondaryCustomTargetPowerHigh);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToUInt32(val));

			}
			set
			{
				SetFieldValue(22, 0, value, SecondaryCustomTargetValueHighSubfield.SecondaryCustomTargetPowerHigh);
			}
		}
		#endregion // Methods
	} // Class
} // namespace
