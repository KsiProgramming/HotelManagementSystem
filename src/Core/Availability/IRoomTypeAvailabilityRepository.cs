//-----------------------------------------------------------------------
// <copyright file="IRoomTypeAvailabilityRepository.cs" company="HotelManagementSystem">
//     Copyright (c) HotelManagementSystem. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace HotelManagementSystem.Availability;

public interface IRoomTypeAvailabilityRepository
{
    public IReadOnlyList<int> FindAvailableRoomTypeIds(RoomTypeAvailibilityQuery query);
}
