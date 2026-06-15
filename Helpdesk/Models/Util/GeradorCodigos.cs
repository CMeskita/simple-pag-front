using System;
using System.Security.Cryptography;
using System.Text;

namespace Helpdesk.Models.Util
{
    public class GeradorCodigos
    {
        public static string GerarCodigoPerfil()
        {
            int comprimentoTotal = 6;
            if (comprimentoTotal < 2)
                throw new ArgumentException("O comprimento total deve ser de pelo menos 2 caracteres.", nameof(comprimentoTotal));

            // Caracteres permitidos para o restante do código (letras maiúsculas e números)
            const string caracteresPermitidos = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            // Usamos StringBuilder para melhor performance na manipulação de strings
            StringBuilder codigo = new StringBuilder(comprimentoTotal);

            // Regra de negócio: Sempre começa com a letra 'S'
            codigo.Append('P');

            // Preenche o restante do comprimento com caracteres aleatórios seguros
            int comprimentoRestante = comprimentoTotal - 1;
            for (int i = 0; i < comprimentoRestante; i++)
            {
                int indiceAleatorio = RandomNumberGenerator.GetInt32(caracteresPermitidos.Length);
                codigo.Append(caracteresPermitidos[indiceAleatorio]);
            }

            return codigo.ToString();
        }
        public static string GerarCodigoUsuario()
        {
            int comprimentoTotal = 6;
            if (comprimentoTotal < 2)
                throw new ArgumentException("O comprimento total deve ser de pelo menos 2 caracteres.", nameof(comprimentoTotal));

            // Caracteres permitidos para o restante do código (letras maiúsculas e números)
            const string caracteresPermitidos = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            // Usamos StringBuilder para melhor performance na manipulação de strings
            StringBuilder codigo = new StringBuilder(comprimentoTotal);

            // Regra de negócio: Sempre começa com a letra 'S'
            codigo.Append('U');

            // Preenche o restante do comprimento com caracteres aleatórios seguros
            int comprimentoRestante = comprimentoTotal - 1;
            for (int i = 0; i < comprimentoRestante; i++)
            {
                int indiceAleatorio = RandomNumberGenerator.GetInt32(caracteresPermitidos.Length);
                codigo.Append(caracteresPermitidos[indiceAleatorio]);
            }

            return codigo.ToString();
        }
        public static string GerarCodigoSetor()
        {
            int comprimentoTotal = 6;
            if (comprimentoTotal < 2)
                throw new ArgumentException("O comprimento total deve ser de pelo menos 2 caracteres.", nameof(comprimentoTotal));

            // Caracteres permitidos para o restante do código (letras maiúsculas e números)
            const string caracteresPermitidos = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            // Usamos StringBuilder para melhor performance na manipulação de strings
            StringBuilder codigo = new StringBuilder(comprimentoTotal);

            // Regra de negócio: Sempre começa com a letra 'S'
            codigo.Append('S');

            // Preenche o restante do comprimento com caracteres aleatórios seguros
            int comprimentoRestante = comprimentoTotal - 1;
            for (int i = 0; i < comprimentoRestante; i++)
            {
                int indiceAleatorio = RandomNumberGenerator.GetInt32(caracteresPermitidos.Length);
                codigo.Append(caracteresPermitidos[indiceAleatorio]);
            }

            return codigo.ToString();
        }

    }
}
