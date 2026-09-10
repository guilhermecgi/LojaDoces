namespace LojaDoces
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNomeDoce = new Label();
            lblPrecoUnitario = new Label();
            btnCalcular = new Button();
            lblQuantidade = new Label();
            lblIdadeCliente = new Label();
            lblNome = new Label();
            txtPrecoUnitario = new TextBox();
            txtQuantidade = new TextBox();
            txtIdadeCliente = new TextBox();
            txtNomeDoce = new TextBox();
            lblDesconto = new Label();
            lblValorFinal = new Label();
            lblStatus = new Label();
            lblParcela = new Label();
            SuspendLayout();
            // 
            // lblNomeDoce
            // 
            lblNomeDoce.AutoSize = true;
            lblNomeDoce.Location = new Point(45, 11);
            lblNomeDoce.Name = "lblNomeDoce";
            lblNomeDoce.Size = new Size(70, 15);
            lblNomeDoce.TabIndex = 0;
            lblNomeDoce.Text = "Nome Doce";
            // 
            // lblPrecoUnitario
            // 
            lblPrecoUnitario.AutoSize = true;
            lblPrecoUnitario.Location = new Point(45, 45);
            lblPrecoUnitario.Name = "lblPrecoUnitario";
            lblPrecoUnitario.Size = new Size(82, 15);
            lblPrecoUnitario.TabIndex = 1;
            lblPrecoUnitario.Text = "Preço Unitário";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(45, 328);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(109, 23);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(46, 88);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(69, 15);
            lblQuantidade.TabIndex = 4;
            lblQuantidade.Text = "Quantidade";
            // 
            // lblIdadeCliente
            // 
            lblIdadeCliente.AutoSize = true;
            lblIdadeCliente.Location = new Point(45, 126);
            lblIdadeCliente.Name = "lblIdadeCliente";
            lblIdadeCliente.Size = new Size(76, 15);
            lblIdadeCliente.TabIndex = 5;
            lblIdadeCliente.Text = "Idade Cliente";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(59, 162);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 6;
            lblNome.Text = "Nome";
            // 
            // txtPrecoUnitario
            // 
            txtPrecoUnitario.Location = new Point(137, 45);
            txtPrecoUnitario.Name = "txtPrecoUnitario";
            txtPrecoUnitario.Size = new Size(100, 23);
            txtPrecoUnitario.TabIndex = 7;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(137, 85);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(100, 23);
            txtQuantidade.TabIndex = 8;
            // 
            // txtIdadeCliente
            // 
            txtIdadeCliente.Location = new Point(137, 123);
            txtIdadeCliente.Name = "txtIdadeCliente";
            txtIdadeCliente.Size = new Size(100, 23);
            txtIdadeCliente.TabIndex = 9;
            // 
            // txtNomeDoce
            // 
            txtNomeDoce.Location = new Point(137, 8);
            txtNomeDoce.Name = "txtNomeDoce";
            txtNomeDoce.Size = new Size(100, 23);
            txtNomeDoce.TabIndex = 10;
            // 
            // lblDesconto
            // 
            lblDesconto.AutoSize = true;
            lblDesconto.Location = new Point(59, 193);
            lblDesconto.Name = "lblDesconto";
            lblDesconto.Size = new Size(57, 15);
            lblDesconto.TabIndex = 11;
            lblDesconto.Text = "Desconto";
            // 
            // lblValorFinal
            // 
            lblValorFinal.AutoSize = true;
            lblValorFinal.Location = new Point(59, 226);
            lblValorFinal.Name = "lblValorFinal";
            lblValorFinal.Size = new Size(61, 15);
            lblValorFinal.TabIndex = 12;
            lblValorFinal.Text = "Valor Final";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(61, 291);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 15);
            lblStatus.TabIndex = 14;
            lblStatus.Text = "Status";
            // 
            // lblParcela
            // 
            lblParcela.AutoSize = true;
            lblParcela.Location = new Point(60, 263);
            lblParcela.Name = "lblParcela";
            lblParcela.Size = new Size(46, 15);
            lblParcela.TabIndex = 15;
            lblParcela.Text = "Parcelo";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblParcela);
            Controls.Add(lblStatus);
            Controls.Add(lblValorFinal);
            Controls.Add(lblDesconto);
            Controls.Add(txtNomeDoce);
            Controls.Add(txtIdadeCliente);
            Controls.Add(txtQuantidade);
            Controls.Add(txtPrecoUnitario);
            Controls.Add(lblNome);
            Controls.Add(lblIdadeCliente);
            Controls.Add(lblQuantidade);
            Controls.Add(btnCalcular);
            Controls.Add(lblPrecoUnitario);
            Controls.Add(lblNomeDoce);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNomeDoce;
        private Label lblPrecoUnitario;
        private Button btnCalcular;
        private Label lblQuantidade;
        private Label lblIdadeCliente;
        private Label lblNome;
        private TextBox txtPrecoUnitario;
        private TextBox txtQuantidade;
        private TextBox txtIdadeCliente;
        private TextBox txtNomeDoce;
        private Label lblDesconto;
        private Label lblValorFinal;
        private Label lblStatus;
        private Label lblParcela;
    }
}
