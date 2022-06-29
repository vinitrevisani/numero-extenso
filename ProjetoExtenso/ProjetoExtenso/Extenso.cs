namespace ProjetoExtenso
{
    internal class Extenso
    {

        private int numero;
        public Extenso()
        {
            numero = 0;
        }
        public string Escrever(string Numero)
        {
            int n = int.Parse(Numero);
            int c, d, u;
            if(n >= 100)
            {
                c = n / 100;
                d = (n % 100) / 10; 
                u = n % 10;

                return Centena(c, d, u);
            }
            else if(n >= 10)
            {
                d = n / 10;
                u = n % 10;
                return Dezena(d, u);
            }
            else
            {
                return Unidade(n);
            }
        }

        public string Unidade(int U)
        {
            string[] numeros = { "zero", "um", "dois", "tres", 
            "quatro", "cinco", "seis", "sete", "oito", "nove" };
            return numeros[U];
        }

        public string Dezena(int D, int U)
        {
            string[] dezena1 = { "dez", "onze", "doze", "treze",
                "quatorze", "quinze", "dezesseis", "dezessete", 
                "dezoito", "dezenove" };

            string[] dezena2 = { "vinte", "trinta", "quarenta", "cinquenta", "sessenta", "setenta", "oitenta", "noventa" };

            if(D == 1) return dezena1[U];

            else return dezena2[D-2]+(U!=0?" e " + Unidade(U):"");

        }

        public string Centena(int C, int D, int U)
        {
            string[] centena = { "cento", "duzentos", "trezentos", "quatrocentos", "quinhentos", "seiscentos", "setecentos", "oitocentos", "novecentos" };
            if (C == 1 && D == 0 && U == 0) return "cem";

            if (D == 0) return centena[C - 1] + (U != 0 ? " e " + Unidade(U) : "");

            else return centena[C - 1] + (D != 0 ? " e " + Dezena(D, U) : "");
        }
    }
}