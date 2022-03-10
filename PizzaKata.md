
## Contexte
L'entreprise Mario Pizza est une société qui fait des pizzas maison pour la vente à emporter ou en livraison. 
Elle veut être capable de suivre la réalisation des commandes de pizza quelle produit.

## Le pipeline de réalisation des commandes

La commande est reçue et formalisée par une liste de recette à réaliser et à transmettre à la personne qui a fait la demande.
Une recette est une suite d'opérations à réaliser dans l'ordre pour réaliser une pizza spécifique.

### Recette et réalisation
Exemple de recette :

* Pizza Reine
* Préparer la pate
* Mettre la base de tomate
* Mettre la Mozzarella pour le cuisson
* Cuire 
* Ajouter le Jambon
* Ajouter de la Mozarella fraiche
* Ajouter des champignons

Chaque étape est faite par un opérateur différent afin de créer des pipeline de production efficace. 
Dans la modélisation du système, ces opérateurs seront matérialisés par des service (qui pourrait être extérieur au système de gestion des commandes).
Il faudra donc lui transmettre ce qu'il doit faire.

### Les fours
La cuisson se fait dans des fours limités en taille (3 pizzas maximum) et dure 5 minutes par Pizza.
