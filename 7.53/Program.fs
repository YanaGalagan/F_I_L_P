// Learn more about F# at http://fsharp.org
(*1.53. Для введенного списка построить новый с элементами, большими, чем
среднее арифметическое списка, но меньшими, чем его максимальное
значение.*)
open System

let rec readList n =
   Console.WriteLine("Введите элементы:")
   List.init(n) (fun index->Console.ReadLine()|>Double.Parse)

let readData = 
   Console.WriteLine("Введите количество элементов:")
   let n=System.Convert.ToInt32(System.Console.ReadLine())
   readList n

[<EntryPoint>]
let main argv =
    let l = readData
    let sredn = List.average l
    let max = List.max l
    Program.writelist(List.filter (fun x -> x>sredn && x<max) l)
    0 // return an integer exit code
