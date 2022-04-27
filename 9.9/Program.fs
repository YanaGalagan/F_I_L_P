// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp
// See the 'F# Tutorial' project for more help.

// Define a function to construct a message to print
open System
open System.Windows.Forms
open System.Drawing

Application.EnableVisualStyles()

let form = new Form(Width=302, Height=350,Text = "Работа со списками")

let concatbutton = new Button(Left=21, Top=38, Text="вывод списка", Width=96,
Height=23)
let concatTB = new TextBox(Left=156, Top=38, Width=114, Height=20)
let list1 = new TextBox(Left=156, Top=107, Width=114, Height=20)
let list2 = new TextBox(Left=156, Top=187, Width=114, Height=20)

form.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
form.ClientSize = new System.Drawing.Size(302, 314);

form.Controls.Add(list1);
form.Controls.Add(list2);
form.Controls.Add(concatTB);

form.Controls.Add(concatbutton);
form.Text = "Работа со списками";

form.ResumeLayout(false);
form.PerformLayout();

concatbutton.Click.AddHandler(
    fun _ _ ->
        concatTB.Text <- list1.Text + ";" + list2.Text
)

Application.Run(form)
