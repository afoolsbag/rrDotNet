namespace rrFS

open System

/// <summary>
/// F# https://fsharp.org/
/// F# https://docs.microsoft.com/dotnet/fsharp/
/// </summary>
module EntryPoint =

    [<EntryPoint>]
    let main args =
        printfn "hello, world"
        Console.ReadLine |> ignore
        0
