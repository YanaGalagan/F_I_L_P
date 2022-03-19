// Learn more about F# at http://fsharp.org
//дан в целочисленный массив, в котором лишь один элемент отличается. найти значение этого элемента
//5 11 5 5 5 5
open System

let poisk list=
    let rec p list  =
        match list with
        |[]-> list.Head
        |h::t->
        if list.Head<>list.Tail.Head then list.Tail.Head else p list.Tail
    p list 
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
                      


[<EntryPoint>]
let main argv =
    printfn "Введите количество элементов списка:"
    let n = System.Convert.ToInt32(System.Console.ReadLine())
    printfn "Введите элементы списка:"
    let l= readList n
    System.Console.WriteLine(poisk l)
    0 // return an integer exit code
