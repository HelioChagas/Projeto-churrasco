using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_churrasco
{
    public partial class Form1 : Form
    {

        public Form1()
        { 
            InitializeComponent();
        }
        public void Zerar() 
        {
            Masculino.Text = "";
            Feminino.Text = "";
            Criança.Text = "";
            B.Checked = false;
            S.Checked = false;
            A.Checked = false;
            P.Checked = false;
            InfoCarne.Text = "";
            ValorRef.Text = "";
            ValorCerve.Text = "";
            InfoRefri.Text = "";
            InfoCerv.Text = "";
            InfoCopo.Text = "";
            InfoGuard.Text = "";
            Infoprat.Text = "";
            InfoColher.Text = "";
            InfoGarfFac.Text = "";
        }

        private void Informacoes()
        {
            double TotalB = 0;
            double TotalS = 0;
            double TotalA = 0;
            double TotalP = 0;
            double Bovino = 71.00;
            double Suino = 18.00;
            double Ave = 10.00;
            double Peixe =20.00;
            double masculinoc = 0;
            double femininoc = 0;
            double criancac = 0;
            double Refrigerante = 0;
            double Cerveja = 0;

            //Campo para trasformações//
            Cerveja = double.Parse(ValorCerve.Text);
            Refrigerante = double.Parse(ValorRef.Text);
            masculinoc = double.Parse(Masculino.Text);
            femininoc = double.Parse(Feminino.Text);
            criancac = double.Parse(Criança.Text);
                    
                    //Campo para calculo//
            
            double Copos = (masculinoc + femininoc + criancac) * 4;
            double Guardanapos = (masculinoc + femininoc + criancac) * 10;
            double Pratos = (masculinoc + femininoc + criancac) * 2;
            double Colheres = (masculinoc + femininoc + criancac) * 2;
            double GarfoFaca = (masculinoc + femininoc + criancac) * 2;
            double Refrigeranteconta= (masculinoc + femininoc + criancac) * Refrigerante;
            double cervejaconta = (masculinoc + femininoc) * Cerveja;
            //Campo para Checar botoes e fazer contas para carnes//

            if (B.Checked == true) 
            {
                double somaB = (Bovino * masculinoc)/2;
                double somaB2 = (Bovino * femininoc)/3;
                double somaB3 = (Bovino * criancac)/1.5;
                           //total de bovino//
                 TotalB = somaB + somaB2 + somaB3;
                            
            }
            if (S.Checked == true)
            {
                double somaS = (Suino * masculinoc)/2;
                double somaS2 = (Suino * femininoc)/3;
                double somaS3 = (Suino * criancac)/1.5;
                          //Total de Suino//
                TotalS = somaS + somaS2 + somaS3;
            }
            if (A.Checked == true)
            {
                double somaA = (Ave * masculinoc)/2;
                double somaA2 = (Ave * femininoc)/3;
                double somaA3 = (Ave * criancac)/1.5;
                    //Total de Aves//
                TotalA = somaA + somaA2 + somaA3;
            }
            if (P.Checked == true)
            {
                double somaP = (Peixe * masculinoc)/2;
                double somaP2 = (Peixe * femininoc)/3;
                double somaP3 = (Peixe * criancac)/1.5;
                        //Total de Peixes//
                TotalP = somaP + somaP2 + somaP3;
                
            }
                    //Preços de carnes//            
            double Totalcarnes = (TotalA + TotalB + TotalP + TotalS);
            InfoCarne.Text = Totalcarnes.ToString("N2");
                    //Preço de refrigerantes//
            InfoRefri.Text = Refrigeranteconta.ToString("N2");
                    //Preço de Cervejas//
            InfoCerv.Text = cervejaconta.ToString("N2");
                    //Preço de copos//
            InfoCopo.Text = Copos.ToString("N2");
                    //Preço Guardanapos//
            InfoGuard.Text = Guardanapos.ToString("N2");
                    //Preço de Pratos//
            Infoprat.Text = Pratos.ToString("N2");
                    //Preço Colher//
            InfoColher.Text = Colheres.ToString("N2");
                    //Preço Garfos e Facas//
            InfoGarfFac.Text = GarfoFaca.ToString("N2");
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Informacoes();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Zerar();
        }
    }
}
