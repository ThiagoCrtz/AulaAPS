using System;
using System.Windows.Forms;

namespace AulaAPS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbForma_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbForma.Text)
            {
                case "Quadrado":
                    SelecionarQuadrado();
                    break;
                case "Triângulo":
                    ExibircbmTriangulo(true);
                    break;
                case "Circunferência":
                    SelecionarCircunferencia();
                    break;
                case "Retângulo":
                    SelecionarRetangulo();
                    break;
                default:
                    break;
            }
        }
        private void cmbTriangulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbTriangulo.Text)
            {
                case "Equilátero":
                    TrianguloEquilatero();
                    break;
                case "Isósceles":
                    TrianguloIsosceles();
                    break;
                case "Reto":
                    TrianguloReto();
                    break;
                default:
                    break;
            }
        }
        private void ExibirAltura(bool visivel)
        {
            lblAltura.Visible = txtAltura.Visible = visivel;
        }
        private void ExibirBase(bool visivel)
        {
            lblBase.Visible = txtBase.Visible = visivel;
        }
        private void ExibirRaio(bool visivel)
        {
            lblRaio.Visible = txtRaio.Visible = visivel;
        }
        private void ExibircbmTriangulo(bool visivel)
        {
            cmbTriangulo.Visible = visivel;
        }

        private void SelecionarQuadrado()
        {
            ExibirBase(true);
            ExibirAltura(false);
            ExibirRaio(false);
            ExibircbmTriangulo(false);
        }

        private void SelecionarRetangulo()
        {
            ExibirBase(true);
            ExibirAltura(true);
            ExibirRaio(false);
            ExibircbmTriangulo(false);

        }
   
        private void SelecionarCircunferencia()
        {
            ExibirBase(false);
            ExibirAltura(false);
            ExibirRaio(true);
            ExibircbmTriangulo(false);
        }
        private void TrianguloIsosceles()
        {
            ExibirBase(true);
            ExibirAltura(true);
            ExibirRaio(false);
            ExibircbmTriangulo(true);
        }
        private void TrianguloReto()
        {
            ExibirBase(true);
            ExibirAltura(true);
            ExibirRaio(false);
            ExibircbmTriangulo(true);
        }
        private void TrianguloEquilatero()
        {
            ExibirBase(true);
            ExibirAltura(false);
            ExibirRaio(false);
            ExibircbmTriangulo(true);
        }
        private void limpaCampos()
        {
            txtAltura.Clear();
            txtRaio.Clear();
            txtBase.Clear();    
        }
        private void btnCriar_Click(object sender, EventArgs e)
        {
            switch (cmbForma.Text)
            {
                case "Quadrado":
                    CadQuadrado();
                    break;
                case "Circunferência":
                    CadCircuferência();
                    break;
                case "Retângulo":
                    CadRetangulo();
                    break;
                case "Triângulo":
                    CadTriangulo();
                    break;
                    
            }
         
        }

        
        private void CadQuadrado()
        {
            FormaGeometrica quadrado = new Quadrado()
            {
                Lado = Convert.ToDouble(txtBase.Text)
                
            };
            cmbObjetos.Items.Add(quadrado);
        }
        private void CadCircuferência()
        {
            FormaGeometrica circunferencia = new Circunferencia()
            {
                Raio = Convert.ToDouble(txtRaio.Text)
            };
            cmbObjetos.Items.Add(circunferencia);

        }
        private void CadRetangulo()
        {
            FormaGeometrica retangulo = new Retangulo()
            {
                Altura = Convert.ToDouble(txtAltura.Text),
                Base = Convert.ToDouble(txtBase.Text)
            };
            cmbObjetos.Items.Add(retangulo);
        }
        private void CadTriangulo() 
        {
            switch (cmbTriangulo.Text)
            {
                case "Equilátero":
                    CadTrianguloEquilatero();
                    break;

                case "Reto":
                    CadTrianguloReto();
                    break;

                case "Isósceles":
                    CadTrianguloIsosceles();
                    break;
            }
        }

        private void CadTrianguloIsosceles()
        {
            FormaGeometrica isosceles = new TrianguloIsosceles()
            {
                Base = Convert.ToDouble(txtBase.Text),
                Altura = Convert.ToDouble(txtAltura.Text)
            };
            cmbObjetos.Items.Add(isosceles);
        }

        private void CadTrianguloReto()
        {
            FormaGeometrica reto = new TrianguloReto()
            {
                Base = Convert.ToDouble(txtBase.Text),
                Altura = Convert.ToDouble(txtAltura.Text)
            };
            cmbObjetos.Items.Add(reto);
        }

        private void CadTrianguloEquilatero()
        {
            FormaGeometrica equilatero = new TrianguloEquilatero()
            {
                Base = Convert.ToDouble(txtBase.Text)
            };
            cmbObjetos.Items.Add(equilatero);
        }
        private void cmbObjetos_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormaGeometrica obj = cmbObjetos.SelectedItem as FormaGeometrica;
            txtArea.Text = obj.CalcularArea().ToString("F2");
            txtPerimetro.Text = obj.CalcularPerimetro().ToString("F2");
        }

       
    }
}
