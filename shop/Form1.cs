using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace shop
{
    //posion shop
    //found in dream land this shop has just entered into a new erra allowing a witch to create them a program that will caculate
    //costs, change, etc.
    public partial class Form1 : Form
    {
        //all variables 
        const int elfoCost = 1, beanCost = 9, bottleCost = 5;
        int elfo,  bean, bottle, elfoTotal, beanTotal, bottleTotal;
        double givenZogs, changeZogs, subTotal, taxTotal, tax;

        private void NewOrder_Click(object sender, EventArgs e)
        {
            //resetting entire program 
            //reset all vars
            elfo = 0;
            bean = 0;
            bottle = 0;
            elfoTotal = 0; 
            beanTotal = 0;
            bottleTotal = 0;
            givenZogs = 0;
            changeZogs = 0;
            subTotal = 0;
            tax = 0;
            taxTotal = 0;
            givenZogs = 0;
            //reset all input boxes
            amntBean.Text = String.Empty;
            amntBottle.Text = String.Empty;
            amntElfo.Text = String.Empty;
            inputTender.Text = String.Empty;
            //reset all cash outputs
            outputChange.Text = "0.00z";
            outputSub.Text = "0.00z";
            outputTax.Text = "0.00z";
            outputTotal.Text = "0.00z";
            //covering up receipt
            Graphics g = this.CreateGraphics();
            SolidBrush backBrush = new SolidBrush(Color.White);
            g.FillRectangle (backBrush, 500, 50, 1000, 1000);
        }


        private void Receipt_Click(object sender, EventArgs e)
        {
            try
            {
                //clearing error if they fixed it
                errorOutput.Text = String.Empty;
                //declare receipt vars

                SoundPlayer grunt = new SoundPlayer(Properties.Resources._546390_SOUNDDOGS__gr);
                grunt.Play();
                Graphics g = this.CreateGraphics();
                SolidBrush textBrush = new SolidBrush(Color.Black);
                SolidBrush backBrush = new SolidBrush(Color.White);
                Font drawFont = new Font("courier new", 12, FontStyle.Bold);
                //drawing receipt
                g.TranslateTransform(300, 50);
                g.FillRectangle(textBrush, 250, 120, 745, 790);
                g.FillRectangle(backBrush, 270, 140, 705, 750);
                g.DrawString(" Little Seizures Poison Shop\n\n\n" +
                    "Hi Im elfos    x" + elfo + "       " + elfoTotal.ToString("0.00") + "z\nBottle Breaker x" +
                    bottle + "       " + bottleTotal.ToString("0.00") + "z" + "\nBean Specials  x" + bean + "       "
                    + beanTotal.ToString("0.00") + "z\n\nSub Total              " + subTotal.ToString("0.00") + "z\nTax                     "
                    + tax.ToString("0.00") + "z\nTotal                  " + taxTotal.ToString("0.00") + "z\n\nZogs Given" +
                    "             " + givenZogs.ToString("0.00") + "z\nZogs returned           " + changeZogs.ToString("0.00") + "z\n\n\n" +
                    " See You In The Plague Pit!"
                    , drawFont, textBrush, 300, 200);
            }
            catch
            {
                //error message
                errorOutput.Text = "Fill in all the boxes with numbers\n or ill put you in the plague pit!";
            }
        }


        private void CacChange_Click(object sender, EventArgs e)
        {
                try
                {
                //caculating change
                    errorOutput.Text = String.Empty;
                    givenZogs = Convert.ToInt16(inputTender.Text);
                    changeZogs = givenZogs - taxTotal;
                    outputChange.Text = changeZogs.ToString("0.00") + "z";
                }
                catch
                {
                    errorOutput.Text = "Fill in all the boxes with numbers\n or ill put you in the plague pit!";
                }
            }
        public Form1()
        {
            InitializeComponent();
        }
        private void CacTotal_Click(object sender, EventArgs e)
        {
            try
            {
                errorOutput.Text = String.Empty;
                //gather amount of each item
                elfo = Convert.ToInt16(amntElfo.Text);
                bean = Convert.ToInt16(amntBean.Text);
                bottle = Convert.ToInt16(amntBottle.Text);
                //caculating tax, subtotal, and total.
                elfoTotal = elfo * elfoCost;
                beanTotal = bean * beanCost;
                bottleTotal = bottle * bottleCost;
                subTotal = elfoTotal + beanTotal + bottleTotal;
                tax = subTotal * 0.13;
                taxTotal = subTotal + tax;
                //displaying tax, subtotal, and total. 
                outputSub.Text = subTotal.ToString("0.00") + "z";
                outputTotal.Text = taxTotal.ToString("0.00") + "z";
                outputTax.Text = tax.ToString("0.00") + "z";
            }
            catch
            {
                errorOutput.Text = "Fill in all the boxes with numbers\n or ill put you in the plague pit!";
            }
        }
    }
}
