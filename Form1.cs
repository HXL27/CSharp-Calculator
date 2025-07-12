//Need fixing have to make the calculator be able to use more than once
  

namespace CalculatorAppWindows;

using System.Windows.Forms;

public partial class Form1 : Form
{
    TextBox input, input2;

    Label result;

    Button enter, clear, add, subtract, multiply, divide;

    Boolean hasOperation;
    int answer;

    public Form1() 
    {
        InitializeComponent();
        this.Text = "Calulator App";

        this.Width = 300;
        this.Height = 200;

        input = new TextBox()
        {
            Left = 20,
            Top = 40,
            Width = 100
        };

        input2 = new TextBox()
        {
            Left = 20,
            Top = 60,
            Width = 100
        };


        enter = new Button()
        {
            Left = 20,
            Top = 80,
            Width = 50,
            Text = "Enter"
        };

        clear = new Button()
        {
            Left = 70,
            Top = 80,
            Width = 50,
            Text = "Clear"
        };

        add = new Button()
        {
            Left = 140,
            Top = 40,
            Width = 60,
            Text = "Add"
        };

        subtract = new Button()
        {
            Left = 200,
            Top = 40,
            Width = 60,
            Text = "Subtract"
        };

        multiply = new Button()
        {
            Left = 140,
            Top = 60,
            Width = 60,
            Text = "Multiply"
        };

        divide = new Button()
        {
            Left = 200,
            Top = 60,
            Width = 60,
            Text = "Divide"
        };

        result = new Label()
        {
            Left = 20,
            Top = 100,
            Width = 20
        };

        hasOperation = false;


        //adding event handlers to the buttons
        enter.Click += button1_Click;

        //reset button
        clear.Click += clear_Click;

        //event handers for operations        
        add.Click += add_Click;
        subtract.Click += subtract_Click;
        multiply.Click += multiply_Click;
        divide.Click += divide_Click;


        this.Controls.Add(input);

        this.Controls.Add(input2);  

        this.Controls.Add(enter);

        this.Controls.Add(clear);

        //operations
        this.Controls.Add(add);
        this.Controls.Add(subtract);
        this.Controls.Add(multiply);
        this.Controls.Add(divide);

        this.Controls.Add(result);

    }

    private void button1_Click(object sender, System.EventArgs e)
    {

        result.Text = answer + "";

        if (!hasOperation)
        {
            MessageBox.Show("Please select an operation");
        }

        result.Refresh();
    }

    private void clear_Click(object sender, System.EventArgs e)
    {
        result.ResetText();
        Console.WriteLine(result.Text);
    }

    private void add_Click(object sender, System.EventArgs e)
    {
        answer = int.Parse(input.Text) + int.Parse(input2.Text);
    }

    private void subtract_Click(object sender, System.EventArgs e)
    {
        answer = int.Parse(input.Text) - int.Parse(input2.Text);
    }

    private void multiply_Click(object sender, System.EventArgs e)
    {
        answer = int.Parse(input.Text) * int.Parse(input2.Text);
    }

    private void divide_Click(object sender, System.EventArgs e)
    {
        answer = int.Parse(input.Text) / int.Parse(input2.Text);
    }
}
