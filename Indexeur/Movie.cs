using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexeur
{
    class Movie
    {
        public string Title { get; set; }
        private Dictionary<string, Actor> roles = new Dictionary<string, Actor>(); 

        public Actor this[string characterName] // propriété qui cherche la valeur en fonction de la clé
        {
            get // va récupérer l'acteur
            {
                Actor actor = null; // je dois chercher mon dico
                roles.TryGetValue(characterName, out actor); // essaye de trouver la valeur selon le nom du caractère, si oui sort le nom la valeur actor, si non c'est la valeur par défaut = null
                return actor;
            }
            set // remplit le tableau de rôle
            {
                if (value != null) roles[characterName] = value;
            }
        }
    }
}
