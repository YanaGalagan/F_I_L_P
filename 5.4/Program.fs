// Learn more about F# at http://fsharp.org

let rec cifrSum n = 
    if n = 0 then 0
    else (n%10) + (cifrSum (n / 10))
[<EntryPoint>]
let main argv = 
    System.Convert.ToInt32(System.Console.ReadLine()) |> cifrSum |> System.Console.WriteLine
    let z = System.Console.ReadKey()
    0 // возвращение целочисленного кода выхода
