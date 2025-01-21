Dans cette mission, vous allez implémenter des raccourcis clavier pour faire apparaître des cartes rapidement. Vous savez déjà comment créer et afficher des cartes grâce aux missions précédentes.

---

### Étape 1 : Utiliser ou Créer un Script

-  Si vous avez déjà un objet (par exemple, un GameObject nommé `GameManager`) avec un script attaché, vous pouvez utiliser ce script.
-  Sinon, créez un nouveau GameObject ainsi qu'un nouveau script et nommez-le `CardShortcuts`.

---

### Étape 2 : Ajouter les Raccourcis Clavier

1. **Modifier le script**  
    Dans le script que vous avez choisi ou créé, ajoutez la gestion des raccourcis clavier :

```
using UnityEngine;

public class CardShortcuts : MonoBehaviour
{
    public GameObject cardPrefab; // Le prefab de carte à instancier
    public Transform spawnPoint; // L'emplacement où les cartes apparaîtront

    void Update()
    {
        // Vérifie si une touche est pressée pour faire apparaître une carte
        if (Input.GetKeyDown(KeyCode.Alpha1)) // Touche "1"
        {
            SpawnCard("Card 1");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2)) // Touche "2"
        {
            SpawnCard("Card 2");
        }
    }

    private void SpawnCard(string cardName)
    {
        if (cardPrefab != null && spawnPoint != null)
        {
            // Instancier une carte
            GameObject newCard = Instantiate(cardPrefab, spawnPoint.position, Quaternion.identity);
            newCard.name = cardName; // Renommer la carte pour identifier son origine
        }
        else
        {
            Debug.LogWarning("CardPrefab ou SpawnPoint n'est pas assigné dans l'Inspector !");
        }
    }
}

```

Vous pouvez simplement vous inspirer de se script et/ou réutiliser des méthodes déjà créées.

---
### Étape 3 : Configurer les Paramètres dans l’Inspector

1. **Assigner le Prefab et le Point d’Apparition**
    - Sélectionnez le GameObject `GameManager` dans la **Hierarchy**.
    - Dans l’**Inspector**, localisez le script `CardShortcuts`.
    - Assignez :
        - **Card Prefab** : Faites glisser le Prefab de votre carte dans ce champ.
        - **Spawn Point** : Ajoutez un GameObject (par exemple, un Empty nommé `CardSpawnPoint`) et placez-le où vous voulez que les cartes apparaissent. Faites glisser cet objet dans le champ **Spawn Point**.

---

### Étape 4 : Tester les Raccourcis

1. **Lancer la Scène**
    - Appuyez sur **Play** dans Unity.
    
2. **Utiliser les Raccourcis**
    - Appuyez sur les touches "1" et "2" pour faire apparaître des cartes avec les noms correspondants. Si vous n'avez pas de pavé numérique, il va falloir ALLER VOIR LA DOC 😱. > https://docs.unity3d.com/6000.0/Documentation/ScriptReference/KeyCode.html