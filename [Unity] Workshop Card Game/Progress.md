### Légende
⬜ TODO 🟨 DOIN 🟩 DONE 🟦 NEXT 🟪 WAIT 🟥 WARN
 └──
 ├──
 │  
### Dépendance des tâches :
TODO: CardPrefab
 ├──DOIN: Grimoire
 │   └──TODO: Sandbox
 │       ├──DOIN: ? Button
 │       └──DOIN: Bouton pause et restart
 └──TODO: Eclairage dynamique


### Taches indépendantes :
- Menu principal
- Level select
- Boucle musicale

# Progress
(5/22)
🟩🟩🟩🟩🟩🟩🟩🟩🟩🟩🟨🟨⬜⬜⬜⬜⬜⬜⬜
⬜⬜⬜⬜🟪🟪🟪🟪🟪🟪🟪🟪🟪🟪🟪🟪🟪🟪🟪
## New features
Settings    🟩🟩🟩🟩🟩🟩🟩🟩
Grimoire    🟩🟪🟪🟪🟪🟪🟪🟪🟪🟪
Sandbox     🟪🟪🟪🟪🟪🟪
? Button    ⬜⬜⬜⬜
Lights      ⬜⬜⬜⬜
Others      🟨🟨

## Fixs
CardPrefab  ⬜⬜⬜⬜⬜⬜
Others      🟩⬜⬜⬜

# New features
## Settings 🟩🟩🟩🟩🟩🟩🟩🟩
- [x] Rendre la page accessible depuis 🟩
    - [x] Le menu principal
        - [x] Corriger problème quand on fais escape dans le main menu.
    - [x] Le menu pause
- [x] Réglage son 🟩🟩🟩
    - [x] Musique
        - [x] Faire le slider
    - [x] Effets sonores
        - [x] Faire le slider
        - [x] Ajouter un sfx à chaque changement de valeur du slider
    - [x] Sauvegarder ses valeurs à travers tout le jeu
    - [x] Recréer entièrement le système de son du jeu
- [x] Réglages graphiques 🟩🟩🟩
    - [x] Plein écran
    - [x] Taille des cartes
- [x] Créer les sprites 🟩
    - [x] Logos
        - [x] Musique
        - [x] Effet sonores
    - [x] Sliders
    - [x] Checkboxs
    - [x] Sélection de la taille des cartes (3icons de cartes de taille différentes)

## Grimoire 🟩⬜⬜⬜⬜⬜⬜⬜⬜⬜
- [ ] Pouvoir faire défiler les pages du grimoire [0.25JH]
- [ ] Ajouter un bouton dans les modes de jeu sandbox et riddles pour accéder au grimoire [0.25JH]
- [ ] Recettes ⬜⬜⬜⬜⬜
    - [ ] Fusions
        - [ ] Cartes consommées
    - [ ] Recette est inconnue
- [ ] Mettre en place un système de sauvegarde des cartes et recettes connues par le joueur ⬜⬜
- [ ] Masquer les cartes inconnues ⬜
- [x] Créer tout les sprites 🟩
    - [x] Fond : livre sur lequel apparaissent les cartes
    - [x] Page pour les cartes standard
    - [x] Page pour les carte spéciales (avec ornements)
    - [x] Flèches pour passer d’une page à l’autre
    - [x] Pop-up des recettes
        - [x] Background
        - [x] Fusion sans consommation de la carte
        - [x] Fusion avec consommation de la carte
        - [x] Création  en cliquant sur une autre carte
        - [x] Cartes/Icon pour représenter les objets utilisé :
            - [x] Crucifix
            - [x] Bougie
            - [x] Encrier
            - [x] Miroir
            - [x] Sablier

## Mode Sandbox 🟪🟪🟪🟪🟪🟪
- [ ] Accessible depuis le menu de sélection du mode de jeu 🟪
- [ ] Sauvegardé cartes et recettes dans le grimoire 🟪🟪
    - [ ] Les cartes et recettes connues doivent être communes aux différents styles de jeu
- [ ] Il est possible de faire apparaître les cartes connues de son choix 🟪🟪🟪

## Bouton “?” ⬜⬜⬜⬜
- [ ] Ajouter un bouton ⬜
    - [ ] Mode riddles
    - [ ] Mode sandbox
- [ ] Créer la pop-up ⬜⬜⬜
    - [ ] Mode riddles
    - [ ] Mode sandbox

## Eclairage dynamique ⬜⬜⬜⬜
- [ ] Eclairage style bougie qui suit le curseur du joueur ⬜⬜
- [ ] Eclairage du curseur réduit dans les niveau ou la bougie est utilisée ⬜
- [ ] Éclairage dynamique sur la bougie ⬜

## Ajouts mineurs 🟨🟨
### Bouton pause et restart 🟨
- [x] Créer les sprites pour chaques bouton
- [ ] Implémenter la fonctionnalité de chaque bouton

### Curseur personnalisé (0.25/0.25)
- [x] Créer le sprite
- [x] Implémenter

### Menu principal (0/0.25)
- [ ] Ajouter un bouton pour revenir à l’écran titre
- [ ] Ajouter un bouton pour quitter le jeu

# FIXs
## Refaire le prefab de carte ⬜⬜⬜⬜⬜⬜
- [ ] Corriger les problèmes d’affichage des noms
- [ ] Corriger les collisions
- [ ] Gérer l’affichage des cartes superposées
- [ ] Rendre la taille des cartes modifiables
- [ ] Appliquer les modifications sur chaques cartes
- [ ] Appliquer un poids à chaques carte
- [ ] Refaire le système de sfx pour s'adapter au nouvel audio manager
    - [ ] Réappliquer les sfx à chaques cartes

## Others 🟩⬜⬜⬜
### Mettre à jour les menus de sélection des niveaux ⬜⬜
- [ ] Rendre certains niveaux inaccessible pour assurer la progression du joueur
- [ ] Afficher les niveaux inaccessibles, accessibles et finis
- [ ] Mettre en place un système de sauvegarde de la progression du joueur

### Boucle musicale ⬜
- [ ] Corriger la boucle musicale en jeu
- [ ] Corriger la musique qui se lance quand les crédits démarrent

### Modifier les boutons de fin de niveau 🟩
- [x] Créer le préfab
    - [x] Bouton Menu
    - [x] Bouton Next
- [x] Appliquer sur tout les niveaux (12/12)
- [x] Créer des sprites

# Autres
- [ ] Gérer le fullscreen au démarrage du jeu
- [ ] 
- [ ] 
- [ ] 
