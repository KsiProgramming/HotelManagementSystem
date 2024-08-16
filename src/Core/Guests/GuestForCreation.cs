//-----------------------------------------------------------------------
// <copyright file="GuestForCreation.cs" company="HotelManagementSystem">
//     Copyright (c) HotelManagementSystem. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace HotelManagementSystem.Guests;

public class GuestForCreation
{
    required public string ReservationUuid { get; init; }

    required public Guest Guest { get; init; }
}
