using System.Collections;

namespace ExempleIterateur
{
    /// <summary>
    /// Itère sur les entiers de 1 à 20
    /// </summary>
    public class IterateurCompteur : IEnumerator<int>
    {
        // Valeur du plus grand entier pouvant être généré
        private const int MAX_VALEUR = 20;

        /// <summary>
        /// Élément courrant pointé par l'itérateur
        /// </summary>
        public int Current { get; private set; }

        /// <summary>
        /// Élément courrant pointé par l'itérateur
        /// </summary>
        object IEnumerator.Current => Current;

        /// <summary>
        /// Crée un nouvel itérateur vanilla
        /// </summary>
        public IterateurCompteur()
        {
            Current = default;
        }

        /// <summary>
        /// Libère les ressources non gérées par l'itérateur
        /// </summary>
        public void Dispose()
        {
            // Pas de traitement particulier
        }

        /// <summary>
        /// Avance le pointeur de l'itérateur vers le prochain élément
        /// </summary>
        /// <returns>True si un autre élément existe ou false si l'itérateur est arrivé à terme.</returns>
        public bool MoveNext()
        {
            if(Current < MAX_VALEUR)
            {
                Current++; 
                return true;
            }

            return false;
        }

        /// <summary>
        /// Repositionne l'itérateur dans sa configuration initiale
        /// </summary>
        public void Reset()
        {
            Current = default;
        }
    }
}
