using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleMetas.Exceptions;

namespace ControleMetas.Utils.FormatUtils
{
    public class FormatUtils
    {
        public static string FormatarValor(string valorTextBox, string? formatoSelecionado)
        {
            if (string.IsNullOrEmpty(valorTextBox)) throw new NotFoundException("Valor não pode ser nulo ou vazio");

            if (string.IsNullOrEmpty(formatoSelecionado)) throw new NotFoundException("Formato não pode ser nulo ou vazio");

            string valorSemFormatacao = new(valorTextBox.Where(c => char.IsDigit(c) || c == ',').ToArray());

            if (decimal.TryParse(valorSemFormatacao, out decimal valor))
            {
                if (formatoSelecionado == "Litros")
                {
                    valor /= 100;
                    return valor.ToString("N2") + " L";
                }
                else if (formatoSelecionado == "Monetario")
                {
                    valor /= 100; 
                    return valor.ToString("C2", CultureInfo.GetCultureInfo("pt-BR")); 
                }
                else
                {
                    return valor.ToString("N0") + " UN"; 
                }
            }

            return valorTextBox;
        }

        public static string FormatarNome(string nome)
        {
            if (string.IsNullOrEmpty(nome)) throw new NotFoundException("Nome não pode ser nulo ou vazio");
            nome = nome.ToUpper();
            nome = nome.Trim();
            return nome;
        }

        public static async void FormatarErroLabel(Label erroLabel, string mensagem)
        {
            erroLabel.ForeColor = Color.FromArgb(252,199,194);
            erroLabel.Text = "*" + mensagem;
            erroLabel.Visible = true;

            await Task.Delay(5000);
            erroLabel.Visible = false;

        }
    }
}
