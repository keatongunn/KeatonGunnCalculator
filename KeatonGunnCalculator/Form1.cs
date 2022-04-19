namespace KeatonGunnCalculator
{
    public partial class Form1 : Form
    {
        public bool NonNumberEntered { get; set; }
        public double StoredAnswer { get; set; }
        public string StoredOperation { get; set; }

        public event System.Windows.Forms.KeyPressEventHandler KeyPress;

        public bool IsBinary { get; set; } = false;
 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e) // 0
        {
            NumDisplay.Text = NumDisplay.Text + 0;
        }

        private void NumBtn1_Click(object sender, EventArgs e)
        {
            NumDisplay.Text = NumDisplay.Text + 1;
        }

        private void NumBtn2_Click(object sender, EventArgs e)
        {
            NumDisplay.Text = NumDisplay.Text + 2;
        }

        private void NumBtn3_Click(object sender, EventArgs e)
        {
            NumDisplay.Text = NumDisplay.Text + 3;
        }

        private void NumBtn4_Click(object sender, EventArgs e)
        {
            NumDisplay.Text = NumDisplay.Text + 4;
        }

        private void button5_Click(object sender, EventArgs e) // 5
        {
            NumDisplay.Text = NumDisplay.Text + 5;
        }

        private void NumBtn6_Click(object sender, EventArgs e)
        {
            NumDisplay.Text = NumDisplay.Text + 6;
        }

        private void NumBtn7_Click(object sender, EventArgs e)
        {
            NumDisplay.Text = NumDisplay.Text + 7;
        }

        private void NumBtn8_Click(object sender, EventArgs e)
        {
            NumDisplay.Text = NumDisplay.Text + 8;
        }

        private void NumBtn9_Click(object sender, EventArgs e)
        {
            NumDisplay.Text = NumDisplay.Text + 9;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            NumDisplay.Text = "";
            StoredAnswer = 0;
            StoredBox.Text = "";
            OpBox.Text = "";
        }

        private void button11_Click(object sender, EventArgs e) // DEL
        {
            if(NumDisplay.Text.Length > 0)
            {
                NumDisplay.Text = NumDisplay.Text.Remove(NumDisplay.Text.Length - 1);
            }
            
        }

        private void BinBtn_Click(object sender, EventArgs e)
        {
            if(NumDisplay.Text.Length > 0 && IsBinary == false)
            {
                int NumToConvert = int.Parse(NumDisplay.Text);
                if (NumToConvert >= 0)
                {
                    string binary = Convert.ToString(NumToConvert, 2);
                    IsBinary = true;
                    NumDisplay.Text = binary;
                }
                if(NumToConvert < 0)
                {
                    NumDisplay.Text = "ERROR";                    
                }
                
            }                                   
        }

        private void DecConvBtn_Click(object sender, EventArgs e)
        {
            if(NumDisplay.Text.Length > 0 && IsBinary == true)
            {
                string TextConvert = NumDisplay.Text;
                int NumToCon = Convert.ToInt32(TextConvert, 2);
                string DecimalOutput = NumToCon.ToString();
                NumDisplay.Text = DecimalOutput;
                IsBinary = false;
            }
            else
            {
                NumDisplay.Text = "ERROR - INVALID INPUT";
            }
        }

        private void XBtn_Click(object sender, EventArgs e)
        {
            if (StoredOperation != "*")
            {
                EqualButton_Click(sender, e);
                StoredOperation = "*";
                OpBox.Text = $"{StoredOperation}";
            }
            if (NumDisplay.Text.Length > 0)
            {
                double BottomNumber = double.Parse(NumDisplay.Text);
                if (StoredBox.Text.Length > 0)
                {
                    double TopNumber = double.Parse(StoredBox.Text);
                    StoredAnswer = TopNumber * BottomNumber;
                    NumDisplay.Text = "";
                    StoredBox.Text = $"{StoredAnswer}";
                    OpBox.Text = $"{StoredOperation}";

                }
                else
                {
                    NumDisplay.Text = "";
                    StoredBox.Text = $"{BottomNumber}";
                    OpBox.Text = $"{StoredOperation}";
                }
            }
        }

        private void DivBtn_Click(object sender, EventArgs e)
        {
            if (StoredOperation != "/")
            {
                EqualButton_Click(sender, e);
                StoredOperation = "/";
                OpBox.Text = $"{StoredOperation}";
            }
            if (NumDisplay.Text.Length > 0)
            {
                double BottomNumber = double.Parse(NumDisplay.Text);
                if (StoredBox.Text.Length > 0)
                {
                    double TopNumber = double.Parse(StoredBox.Text);
                    StoredAnswer = TopNumber / BottomNumber;
                    NumDisplay.Text = "";
                    StoredBox.Text = $"{StoredAnswer}";
                    OpBox.Text = $"{StoredOperation}";

                }
                else
                {
                    NumDisplay.Text = "";
                    StoredBox.Text = $"{BottomNumber}";
                    OpBox.Text = $"{StoredOperation}";
                }
            }
        }

        private void PlusBtn_Click(object sender, EventArgs e)
        {
            if(StoredOperation != "+")
            {
                EqualButton_Click(sender, e);
                StoredOperation = "+";
                OpBox.Text = $"{StoredOperation}";
            }

            if (NumDisplay.Text.Length > 0)
            {
                double BottomNumber = double.Parse(NumDisplay.Text);
                if (StoredBox.Text.Length > 0)
                {

                    double TopNumber = double.Parse(StoredBox.Text);
                    StoredAnswer = TopNumber + BottomNumber;
                    NumDisplay.Text = "";
                    StoredBox.Text = $"{StoredAnswer}";
                    OpBox.Text = $"{StoredOperation}";

                }
                else
                {
                    NumDisplay.Text = "";
                    StoredBox.Text = $"{BottomNumber}";
                    OpBox.Text = $"{StoredOperation}";
                }
            }
            
        }

        private void MinBtn_Click(object sender, EventArgs e)
        {
            if (StoredOperation != "-")
            {
                EqualButton_Click(sender, e);
                StoredOperation = "-";
                OpBox.Text = $"{StoredOperation}";
            }

            if (NumDisplay.Text.Length > 0)
            {
                double BottomNumber = double.Parse(NumDisplay.Text);
                if (StoredBox.Text.Length > 0)
                {

                    double TopNumber = double.Parse(StoredBox.Text);
                    StoredAnswer = TopNumber - BottomNumber;
                    NumDisplay.Text = "";
                    StoredBox.Text = $"{StoredAnswer}";
                    OpBox.Text = $"{StoredOperation}";

                }
                else
                {
                    NumDisplay.Text = "";
                    StoredBox.Text = $"{BottomNumber}";
                    OpBox.Text = $"{StoredOperation}";
                }
            }
        }
        private void EqualButton_Click(object sender, EventArgs e)
        {            
            
            if(StoredBox.Text.Length > 0 && NumDisplay.Text.Length > 0 && NumDisplay.Text != "\r\n")
            {
                double BottomNumber = double.Parse(NumDisplay.Text);
                double TopNumber = double.Parse(StoredBox.Text);
                switch (StoredOperation)
                {
                    case "+":
                        StoredAnswer = TopNumber + BottomNumber;
                        StoredBox.Text = $"{StoredAnswer}";
                        NumDisplay.Text = "";
                        StoredOperation = "";
                        break;
                    case "-":
                        StoredAnswer = TopNumber - BottomNumber;
                        StoredBox.Text = $"{StoredAnswer}";
                        NumDisplay.Text = "";
                        StoredOperation = "";
                        break;
                    case "*":
                        StoredAnswer = TopNumber * BottomNumber;
                        StoredBox.Text = $"{StoredAnswer}";
                        NumDisplay.Text = "";
                        StoredOperation = "";
                        break;
                    case "/":
                        StoredAnswer = TopNumber / BottomNumber;
                        StoredBox.Text = $"{StoredAnswer}";
                        NumDisplay.Text = "";
                        StoredOperation = "";
                        break;
    

                }
            }
            StoredOperation = "";
            OpBox.Text = $"{StoredOperation}";
        }

        private void DecBtn_Click(object sender, EventArgs e)
        {
            if(!NumDisplay.Text.Contains("."))
            {
                NumDisplay.Text = NumDisplay.Text + ".";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NumDisplay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            
          
        }

        private void NumDisplay_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                EqualButton_Click(sender, e);
                NumDisplay.Text = "";
            }
            if (e.KeyCode == Keys.Multiply)
            {
                XBtn_Click(sender, e);
                NumDisplay.Text = "";
            }
            if (e.KeyCode == Keys.Divide)
            {
                DivBtn_Click(sender, e);
                NumDisplay.Text = "";
            }
            if (e.KeyCode == Keys.Subtract)
            {
                MinBtn_Click(sender, e);
                NumDisplay.Text = "";
            }
            if (e.KeyCode == Keys.Add)
            {
                PlusBtn_Click(sender, e);
                NumDisplay.Text = "";
            }
        }
    }
}