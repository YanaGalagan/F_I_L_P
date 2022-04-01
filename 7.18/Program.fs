// Learn more about F# at http://fsharp.org
(*Объединить два произвольных массива в один.*)
open System
let readArray n=
    let rec read n cand=
      if n=0 then cand else
       let new_el=System.Convert.ToInt32(System.Console.ReadLine())
       let newCand=Array.append cand [|new_el|]
       let newn=n-1
       read newn newCand
    read n Array.empty

let printArray array=
    printf "%A" array
[<EntryPoint>]
let main argv =
    printf "Введите размерность первого списка:"
    let n=System.Convert.ToInt32(System.Console.ReadLine())
    printf "Введите элементы первого списка:"
    let l1=readArray n
    printf "Введите размерность второго списка:"
    let k=System.Convert.ToInt32(System.Console.ReadLine())
    printf "Введите элементы второго списка:"
    let l2=readArray k
    let l3=Array.append l1 l2 
    printArray l3
    0 // return an integer exit code
