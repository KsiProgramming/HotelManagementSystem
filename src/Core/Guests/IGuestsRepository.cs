//-----------------------------------------------------------------------
// <copyright file="IGuestsRepository.cs" company="HotelManagementSystem">
//     Copyright (c) HotelManagementSystem. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace HotelManagementSystem.Guests;

public interface IGuestsRepository
{
    public Task<IReadOnlyList<Guest>> FindAsync(GuestsQuery query);
}
