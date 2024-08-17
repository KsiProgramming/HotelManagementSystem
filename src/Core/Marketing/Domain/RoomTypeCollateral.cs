//-----------------------------------------------------------------------
// <copyright file="RoomTypeCollateral.cs" company="HotelManagementSystem">
//     Copyright (c) HotelManagementSystem. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace HotelManagementSystem.Marketing;

public class RoomTypeCollateral
{
    required public int RoomTypeId { get; init; }

    required public string Description { get; init; }

    required public string ImageUri { get; init; }
}
