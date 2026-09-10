namespace LojaDoces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                Pedidio pedido = new Pedidio();
                pedido.NomeDoce = txtNomeDoce.Text;
                pedido.PrecoUnitario = Convert.ToDouble(txtPrecoUnitario.Text);
                pedido.Quantidade = int.Parse(txtQuantidade.Text);
                pedido.IdadeCliente = int.Parse(txtIdadeCliente.Text);

                double desconto = pedido.CalcularDesconto();
                double valorFinal = pedido.CalcularValorFinal();
                double parcela = pedido.CalcularParcela();
                bool brindeAprovado = pedido.ValidarBrinde();

                lblNome.Text = $"{pedido.NomeDoce.ToUpper()}";
                lblDesconto.Text = $"R$ {desconto:N2}";
                lblValorFinal.Text = $"R$ {valorFinal:N2}";
                lblParcela.Text = $"3x de R$ {parcela:N2}";

                txtNomeDoce.Clear();
                txtPrecoUnitario.Clear();
                txtQuantidade.Clear();
                txtIdadeCliente.Clear();

                if (brindeAprovado)
                {
                    lblStatus.Text = "Minhas felicitações! Recebestes um presente dos olimpios surpresa!!";
                    lblStatus.ForeColor = Color.HotPink;
                }
                else
                {
                    lblStatus.Text = "Adquirição padronizada efetuada com sucesso!";
                    lblStatus.ForeColor = Color.Orange;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Preencha os campos numericos com os devidos numeros corretos!",
                    "Erro de Digitação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            
            }
        }
    }
}
