// Learn more about F# at http://fsharp.org

open System
//произведение цифр числа рекурсия вверх
let rec proizv n=
        if n=0 then 1 else
        (n%10)*proizv(n/10)

//произведение цифр числа рекурсия вниз(хвостовая)
let proizvH n=
    let rec pr n otvet=
        if n=0 then otvet
        else
        let n1=n/10
        let mn=n%10
        let newOtv=otvet*mn
        pr n1 newOtv
    pr n 1
//Максимальная цифра (вверх)
let rec maxN n=
    if n<10 then n
    else max (n%10) (maxN(n/10))

//максимальная цифра хвостовая
let maximum n=
    let rec max1 n otvet=
        if n=0 then otvet
         else  
             let n1=n/10
             let newOtvet= if n%10 > otvet then n%10 else otvet
             max1 n1 newOtvet
    max1 n 0

 //минимальная цифра числа(вверх)
let rec minN n=
    if n<10 then n
    else min (n%10) (minN(n/10))
     
//минимальная цифра числа хвостовая
let minimum n=
     let rec minn n otvet=
         if n=0 then otvet 
         else
         let n1=n/10
         let newOtvet=if n%10 < otvet then n%10 else otvet
         minn n1 newOtvet
     minn n 9
[<EntryPoint>]
let main argv =
    let a=System.Convert.ToInt32(System.Console.ReadLine())
    Console.WriteLine("Произведение (вверх):{0}",proizv a)
    Console.WriteLine("Произведение (хвостовая):{0}",proizvH a)
    Console.WriteLine("Максимальная цифра числа (вверх):{0}",maxN a)
    Console.WriteLine("Максимальная цифра числа (хвостовая):{0}",maximum a)
    Console.WriteLine("Минимальная цифра числа (вверх):{0}",minN a)
    Console.WriteLine("Минимальная цифра числа (хвостовая):{0}",minimum a)
    0 // return an integer exit code
