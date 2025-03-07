using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        [MyAttribute.MyCustom("Bu,Windows Forms buton metodu için özniteliktir.")]
        private void button1_Click_1(object sender, EventArgs e)
        {
            string secilenOge = listBox1.SelectedItem.ToString();
            string name = textBox1.Text;
            string amount = textBox2.Text;
            IPaymentMethod paymentMethod;
            PayReflection payReflection = new PayReflection();
            paymentMethod=payReflection.GetInstance(secilenOge);
            label3.Text=paymentMethod.payTheAmount(name,amount);

        }
    }
}