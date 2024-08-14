//-----------------------------------------------------------------------
// <copyright file="RoomTypeAvailabilityManager.cs" company="HotelManagementSystem">
//     Copyright (c) HotelManagementSystem. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace HotelManagementSystem.Availability;

public class RoomTypeAvailabilityManager
{
    private readonly IRoomTypeAvailabilityRepository repository;

    public RoomTypeAvailabilityManager(IRoomTypeAvailabilityRepository repository)
    {
        this.repository = repository;
    }

    public IReadOnlyList<int> FindAvailableRoomTypeIds(RoomTypeAvailibilityQuery query)
    {
        return this.repository.FindAvailableRoomTypeIds(query);
    }
}
