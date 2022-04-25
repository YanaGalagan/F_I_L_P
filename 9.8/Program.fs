// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp
// See the 'F# Tutorial' project for more help.

// Define a function to construct a message to print
open System
open System.Windows.Forms
open System.Drawing

Application.EnableVisualStyles()
// Создание формы с заголовком "Работа с массивом"
let form = new Form(Text="Работа с массивом")
// Создание подписи для поля ввода
let label1 = new Label()
label1.Location<-new Point(100,25) 
label1.Text<-"массив 1" 
label1.Width<-60 
label1.Height<-12 
 
// Создание подписи для поля вывода
let label2 = new Label()
label2.Location<-new Point(100,70)
label2.Text<-" массив 2"
label2.Width<-60
label2.Height<-12
let label3 = new Label()
label3.Location<-new Point(100,110)
label3.Text<-"массив 3"
label3.Width<-60
label3.Height<-12

// Создание текстового поля для ввода информации
let txtInputA = new TextBox()
txtInputA.Location<-new Point(170,25)
txtInputA.Width<-100
txtInputA.Height<-25
txtInputA.Text<-"" 
// Создание текстового поля для вывода информации
let txtOutputB = new TextBox()
txtOutputB.Location<-new Point(170,70)
txtOutputB.Width<-100
txtOutputB.Height<-25
txtOutputB.Text<-""
let txtOutputC = new TextBox()
txtOutputC.Location<-new Point(50,150)
txtOutputC.Width<-200
txtOutputC.Height<-25
txtOutputC.Text<-""

// Создание кнопки с текстом "Вычислить!"
let button = new Button(Text="Склеить")
button.Location<-new Point(15,25) // позиция кнопки

//Добавление обработчика события - Нажатие на кнопку
button.Click.AddHandler(fun _ _ -> 
 let array3 = txtInputA.Text + ", " + txtOutputB.Text
 txtOutputC.Text <- (array3 |> sprintf "%A")
 //let run = txtInputA.Text<- (array3 |> Seq.map string |> String.concat ", ")
 array3 |> ignore)




let button2 = new Button(Text="Выход")
button2.Location<-new Point(200,235)


button2.Click.AddHandler(fun _ _ -> 
 let cl = form.Close()
 cl
 |> ignore)

//Добавление элементов на форму
form.Controls.Add(button)

form.Controls.Add(button2)

form.Controls.Add(label1)
form.Controls.Add(label2)
form.Controls.Add(label3)

form.Controls.Add(txtInputA)
form.Controls.Add(txtOutputB)
form.Controls.Add(txtOutputC)

// запуск формы
Application.Run(form)