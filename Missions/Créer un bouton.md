## Créer un bouton

Dans cette mission, vous apprendrez à ajouter un bouton à votre jeu Unity. Ce bouton permettra simplement d'exécuter une méthode qui affichera un message dans la console.

---
### Étape 1 : Ajouter un bouton à la scène

1. **Créer le bouton**
    - Dans la fenêtre **Hierarchy**, faites un clic droit, puis sélectionnez :  
        `UI > Button (TextMeshPro)` (vous pouvez également choisir `UI > Button` si TextMeshPro n'est pas installé).
    - Cela ajoutera un bouton dans votre scène ainsi qu'un canvas pour l'afficher.
2. **Configurer le bouton**
    - Renommez l'objet bouton dans la **Hierarchy** (par exemple, `Button_Message`).
    - Sélectionnez le bouton et allez dans l'onglet **Inspector** :
        - Dans le composant `Button`, repérez la section **On Click ()**. C'est ici que nous allons lier une méthode à exécuter lorsque le bouton sera cliqué.
        - Vous pouvez également modifier l'apparence du bouton en lui assignant un des sprites fournis.

---
### Étape 2 : Créer un script pour gérer le bouton

1. **Créer un nouveau script**
    
    - Dans le dossier `Assets/Scripts`, faites un clic droit, puis sélectionnez :  
        `Create > C# Script`.
    - Nommez ce script `ButtonHandler`.
2. **Attacher le script à un GameObject**
    - Glissez le script `ButtonHandler` sur un GameObject de votre scène, par exemple le GameObject `Canvas` ou un GameObject vide que vous créez pour l'occasion.
3. **Éditer le script**  
    Ouvrez le script `ButtonHandler` et ajoutez le contenu suivant :

```
using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    public void ShowMessage()
    {
        Debug.Log("Y fonkssionne leu bouton!");
    }
}
```

---
### Étape 3 : Connecter le bouton et la méthode

1. **Sélectionner la méthode**
    
    - Dans la fenêtre **Hierarchy**, cliquez sur `Button_Message` pour le sélectionner.
    - Dans l'onglet **Inspector**, descendez jusqu'à la section **On Click ()** du composant `Button`.
    - Cliquez sur le bouton `+` pour ajouter une nouvelle entrée.
    - Glissez le GameObject contenant le script `ButtonHandler` dans le champ `Object`.
2. **Lier la méthode**
    
    - Une fois le GameObject assigné, cliquez sur le menu déroulant qui apparaît et sélectionnez :  
        `ButtonHandler > ShowMessage`.

---
### Étape 4 : Tester le bouton

1. Lancez la scène en appuyant sur le bouton **Play**.
2. Cliquez sur le bouton `Button_Message`.
3. Ouvrez la console Unity (**Window > General > Console**) et vérifiez que le message `Y fonkssionne leu bouton!` apparaît. 🎉
