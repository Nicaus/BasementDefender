# BasementDefender
#### Jeu fait avec Unity et C#

## Améliorations à faire
### Vitesse aléatoire
Trouvez une solution pour faire varier aléatoirement la vitesse de chaque VilainBoulet créé.
### Paravent mobile
Ajoutez un script (composante Monobehavior) sur le paravent. Celui-ci devra se diriger progressivement vers la gauche afin de cacher les VilainBoulets. Il devra éventuellement s’arrêter environ à la moitié de l’écran.
Indice : utilisez la fonction Mathf.Clamp pour faire arrêter l’objet.
### Faire tirer le joueur
Le joueur pourra se défendre avec le pouvoir de l’amour !

#### Prefab
Créer un objet nommé Amour affichant la texture Hearth. Placez-le dans la couche d’affichage Default. Ajoutez des composantes Collider 2D (forme au choix) et RigidBody. Faites-en un prefab.
Ajoutez un script qui fait que la balle bouge vers la droite. Si elle entre en collision avec quoique ce soit, elle doit être détruite.

> Bien tester votre balle avant d’aller plus loin.

#### Modifier le script du joueur
Inspirez-vous de la source des VilainBoulets pour faire tirer le joueur.
Dans le FixedUpdate, utilisez le code ci-bas pour faire tirer le joueur. La touche de tir est contrôle à gauche.
 
```csharp
IF (INPUT.GETBUTTONDOWN("FIRE1")) {
    INSTANTIATE(PROJECTILE, TRANSFORM.POSITION + VECTOR3(2F,0F,0F), QUATERNION.IDENTITY);
}
```
ATTENTION : faites bien attention de créer la balle DEVANT votre joueur. Autrement, elle pourrait disparaître immédiatement.


#### Limiter la cadence de tir
Trouvez une solution pour limiter la rapidité de tir du joueur à 1 fois par 0.2 secondes.

#### Balles perdues
Est-ce qu’il y a un problème avec nos balles qui ne touche à rien en ce moment? Corrigez la situation.
