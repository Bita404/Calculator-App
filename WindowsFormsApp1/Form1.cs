using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double x, y, z;
        string c,d;
        public Form1()
        {
            InitializeComponent();
        }

        private void number_click(object sender, EventArgs e)
        {
            textBoxType.Text += ((Button)sender).Text;
            labelHistory.Text += ((Button)sender).Text;
        }

        private void buttonEqu_Click(object sender, EventArgs e)
        {
            y = Convert.ToDouble(textBoxType.Text);
            switch (c)
            {
                case "+":
                    z = x + y;
                    break;
                case "-":
                    z = x - y;
                    break;
                case "÷":
                    z = x / y;
                    break;
                case "×":
                    z = x * y;
                    break;
            }
            switch (d)
            {
                case "x^y":
                    z = Math.Pow(x, y);
                    break;
            }

            textBoxType.Text = z.ToString();
            labelHistory.Text += "=" + z.ToString();
        }

        private void textBoxType_TextChanged(object sender, EventArgs e)
        {
            if (textBoxType.Text.Contains("."))
                buttonPoint.Enabled = false;
            else
                buttonPoint.Enabled = true;

            if (textBoxType.Text == "")
            {
                buttonBackSpace.Enabled = false;
                button1x.Enabled = false;
                buttonXpowerY.Enabled = false;
                buttonsum.Enabled = false;
                buttonsub.Enabled = false;
                buttondev.Enabled = false;
                buttonmul.Enabled = false;
                buttonEqu.Enabled = false;
                button10powerX.Enabled = false;
                buttonSqrt.Enabled = false;
                buttonLogx.Enabled = false;
                buttonLnx.Enabled = false;
            }
            else
            {
                buttonBackSpace.Enabled = true;
                button1x.Enabled = true;
                buttonXpowerY.Enabled = true;
                buttonsum.Enabled = true;
                buttonsub.Enabled = true;
                buttondev.Enabled = true;
                buttonmul.Enabled = true;
                buttonEqu.Enabled = true;
                button10powerX.Enabled = true;
                buttonSqrt.Enabled = true;
                buttonLogx.Enabled = true;
                buttonLnx.Enabled = true;
            }
        }

        private void button0_MouseEnter(object sender, EventArgs e)
        {
            button0.ForeColor = Color.RoyalBlue;
        }

        private void button0_MouseLeave(object sender, EventArgs e)
        {
            button0.ForeColor = Color.DarkBlue;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.RoyalBlue;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.DarkBlue;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.ForeColor = Color.RoyalBlue;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = Color.DarkBlue;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.ForeColor = Color.RoyalBlue;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.ForeColor = Color.DarkBlue;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.ForeColor = Color.RoyalBlue;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.ForeColor = Color.DarkBlue;
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.ForeColor = Color.RoyalBlue;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.ForeColor = Color.DarkBlue;
        }

        private void button26_MouseEnter(object sender, EventArgs e)
        {
            button26.ForeColor = Color.RoyalBlue;
        }

        private void button26_MouseLeave(object sender, EventArgs e)
        {
            button26.ForeColor = Color.DarkBlue;
        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {
            button7.ForeColor = Color.RoyalBlue;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.ForeColor = Color.DarkBlue;
        }

        private void button8_MouseEnter(object sender, EventArgs e)
        {
            button8.ForeColor = Color.RoyalBlue;
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            button8.ForeColor = Color.DarkBlue;
        }

        private void button9_MouseEnter(object sender, EventArgs e)
        {
            button9.ForeColor = Color.RoyalBlue;
        }

        private void buttonBackSpace_Click(object sender, EventArgs e)
        {
           textBoxType.Text =  textBoxType.Text.Substring(0, textBoxType.Text.Length - 1);
            labelHistory.Text = labelHistory.Text.Substring(0, labelHistory.Text.Length - 1);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxType.Text = "";
            labelHistory.Text = "";
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Button temp = new Button();
            temp.Text = e.KeyChar.ToString();

            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '.' && !textBoxType.Text.Contains("."))
            {
                number_click(temp, null);
            }
            else if (e.KeyChar == '+' || e.KeyChar == '-' || e.KeyChar == '*' || e.KeyChar == '/' )
            {
                oprators_click(temp, null);
            }
            else if( e.KeyChar =='=')
            {
                buttonEqu_Click(null, null);
            }
          
           
        }

        private void button1x_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBoxType.Text);
            z = 1 / x ;
            textBoxType.Text = z.ToString();
            labelHistory.Text = "1/"+ x + "=" + z.ToString();
        }

        private void button10powerX_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBoxType.Text);
            z =Math.Pow(10, x) ;
            textBoxType.Text = z.ToString();
            labelHistory.Text = "10^" + x + "=" + z.ToString();
        }

        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBoxType.Text);
            z = Math.Sqrt(x);
            textBoxType.Text = z.ToString();
            labelHistory.Text = "sqrt" + x + "=" + z.ToString();
        }

        private void buttonLogx_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBoxType.Text);
            z = Math.Log10(x);
            textBoxType.Text = z.ToString();
            labelHistory.Text = "log" + x + "=" + z.ToString();
        }

        private void buttonLnx_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBoxType.Text);
            z = Math.Log(x);
            textBoxType.Text = z.ToString();
            labelHistory.Text = "ln(" + x + ")=" + z.ToString();
        }

        private void buttonClear_MouseEnter(object sender, EventArgs e)
        {
            buttonClear.ForeColor = Color.Yellow;
        }

        private void buttonClear_MouseLeave(object sender, EventArgs e)
        {
            buttonClear.ForeColor = Color.Purple;
        }

        private void buttonEqu_MouseEnter(object sender, EventArgs e)
        {
            buttonEqu.ForeColor = Color.Blue;
        }

        private void buttonEqu_MouseLeave(object sender, EventArgs e)
        {
            buttonEqu.ForeColor = Color.DarkBlue;
        }

        private void buttonBackSpace_MouseEnter(object sender, EventArgs e)
        {
            buttonBackSpace.ForeColor = Color.Red;
        }

        private void buttonBackSpace_MouseLeave(object sender, EventArgs e)
        {
            buttonBackSpace.ForeColor = Color.DarkRed;
        }

        private void buttondev_MouseEnter(object sender, EventArgs e)
        {
            buttondev.ForeColor = Color.DeepPink;
        }

        private void buttondev_MouseLeave(object sender, EventArgs e)
        {
            buttondev.ForeColor = Color.Purple;
        }

        private void buttonmul_MouseEnter(object sender, EventArgs e)
        {
            buttonmul.ForeColor = Color.DeepPink;
        }

        private void buttonmul_MouseLeave(object sender, EventArgs e)
        {
            buttonmul.ForeColor = Color.Purple;
        }

        private void buttonsub_MouseEnter(object sender, EventArgs e)
        {
            buttonsub.ForeColor = Color.DeepPink;
        }

        private void buttonsub_MouseLeave(object sender, EventArgs e)
        {
            buttonsub.ForeColor = Color.Purple;
        }

        private void buttonsum_MouseEnter(object sender, EventArgs e)
        {
            buttonsum.ForeColor = Color.DeepPink;
        }

        private void buttonsum_MouseLeave(object sender, EventArgs e)
        {
            buttonsum.ForeColor = Color.Purple;
        }

        private void buttonSqrt_MouseEnter(object sender, EventArgs e)
        {
            buttonSqrt.ForeColor = Color.DeepPink;
        }

        private void buttonSqrt_MouseLeave(object sender, EventArgs e)
        {
            buttonSqrt.ForeColor = Color.DarkSlateBlue;
        }

        private void button10powerX_MouseEnter(object sender, EventArgs e)
        {
            button10powerX.ForeColor = Color.DeepPink;
        }

        private void button10powerX_MouseLeave(object sender, EventArgs e)
        {
            button10powerX.ForeColor = Color.DarkSlateBlue;
        }

        private void buttonXpowerY_MouseEnter(object sender, EventArgs e)
        {
            buttonXpowerY.ForeColor = Color.DeepPink;
        }

        private void buttonXpowerY_MouseLeave(object sender, EventArgs e)
        {
            buttonXpowerY.ForeColor = Color.DarkSlateBlue;
        }

        private void buttonLogx_MouseEnter(object sender, EventArgs e)
        {
            buttonLogx.ForeColor = Color.DeepPink;
        }

        private void buttonLogx_MouseLeave(object sender, EventArgs e)
        {
            buttonLogx.ForeColor = Color.DarkSlateBlue;
        }

        private void buttonLnx_MouseEnter(object sender, EventArgs e)
        {
            buttonLnx.ForeColor = Color.DeepPink;
        }

        private void buttonLnx_MouseLeave(object sender, EventArgs e)
        {
            buttonLnx.ForeColor = Color.DarkSlateBlue;
        }

        private void button1x_MouseEnter(object sender, EventArgs e)
        {
            button1x.ForeColor = Color.DeepPink;
        }

        private void button1x_MouseLeave(object sender, EventArgs e)
        {
            button1x.ForeColor = Color.DarkSlateBlue;
        }

        private void buttonPoint_MouseEnter(object sender, EventArgs e)
        {
            buttonPoint.ForeColor = Color.Blue;
        }

        private void buttonPoint_MouseLeave(object sender, EventArgs e)
        {
            buttonPoint.ForeColor = Color.DarkSlateBlue;
        }

        private void labelinfo_Click(object sender, EventArgs e)
        {

        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
            button9.ForeColor = Color.DarkBlue;
        }

        private void oprators_click(object sender, EventArgs e)
        {
            
            x = Convert.ToDouble(textBoxType.Text);
            textBoxType.Text = "";
            labelHistory.Text += ((Button)sender).Text;
            c = ((Button)sender).Text;
        }

        private void power_click(object sender, EventArgs e)
        {
            
            x = Convert.ToDouble(textBoxType.Text);
            textBoxType.Text = "";
            labelHistory.Text += "^";
            d = ((Button)sender).Text;
        }

    }

}
