# .NET y Entity
> Se irán cambiando cositas segun avance la BA.

![rakai](../img/rakai-read-rakai.png)

## Contexto
A diferencia de Laravel, **los objetos no se convierten en tablas hasta que se añaden al contexto**
```php
var m6 = new Modul() { Codi = 6, nom = "Acces a Dades", horesSetmana = 4 }; // Se crea un nuevo módulo.
ctx.Modul.Add(m6); // Se añade el módulo al contexto
ctx.SaveChanges(); // Se guarda el contexto. Equivalente de cuando hacíamos <tabla>.save(); en Laravel.
```

```php 
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.None)] // Sirve para que la primary key no sea autoincremental
``` 
