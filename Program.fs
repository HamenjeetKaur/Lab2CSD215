// For more information see https://aka.ms/fsharp-console-apps

type coach={
    Name: string
    Formerplayer: bool
    }
type stats={
    Wins: int
    Losses: int
    }
type team={
    Name: string
    Coach: coach
    Stats: stats
    }


let teams = [
    {Name="Indiana Pacers"; Coach={Name= "Rick Carlisle"; Formerplayer= true}; Stats={Wins=1883; Losses=1903}}
    {Name="Utah Jazz"; Coach={Name= "Quin Snyder"; Formerplayer= true}; Stats={Wins=2146; Losses=1804}}
    {Name="New York Knicks"; Coach={Name= "Tom Thibodeau"; Formerplayer= true}; Stats={Wins=2924; Losses=3099}}
    {Name="Los Angeles Clippers"; Coach={Name= "Tyronn Lue"; Formerplayer= true}; Stats={Wins=1792; Losses=2486}}
    {Name="Phoenix Suns"; Coach={Name= "Igor Kokoskov"; Formerplayer= true}; Stats={Wins=2380; Losses=2063}}
    ]

let goodteam =  teams |>  List.filter (fun teams -> teams.Stats.Wins > teams.Stats.Losses)    
goodteam |> List.iter (fun teams -> printfn " Best Team = %s" teams.Name)  

let sper teams = float teams.Stats.Wins / float (teams.Stats.Wins+ teams.Stats.Losses)*100.0
let successper = goodteam |> List.map sper
let avg = List.average successper
printfn "Average Success percentage = %f" avg