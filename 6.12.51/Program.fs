// Learn more about F# at http://fsharp.org
//Для введенного списка построить два списка L1 и L2, где элементы L1 это неповторяющиеся элементы исходного списка, а элемент списка L2 с
//номером i показывает, сколько раз элемент списка L1 с таким номером повторяется в исходном.
open System
let rec frequency list elem count =
    match list with
    |[] -> count
    | h::t -> 
                    let count1 = count + 1
                    if h = elem then frequency t elem count1 
                    else frequency t elem count

let newL1 list =
    let rec L1 list newList=
        match list with
        |[] -> newList
        |h::t ->
              if frequency list h 0 = 1 then 
                let newList1=newList@[h]
                L1 t newList1
              else L1 t newList         
    L1 list []
    
let newL2 list listCol=
    let rec L2 list listCol list2=
        match listCol with
             |[]-> list2
             |h::t ->
                 let newE= frequency list h 0
                 let newlist=list2@[newE]
                 L2 list t newlist
    L2 list listCol []

[<EntryPoint>]
let main argv =
    printfn "Введите количество элементов списка:"
    let n = System.Convert.ToInt32(System.Console.ReadLine())
    printfn "Введите элементы списка:"
    let l= Program.readList n
    printfn" L1 "
    let k= newL1 l
    Program.writeList k
    printfn" L2 "
    newL2 l k|>Program.writeList|>ignore
    0 // return an integer exit code
