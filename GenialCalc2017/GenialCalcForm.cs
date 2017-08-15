using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenialCalc2017
{
    public partial class GenialCalcForm : Form
    {
        // Constantes dos sinais das Operações
        const string strAdicao = "+";
        const string strSubtracao = "-";
        const string strMultiplicacao = "x";
        const string strDivisao = "/";
        const int intMaxEntradas = 16; // Limite Máximo de caracteres possíveis no Display
        const int tipBtnNumerico = 1; // Valor para Botão Numérico utilizado
        const int tipBtnOperacao = 2; // Valor para Botão de Operação utilizado
        double fltAcumuladoAtual = 0; // Acumulador
        int intUltimoTipoBotao = tipBtnNumerico; // Variável com o Útlimo Botão utilizado: 1 - Numérico; 2 - Operação;
        int intQtdItemsNaExp = 0; // Variável para saber quantos Items foram adicionados a Expressão
        string strOperacaoAnterior; // Variável para guardar a Operação Anterior a atual
        string strSeparadorDecAtual = CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator; // Variável com o caracter utilizado pelo sistema como separador decimal

        public GenialCalcForm()
        {
            InitializeComponent(); // Inicializa todos os compoentes de tela
            BtnSeparadorDecimal.Text = strSeparadorDecAtual; // Atualiza o texto do botão de separador decimal para o utilizado pelo windows
        }

        private void GenialCalcForm_Load(object sender, EventArgs e)
        {
            txtDisplay.Text = "0"; // Limpa o Display
            txtExpressao.Text = ""; // Limpa o Mostrador de Expressão
        }

        private void UsarBotaoNumerico(int intValor)
        {
            if (intUltimoTipoBotao == tipBtnOperacao) // Se o útlimo botão usado foi de Operação...
            {
                txtDisplay.Text = intValor.ToString();
            }
            else // caso tenha sido outro que nã uma Operação...
            {
                if (txtDisplay.TextLength < intMaxEntradas) // Se não estourou o limite do Display...
                {
                    if (txtDisplay.Text == "0") // Se o Display estiver zerado...
                    {
                        txtDisplay.Text = intValor.ToString(); // Coloque o valor escolhido no Display
                    }
                    else // Caso o Display apresente outro valor que não zero...
                    {
                        txtDisplay.Text = txtDisplay.Text + intValor.ToString(); // Acrescente o valor escolhido ao final do Display
                    }
                }
                else // Caso tenha ultrapassado o limite do Display mostre uma mensagem de Aviso
                {
                    MessageBox.Show("Limite Máximo de " + intMaxEntradas + " caracteres de entrada ultrapassado.");
                }
            }
            intUltimoTipoBotao = tipBtnNumerico; // Informa que o útlimo botão usado foi de Número
        }

        private void UsarBotaoOperacao(string strOperacaoAtual)
        {
            // So executar se houver alguma coisa no display.
            if (txtDisplay.TextLength != 0)
            {
                // Se o último botão usado foi de operação somente troca a operação.
                if (intUltimoTipoBotao == tipBtnOperacao)
                {
                    txtExpressao.Text = txtExpressao.Text.Substring(0, txtExpressao.Text.Length - 1);
                    txtExpressao.Text = txtExpressao.Text + strOperacaoAtual;
                }
                else if (intUltimoTipoBotao == tipBtnNumerico)
                {
                    // Se o último botão usado foi de número e...
                    if (intQtdItemsNaExp >= 2)
                    // Se existem mais que 2 registros na lista de operações da expressão, executa a operação.
                    {
                        strOperacaoAnterior = txtExpressao.Text.Substring(txtExpressao.Text.Length - 1, 1);
                        if (strOperacaoAnterior == strAdicao)
                        {
                            fltAcumuladoAtual = fltAcumuladoAtual + double.Parse(txtDisplay.Text);
                        }
                        else if (strOperacaoAnterior == strSubtracao)
                        {
                            fltAcumuladoAtual = fltAcumuladoAtual - double.Parse(txtDisplay.Text);
                        }
                        else if (strOperacaoAnterior == strMultiplicacao)
                        {
                            fltAcumuladoAtual = fltAcumuladoAtual * double.Parse(txtDisplay.Text);
                        }
                        else if (strOperacaoAnterior == strDivisao)
                        {
                            fltAcumuladoAtual = fltAcumuladoAtual / double.Parse(txtDisplay.Text);
                        }

                        txtExpressao.Text = txtExpressao.Text + txtDisplay.Text + strOperacaoAtual;
                        txtDisplay.Text = fltAcumuladoAtual.ToString();
                    }
                    // Se existem menos que 2 registros na lista de operações da expressão, somente adicione o primeiro valor ao acumulado.
                    else
                    {
                        fltAcumuladoAtual = double.Parse(txtDisplay.Text);// Passa a conversão do texto do display para double p/a var. Acumulador
                        txtExpressao.Text = txtExpressao.Text + txtDisplay.Text + strOperacaoAtual; // Adiciona o valor do Display e a Operação ao mostrador de Expressão
                        intQtdItemsNaExp = 0; // Limpa a var. de Qtd de Items da Expressão
                        intQtdItemsNaExp = intQtdItemsNaExp + 2;// Adiciona o valor do display e a operação a var. de Qtd de Items da Expressão
                    }
                }
                intUltimoTipoBotao = tipBtnOperacao; // Indica que um botão de operação foi o último usado.
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0"; // Limpa o Display
            txtExpressao.Text = ""; // Limpa o Mostrador de Expressão
            fltAcumuladoAtual = 0; // Zera o Acumulador
            intQtdItemsNaExp = 0; // Zera a Quantidade de Items na Expressão
        }

        private void BtnCancelEntry_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0"; // Limpa o Display
        }

        private void BtnBackSpace_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0) // Se houver algo no Display...
            {
                // Remove o último caracter do display
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
                if (txtDisplay.Text.Length == 0) // Se não houver mais caracteres...
                {
                    txtDisplay.Text = "0"; // Coloca zero no Display
                }
            }
        }

        private void BtnSeparadorDecimal_Click(object sender, EventArgs e)
        {
            if (!(txtDisplay.Text.Contains(BtnSeparadorDecimal.Text))) // Se não houver o separador decimal no display
            {
                txtDisplay.Text = txtDisplay.Text + BtnSeparadorDecimal.Text; // Acrescente o separador decimal ao Display
            }
        }

        private void BtnNum0_Click(object sender, EventArgs e)
        {
            UsarBotaoNumerico(0); // Chama função genérica de botão numérico passando 0
        }

        private void BtnNum1_Click(object sender, EventArgs e)
        {
            UsarBotaoNumerico(1); // Chama função genérica de botão numérico passando 1
        }

        private void BtnNum2_Click(object sender, EventArgs e)
        {
            UsarBotaoNumerico(2); // Chama função genérica de botão numérico passando 2
        }

        private void BtnNum3_Click(object sender, EventArgs e)
        {
            UsarBotaoNumerico(3); // Chama função genérica de botão numérico passando 3
        }

        private void BtnNum4_Click(object sender, EventArgs e)
        {
            UsarBotaoNumerico(4); // Chama função genérica de botão numérico passando 4
        }

        private void BtnNum5_Click(object sender, EventArgs e)
        {
            UsarBotaoNumerico(5); // Chama função genérica de botão numérico passando 5
        }

        private void BtnNum6_Click(object sender, EventArgs e)
        {
            UsarBotaoNumerico(6); // Chama função genérica de botão numérico passando 6
        }

        private void BtnNum7_Click(object sender, EventArgs e)
        {
            UsarBotaoNumerico(7); // Chama função genérica de botão numérico passando 7
        }

        private void BtnNum8_Click(object sender, EventArgs e)
        {
            UsarBotaoNumerico(8); // Chama função genérica de botão numérico passando 8
        }

        private void BtnNum9_Click(object sender, EventArgs e)
        {
            UsarBotaoNumerico(9); // Chama função genérica de botão numérico passando 9
        }

        private void BtnDivisao_Click(object sender, EventArgs e)
        {
            UsarBotaoOperacao(BtnDivisao.Text); // Chama função genérica de botão de operação passando a Divisão
        }

        private void BtnMultiplicacao_Click(object sender, EventArgs e)
        {
            UsarBotaoOperacao(BtnMultiplicacao.Text); // Chama função genérica de botão de operação passando a Multiplicação
        }

        private void BtnSubtracao_Click(object sender, EventArgs e)
        {
            UsarBotaoOperacao(BtnSubtracao.Text); // Chama função genérica de botão de operação passando a Subtração
        }

        private void BtnAdicao_Click(object sender, EventArgs e)
        {
            UsarBotaoOperacao(BtnAdicao.Text); // Chama função genérica de botão de operação passando a Adição
        }

        private void BtnCalcula_Click(object sender, EventArgs e)
        {
            if (txtDisplay.TextLength != 0) // Se houver algo no Display...
            {
                    if (intQtdItemsNaExp >= 2) // Se a qtd de items na expressão for maior ou igual a 2...
                    {
                        // Pega o último item da expressão
                        strOperacaoAnterior = txtExpressao.Text.Substring(txtExpressao.Text.Length - 1, 1);
                        if (strOperacaoAnterior == strAdicao) // Se o último item da expressão for a operação de Adição...
                        {
                            fltAcumuladoAtual = fltAcumuladoAtual + double.Parse(txtDisplay.Text);
                        }
                        else if (strOperacaoAnterior == strSubtracao) // Se o último item da expressão for a operação de Subtração...
                        {
                            fltAcumuladoAtual = fltAcumuladoAtual - double.Parse(txtDisplay.Text);
                        }
                        else if (strOperacaoAnterior == strMultiplicacao) // Se o último item da expressão for a operação de Multiplicação...
                        {
                            fltAcumuladoAtual = fltAcumuladoAtual * double.Parse(txtDisplay.Text);
                        }
                        else if (strOperacaoAnterior == strDivisao) // Se o último item da expressão for a operação de Divisão...
                        {
                            fltAcumuladoAtual = fltAcumuladoAtual / double.Parse(txtDisplay.Text);
                        }
                        txtExpressao.Text = ""; // Limpa o Mostrador de Expressão
                        intQtdItemsNaExp = 0; // Zera a qtd de Items na Expressão
                        txtDisplay.Text = fltAcumuladoAtual.ToString(); // Mostra o resultado das operações
                    }
                    else // Se houver 1 ou nenhum item na Expressão...
                    {
                        txtExpressao.Text = ""; // Limpa o Mostrador de Expressão
                        intQtdItemsNaExp = 0; // Limpa o Display com 0(zero)
                    }
            }
            intUltimoTipoBotao = tipBtnOperacao; // Indica que um botão de operação foi o último usado.
        }

        private void GenialCalcForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D0:
                case Keys.NumPad0:
                    BtnNum0_Click(sender, e);
                    break;
                case Keys.D1:
                case Keys.NumPad1:
                    BtnNum1_Click(sender, e);
                    break;
                case Keys.D2:
                case Keys.NumPad2:
                    BtnNum2_Click(sender, e);
                    break;
                case Keys.D3:
                case Keys.NumPad3:
                    BtnNum3_Click(sender, e);
                    break;
                case Keys.D4:
                case Keys.NumPad4:
                    BtnNum4_Click(sender, e);
                    break;
                case Keys.D5:
                case Keys.NumPad5:
                    BtnNum5_Click(sender, e);
                    break;
                case Keys.D6:
                case Keys.NumPad6:
                    BtnNum6_Click(sender, e);
                    break;
                case Keys.D7:
                case Keys.NumPad7:
                    BtnNum7_Click(sender, e);
                    break;
                case Keys.D8:
                case Keys.NumPad8:
                    BtnNum8_Click(sender, e);
                    break;
                case Keys.D9:
                case Keys.NumPad9:
                    BtnNum9_Click(sender, e);
                    break;
                case Keys.Oemcomma:
                case Keys.Decimal:
                    BtnSeparadorDecimal_Click(sender, e);
                    break;
                case Keys.Add:
                case Keys.Oemplus:
                    BtnAdicao_Click(sender, e);
                    break;
                case Keys.Subtract:
                case Keys.OemMinus:
                    BtnSubtracao_Click(sender, e);
                    break;
                case Keys.Multiply:
                case Keys.Oem8:
                    BtnMultiplicacao_Click(sender, e);
                    break;
                case Keys.Divide:
                    BtnDivisao_Click(sender, e);
                    break;
                case Keys.Enter:
                    BtnCalcula_Click(sender, e);
                    break;
                case Keys.Escape:
                    BtnCancel_Click(sender, e);
                    break;
                case Keys.Delete:
                    BtnCancelEntry_Click(sender, e);
                    break;
                case Keys.Back:
                    BtnBackSpace_Click(sender, e);
                    break;
            }
        }

        private void GenialCalcForm_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    e.IsInputKey = true;
                    base.OnPreviewKeyDown(e);
                    break;
            }
        }
    }
}
