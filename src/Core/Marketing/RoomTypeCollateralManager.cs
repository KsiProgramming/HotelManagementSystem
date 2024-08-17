//-----------------------------------------------------------------------
// <copyright file="RoomTypeCollateralManager.cs" company="HotelManagementSystem">
//     Copyright (c) HotelManagementSystem. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace HotelManagementSystem.Marketing;

public class RoomTypeCollateralManager
{
    private readonly IRoomTypeCollateralRepository repository;

    public RoomTypeCollateralManager(IRoomTypeCollateralRepository repository)
    {
        this.repository = repository;
    }

    public async Task<IReadOnlyList<RoomTypeCollateral>> FindAsync(RoomTypeCollateralQuery query)
    {
        return await this.repository.FindAsync(query);
    }
}
