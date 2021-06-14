using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalizadorLexico
{
    public partial class AnalizadorLexico : Form
    {
        Lexico Analiza_Lexico = new Lexico();
        public AnalizadorLexico()
        {            
            InitializeComponent();
        }

        private void BAnalisisL_Click(object sender, EventArgs e)
        {
            Analiza_Lexico.Inicia(); 
            Analiza_Lexico.Analiza(TCodigo.Text);
            DGTokenLexema.Rows.Clear(); 
            if (Analiza_Lexico.NoTokens > 0) 
                DGTokenLexema.Rows.Add(Analiza_Lexico.NoTokens); 
            for (int i = 0; i < Analiza_Lexico.NoTokens; i++) 
            {
                DGTokenLexema.Rows[i].Cells[0].Value = Analiza_Lexico.Token[i];
                DGTokenLexema.Rows[i].Cells[1].Value = Analiza_Lexico.Lexema[i]; 
            }
        }

        private void BLTabla_Click(object sender, EventArgs e)
        {
            //Limpiar el Datagrid             
            DGTokenLexema.Rows.Clear();
            //Limpiar el TextBoxt             
            TCodigo.Text = "";
            TCodigo.Focus();
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
