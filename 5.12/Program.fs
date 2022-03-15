// Learn more about F# at http://fsharp.org

open System
let otvet (k: String)=
     if k="Prolog" || k="F#" then System.Console.WriteLine("Вы подлиза!")
       else 
       if k="C#" then System.Console.WriteLine("Мы подружимся!")
       else 
         if k="Pascal" then System.Console.WriteLine("Вы Кирилл Цветков?")
         else 
           if k="C++" then System.Console.WriteLine("Привет, первокурсник ФКТиПМ")
           else 
             if k="Java" then System.Console.WriteLine("Ква")
             else 
                if k="Python" then System.Console.WriteLine("*Шипит по змеиному*")
                  else 
                  System.Console.WriteLine("До 7 считать умеете ?")


[<EntryPoint>]
let main argv =
    System.Console.WriteLine("Выберите ваш любимый язык программирования (введите номер из списка):")
    System.Console.WriteLine("1.Prolog")
    System.Console.WriteLine("2.F#")
    System.Console.WriteLine("3.C#")
    System.Console.WriteLine("4.Pascal")
    System.Console.WriteLine("5.C++")
    System.Console.WriteLine("6.Java")
    System.Console.WriteLine("7.Python")
    //cуперпозиция
    (Console.ReadLine >> otvet)()
    //каррирование
    let pot (x:string->unit) y  =  x(y())
    pot otvet Console.ReadLine 
  
    0 // return an integer exit code