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
	/// Implements the SlaveDevice profile message.
	/// </summary>
	public class SlaveDeviceMesg : Mesg
	{
		#region Fields
		static class ProductSubfield
		{
			public static ushort FaveroProduct = 0;
			public static ushort GarminProduct = 1;
			public static ushort Subfields = 2;
			public static ushort Active = Fit.SubfieldIndexActiveSubfield;
			public static ushort MainField = Fit.SubfieldIndexMainField;
		}
		#endregion

		/// <summary>
		/// Field Numbers for <see cref="SlaveDeviceMesg"/>
		/// </summary>
		public sealed class FieldDefNum
		{
			public const byte Manufacturer = 0;
			public const byte Product = 1;
			public const byte Invalid = Fit.FieldNumInvalid;
		}

		#region Constructors
		public SlaveDeviceMesg() : base(Profile.GetMesg(MesgNum.SlaveDevice))
		{
		}

		public SlaveDeviceMesg(Mesg mesg) : base(mesg)
		{
		}
		#endregion // Constructors

		#region Methods
		///<summary>
		/// Retrieves the Manufacturer field</summary>
		/// <returns>Returns nullable ushort representing the Manufacturer field</returns>
		public ushort? Manufacturer
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
		/// Retrieves the Product field</summary>
		/// <returns>Returns nullable ushort representing the Product field</returns>
		public ushort? Product
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


		/// <summary>
		/// Retrieves the FaveroProduct subfield</summary>
		/// <returns>Nullable ushort representing the FaveroProduct subfield</returns>
		public ushort? FaveroProduct
		{
			get
			{
				Object val = GetFieldValue(1, 0, ProductSubfield.FaveroProduct);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToUInt16(val));

			}
			set
			{
				SetFieldValue(1, 0, value, ProductSubfield.FaveroProduct);
			}
		}

		/// <summary>
		/// Retrieves the GarminProduct subfield</summary>
		/// <returns>Nullable ushort representing the GarminProduct subfield</returns>
		public ushort? GarminProduct
		{
			get
			{
				Object val = GetFieldValue(1, 0, ProductSubfield.GarminProduct);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToUInt16(val));

			}
			set
			{
				SetFieldValue(1, 0, value, ProductSubfield.GarminProduct);
			}
		}
		#endregion // Methods
	} // Class
} // namespace
