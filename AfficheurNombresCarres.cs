using System;
namespace ExempleIterateur
{
    /// <summary>
    /// Affiche le carré de nombres tant que la touche pour continuer est saisie
    /// </summary>
    public class AfficheurNombresCarres
    {
        /// <summary>
        /// Retourne un itérateur de nombres carrés tant que la touche de continuation est saisie.
        /// </summary>
        /// <param name="toucheContinuer">La touche pour avancer dans l'itérateur.</param>
        /// <returns>Un itérateur de nombres carrés</returns>
        public static IEnumerator<int> GetSequence(ConsoleKey toucheContinuer = ConsoleKey.Tab)
        {
            int nombre = 1;

            Console.WriteLine($"Appuyez sur {toucheContinuer} pour afficher des carres. Appuyez sur n'importe" +
                $"quelle autre touche pour arreter.");

            // Tant que la touche est la touche continuer
            while(Console.ReadKey().Key.Equals(toucheContinuer))
            {
                yield return nombre * nombre;
                nombre++;
            }
        }

    }
}
