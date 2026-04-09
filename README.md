# FOXMON---JEUX
Le tableau de faiblesse
| Type       | Fort contre (inflige + dégâts) | Faible contre (subit + dégâts)         |
| ---------- | ------------------------------ | -------------------------------------- |
| Feu        | Plante                         | Eau, Métal                             |
| Eau        | Feu                            | Plante, Électrique                     |
| Plante     | Eau                            | Feu, Glace                             |
| Glace      | Plante                         | Feu, Métal                             |
| Métal      | Glace                          | Feu, Électrique                        |
| Électrique | Eau                            | Sol (si tu ajoutes un type Sol), Métal |

Le tableau des multiplicateurs de dégâts
| Attaquant (Type) | Cible (Type) | Multiplicateur |
| ---------------- | ------------ | -------------- |
| Feu              | Plante       | 2              |
| Feu              | Eau          | 0.5            |
| Feu              | Feu          | 0.5            |
| Feu              | Glace        | 1              |
| Feu              | Métal        | 0.5            |
| Feu              | Sol          | 1              |
| Feu              | Électrique   | 1              |
| Feu              | Roche        | 0.5            |
| Eau              | Feu          | 2              |
| Eau              | Plante       | 0.5            |
| Eau              | Eau          | 0.5            |
| Eau              | Glace        | 1              |
| Eau              | Métal        | 1              |
| Eau              | Sol          | 2              |
| Eau              | Électrique   | 0.5            |
| Eau              | Roche        | 2              |
| Plante           | Eau          | 2              |
| Plante           | Feu          | 0.5            |
| Plante           | Plante       | 0.5            |
| Plante           | Glace        | 1              |
| Plante           | Métal        | 1              |
| Plante           | Sol          | 2              |
| Plante           | Électrique   | 1              |
| Plante           | Roche        | 1              |
| Glace            | Plante       | 2              |
| Glace            | Feu          | 0.5            |
| Glace            | Eau          | 0.5            |
| Glace            | Glace        | 0.5            |
| Glace            | Métal        | 1              |
| Glace            | Sol          | 1              |
| Glace            | Électrique   | 1              |
| Glace            | Roche        | 1              |
| Métal            | Glace        | 2              |
| Métal            | Plante       | 1              |
| Métal            | Feu          | 0.5            |
| Métal            | Eau          | 0.5            |
| Métal            | Métal        | 0.5            |
| Métal            | Sol          | 2              |
| Métal            | Électrique   | 0.5            |
| Métal            | Roche        | 2              |
| Sol              | Feu          | 1              |
| Sol              | Eau          | 1              |
| Sol              | Plante       | 0.5            |
| Sol              | Glace        | 1              |
| Sol              | Métal        | 2              |
| Sol              | Sol          | 1              |
| Sol              | Électrique   | 2              |
| Sol              | Roche        | 2              |
| Électrique       | Eau          | 2              |
| Électrique       | Sol          | 0              |
| Électrique       | Plante       | 1              |
| Électrique       | Feu          | 1              |
| Électrique       | Glace        | 1              |
| Électrique       | Métal        | 1              |
| Électrique       | Électrique   | 0.5            |
| Électrique       | Roche        | 1              |
| Roche            | Feu          | 2              |
| Roche            | Plante       | 1              |
| Roche            | Eau          | 1              |
| Roche            | Glace        | 2              |
| Roche            | Métal        | 0.5            |
| Roche            | Sol          | 0.5            |
| Roche            | Électrique   | 1              |
| Roche            | Roche        | 0.5            |

fonction qui récupère les types et faire un tableau à double dimensions.
