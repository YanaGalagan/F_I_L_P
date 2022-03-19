// Learn more about F# at http://fsharp.org

open System

let dobavlenie n list=
    let rec dob list n=
        if n%3=0 then list
           else 
           let newn=n+1
           let newList= list@[1]
           dob newList newn
    dob list n

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
                         
let sum list func=
    let rec s list func newList=
        match list with
        |[]-> newList
        |h::t-> 
            let s1=h
            let s2=t.Head
            let s3=t.Tail.Head
            let all= func s1 s2 s3
            let NewList1=newList@[all]
            s t.Tail.Tail func NewList1
    s list func []

[<EntryPoint>]


   
let main argv =
    let n=System.Convert.ToInt32(Console.ReadLine())
    let l= readList n
    let l2= dobavlenie n l
    let l3= sum l2 (fun x y z-> x + y + z)
    writeList l3|>ignore
    0 // return an integer exit code
