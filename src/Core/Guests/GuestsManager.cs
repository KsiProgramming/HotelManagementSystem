//-----------------------------------------------------------------------
// <copyright file="GuestsManager.cs" company="HotelManagementSystem">
//     Copyright (c) HotelManagementSystem. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace HotelManagementSystem.Guests;

public class GuestsManager
{
    private readonly IGuestsRepository repository;

    public GuestsManager(IGuestsRepository repository) => this.repository = repository;

    public async Task<IReadOnlyList<Guest>> FindAsync(GuestsQuery query) => await this.repository.FindAsync(query);
}
