using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            value1.Maximum = long.MaxValue;
            value1.Minimum = long.MinValue;
            value2.Maximum = long.MaxValue;
            value2.Minimum = long.MinValue;
        }
        void startStuff()
        {
            value1.ReadOnly = false;
            value2.ReadOnly = false;
            processData();
        }
        void onOpClick(object sender, EventArgs e)
        {
            if(sender is Button botao)
            {
                operation.Text = botao.Text;
            }
            startStuff();
        }
        bool temp = false;
        void processData()
        {
            if (operation.Text == plus.Text)
                result.Text = (value1.Value + value2.Value).ToString();
                temp = true;
            if (operation.Text == minus.Text)
                result.Text = (value1.Value - value2.Value).ToString();
                temp = true;
            if (operation.Text == multiply.Text)
                result.Text = (value1.Value * value2.Value).ToString();
                temp = true;
            if (operation.Text == division.Text){
                if (value2.Value == 0)
                { result.Text = "Divide por zero n";
                    temp = false;
                }
                else
                { result.Text = (value1.Value / value2.Value).ToString(); temp = true; }
            }

        }
        void hasValueChanged(object sender, EventArgs e)
        {
            if(sender is NumericUpDown nums)
                processData();
        }
        private void segue_Click(object sender, EventArgs e)
        {
            if(temp == true){ 
                if (!(long.TryParse(result.Text, out _)))
                    result.Text = "Valor máximo atingido :D";
                else
                    value1.Value = Decimal.Parse(result.Text);
            }
        }

        private void clean_Click(object sender, EventArgs e)
        {
            value1.Value = 0;
            value2.Value = 0;
            result.Text = "0";
            operation.Text = "op";
            value1.ReadOnly = true;
            value2.ReadOnly = true;
        }
    }
}
