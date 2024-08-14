//-----------------------------------------------------------------------
// <copyright file="DateRange.cs" company="HotelManagementSystem">
//     Copyright (c) HotelManagementSystem. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace HotelManagementSystem.DatesAndTimes;

#pragma warning disable SA1313 // ParameterNamesMustBeginWithLowerCaseLetter
public record struct DateRange(DateOnly StartDate, DateOnly EndDate);
#pragma warning restore SA1313 // ParameterNamesMustBeginWithLowerCaseLetter
