Une fois votre carte créée, vous allez lui ajouter des fonctionnalités en créant un script. Ce script permettra de prendre et de déplacer la carte à l'aide de la souris.

---
### 1. Ajouter un BoxCollider

De la même manière que pour le Sprite renderer, ajoutez un component **BoxCollider2D** à votre GameObject. Celà vous sera également utile plus tard pour détecter les collisions avec d'autres GameObjects.

---
### 2. Création du script

1. Dans le dossier `Assets/Scripts`, faites un clic droit, puis sélectionnez :  
    `Create > C# Script`.
2. Nommez le script `Card`(par exemple).
3. Glissez ce script sur votre GameObject carte dans la fenêtre **Hierarchy**. Cela attachera le script à votre objet.

---
### 3. Contenu du script

Ouvrez le script `Card`, les méthodes **Start()** et **Update()** devraient avoir été générées par défaut :

- **Start()** : cette méthode est appelée une seule fois lorsque le GameObject attaché au script est créé.
- **Update()** : cette méthode est appelée en boucle à chaque tick.

Ici, la méthode Start() ne sera pas utilisée. Copiez ce code dans votre script :
```
using UnityEngine;

public class Card : MonoBehaviour
{
    private bool isDragging = false;
    private Vector3 offset;

    void OnMouseDown()
    {
        isDragging = false;
        offset = transform.position - GetMouseWorldPosition();
    }

    void OnMouseUp()
    {
        isDragging = true;
    }

    void Update()
    {}

    void UpdatePosition()
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

⚠️ Ce code contient volontairement des erreurs, à vous de les corriger pour avancer.
