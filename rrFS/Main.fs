/// <summary>
/// <para> F# https://fsharp.org/ </para>
/// <para> F# https://docs.microsoft.com/dotnet/fsharp/ </para>
/// </summary>
module RrFS

open System

[<EntryPoint>]
let main argv = 
    printfn "hello, fsharp" 
    Console.ReadLine() |> ignore
    0 
