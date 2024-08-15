//-----------------------------------------------------------------------
// <copyright file="RoomTypeAvailabilityByDate.cs" company="HotelManagementSystem">
//     Copyright (c) HotelManagementSystem. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace HotelManagementSystem.Availability;

using System.Collections.ObjectModel;

public class RoomTypeAvailabilityByDate
{
    required public DateOnly Date { get; init; }

    public Collection<int> AvailableRoomTypes { get; } = new Collection<int>();
}
