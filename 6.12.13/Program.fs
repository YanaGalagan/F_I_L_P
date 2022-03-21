// Learn more about F# at http://fsharp.org
//разместить элементы, расположенные до минимального, в конце массива
open System
let rec readList n = 
    if n=0 then []
    else
    let Head = System.Convert.ToInt32(System.Console.ReadLine())
    let Tail = readList (n-1)
    Head::Tail

let rec writeList = function
    [] ->   let z = System.Console.ReadKey()
            0
    | (head : int)::tail -> 
                       System.Console.WriteLine(head)
                       writeList tail 

let min_element list =
    let rec minE list init=
        match list with
        |[]->init
        |h::t ->
          let newInit =if h<init then h else init
          let newList=t
          minE newList newInit          
    minE list list.Head

let izmenenie list=
    let rec izm list =
        match list with
        |[]->list
        |h::t -> 
           if min_element list = h then list
           else 
           let newList=t@[h]
           izm newList
    izm list

        
[<EntryPoint>]
let main argv =
    printfn "Введите количество элементов списка:"
    let n = System.Convert.ToInt32(System.Console.ReadLine())
    printfn "Введите элементы списка:"
    readList n |> izmenenie|>writeList |>ignore
    

    0 // return an integer exit code
