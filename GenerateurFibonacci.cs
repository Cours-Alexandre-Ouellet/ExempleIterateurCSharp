namespace ExempleIterateur
{
    /// <summary>
    /// Génère des nombres de Fibonacci 
    /// </summary>
    public class GenerateurFibonacci
    {
        /// <summary>
        /// Génère un énumérateur de nombres de Fibonacci. Le nombre de termes à générer doit être spécifié
        /// </summary>
        /// <param name="termes">Le nombre de termes à afficher.</param>
        /// <returns>Un énumérateur de nombres de Fibonacci.</returns>
        public static IEnumerator<int> GetSequence(int termes)
        {
            // La suite de Fibonacci correspond à n_i = n_(i - 2) + n_(i - 1) avec n_0 = 1 et n_1 = 1 
            int nombreTermesGeneres = 0;
            int avantPrecedent = 0;
            int precedent = 0;

            while(nombreTermesGeneres < termes)
            {
                nombreTermesGeneres++;
                if(avantPrecedent == 0)
                {
                    avantPrecedent = 1;
                    yield return 1;
                }
                else if(precedent == 0)
                {
                    precedent = 1;
                    yield return 1;
                }
                else
                {
                    int terme = avantPrecedent + precedent;
                    avantPrecedent = precedent;
                    precedent = terme;

                    yield return terme;
                }
            }

        }

    }
}
