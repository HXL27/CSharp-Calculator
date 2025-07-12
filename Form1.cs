// Declare the namespace for this calculator app
namespace CalculatorAppWindows;

using System.Windows.Forms; // Import necessary Windows Forms components

// Define a partial class for the main form (UI)
public partial class Form1 : Form
{
    // Declare form controls
    TextBox input, input2;             // Two textboxes for user input
    Label result;                      // Label to display the result
    Button enter, clear;              // Enter and Clear buttons
    Button add, subtract, multiply, divide;  // Operation buttons

    Boolean hasOperation;             // Flag to indicate if an operation was selected
    int answer;                       // Stores result of the operation

    // Constructor for initializing the form
    public Form1() 
    {
        InitializeComponent();        // Initialize form components
        this.Text = "Calulator App";  // Set form title (Note: typo in "Calculator")

        // Set form size
        this.Width = 300;
        this.Height = 200;

        // Create and position first input TextBox
        input = new TextBox()
        {
            Left = 20,
            Top = 40,
            Width = 100
        };

        // Create and position second input TextBox
        input2 = new TextBox()
        {
            Left = 20,
            Top = 60,
            Width = 100
        };

        // Create Enter button to show the result
        enter = new Button()
        {
            Left = 20,
            Top = 80,
            Width = 50,
            Text = "Enter"
        };

        // Create Clear button to reset the result label
        clear = new Button()
        {
            Left = 70,
            Top = 80,
            Width = 50,
            Text = "Clear"
        };

        // Create Add button
        add = new Button()
        {
            Left = 140,
            Top = 40,
            Width = 60,
            Text = "Add"
        };

        // Create Subtract button
        subtract = new Button()
        {
            Left = 200,
            Top = 40,
            Width = 60,
            Text = "Subtract"
        };

        // Create Multiply button
        multiply = new Button()
        {
            Left = 140,
            Top = 60,
            Width = 60,
            Text = "Multiply"
        };

        // Create Divide button
        divide = new Button()
        {
            Left = 200,
            Top = 60,
            Width = 60,
            Text = "Divide"
        };

        // Create result label to show output
        result = new Label()
        {
            Left = 20,
            Top = 100,
            Width = 20
        };

        hasOperation = false; // Initially, no operation is selected

        // Assign event handlers to each button
        enter.Click += button1_Click;         // Shows result when clicked
        clear.Click += clear_Click;           // Resets result label
        add.Click += add_Click;               // Performs addition
        subtract.Click += subtract_Click;     // Performs subtraction
        multiply.Click += multiply_Click;     // Performs multiplication
        divide.Click += divide_Click;         // Performs division

        // Add all controls to the form
        this.Controls.Add(input);
        this.Controls.Add(input2);
        this.Controls.Add(enter);
        this.Controls.Add(clear);
        this.Controls.Add(add);
        this.Controls.Add(subtract);
        this.Controls.Add(multiply);
        this.Controls.Add(divide);
        this.Controls.Add(result);
    }

    // Event handler for Enter button
    private void button1_Click(object sender, System.EventArgs e)
    {
        result.Text = answer + "";  // Convert result to string and display

        if (!hasOperation)          // If no operation was chosen, warn the user
        {
            MessageBox.Show("Please select an operation");
        }

        result.Refresh();           // Refresh the result label
    }

    // Event handler for Clear button
    private void clear_Click(object sender, System.EventArgs e)
    {
        result.ResetText();         // Clear the result label
        Console.WriteLine(result.Text); // (Debug) Show result in console
    }

    // Event handler for Add button
    private void add_Click(object sender, System.EventArgs e)
    {
        answer = int.Parse(input.Text) + int.Parse(input2.Text); // Calculate sum
        hasOperation = true;
    }

    // Event handler for Subtract button
    private void subtract_Click(object sender, System.EventArgs e)
    {
        answer = int.Parse(input.Text) - int.Parse(input2.Text); // Calculate difference
        hasOperation = true;
    }

    // Event handler for Multiply button
    private void multiply_Click(object sender, System.EventArgs e)
    {
        answer = int.Parse(input.Text) * int.Parse(input2.Text); // Calculate product
        hasOperation = true;
    }

    // Event handler for Divide button
    private void divide_Click(object sender, System.EventArgs e)
    {
        answer = int.Parse(input.Text) / int.Parse(input2.Text); // Calculate quotient
        hasOperation = true;
    }
}
