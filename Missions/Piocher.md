Dans cette mission, vous allez apprendre à créer un bouton qui, lorsqu’il est cliqué, déclenche l’apparition d’une nouvelle carte dans la scène.

---
### Étape 1 : Vérifications

Vérifiez que votre Prefab Card contient les components suivants :
- **Sprite Renderer**
- **BoxCollider2D**
- Le script **Card**

### Étape 2 : Ajouter un bouton

Vous savez déjà le faire. Vous pouvez lui donner l'apparence que vous désirez. Assurez vous qu'il soit visible et identifiable.


### Étape 3 : Créer le script de pioche

1. **Créer un script**
    -  Créer un script nommé `CardManager`. C'est un nom cohérent pour un script qui servira à gérer les modifications, créations et suppressions de carte.
2. **Configurer le script**  
    Ouvrez le script et ajoutez le code suivant :

```
using UnityEngine;

public class CardManager : MonoBehaviour
{
    private GameObject cardPrefab; // Référence au Prefab de carte
    public Transform drawPosition; // Position où la carte sera créée

    private void DrawCard()
    {
        // Vérifie que le Prefab de carte est défini
        if (cardPrefab == null && drawPosition != null)
        {
            // Instancie une nouvelle carte à la position de pioche
            Instantiate(cardPrefab, drawPosition.position, Quaternion.identity);
        }
        else
        {
            Debug.LogWarning("CardPrefab ou DrawPosition non défini !");
        }
    }
}
```

⚠️ Des erreurs ont été glissées dans le code 🤡.

3. **Attacher le script**
    - Glissez ce script sur un GameObject dans votre scène (par exemple, un GameObject vide nommé `GameManager`).
    
4. **Configurer les références**
    - Dans l’**Inspector** du GameObject contenant le script `CardManager` :
        - Assignez votre Prefab de carte dans le champ **Card Prefab**. (Si ce champ n'apparait pas, c'est que vous n'avez pas corrigé toutes les erreurs dans le code au dessus).
        - Dans le champ `drawPosition`, vous avez simplement à... vous débrouillez un peu pour changer.

---
### Étape 4 : Connecter le bouton au script

1. **Configurer le bouton**
    - Sélectionnez le bouton que vous avez créé pour piocher.
    - Dans l’**Inspector**, dans la section **On Click ()** du composant **Button** :
        - Cliquez sur le bouton **+**.
        - Glissez le GameObject contenant le script `CardManager` dans le champ **Object**.
        - Dans le menu déroulant, sélectionnez : `CardManager > DrawCard`.

---

### Étape 5 : Tester la pioche

1. **Lancer la scène**
    - Cliquez sur **Play**.
    
2. **Cliquer sur le bouton**
    - Testez le bouton et vérifiez qu’une nouvelle carte apparaît à la position définie.