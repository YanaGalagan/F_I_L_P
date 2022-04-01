// Learn more about F# at http://fsharp.org
(*3 Дана строка в которой слова записаны через пробел. Необходимо
перемешать все слова этой строки в случайном порядке.
8 Дана строка в которой записаны слова через пробел. Необходимо посчитать количество слов с четным количеством символов.
16 Дан массив в котором находятся строки "белый", "синий" и "красный" в случайном порядке. Необходимо упорядочить массив так,
чтобы получился российский флаг.*)
open System

let rec writeString = function
    |[]-> let z =System.Console.ReadKey()
          0
    |(head:string)::tail ->
                    System.Console.WriteLine(head)
                    writeString tail
// найти следующий пробел 
let probel n=
    let rec p n init s = 
        match n with 
        |""| " "-> init+1
        |_->
            match s with 
            |' '-> init
            |_ ->
                let newi= init+1
                let news = n.[0]
                let newn = n.[1..String.length n]
                p newn newi news
    p n 0 'a'
//  строки делим на слова
let razdelenie (s:string) = 
    let rec raz (s:string) (words : 'string list)  =
        match s with
        |""->words
        |_->
            let newWord = s.[0 .. (probel s-1)]
            let newS= s.[(probel s).. String.length s]
            raz newS (words@[newWord])
    raz s []

// перемешивание по длине слов
let random s =
    let newS = razdelenie s 
    let rnd = System.Random()
    let pers= List.permute (fun x->(x+5)%List.length newS)newS 
    pers
// сборка списка слов в строку
let intostring (list: 'string list) = 
    let rec r list (str : string) =
        match list with
        |[]->
            let newS = str.[1..(String.length str - 1)]
            newS
        | h::tail->
            let newS = str + " " + h
            r tail newS
    r list ""

let perWords str = intostring(random str)

let rec accCond list (f: string->int->int) p acc = 
    match list with 
    |[]->acc
    | h::tail->
            if p h then
              let newAcc= f h acc
              accCond tail f p newAcc
              else accCond tail f p acc
 
let evenWordsCount (s:string) = 
    let s1= razdelenie s
    let res = accCond s1 (fun x y-> if (x.Length % 2 = 0) then y + 1 else y ) (fun x-> true) 0
    res

let Rus (arr:string array) = 
    let newarr = Array.sortBy (fun (x:string)-> x.[1]) arr 
    newarr

let readArray n=
    let rec read n cand=
      if n=0 then cand else
       let new_el=System.Console.ReadLine()
       let newCand=Array.append cand [|new_el|]
       let newn=n-1
       read newn newCand
    read n Array.empty
let otvet n=
    match n with
    |1-> let (s:string) = Console.ReadLine()
         Console.WriteLine (perWords s)
    |2 ->let (s:string) = Console.ReadLine()
         Console.WriteLine (evenWordsCount s)
    |3-> let s=readArray 3
         printfn "%A" (Rus s)
    |_-> Console.WriteLine(0)

[<EntryPoint>]
let main argv =
    Console.WriteLine("Выберите функцию:")
    Console.WriteLine("1. Перемешать слова в строке")
    Console.WriteLine("2. Количество слов с чётным количеством букв") 
    Console.WriteLine("3.Отсортировать цвета в российский флаг")
    let n = int(Console.ReadLine())
    otvet n 
    0 // return an integer exit code
 

