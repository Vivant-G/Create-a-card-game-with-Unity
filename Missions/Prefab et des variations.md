Votre prochaine mission consiste à transformer la carte que vous avez créée en **Prefab**, à générer des variations de ce Prefab, et à vérifier que toute modification sur le Prefab principal se répercute correctement sur ses variations.

*Utiliser des Prefabs est extrèmement imlportant dans Unity, celà évite la duplication de contenu et permet des modifications et des mises à jour des composants BEAUCOUP plus simples.*

---
### Étape 1 : Créer un Prefab
1. **Créer un dossier pour les Prefabs**
    
    - Dans la fenêtre **Project**, faites un clic droit dans `Assets` et sélectionnez :  
        `Create > Folder`.
    - Nommez ce dossier `Prefabs`.
2. **Transformer la carte en Prefab**
    
    - Glissez le GameObject de votre carte depuis la **Hierarchy** vers le dossier `Prefabs`.
    - La carte devient maintenant un **Prefab** (représenté par une icône bleue).

💡Vous pouvez maintenant placer ce prefab dans vos scènes. Quand vous modifiez le prefab, les modifications s'appliquent à toutes les instances.

---
### Étape 2 : Créer des variations du Prefab

1. **Ajouter des variations**
    - Ajouter un Prefab dans votre scène et dupliquez le (`Ctrl + D`).
    - Modifiez des propriétés spécifiques pour chaque instance, comme :
        - La couleur
        - Le nom
        - L'image du Sprite Renderer
        - L'avis sur les films Twilights
        - etc.
    - Garder un élément inchangé sur toutes les instances (par exemple la taille des cartes). Celà servira plus tard à tester le Prefab.
1. **Sauvegarder les variations**
    
    - Ces modifications n'affectent pas le Prefab principal mais restent propres à chaque instance.

---

### Étape 3 : Tester les modifications sur le Prefab principal

1. **Modifier le Prefab principal**
    
    - Double-cliquez sur le Prefab dans le dossier `Prefabs` pour l’éditer.
    - Par exemple modifiez la taille de l'objet.
2. **Vérifier les répercussions**
    
    - Revenez à la scène et observez que toutes les instances du Prefab ont été mises à jour avec vos changements, à l’exception des propriétés qui ont été modifiées directement sur les instances (par exemple, la couleur ou la position).

---

### Étape 4 : Modifier le script

1. **Ajouter des propriétés modifiables**
    
    - Pour rendre vos cartes plus flexibles, vous pouvez ajouter des valeurs à modifier dans le script.

```
using UnityEngine;

public class Card : MonoBehaviour
{
	// Pour pouvoir être modifiées, les propriétés doivent être en public
	pûblic string cardName;
	public int cardValue;

    private bool isDragging = false;
    private Vector3 offset;
  
    void OnMouseDown()
    {
		...
```

### Étape 5 : Tester vos cartes

1. Lancez la scène en mode **Play**.
2. Vérifiez que les propriétés spécifiques des cartes s’affichent correctement dans la console.
3. Testez à nouveau les modifications sur le Prefab principal et confirmez qu’elles se répercutent correctement sur toutes les instances. 🎉