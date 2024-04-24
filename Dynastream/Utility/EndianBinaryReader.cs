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

namespace Dynastream.Utility
{
    /// <summary>
    /// Extend framework BinaryReader to support BigEndian datasources.
    /// When reading multibyte values, the bytes are reordered appropriately.
    /// </summary>
    public class EndianBinaryReader : BinaryReader
    {
        #region Fields
        private bool isBigEndian = false;
        #endregion

        #region Properties
        public bool IsBigEndian
        {
            get { return isBigEndian; }
            set { isBigEndian = value; }
        }
        #endregion

        #region Constructors
        public EndianBinaryReader(Stream input, Encoding encoding, bool isBigEndian)
            : base(input, encoding)
        {
            this.isBigEndian = isBigEndian;
        }

        public EndianBinaryReader(Stream input, bool isBigEndian)
            : this(input, Encoding.UTF8, isBigEndian)
        {
        }
        #endregion

        #region Methods
        public override short ReadInt16()
        {
            if (!IsBigEndian)
            {
                return base.ReadInt16();
            }
            byte[] buffer = new byte[2];
            Read(buffer, 0, 2);
            Array.Reverse(buffer);

            return BitConverter.ToInt16(buffer, 0);
        }

        public override ushort ReadUInt16()
        {
            if (!IsBigEndian)
            {
                return base.ReadUInt16();
            }
            byte[] buffer = new byte[2];
            Read(buffer, 0, 2);
            Array.Reverse(buffer);

            return BitConverter.ToUInt16(buffer, 0);
        }

        public override int ReadInt32()
        {
            if (!IsBigEndian)
            {
                return base.ReadInt32();
            }
            byte[] buffer = new byte[4];
            Read(buffer, 0, 4);
            Array.Reverse(buffer);

            return BitConverter.ToInt32(buffer, 0);
        }

        public override uint ReadUInt32()
        {
            if (!IsBigEndian)
            {
                return base.ReadUInt32();
            }
            byte[] buffer = new byte[4];
            Read(buffer, 0, 4);
            Array.Reverse(buffer);

            return BitConverter.ToUInt32(buffer, 0);
        }

        public override long ReadInt64()
        {
            if (!IsBigEndian)
            {
                return base.ReadInt64();
            }
            byte[] buffer = new byte[8];
            Read(buffer, 0, 8);
            Array.Reverse(buffer);

            return BitConverter.ToInt64(buffer, 0);
        }

        public override ulong ReadUInt64()
        {
            if (!IsBigEndian)
            {
                return base.ReadUInt64();
            }
            byte[] buffer = new byte[8];
            Read(buffer, 0, 8);
            Array.Reverse(buffer);

            return BitConverter.ToUInt64(buffer, 0);
        }

        public override float ReadSingle()
        {
            if (!IsBigEndian)
            {
                return base.ReadSingle();
            }
            byte[] buffer = new byte[4];
            Read(buffer, 0, 4);
            Array.Reverse(buffer);

            return BitConverter.ToSingle(buffer, 0);
        }

        public override double ReadDouble()
        {
            if (!IsBigEndian)
            {
                return base.ReadDouble();
            }
            byte[] buffer = new byte[8];
            Read(buffer, 0, 8);
            Array.Reverse(buffer);

            return BitConverter.ToDouble(buffer, 0);
        }
        #endregion
    }
} // namespace
