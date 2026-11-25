# .NET y Entity
> Se irán cambiando cositas segun avance la BA.

![rakai](../img/rakai-read-rakai.png)

## Creación de clases
Estos son los pasos que tienen que seguirse para **crear las clases:**
![instalacion](../img/creacion-clase.png)
```php
 public class Castillo // Muy importante cambiar la clase y ponerla pública.
 {
     public int CastilloID { get; set; } 
     // Muy importante siempre poner los getter y los setter
     // Visual Studio suele rellenar pero igualmente
 }
```

## Creación de relaciones

En un ejemplo de un `castillo` en el que hay muchos `goombas`, así se vería cada lado:

### Castillo
```php
    public class Castillo
    {
        public int CastilloID { get; set; }
        public string nombre { get; set; }
        public double metroscuadrados { get; set; }
        public virtual ICollection <Goomba> Goombas { get; set; } // Esto en una relación 1-N apunta a todas las N.
    }
```
### Goomba
```php
public class Goomba
{
    public int GombaID { get; set; }
    public string nombre { get; set; }
    public float altura { get; set; }
    public virtual Castillo Castillo { get; set; } 
    // Como es una relación 1-N, la parte del N tiene la <Castillo>.
    // Porque siempre apuntará a una misma entidad.
}
```
# Framework de *.NET*

# Extensiones

