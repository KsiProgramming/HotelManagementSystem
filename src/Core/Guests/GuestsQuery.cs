//-----------------------------------------------------------------------
// <copyright file="GuestsQuery.cs" company="HotelManagementSystem">
//     Copyright (c) HotelManagementSystem. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace HotelManagementSystem.Guests;

using System.Collections.ObjectModel;

public class GuestsQuery
{
    public Collection<int> Ids { get; } = new Collection<int>();
}
