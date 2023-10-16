using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace triugol_niki
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                int First = Convert.ToInt32(first.Text);
                int Second = Convert.ToInt32(second.Text);
                int Third = Convert.ToInt32(third.Text);
                int check=1;
                if ((First <= 0) || (Second <= 0) || (Third <= 0))
                {
                        MessageBox.Show("Неверные данные");
                        check = 0;
                        if (First <= 0)
                        {
                            first.Text = "";
                        }
                        if (Second <= 0)
                        {
                            second.Text = "";
                        }
                        if (Third <= 0)
                        {
                            third.Text = "";
                        }

                }
                else if (((First + Second) <= Third) || ((First + Third) <= Second) || ((Second + Third) <=First))
                {

                    MessageBox.Show("Неверные данные");
                    check = 0;
                }
                
                    
                if (check == 1)
                {
                    if (First != Second && First != Third && Second != Third)
                    {
                        MessageBox.Show("Разносторонний");
                        first.Text = "";
                        second.Text = "";
                        third.Text = "";


                    }
                    if (((First == Second) && (First != Third || Second != Third)) || ((Second == Third) && (Second != First || Third != Second)))
                    {
                        MessageBox.Show("Равнобедренный");
                        first.Text = "";
                        second.Text = "";
                        third.Text = "";
                    }
                    if (First == Second && Second == Third)
                    {

                        MessageBox.Show("Равносторонний");
                        first.Text = "";
                        second.Text = "";
                        third.Text = "";
                    }
                    
                }

            }
            catch { }
           
           
            
        }

        private void first_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!(char.IsDigit(e.KeyChar))) && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("Недопустимый символ");

            }
        }
    }
}