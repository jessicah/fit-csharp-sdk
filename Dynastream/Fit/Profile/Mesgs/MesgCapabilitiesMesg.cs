#region Copyright
/////////////////////////////////////////////////////////////////////////////////////////////
// Copyright 2024 Garmin International, Inc.
// Licensed under the Flexible and Interoperable Data Transfer (FIT) Protocol License; you
// may not use this file except in compliance with the Flexible and Interoperable Data
// Transfer (FIT) Protocol License.
/////////////////////////////////////////////////////////////////////////////////////////////
// ****WARNING****  This file is auto-generated!  Do NOT edit this file.
// Profile Version = 21.139.2Release
// Tag = production/release/21.139.2-0-g9eaea05
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
    /// Implements the MesgCapabilities profile message.
    /// </summary>
    public class MesgCapabilitiesMesg : Mesg
    {
        #region Fields
        static class CountSubfield
        {
            public static ushort NumPerFile = 0;
            public static ushort MaxPerFile = 1;
            public static ushort MaxPerFileType = 2;
            public static ushort Subfields = 3;
            public static ushort Active = Fit.SubfieldIndexActiveSubfield;
            public static ushort MainField = Fit.SubfieldIndexMainField;
        }
        #endregion

        /// <summary>
        /// Field Numbers for <see cref="MesgCapabilitiesMesg"/>
        /// </summary>
        public sealed class FieldDefNum
        {
            public const byte MessageIndex = 254;
            public const byte File = 0;
            public const byte MesgNum = 1;
            public const byte CountType = 2;
            public const byte Count = 3;
            public const byte Invalid = Fit.FieldNumInvalid;
        }

        #region Constructors
        public MesgCapabilitiesMesg() : base(Profile.GetMesg(MesgNum.MesgCapabilities))
        {
        }

        public MesgCapabilitiesMesg(Mesg mesg) : base(mesg)
        {
        }
        #endregion // Constructors

        #region Methods
        ///<summary>
        /// Retrieves the MessageIndex field</summary>
        /// <returns>Returns nullable ushort representing the MessageIndex field</returns>
        public ushort? GetMessageIndex()
        {
            Object val = GetFieldValue(254, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt16(val));
            
        }

        /// <summary>
        /// Set MessageIndex field</summary>
        /// <param name="messageIndex_">Nullable field value to be set</param>
        public void SetMessageIndex(ushort? messageIndex_)
        {
            SetFieldValue(254, 0, messageIndex_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the File field</summary>
        /// <returns>Returns nullable File enum representing the File field</returns>
        public File? GetFile()
        {
            object obj = GetFieldValue(0, 0, Fit.SubfieldIndexMainField);
            File? value = obj == null ? (File?)null : (File)obj;
            return value;
        }

        /// <summary>
        /// Set File field</summary>
        /// <param name="file_">Nullable field value to be set</param>
        public void SetFile(File? file_)
        {
            SetFieldValue(0, 0, file_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the MesgNum field</summary>
        /// <returns>Returns nullable ushort representing the MesgNum field</returns>
        public ushort? GetMesgNum()
        {
            Object val = GetFieldValue(1, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt16(val));
            
        }

        /// <summary>
        /// Set MesgNum field</summary>
        /// <param name="mesgNum_">Nullable field value to be set</param>
        public void SetMesgNum(ushort? mesgNum_)
        {
            SetFieldValue(1, 0, mesgNum_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the CountType field</summary>
        /// <returns>Returns nullable MesgCount enum representing the CountType field</returns>
        public MesgCount? GetCountType()
        {
            object obj = GetFieldValue(2, 0, Fit.SubfieldIndexMainField);
            MesgCount? value = obj == null ? (MesgCount?)null : (MesgCount)obj;
            return value;
        }

        /// <summary>
        /// Set CountType field</summary>
        /// <param name="countType_">Nullable field value to be set</param>
        public void SetCountType(MesgCount? countType_)
        {
            SetFieldValue(2, 0, countType_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Count field</summary>
        /// <returns>Returns nullable ushort representing the Count field</returns>
        public ushort? GetCount()
        {
            Object val = GetFieldValue(3, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt16(val));
            
        }

        /// <summary>
        /// Set Count field</summary>
        /// <param name="count_">Nullable field value to be set</param>
        public void SetCount(ushort? count_)
        {
            SetFieldValue(3, 0, count_, Fit.SubfieldIndexMainField);
        }
        

        /// <summary>
        /// Retrieves the NumPerFile subfield</summary>
        /// <returns>Nullable ushort representing the NumPerFile subfield</returns>
        public ushort? GetNumPerFile()
        {
            Object val = GetFieldValue(3, 0, CountSubfield.NumPerFile);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt16(val));
            
        }

        /// <summary>
        ///
        /// Set NumPerFile subfield</summary>
        /// <param name="numPerFile">Subfield value to be set</param>
        public void SetNumPerFile(ushort? numPerFile)
        {
            SetFieldValue(3, 0, numPerFile, CountSubfield.NumPerFile);
        }

        /// <summary>
        /// Retrieves the MaxPerFile subfield</summary>
        /// <returns>Nullable ushort representing the MaxPerFile subfield</returns>
        public ushort? GetMaxPerFile()
        {
            Object val = GetFieldValue(3, 0, CountSubfield.MaxPerFile);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt16(val));
            
        }

        /// <summary>
        ///
        /// Set MaxPerFile subfield</summary>
        /// <param name="maxPerFile">Subfield value to be set</param>
        public void SetMaxPerFile(ushort? maxPerFile)
        {
            SetFieldValue(3, 0, maxPerFile, CountSubfield.MaxPerFile);
        }

        /// <summary>
        /// Retrieves the MaxPerFileType subfield</summary>
        /// <returns>Nullable ushort representing the MaxPerFileType subfield</returns>
        public ushort? GetMaxPerFileType()
        {
            Object val = GetFieldValue(3, 0, CountSubfield.MaxPerFileType);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt16(val));
            
        }

        /// <summary>
        ///
        /// Set MaxPerFileType subfield</summary>
        /// <param name="maxPerFileType">Subfield value to be set</param>
        public void SetMaxPerFileType(ushort? maxPerFileType)
        {
            SetFieldValue(3, 0, maxPerFileType, CountSubfield.MaxPerFileType);
        }
        #endregion // Methods
    } // Class
} // namespace
