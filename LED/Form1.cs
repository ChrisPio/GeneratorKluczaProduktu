using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LED
{
    public partial class Form1 : Form
    {
        public Form1()
        {
    
        InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // RODZAJ OBUDOWY
      
            if (radioMleczna.Checked == true)
            {
                labelSymbol1.Text = "M";
            }
            if (radioTransparentna.Checked == true)
            {
                labelSymbol1.Text = "A";
            }

            // DŁUGOŚĆ
            if(radio49cm.Checked == true)
            {
                labelSymbol2.Text = "049";
            }
            if(radio74cm.Checked == true)
            {
                labelSymbol2.Text = "074";
            }
            if(radio131cm.Checked == true)
            {
                labelSymbol2.Text = "131";
            }

            // BARWA ŚWIATŁA

            if (radio4k.Checked == true)
            {
                labelSymbol3.Text = "4K";
            }
            if (radio5k.Checked == true)
            {
                labelSymbol3.Text = "5K";
            }
            if (radio6k.Checked == true)
            {
                labelSymbol3.Text = "6K";
            }

            // ZASILANIE
            if (radio12vdc.Checked == true)
            {
                labelSymbol4.Text = "012";
            }
            if (radio24vdc.Checked == true)
            {
                labelSymbol4.Text = "024";
            }
            if (radio230vdc.Checked == true)
            {
                labelSymbol4.Text = "230";
            }

            // DŁUGOŚĆ PRZEWODU
            if(radioBrakPrzewodu.Checked == true)
            {
                labelSymbol5.Text = "00";
            }
            if(radio1m.Checked == true)
            {
                labelSymbol5.Text = "01";
            }
            if(radio5m.Checked == true)
            {
                labelSymbol5.Text = "05";
            }
            if(radio10m.Checked == true)
            {
                labelSymbol5.Text = "10";
            }

            //ZAKOŃCZENIE PRZEWODU
            if (radioWtyczkaOkragla.Checked == true)
            {
                labelSymbol6.Text = "W";
            }
            if(radioRozszyteZyly.Checked == true)
            {
                labelSymbol6.Text = "S";
            }
            if(radioKostka.Checked == true)
            {
                labelSymbol6.Text = "P";
            }
            if(radioWtyczkaDoGniazda.Checked == true)
            {
                labelSymbol6.Text = "G";
            }

            //OBLICZANIE CENY

            //M131-4K-230-05-W
            if(radioMleczna.Checked == true &&
                radio131cm.Checked == true &&
                radio4k.Checked == true &&
                radio230vdc.Checked == true &&
                radio5m.Checked == true &&
                radioWtyczkaOkragla.Checked == true
            )
            {
                labelCenaWartosc.Text = "199,00 PLN";
            }
            else
            {
                labelCenaWartosc.Text = "Zapytaj o cenę";
            }
            //M131-5K-230-05-0W
            if (radioMleczna.Checked == true &&
                radio131cm.Checked == true &&
                radio5k.Checked == true &&
                radio230vdc.Checked == true &&
                radio5m.Checked == true &&
                radioWtyczkaOkragla.Checked == true
            )
            {
                labelCenaWartosc.Text = "198,00 PLN";
            }
            //M131-6K-230-05-W
            if (radioMleczna.Checked == true &&
                radio131cm.Checked == true &&
                radio6k.Checked == true &&
                radio230vdc.Checked == true &&
                radio5m.Checked == true &&
                radioWtyczkaOkragla.Checked == true
            )
            {
                labelCenaWartosc.Text = "197,00 PLN";
            }
           
            //A131-4K-230-05-W
            if (radioTransparentna.Checked == true &&
                radio131cm.Checked == true &&
                radio4k.Checked == true &&
                radio230vdc.Checked == true &&
                radio5m.Checked == true &&
                radioWtyczkaOkragla.Checked == true
            )
            {
                labelCenaWartosc.Text = "196,00 PLN";
            }
           
            //A131-5K-230-05-W
            if (radioTransparentna.Checked == true &&
                radio131cm.Checked == true &&
                radio5k.Checked == true &&
                radio230vdc.Checked == true &&
                radio5m.Checked == true &&
                radioWtyczkaOkragla.Checked == true
            )
            {
                labelCenaWartosc.Text = "195,00 PLN";
            }
            //A131-6K-230-05-W
            if (radioTransparentna.Checked == true &&
                radio131cm.Checked == true &&
                radio6k.Checked == true &&
                radio230vdc.Checked == true &&
                radio5m.Checked == true &&
                radioWtyczkaOkragla.Checked == true
            )
            {
                labelCenaWartosc.Text = "197,00 PLN";
            }
          
            //A074-4K-230-05-W
            if (radioTransparentna.Checked == true &&
                radio74cm.Checked == true &&
                radio4k.Checked == true &&
                radio230vdc.Checked == true &&
                radio5m.Checked == true &&
                radioWtyczkaOkragla.Checked == true
            )
            {
                labelCenaWartosc.Text = "109,00 PLN";
            }
            
            //A074-5K-230-05-W
            if (radioTransparentna.Checked == true &&
                radio74cm.Checked == true &&
                radio5k.Checked == true &&
                radio230vdc.Checked == true &&
                radio5m.Checked == true &&
                radioWtyczkaOkragla.Checked == true
            )
            {
                labelCenaWartosc.Text = "109,00 PLN";
            }
            //A074-6K-230-05-W
            if (radioTransparentna.Checked == true &&
                radio74cm.Checked == true &&
                radio6k.Checked == true &&
                radio230vdc.Checked == true &&
                radio5m.Checked == true &&
                radioWtyczkaOkragla.Checked == true
            )
            {
                labelCenaWartosc.Text = "109,00 PLN";
            }
            //M074-4K-230-05-W
            if (radioMleczna.Checked == true &&
                radio74cm.Checked == true &&
                radio4k.Checked == true &&
                radio230vdc.Checked == true &&
                radio5m.Checked == true &&
                radioWtyczkaOkragla.Checked == true
            )
            {
                labelCenaWartosc.Text = "101,00 PLN";
            }
            //M074-5K-230-05-W
            if (radioMleczna.Checked == true &&
                radio74cm.Checked == true &&
                radio5k.Checked == true &&
                radio230vdc.Checked == true &&
                radio5m.Checked == true &&
                radioWtyczkaOkragla.Checked == true
            )
            {
                labelCenaWartosc.Text = "101,00 PLN";
            }
            //M074-6K-230-05-W
            if (radioMleczna.Checked == true &&
                radio74cm.Checked == true &&
                radio6k.Checked == true &&
                radio230vdc.Checked == true &&
                radio5m.Checked == true &&
                radioWtyczkaOkragla.Checked == true
            )
            {
                labelCenaWartosc.Text = "101,00 PLN";
            }
            //M049 - 4K - 230 - 05 - W
            if (radioMleczna.Checked == true &&
                radio49cm.Checked == true &&
                radio4k.Checked == true &&
                radio230vdc.Checked == true &&
                radio5m.Checked == true &&
                radioWtyczkaOkragla.Checked == true
            )
            {
                labelCenaWartosc.Text = "99,00 PLN";
            }
            //A049-4K-230-05-W
            if (radioTransparentna.Checked == true &&
                radio49cm.Checked == true &&
                radio4k.Checked == true &&
                radio230vdc.Checked == true &&
                radio5m.Checked == true &&
                radioWtyczkaOkragla.Checked == true
            )
            {
                labelCenaWartosc.Text = "99,00 PLN";
            }

            



        }

        private void labelMleczna_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radio12vdc_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radio6k_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
