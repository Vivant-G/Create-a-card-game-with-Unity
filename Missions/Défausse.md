Dans cette mission, vous allez apprendre à créer une zone de défausse. Si une carte est placée dans cette zone, elle sera automatiquement détruite.

---

### Étape 1 : Créer une zone de défausse

1. **Créer un GameObject pour la zone**
    
    - Dans la **Hierarchy**, faites un clic droit :  
        `2D Object > Sprite > Square`.
    - Renommez ce GameObject : `DiscardZone`.
2. **Configurer l'apparence de la zone**
    
    - Dans l’**Inspector**, ajustez les propriétés suivantes pour rendre la zone visible :
        - Augmentez la taille (Scale)
        - Changez la couleur dans le composant **Sprite Renderer**. Dans la situation présente, vous pouriez simplement rendre la zone de défausse noir et abaisser son opacité pour créer une zone plus sombre sur le tapis de jeu.
        - Position
        - etc.

---

### Étape 2 : Ajouter un composant de détection

1. **Ajouter un composant Collider**
    - Recherchez et ajoutez un **Box Collider 2D** a votre zone de défausse.
    - Cochez **Is Trigger** pour que ce Collider agisse comme une zone de détection sans collision physique.

---

### Étape 3 : Créer un script pour la défausse

1. **Créer le script**
    
    - Dans `Assets/Scripts`, créez un script nommé `DiscardZone`.
2. **Configurer le script**  
    Ouvrez le script et copiez le code suivant :

```
using UnityEngine;

public class DiscardZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Vérifie si l'objet qui entre dans la zone est une carte
        if (collision.gameObject.CompareTag("Card"))
        {
            Destroy(collision.gameObject); // Détruit la carte
        }
    }
}

```

⚠️ Assurez vous que vous avez assigné le tag "Card" à vos cartes, sinon elles ne seront pas détruite. Si vous avez créé plusieurs cartes, pensez à créer un **Prefab** (dans une autre mission). Celà vous permettra de pouvoir mettre à jour toutes vos cartes simultanément.

### Étape 4 : Tester la zone de défausse

1. **Lancer la scène**
    
    - Cliquez sur **Play** pour tester votre scène.
2. **Déplacer une carte dans la zone**
    
    - Faites glisser une carte dans la zone de défausse.
    - Vérifiez que la carte est détruite lorsqu’elle entre dans la zone.

Si la carte n'apparait plus dans la hierarchie, c'est gg well play.