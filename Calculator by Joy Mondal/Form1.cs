namespace Calculator_by_Joy_Mondal
{
    public partial class Form : System.Windows.Forms.Form
    {
        Double resultValue = 0;
        String operationParformed = "";
        bool isOperationPerformed=false;
        private string operationPerformed;

        public Form()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((text_box.Text == "0") ||(isOperationPerformed))
                text_box.Clear();
            isOperationPerformed = false;
            Button button = (Button)sender;

            if (button.Text == ".")
            {
                if (!text_box.Text.Contains("."))
                    text_box.Text = text_box.Text + button.Text;
            }
            else
            text_box.Text = text_box.Text + button.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultValue !=0)
            {
                button11.PerformClick();
                operationParformed = button.Text;
                label_result.Text = resultValue + " " + operationParformed;
                isOperationPerformed = true;
            }
            else
            {
                operationParformed = button.Text;
                resultValue = Double.Parse(text_box.Text);
                label_result.Text = resultValue + " " + operationParformed;
                isOperationPerformed = true;
            }


        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            text_box.Text = "0";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            text_box.Text = "0";
            resultValue = 0;
        }

        private void button11_Click(object sender, EventArgs e)
        {
           switch (operationParformed)
            {
                case "+":
                    text_box.Text = (resultValue + Double.Parse(text_box.Text)).ToString();
                    break;
                case "-":
                    text_box.Text = (resultValue - Double.Parse(text_box.Text)).ToString();
                    break;
                case "*":
                    text_box.Text = (resultValue * Double.Parse(text_box.Text)).ToString();
                    break;
                case "/":
                    text_box.Text = (resultValue / Double.Parse(text_box.Text)).ToString();
                    break;
                default:
                    break;

            }
            resultValue=Double.Parse(text_box.Text);
            label_result.Text = "";
        }
    }
}