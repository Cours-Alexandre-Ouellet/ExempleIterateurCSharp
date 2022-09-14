namespace ExempleIterateur
{
    public class Application
    {
        public static void Main(string[] args)
        {
            // Affiche les nombres carrés
            IEnumerator<int> sequenceCarres = AfficheurNombresCarres.GetSequence();
            while(sequenceCarres.MoveNext())
            {
                Console.WriteLine(sequenceCarres.Current + ", ");
            }

            // Affiche les nombres de Fibonacci
            Console.WriteLine("Combien de termes de Fibonacci doit-on afficher ?");
            if(int.TryParse(Console.ReadLine(), out int nombreTermes))
            {
                IEnumerator<int> sequenceFibonacci = GenerateurFibonacci.GetSequence(10);

                while(sequenceFibonacci.MoveNext())
                {
                    Console.WriteLine(sequenceFibonacci.Current + ", ");
                }
                
            }
        }
    }
}