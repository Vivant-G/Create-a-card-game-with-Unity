Dans le fichier `Assets/Sprites/Cards/Highlights` vous trouverez 2 images qui vous serviront d'effet de surbrillance. L'objectif est de faire apparaitre cet effet de surbrillance lorsque vous survolez une carte avec votre sourie.

### Étape 1 : Ajouter un Sprite de surbrillance
1. **Modifier le Prefab de la carte**
    - Double-cliquez sur le Prefab de carte pour l’éditer.
    
2. **Ajouter un GameObject enfant**
    - Faites un clic droit sur la carte dans la **Hierarchy** :  
        `2D Object > Sprite > Square`.
    - Renommez ce nouvel objet `Highlight`.
    
3. **Configurer le Sprite Renderer**
    - Sélectionnez l’objet `Highlight` :
        - Dans l’**Inspector**, assignez l’image de surbrillance dans le champ **Sprite** du composant **Sprite Renderer**.
        - Modifiez les paramètres :
            - **Color** : Ajustez pour une transparence partielle si nécessaire (par exemple, baissez l’alpha).
            - **Sorting Layer** : Assurez-vous que le `Highlight` est affiché au-dessus du Sprite de la carte.
    
4. **Redimensionner et positionner**
    - Ajustez l’échelle et la position pour que le `Highlight` entoure parfaitement la carte.
    
5. **Désactiver par défaut**
    - Cochez la case **Enabled** du composant **Sprite Renderer** sur `Highlight` pour le désactiver au démarrage.

---

### Étape 2 : Modifier le script `Card`

1. **Ouvrir le script `Card`**    
    - Localisez le script déjà attaché à vos cartes, nommé `Card`.
    
1. **Ajouter la gestion du surbrillance**  
    Modifiez le script pour inclure la logique suivante :

```
using UnityEngine;

public class Card : MonoBehaviour
{
    private SpriteRenderer highlightRenderer;

    void Start()
    {
        // Initialisation pour le déplacement
        highlightRenderer = transform.Find("Highlight").GetComponent<SpriteRenderer>();
        if (highlightRenderer != null)
        {
            highlightRenderer.enabled = false; // Désactive l'effet de surbrillance au début
        }
    }

    void OnMouseEnter()
    {
        // Active l'effet de surbrillance lorsque la souris survole la carte
        if (highlightRenderer != null)
        {
            highlightRenderer.enabled = true;
        }
    }

    void OnMouseExit()
    {
        // Désactive l'effet de surbrillance lorsque la souris quitte la carte
        if (highlightRenderer != null)
        {
            highlightRenderer.enabled = false;
        }
    }

    void Update()
    {
        UpdatePosition();
    }

    private void UpdatePosition()
    {
        if (isDragging)
        {
            transform.position = GetMouseWorldPosition() + offset;
        }
    }

    private Vector3 GetMouseWorldPosition()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0;
        return mousePosition;
    }
}

```

### Étape 3 : Tester l’effet de surbrillance
- Lancer la scène
- **Survoler une carte**
    - Passez votre souris sur une carte.
    - Vérifiez que l’effet de surbrillance s’active et disparaît correctement.
