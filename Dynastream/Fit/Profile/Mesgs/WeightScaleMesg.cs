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
	/// Implements the WeightScale profile message.
	/// </summary>
	public class WeightScaleMesg : Mesg
	{
		#region Fields
		#endregion

		/// <summary>
		/// Field Numbers for <see cref="WeightScaleMesg"/>
		/// </summary>
		public sealed class FieldDefNum
		{
			public const byte Timestamp = 253;
			public const byte Weight = 0;
			public const byte PercentFat = 1;
			public const byte PercentHydration = 2;
			public const byte VisceralFatMass = 3;
			public const byte BoneMass = 4;
			public const byte MuscleMass = 5;
			public const byte BasalMet = 7;
			public const byte PhysiqueRating = 8;
			public const byte ActiveMet = 9;
			public const byte MetabolicAge = 10;
			public const byte VisceralFatRating = 11;
			public const byte UserProfileIndex = 12;
			public const byte Bmi = 13;
			public const byte Invalid = Fit.FieldNumInvalid;
		}

		#region Constructors
		public WeightScaleMesg() : base(Profile.GetMesg(MesgNum.WeightScale))
		{
		}

		public WeightScaleMesg(Mesg mesg) : base(mesg)
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
		/// Retrieves the Weight field
		/// Units: kg</summary>
		/// <returns>Returns nullable float representing the Weight field</returns>
		public float? Weight
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
		/// Retrieves the PercentFat field
		/// Units: %</summary>
		/// <returns>Returns nullable float representing the PercentFat field</returns>
		public float? PercentFat
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
		/// Retrieves the PercentHydration field
		/// Units: %</summary>
		/// <returns>Returns nullable float representing the PercentHydration field</returns>
		public float? PercentHydration
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
		/// Retrieves the VisceralFatMass field
		/// Units: kg</summary>
		/// <returns>Returns nullable float representing the VisceralFatMass field</returns>
		public float? VisceralFatMass
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
		/// Retrieves the BoneMass field
		/// Units: kg</summary>
		/// <returns>Returns nullable float representing the BoneMass field</returns>
		public float? BoneMass
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
		/// Retrieves the MuscleMass field
		/// Units: kg</summary>
		/// <returns>Returns nullable float representing the MuscleMass field</returns>
		public float? MuscleMass
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
		/// Retrieves the BasalMet field
		/// Units: kcal/day</summary>
		/// <returns>Returns nullable float representing the BasalMet field</returns>
		public float? BasalMet
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
		/// Retrieves the PhysiqueRating field</summary>
		/// <returns>Returns nullable byte representing the PhysiqueRating field</returns>
		public byte? PhysiqueRating
		{
			get
			{
				Object val = GetFieldValue(8, 0, Fit.SubfieldIndexMainField);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToByte(val));

			}
			set
			{
				SetFieldValue(8, 0, value, Fit.SubfieldIndexMainField);
			}
		}

		///<summary>
		/// Retrieves the ActiveMet field
		/// Units: kcal/day
		/// Comment: ~4kJ per kcal, 0.25 allows max 16384 kcal</summary>
		/// <returns>Returns nullable float representing the ActiveMet field</returns>
		public float? ActiveMet
		{
			get
			{
				Object val = GetFieldValue(9, 0, Fit.SubfieldIndexMainField);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToSingle(val));

			}
			set
			{
				SetFieldValue(9, 0, value, Fit.SubfieldIndexMainField);
			}
		}

		///<summary>
		/// Retrieves the MetabolicAge field
		/// Units: years</summary>
		/// <returns>Returns nullable byte representing the MetabolicAge field</returns>
		public byte? MetabolicAge
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
		/// Retrieves the VisceralFatRating field</summary>
		/// <returns>Returns nullable byte representing the VisceralFatRating field</returns>
		public byte? VisceralFatRating
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
		/// Retrieves the UserProfileIndex field
		/// Comment: Associates this weight scale message to a user. This corresponds to the index of the user profile message in the weight scale file.</summary>
		/// <returns>Returns nullable ushort representing the UserProfileIndex field</returns>
		public ushort? UserProfileIndex
		{
			get
			{
				Object val = GetFieldValue(12, 0, Fit.SubfieldIndexMainField);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToUInt16(val));

			}
			set
			{
				SetFieldValue(12, 0, value, Fit.SubfieldIndexMainField);
			}
		}

		///<summary>
		/// Retrieves the Bmi field
		/// Units: kg/m^2</summary>
		/// <returns>Returns nullable float representing the Bmi field</returns>
		public float? Bmi
		{
			get
			{
				Object val = GetFieldValue(13, 0, Fit.SubfieldIndexMainField);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToSingle(val));

			}
			set
			{
				SetFieldValue(13, 0, value, Fit.SubfieldIndexMainField);
			}
		}

		#endregion // Methods
	} // Class
} // namespace
