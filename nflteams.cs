using System;
using System.Collections.Generic;

class NFLTeam
{
    public string TeamName { get; set; }
    public string City { get; set; }
    public string StadiumName { get; set; }
    public int StadiumCapacity { get; set; }
    public int SuperBowlChampionships { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<NFLTeam> teams = new List<NFLTeam>()
        {
            new NFLTeam
            {
                TeamName = "Arizona Cardinals",
                City = "Glendale, Arizona",
                StadiumName = "State Farm Stadium",
                StadiumCapacity = 63400,
                SuperBowlChampionships = 0
            },
            new NFLTeam
            {
                TeamName = "Atlanta Falcons",
                City = "Atlanta, Georgia",
                StadiumName = "Mercedes-Benz Stadium",
                StadiumCapacity = 71000,
                SuperBowlChampionships = 0
            },
            new NFLTeam
            {
                TeamName = "Baltimore Ravens",
                City = "Baltimore, Maryland",
                StadiumName = "M&T Bank Stadium",
                StadiumCapacity = 71008,
                SuperBowlChampionships = 2
            },
            new NFLTeam
            {
                TeamName = "Buffalo Bills",
                City = "Buffalo, New York",
                StadiumName = "Highmark Stadium",
                StadiumCapacity = 71608,
                SuperBowlChampionships = 0
            },
            new NFLTeam
            {
                TeamName = "Carolina Panthers",
                City = "Charlotte, North Carolina",
                StadiumName = "Bank of America Stadium",
                StadiumCapacity = 75523,
                SuperBowlChampionships = 0
            },
            new NFLTeam
            {
                TeamName = "Chicago Bears",
                City = "Chicago, Illinois",
                StadiumName = "Soldier Field",
                StadiumCapacity = 61500,
                SuperBowlChampionships = 1
            },
            new NFLTeam
            {
                TeamName = "Cincinnati Bengals",
                City = "Cincinnati, Ohio",
                StadiumName = "Paul Brown Stadium",
                StadiumCapacity = 65515,
                SuperBowlChampionships = 0
            },
            new NFLTeam
            {
                TeamName = "Cleveland Browns",
                City = "Cleveland, Ohio",
                StadiumName = "FirstEnergy Stadium",
                StadiumCapacity = 67895,
                SuperBowlChampionships = 0
            },
            new NFLTeam
            {
                TeamName = "Dallas Cowboys",
                City = "Arlington, Texas",
                StadiumName = "AT&T Stadium",
                StadiumCapacity = 80000,
                SuperBowlChampionships = 5
            },
            new NFLTeam
            {
                TeamName = "Denver Broncos",
                City = "Denver, Colorado",
                StadiumName = "Empower Field at Mile High",
                StadiumCapacity = 76125,
                SuperBowlChampionships = 3
            },
            new NFLTeam
            {
                TeamName = "Detroit Lions",
                City = "Detroit, Michigan",
                StadiumName = "Ford Field",
                StadiumCapacity = 65000,
                SuperBowlChampionships = 0
            },
            new NFLTeam
            {
                TeamName = "Green Bay Packers",
                City = "Green Bay, Wisconsin",
                StadiumName = "Lambeau Field",
                StadiumCapacity = 81441,
                SuperBowlChampionships = 4
            },
            new NFLTeam
            {
                TeamName = "Houston Texans",
                City = "Houston, Texas",
                StadiumName = "NRG Stadium",
                StadiumCapacity = 72220,
                SuperBowlChampionships = 0
            },
            new NFLTeam
            {
                TeamName = "Indianapolis Colts",
                City = "Indianapolis, Indiana",
                StadiumName = "Lucas Oil Stadium",
                StadiumCapacity = 67000,
                SuperBowlChampionships = 2
            },
            new NFLTeam
            {
                TeamName = "Jacksonville Jaguars",
                City = "Jacksonville, Florida",
                StadiumName = "TIAA Bank Field",
                StadiumCapacity = 67246,
                SuperBowlChampionships = 0
            },
            new NFLTeam
            {
                TeamName = "Kansas City Chiefs",
                City = "Kansas City, Missouri",
                StadiumName = "GEHA Field at Arrowhead Stadium",
                StadiumCapacity = 76416,
                SuperBowlChampionships = 2
            },
            new NFLTeam
            {
                TeamName = "Las Vegas Raiders",
                City = "Paradise, Nevada",
                StadiumName = "Allegiant Stadium",
                StadiumCapacity = 65000,
                SuperBowlChampionships = 3
            },
            new NFLTeam
            {
                TeamName = "Los Angeles Chargers",
                City = "Inglewood, California",
                StadiumName = "SoFi Stadium",
                StadiumCapacity = 70240,
                SuperBowlChampionships = 0
            },
            new NFLTeam
            {
                TeamName = "Los Angeles Rams",
                City = "Inglewood, California",
                StadiumName = "SoFi Stadium",
                StadiumCapacity = 70240,
                SuperBowlChampionships = 1
            },
            new NFLTeam
            {
                TeamName = "Miami Dolphins",
                City = "Miami Gardens, Florida",
                StadiumName = "Hard Rock Stadium",
                StadiumCapacity = 65326,
                SuperBowlChampionships = 2
            },
            new NFLTeam
            {
                TeamName = "Minnesota Vikings",
                City = "Minneapolis, Minnesota",
                StadiumName = "U.S. Bank Stadium",
                StadiumCapacity = 66655,
                SuperBowlChampionships = 0
            },
            new NFLTeam
            {
                TeamName = "New England Patriots",
                City = "Foxborough, Massachusetts",
                StadiumName = "Gillette Stadium",
                StadiumCapacity = 65878,
                SuperBowlChampionships = 6
            },
            new NFLTeam
            {
                TeamName = "New Orleans Saints",
                City = "New Orleans, Louisiana",
                StadiumName = "Caesars Superdome",
                StadiumCapacity = 73208,
                SuperBowlChampionships = 1
            },
            new NFLTeam
            {
                TeamName = "New York Giants",
                City = "East Rutherford, New Jersey",
                StadiumName = "MetLife Stadium",
                StadiumCapacity = 82500,
                SuperBowlChampionships = 4
            },
            new NFLTeam
            {
                TeamName = "New York Jets",
                City = "East Rutherford, New Jersey",
                StadiumName = "MetLife Stadium",
                StadiumCapacity = 82500,
                SuperBowlChampionships = 1
            },
            new NFLTeam
            {
                TeamName = "Philadelphia Eagles",
                City = "Philadelphia, Pennsylvania",
                StadiumName = "Lincoln Financial Field",
                StadiumCapacity = 69796,
                SuperBowlChampionships = 1
            },
            new NFLTeam
            {
                TeamName = "Pittsburgh Steelers",
                City = "Pittsburgh, Pennsylvania",
                StadiumName = "Heinz Field",
                StadiumCapacity = 68400,
                SuperBowlChampionships = 6
            },
            new NFLTeam
            {
                TeamName = "San Francisco 49ers",
                City = "Santa Clara, California",
                StadiumName = "Levi's Stadium",
                StadiumCapacity = 68500,
                SuperBowlChampionships = 5
            },
            new NFLTeam
            {
                TeamName = "Seattle Seahawks",
                City = "Seattle, Washington",
                StadiumName = "Lumen Field",
                StadiumCapacity = 68000,
                SuperBowlChampionships = 1
            },
            new NFLTeam
            {
                TeamName = "Tampa Bay Buccaneers",
                City = "Tampa, Florida",
                StadiumName = "Raymond James Stadium",
                StadiumCapacity = 65890,
                SuperBowlChampionships = 2
            },
            new NFLTeam
            {
                TeamName = "Tennessee Titans",
                City = "Nashville, Tennessee",
                StadiumName = "Nissan Stadium",
                StadiumCapacity = 69143,
                SuperBowlChampionships = 0
            },
            new NFLTeam
            {
                TeamName = "Washington Football Team",
                City = "Landover, Maryland",
                StadiumName = "FedExField",
                StadiumCapacity = 82000,
                SuperBowlChampionships = 3
            }
        };

        Console.WriteLine("NFL Teams Information:");
        Console.WriteLine("----------------------");
        foreach (var team in teams)
        {
            Console.WriteLine($"Team: {team.TeamName}");
            Console.WriteLine($"City: {team.City}");
            Console.WriteLine($"Stadium: {team.StadiumName}");
            Console.WriteLine($"Stadium Capacity: {team.StadiumCapacity}");
            Console.WriteLine($"Super Bowl Championships: {team.SuperBowlChampionships}");
            Console.WriteLine("----------------------");
        }

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
