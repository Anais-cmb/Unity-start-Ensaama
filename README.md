# Unity-start-Ensaama

# Vie et Mort
Pour détruire un composant OU un gameObject :
```csharp
Destroy (gameObject);
// avec un délai de 3 secondes :
Destroy (gameObject, 3f);
```

Pour créer un gameObject à partir d'une source :
- existant dans une scène :
```csharp
Instantiate (gameObject);
```

- en récupérant l'instance créée pour la détruire au bout de 5 secondes :
```csharp
GameObject clone= Instantiate(gameObject);
Destroy(clone, 3f);
```
[voir usage dans CloneOnClick.cs](./Assets/CloneOnClick.cs)

## Component (accès à  une instance, détruire, ajouter)

Pour récupérer un composant existant sur un gameObject, on utilise `GetComponent<MonComposant>()`, par exemple :

```csharp
Rigidbody body = GetComponent<RigidBody>();
```
Attention, le composant récupéré peut être nul (s'il n'existe pas) !

Pour ajouter un composant sur un gameObject, on utilise `gameObject.AddComponent<MonComposant>()`, par exemple :

```csharp
gameObject.GetComponent<RigidBody>();
```
Voir usage dans [Eye.cs](./Assets/SCRIPTS/Eye.cs)

## Debug

Pour mettre en pause le moteur Unity :

```csharp
Debug.Break();
```