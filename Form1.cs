/*
Create an interface named ICalculator with methods add, subtract, divide, and multiply.

Implement them in a class: MyMath

Extra Credit:
    Use WinForms to design a simple calculator with textboxes and buttons. 
    Use the above designed interface in the calculator.
*/

// Still a few bugs, but had to move on to other assignments

namespace Assignment_4._1._2
{
    using static MyMath;
    public partial class Form1 : Form
    {
        MyMath calculation = new();
        bool needsReset = false;
        public Form1()
        {
            InitializeComponent();
            IsNum1Input = true;
            }

        private void Number_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            // send an error message if display is already 12 characters, not including negative
            if((txtDisplay.Text.StartsWith('-') ? txtDisplay.Text.Length - 1 : txtDisplay.Text.Length) == 12)
            {
                MessageBox.Show("Calculator cannot handle more than 12 digits, including a decimal point.", "Error", MessageBoxButtons.OK);
                return;
            }

            // clear display to remove leading zero unless the first button pressed was "dot"
            if (txtDisplay.Text == "0" && button.Name != "btnDot")
                txtDisplay.Text = "";

            // append number (or decimal point) to txtDisplay
            string num = button.Name switch
            {
                "btn0" => "0",
                "btn1" => "1",
                "btn2" => "2",
                "btn3" => "3",
                "btn4" => "4",
                "btn5" => "5",
                "btn6" => "6",
                "btn7" => "7",
                "btn8" => "8",
                "btn9" => "9",
                "btnDot" when !txtDisplay.Text.Contains('.') => ".", // only add . if one doesn't already exist
                _ => "" // default
            };

            if (needsReset)
            {
                txtDisplay.Text = num;
                needsReset = false;
            }
            else
            {
                txtDisplay.Text += num;
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (!IsNum1Input && Convert.ToDouble(txtDisplay.Text) == 0)
            {
                txtDisplay.Font = new Font(txtDisplay.Font.FontFamily, 11);
                txtDisplay.Text = "Cannot divide by zero.";
                DisableAllButClear();
                return;
            }

            Operator = "/";
            calculation.SetNumber(txtDisplay.Text);
            needsReset = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Operator = "+";
            calculation.SetNumber(txtDisplay.Text);
            needsReset = true;
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            Operator = "-";
            calculation.SetNumber(txtDisplay.Text);
            needsReset = true;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            Operator = "*";
            calculation.SetNumber(txtDisplay.Text);
            needsReset = true;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            double result = 0;

            if (!IsNum1Input)
            {

                calculation.SetNumber(txtDisplay.Text);
                try
                {
                    if (Operator == "/" && Num2 == 0)
                        throw new DivideByZeroException();
                }
                catch (Exception ex)
                {
                    txtDisplay.Font = new Font(txtDisplay.Font.FontFamily, 11);
                    txtDisplay.Text = "Cannot divide by zero.";
                    DisableAllButClear();
                    return;
                }

                try
                {
                    result = Operator switch
                    {
                        "+" => calculation.Add(Num1, Num2),
                        "-" => calculation.Subtract(Num1, Num2),
                        "/" => calculation.Divide(Num1, Num2),
                        "*" => calculation.Multiply(Num1, Num2),
                        _ => throw new InvalidOperationException()
                    };
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                txtDisplay.Text = Math.Round(result,12).ToString();
                IsNum1Input = true;
                needsReset = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            txtDisplay.Text = "0";
            IsNum1Input = true;

            // Reset font size
            txtDisplay.Font = new Font(txtDisplay.Font.FontFamily, 20);

            // Re-enable all buttons in case "Divide by zero" occurred
            foreach (Control control in Controls)
            {
                if (control is Button button)
                    button.Enabled = true;
            }
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);

            if (txtDisplay.Text.Length == 0)
                txtDisplay.Text = "0";
        }

        private void DisableAllButClear()
        {
            foreach (Control control in Controls)
            {
                if (control is Button button && button != btnClear)
                    button.Enabled = false;
            }
        }

        private void btnClearError_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        private void btnToggleNegative_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "0") // Only toggle if display is not "0"
            {
                if (txtDisplay.Text[0] == '-')
                    txtDisplay.Text = txtDisplay.Text.Substring(1);
                else
                    txtDisplay.Text = "-" + txtDisplay.Text;
            }
        }
    }
}
