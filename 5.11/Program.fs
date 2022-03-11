// Learn more about F# at http://fsharp.org

open System
let otvet k=
     if k=1 || k=2 then System.Console.WriteLine("Вы подлиза!")
       else 
       if k=3 then System.Console.WriteLine("Мы подружимся!")
       else 
         if k=4 then System.Console.WriteLine("Вы Кирилл Цветков?")
         else 
           if k=5 then System.Console.WriteLine("Привет, первокурсник ФКТиПМ")
           else 
             if k=6 then System.Console.WriteLine("Ква")
             else 
                if k=7 then System.Console.WriteLine("*Шипит по змеиному*")
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
    let a= System.Convert.ToInt32(System.Console.ReadLine())
    otvet a 
    0 // return an integer exit code