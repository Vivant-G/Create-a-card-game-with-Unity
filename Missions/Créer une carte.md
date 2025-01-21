Votre première mission est de créer une carte. Prenez soin de réaliser proprement cet objet que vous allez réutiliser tout au long de la création de votre jeu.

---
### 1. Créer un GameObject
Pour créer un GameObjet, faites clique-droit dans la fenêtre **Hierarchy** (à gauche), une  liste d' ojbjets créables va apparaitre.

`2D Object > Sprite > Square`

Un objet va apparaitre dans la hiérarchie ainsi que sur la scène. Sélectionnez cet objet.
Dans la fenêtre **Inspector** (à droite), vous pouvez voir la liste des **composants** de l'objet selectionné.

---
### 2. Ajouter un Sprite Renderer
Cliquez sur `Add component` et chercher le component **Sprite Renderer**. Celui-ci vous permettra d'ajouter une image à votre GameObject.

Dans le champ **Sprite** de votre nouveau component, faites glisser l'image que vous souhaitez utiliser pour votre première carte (des sprites sont fournis dans `Assets > Sprites > Cards`).

"Mé pourkoi sa safich pa ?" Tout doux loulou, c'est normal.

---
### 3. Ajuster le sorting layer
Le GameObject devrait être normalement créé et visible mais il est affiché derrière d'autres objets de la scène, en l'occurence la table et le tapis de jeu.
- Pour y remedier, ajustez le **Sorting Layer** dans le component Sprite Renderer. Assignez lui le layer "Card".
Le système de sorting layers permet de gérer l'ordre d'affichage des differents GameObjects.