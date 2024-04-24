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

namespace Dynastream.Fit
{
    /// <summary>
    /// Implements the profile LapTrigger type as an enum
    /// </summary>
    public enum LapTrigger : byte
    {
        Manual = 0,
        Time = 1,
        Distance = 2,
        PositionStart = 3,
        PositionLap = 4,
        PositionWaypoint = 5,
        PositionMarked = 6,
        SessionEnd = 7,
        FitnessEquipment = 8,
        Invalid = 0xFF


    }
}

