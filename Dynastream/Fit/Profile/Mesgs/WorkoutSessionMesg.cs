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
	/// Implements the WorkoutSession profile message.
	/// </summary>
	public class WorkoutSessionMesg : Mesg
	{
		#region Fields
		#endregion

		/// <summary>
		/// Field Numbers for <see cref="WorkoutSessionMesg"/>
		/// </summary>
		public sealed class FieldDefNum
		{
			public const byte MessageIndex = 254;
			public const byte Sport = 0;
			public const byte SubSport = 1;
			public const byte NumValidSteps = 2;
			public const byte FirstStepIndex = 3;
			public const byte PoolLength = 4;
			public const byte PoolLengthUnit = 5;
			public const byte Invalid = Fit.FieldNumInvalid;
		}

		#region Constructors
		public WorkoutSessionMesg() : base(Profile.GetMesg(MesgNum.WorkoutSession))
		{
		}

		public WorkoutSessionMesg(Mesg mesg) : base(mesg)
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
		/// Retrieves the Sport field</summary>
		/// <returns>Returns nullable Sport enum representing the Sport field</returns>
		public Sport? Sport
		{
			get
			{
				object obj = GetFieldValue(0, 0, Fit.SubfieldIndexMainField);
				Sport? value = obj == null ? (Sport?)null : (Sport)obj;
				return value;
			}
			set
			{
				SetFieldValue(0, 0, value, Fit.SubfieldIndexMainField);
			}
		}

		///<summary>
		/// Retrieves the SubSport field</summary>
		/// <returns>Returns nullable SubSport enum representing the SubSport field</returns>
		public SubSport? SubSport
		{
			get
			{
				object obj = GetFieldValue(1, 0, Fit.SubfieldIndexMainField);
				SubSport? value = obj == null ? (SubSport?)null : (SubSport)obj;
				return value;
			}
			set
			{
				SetFieldValue(1, 0, value, Fit.SubfieldIndexMainField);
			}
		}

		///<summary>
		/// Retrieves the NumValidSteps field</summary>
		/// <returns>Returns nullable ushort representing the NumValidSteps field</returns>
		public ushort? NumValidSteps
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
		/// Retrieves the FirstStepIndex field</summary>
		/// <returns>Returns nullable ushort representing the FirstStepIndex field</returns>
		public ushort? FirstStepIndex
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
		/// Retrieves the PoolLength field
		/// Units: m</summary>
		/// <returns>Returns nullable float representing the PoolLength field</returns>
		public float? PoolLength
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
		/// Retrieves the PoolLengthUnit field</summary>
		/// <returns>Returns nullable DisplayMeasure enum representing the PoolLengthUnit field</returns>
		public DisplayMeasure? PoolLengthUnit
		{
			get
			{
				object obj = GetFieldValue(5, 0, Fit.SubfieldIndexMainField);
				DisplayMeasure? value = obj == null ? (DisplayMeasure?)null : (DisplayMeasure)obj;
				return value;
			}
			set
			{
				SetFieldValue(5, 0, value, Fit.SubfieldIndexMainField);
			}
		}

		#endregion // Methods
	} // Class
} // namespace
