namespace LojaDoces
{
    class Pedidio
    {
        //atributos

        public string? NomeDoce { get; set; }
        public double PrecoUnitario { get; set; }
        public int Quantidade { get; set; }

        public int IdadeCliente { get; set; }

        //Métodos

        public double CalcularDesconto()
        {
            double valorTotal = PrecoUnitario * Quantidade;

            if (Quantidade >= 10 )
            {
                return valorTotal * 0.10;
            }
            return 0.0;
        }

        //Metodo para calcular o valor final com o desconto aplicado 

        public double CalcularValorFinal()
        {
            double valorTotalBruto = PrecoUnitario * Quantidade;
            double desconto = CalcularDesconto();
            return valorTotalBruto - desconto;
        }

        //Metodo para calcular o parcelamento em 3x sem juros (se o valor final for valido)

        public double CalcularParcela()
        {
            return CalcularValorFinal() /  3.0;
        }

        //metodo para validar se o cliente tem direito a  um brinde especial (ex: maiores de 18 anos ou compre grande)

        public bool ValidarBrinde()
        {
            return (IdadeCliente >= 18 && Quantidade >= 5) || (CalcularValorFinal() > 100.0);
        }
    }
}
