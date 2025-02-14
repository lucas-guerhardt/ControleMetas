using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMetas.Utils.FontUtils
{
    public static class FontUtils
    /*Classe utilitaria para carregar fontes personalizadas*/
    {
        private static PrivateFontCollection _pfc = new PrivateFontCollection();

        public static Font? LoadMontserrat(float size, FontStyle style = FontStyle.Regular)
        {
            try
            {
                string fontPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Fonts", "Montserrat-Regular.ttf");

                if (File.Exists(fontPath))
                {
                    _pfc.AddFontFile(fontPath);
                    return new Font(_pfc.Families[0], size, style);
                }
                else
                {
                    MessageBox.Show("Fonte Montserrat não encontrada!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar a fonte Montserrat: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
