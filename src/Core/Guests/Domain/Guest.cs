//-----------------------------------------------------------------------
// <copyright file="Guest.cs" company="HotelManagementSystem">
//     Copyright (c) HotelManagementSystem. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace HotelManagementSystem.Guests;

public class Guest
{
    required public string Id { get; init; }

    required public string Title { get; init; }

    required public string FirstName { get; init; }

    required public string LastName { get; init; }

    required public string Email { get; init; }

    required public string Address { get; init; }
}
