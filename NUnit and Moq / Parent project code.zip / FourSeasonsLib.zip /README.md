# FourSeasonsLib

## Objective

FourSeasonsLib is a .NET Class Library that determines the season for a given month.

The library accepts a month name and returns the corresponding season.

## Project Type

Class Library (.NET Framework)

## Class

- FourSeasons

## Method

```csharp
string GetSeason(string month)
```

## Seasons

| Months | Season |
|---------|--------|
| February, March | Spring |
| April, May, June | Summer |
| July, August | Monsoon |
| September, October, November | Autumn |
| December, January | Winter |

## Features

- Case-insensitive month comparison
- Trims white spaces
- Throws exception for invalid month names
