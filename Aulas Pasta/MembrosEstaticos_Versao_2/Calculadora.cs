namespace MembrosEstaticos_Versao_2
{
    public class Calculadora
    {

        //Membro/Método estático para o cálculo do Pi
        public static double Pi = 3.14;

        //Membro/Método estático para o cálculo da Circunferência
        public static double Circunferencia(double r)
        {
            return 2.0 * Pi * r;
        }

        //Membro/Método estático para o cálculo do Volume
        public static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * r * r * r;
        }
    }
}
