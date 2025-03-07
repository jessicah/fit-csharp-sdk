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
	/// Implements the SleepAssessment profile message.
	/// </summary>
	public class SleepAssessmentMesg : Mesg
	{
		#region Fields
		#endregion

		/// <summary>
		/// Field Numbers for <see cref="SleepAssessmentMesg"/>
		/// </summary>
		public sealed class FieldDefNum
		{
			public const byte CombinedAwakeScore = 0;
			public const byte AwakeTimeScore = 1;
			public const byte AwakeningsCountScore = 2;
			public const byte DeepSleepScore = 3;
			public const byte SleepDurationScore = 4;
			public const byte LightSleepScore = 5;
			public const byte OverallSleepScore = 6;
			public const byte SleepQualityScore = 7;
			public const byte SleepRecoveryScore = 8;
			public const byte RemSleepScore = 9;
			public const byte SleepRestlessnessScore = 10;
			public const byte AwakeningsCount = 11;
			public const byte InterruptionsScore = 14;
			public const byte AverageStressDuringSleep = 15;
			public const byte Invalid = Fit.FieldNumInvalid;
		}

		#region Constructors
		public SleepAssessmentMesg() : base(Profile.GetMesg(MesgNum.SleepAssessment))
		{
		}

		public SleepAssessmentMesg(Mesg mesg) : base(mesg)
		{
		}
		#endregion // Constructors

		#region Methods
		///<summary>
		/// Retrieves the CombinedAwakeScore field
		/// Comment: Average of awake_time_score and awakenings_count_score. If valid: 0 (worst) to 100 (best). If unknown: FIT_UINT8_INVALID.</summary>
		/// <returns>Returns nullable byte representing the CombinedAwakeScore field</returns>
		public byte? CombinedAwakeScore
		{
			get
			{
				Object val = GetFieldValue(0, 0, Fit.SubfieldIndexMainField);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToByte(val));

			}
			set
			{
				SetFieldValue(0, 0, value, Fit.SubfieldIndexMainField);
			}
		}

		///<summary>
		/// Retrieves the AwakeTimeScore field
		/// Comment: Score that evaluates the total time spent awake between sleep. If valid: 0 (worst) to 100 (best). If unknown: FIT_UINT8_INVALID.</summary>
		/// <returns>Returns nullable byte representing the AwakeTimeScore field</returns>
		public byte? AwakeTimeScore
		{
			get
			{
				Object val = GetFieldValue(1, 0, Fit.SubfieldIndexMainField);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToByte(val));

			}
			set
			{
				SetFieldValue(1, 0, value, Fit.SubfieldIndexMainField);
			}
		}

		///<summary>
		/// Retrieves the AwakeningsCountScore field
		/// Comment: Score that evaluates the number of awakenings that interrupt sleep. If valid: 0 (worst) to 100 (best). If unknown: FIT_UINT8_INVALID.</summary>
		/// <returns>Returns nullable byte representing the AwakeningsCountScore field</returns>
		public byte? AwakeningsCountScore
		{
			get
			{
				Object val = GetFieldValue(2, 0, Fit.SubfieldIndexMainField);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToByte(val));

			}
			set
			{
				SetFieldValue(2, 0, value, Fit.SubfieldIndexMainField);
			}
		}

		///<summary>
		/// Retrieves the DeepSleepScore field
		/// Comment: Score that evaluates the amount of deep sleep. If valid: 0 (worst) to 100 (best). If unknown: FIT_UINT8_INVALID.</summary>
		/// <returns>Returns nullable byte representing the DeepSleepScore field</returns>
		public byte? DeepSleepScore
		{
			get
			{
				Object val = GetFieldValue(3, 0, Fit.SubfieldIndexMainField);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToByte(val));

			}
			set
			{
				SetFieldValue(3, 0, value, Fit.SubfieldIndexMainField);
			}
		}

		///<summary>
		/// Retrieves the SleepDurationScore field
		/// Comment: Score that evaluates the quality of sleep based on sleep stages, heart-rate variability and possible awakenings during the night. If valid: 0 (worst) to 100 (best). If unknown: FIT_UINT8_INVALID.</summary>
		/// <returns>Returns nullable byte representing the SleepDurationScore field</returns>
		public byte? SleepDurationScore
		{
			get
			{
				Object val = GetFieldValue(4, 0, Fit.SubfieldIndexMainField);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToByte(val));

			}
			set
			{
				SetFieldValue(4, 0, value, Fit.SubfieldIndexMainField);
			}
		}

		///<summary>
		/// Retrieves the LightSleepScore field
		/// Comment: Score that evaluates the amount of light sleep. If valid: 0 (worst) to 100 (best). If unknown: FIT_UINT8_INVALID.</summary>
		/// <returns>Returns nullable byte representing the LightSleepScore field</returns>
		public byte? LightSleepScore
		{
			get
			{
				Object val = GetFieldValue(5, 0, Fit.SubfieldIndexMainField);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToByte(val));

			}
			set
			{
				SetFieldValue(5, 0, value, Fit.SubfieldIndexMainField);
			}
		}

		///<summary>
		/// Retrieves the OverallSleepScore field
		/// Comment: Total score that summarizes the overall quality of sleep, combining sleep duration and quality. If valid: 0 (worst) to 100 (best). If unknown: FIT_UINT8_INVALID.</summary>
		/// <returns>Returns nullable byte representing the OverallSleepScore field</returns>
		public byte? OverallSleepScore
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

		///<summary>
		/// Retrieves the SleepQualityScore field
		/// Comment: Score that evaluates the quality of sleep based on sleep stages, heart-rate variability and possible awakenings during the night. If valid: 0 (worst) to 100 (best). If unknown: FIT_UINT8_INVALID.</summary>
		/// <returns>Returns nullable byte representing the SleepQualityScore field</returns>
		public byte? SleepQualityScore
		{
			get
			{
				Object val = GetFieldValue(7, 0, Fit.SubfieldIndexMainField);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToByte(val));

			}
			set
			{
				SetFieldValue(7, 0, value, Fit.SubfieldIndexMainField);
			}
		}

		///<summary>
		/// Retrieves the SleepRecoveryScore field
		/// Comment: Score that evaluates stress and recovery during sleep. If valid: 0 (worst) to 100 (best). If unknown: FIT_UINT8_INVALID.</summary>
		/// <returns>Returns nullable byte representing the SleepRecoveryScore field</returns>
		public byte? SleepRecoveryScore
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
		/// Retrieves the RemSleepScore field
		/// Comment: Score that evaluates the amount of REM sleep. If valid: 0 (worst) to 100 (best). If unknown: FIT_UINT8_INVALID.</summary>
		/// <returns>Returns nullable byte representing the RemSleepScore field</returns>
		public byte? RemSleepScore
		{
			get
			{
				Object val = GetFieldValue(9, 0, Fit.SubfieldIndexMainField);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToByte(val));

			}
			set
			{
				SetFieldValue(9, 0, value, Fit.SubfieldIndexMainField);
			}
		}

		///<summary>
		/// Retrieves the SleepRestlessnessScore field
		/// Comment: Score that evaluates the amount of restlessness during sleep. If valid: 0 (worst) to 100 (best). If unknown: FIT_UINT8_INVALID.</summary>
		/// <returns>Returns nullable byte representing the SleepRestlessnessScore field</returns>
		public byte? SleepRestlessnessScore
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
		/// Retrieves the AwakeningsCount field
		/// Comment: The number of awakenings during sleep.</summary>
		/// <returns>Returns nullable byte representing the AwakeningsCount field</returns>
		public byte? AwakeningsCount
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
		/// Retrieves the InterruptionsScore field
		/// Comment: Score that evaluates the sleep interruptions. If valid: 0 (worst) to 100 (best). If unknown: FIT_UINT8_INVALID.</summary>
		/// <returns>Returns nullable byte representing the InterruptionsScore field</returns>
		public byte? InterruptionsScore
		{
			get
			{
				Object val = GetFieldValue(14, 0, Fit.SubfieldIndexMainField);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToByte(val));

			}
			set
			{
				SetFieldValue(14, 0, value, Fit.SubfieldIndexMainField);
			}
		}

		///<summary>
		/// Retrieves the AverageStressDuringSleep field
		/// Comment: Excludes stress during awake periods in the sleep window</summary>
		/// <returns>Returns nullable float representing the AverageStressDuringSleep field</returns>
		public float? AverageStressDuringSleep
		{
			get
			{
				Object val = GetFieldValue(15, 0, Fit.SubfieldIndexMainField);
				if (val == null)
				{
					return null;
				}

				return (Convert.ToSingle(val));

			}
			set
			{
				SetFieldValue(15, 0, value, Fit.SubfieldIndexMainField);
			}
		}

		#endregion // Methods
	} // Class
} // namespace
