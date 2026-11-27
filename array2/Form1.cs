using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace array2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] nomeCognome = new string[] { "rossi mario", "bianchi luigi", "belli giulia", "dotti fabio", "merli gianna", "zeri giulio", "botti maria" };
        int[] numeroConto = new int[] { 11264, 99780, 00342, 03419, 34562, 09887, 02341 };
        int[] saldoConto = new int[] { 11534, -2345, 3451, 127, 45673, -13, 3452 };
       

        private void btn_n2_Click(object sender, EventArgs e)
        {
            int numeroCercato = int.Parse(txt_n2.Text);
            bool trovato = false;
            for (int i = 0; i < numeroConto.Length; i++)
            {
                if (numeroConto[i] == numeroCercato)
                {
                    lbl_n9.Text =  saldoConto[i].ToString();
                    lbl_n8.Text = nomeCognome[i];
                    
                    trovato= true;
                }
            }
            if(trovato==false)
            {
                lbl_n9.Text = " mumero di conto non esisste";
            }
        }
    }
}
