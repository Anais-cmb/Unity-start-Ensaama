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