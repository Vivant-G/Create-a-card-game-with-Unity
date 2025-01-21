Dans cette mission, vous allez apprendre à naviguer entre deux scènes grâce à des boutons. Vous créerez une nouvelle scène en copiant une scène existante, puis ajouterez des boutons dans chaque scène pour naviguer entre elles.

---
### Étape 1 : Créer une nouvelle scène

- Faites un clic droit sur la scène fournie (**Scene 1**) et sélectionnez `Duplicate`.
- Renommez la copie **Scene2**, ou Scene3 si vous êtes complètement déglingo.

---
### Étape 2 : Ajouter des boutons pour naviguer entre les scènes

#### 1. Dans la première scène (`Scene1`)

1. **Créer le bouton**
    - Ajoutez un bouton et renommez-le `Button_ToScene2`.
    - Vous pouvez ajouter du texte dans le component Text ou Text(TMP).

2. **Créer un script pour gérer la navigation**
	- Dans `Assets/Scripts`, créez un script nommé `SceneNavigator`.
	- Ajoutez ce code au script :

```
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneNavigator : MonoBehaviour
{
    private void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
```

⚠️ J'ai encore glissé une erreur dans ce code car je suis un véritable petit saltimbanque.

- Attachez ce script à un GameObject (par ex. un GameObject vide nommé `GameManager`).

3. **Configurer le bouton**
    - Dans l’Inspector du bouton, sous **OnClick()**, ajoutez :
        - Glissez le GameObject contenant le script `SceneNavigator`.
        - Sélectionnez : `SceneNavigator > LoadScene`.
        - Dans le champ String, entrez `Scene2` ou le nom de la nouvelle scène que vous avez créé.

OUI, CA MARCHE PAS. Regardez l'étape 3.

---
### Étape 3 : Ajouter les scènes au build

1. **Ouvrir les paramètres de build**
    - Allez dans `File > Build Settings`. Ou `Ctrl + Shift + B` si vous êtes un h@cker.
2. **Ajouter les scènes**
    - Cliquez sur **Add Open Scenes** pour ajouter les scènes une par une.
    - Assurez-vous que `Scene1` est en haut de la liste.

---

#### **Dans `Scene2`**

Vous devrez créé un bouton identique mais qui redirigera vers la scène 1. Les étapes sont identiques.

### Étape 4 : Tester la navigation

1. Lancez `Scene1` avec le bouton **Play**.
2. Testez les boutons pour naviguer entre les scènes.
3. Vérifiez que la navigation fonctionne dans les deux sens. 🎉