
open System.Drawing
open System.Windows.Forms

let form = new Form(
 Width= 373, Height = 160, 
 Visible = true, 
 Text = "Кортежи в F#", 
 Menu = new MainMenu()
 )

let button1 = new Button(Text="Сумма", Left=10, Top=9, Width=75,Height=23)
let button2 = new Button(Text="Произведение", Left=91, Top=9, Width=108, Height=23)
let button3 = new Button(Text="Разность", Left=205, Top=9, Width=75, Height=23)
let button4 = new Button(Text="Деление", Left=286, Top=9, Width=75, Height=23)
let textBox1 = new TextBox(Text=" ", Left=10, Top=55, Width=55, Height=20)
let textBox2 = new TextBox(Text=" ", Left=71, Top=55, Width=55, Height=20)

let label1 = new Label(Text="?", Left=132, Top=58, Width=13, Height=13)
let label2 = new Label(Text="a", Left=31, Top=39, Width=13, Height=13)
let label3 = new Label(Text="b", Left=88, Top=39, Width=13, Height=13)

let button5 = new Button(Text="=", Left=160, Top=53, Width=32, Height=23)
let label6 = new Label(Text=" ", Left=198, Top=58, Width=60, Height=13)


form.Controls.Add(label6)
form.Controls.Add(button5)
form.Controls.Add(label3)
form.Controls.Add(label2)
form.Controls.Add(label1)
form.Controls.Add(button1)
form.Controls.Add(button2)
form.Controls.Add(button3)
form.Controls.Add(button4)
form.Controls.Add(textBox2)
form.Controls.Add(textBox1)


let contextMenuStrip1 = new ContextMenuStrip()
let toolStrip1 = new ToolStripMenuItem("+ (Сумма)")
let toolStrip2 = new ToolStripMenuItem("- (Разность)")
let toolStrip3 = new ToolStripMenuItem("* (Произведение)")
let toolStrip4 = new ToolStripMenuItem("/ (Деление)")

contextMenuStrip1.Items.Add(toolStrip1)|>ignore
contextMenuStrip1.Items.Add(toolStrip2)|>ignore
contextMenuStrip1.Items.Add(toolStrip3)|>ignore
contextMenuStrip1.Items.Add(toolStrip4)|>ignore
label1.ContextMenuStrip <- contextMenuStrip1


let krt _ = label1.Text <- "+"
let _ = toolStrip1.Click.Add(krt)
let umn _ =label1.Text <- "*"
let _ = toolStrip3.Click.Add(umn)
let raz _ =label1.Text <- "-"
let _ = toolStrip2.Click.Add(raz)
let delenie _ =label1.Text <- "/"
let _ = toolStrip4.Click.Add(delenie)
let ravno _ = 
    if fst ( textBox1.Text, textBox2.Text) = "" || snd (textBox1.Text,textBox2.Text) = "" then label6.Text <- "Оишбка" 
    else
        match label1.Text with
        |"/" ->
            let del (a:double, b:double) =
                let res = 
                    if b = 0.0 then 0.0 else System.Convert.ToDouble(a/b)
                res
            let d1 = (double textBox1.Text, double textBox2.Text)
            let d3 = del d1  
            label6.Text <- string d3
        |"+" ->
            let sum (a, b) =
                let res = a+b
                res
            let d1 = (float textBox1.Text, float textBox2.Text)
            let d3 = sum d1  
            label6.Text <- string d3
        |"-" ->
            let raznost (a, b) =
                let res = a - b
                res
            let r1 = (float textBox1.Text, float textBox2.Text)
            let r3 = raznost r1 
            label6.Text <- string r3
        |"*" ->
            let umnoj (a, b) =
                let res = a * b
                res
            let u1 = (float textBox1.Text, float textBox2.Text)
            let u3 = umnoj u1 
            label6.Text <- string u3

let _ = button5.Click.Add(ravno)


do Application.Run(form)