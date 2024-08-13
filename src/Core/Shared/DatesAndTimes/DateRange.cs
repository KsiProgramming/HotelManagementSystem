//-----------------------------------------------------------------------
// <copyright file="DateRange.cs" company="HotelManagementSystem">
//     Copyright (c) HotelManagementSystem. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace HotelManagementSystem.Core.Shared.DatesAndTimes;

public record struct DateRange(DateOnly StartDate, DateOnly EndDate);
