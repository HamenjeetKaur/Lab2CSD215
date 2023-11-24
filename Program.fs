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
