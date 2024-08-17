//-----------------------------------------------------------------------
// <copyright file="IRoomTypeCollateralRepository.cs" company="HotelManagementSystem">
//     Copyright (c) HotelManagementSystem. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace HotelManagementSystem.Marketing;

public interface IRoomTypeCollateralRepository
{
    public Task<IReadOnlyList<RoomTypeCollateral>> FindAsync(RoomTypeCollateralQuery query);
}
