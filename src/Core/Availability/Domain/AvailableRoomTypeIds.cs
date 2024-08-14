//-----------------------------------------------------------------------
// <copyright file="AvailableRoomTypeIds.cs" company="HotelManagementSystem">
//     Copyright (c) HotelManagementSystem. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace HotelManagementSystem.Availability;
using System.Collections.ObjectModel;

public class AvailableRoomTypeIds
{
    public Collection<int> AvailableRoomIds { get; } = new Collection<int>();
}
