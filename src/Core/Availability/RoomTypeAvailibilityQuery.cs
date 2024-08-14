//-----------------------------------------------------------------------
// <copyright file="RoomTypeAvailibilityQuery.cs" company="HotelManagementSystem">
//     Copyright (c) HotelManagementSystem. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace HotelManagementSystem.Availability;

using HotelManagementSystem.DatesAndTimes;

public class RoomTypeAvailibilityQuery
{
    public DateRange Dates { get; set; }
}
