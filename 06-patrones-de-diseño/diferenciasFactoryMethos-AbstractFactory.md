# Diferencia con Abstract Factory

| Pregunta                 | Factory Method   | Abstract Factory                |
| ------------------------ | ---------------- | ------------------------------- |
| ¿Qué crea?               | Un objeto        | Una familia de objetos          |
| ¿Cuántos productos crea? | Generalmente uno | Varios relacionados             |
| Ejemplo                  | Perro o Gato     | Guerrero+Espada o Soldado+Rifle |
| Palabra clave            | objeto           | familia                         |

## Regla mental

Si el enunciado dice:

    Necesito crear distintos tipos de X

👉 **Factory Method**

Si dice:

     Necesito crear varios objetos relacionados entre sí

👉 **Abstract Factory**

## Preguntas de defensa

1. ¿Por qué es Factory Method?

Porque:

    Delega la creación del objeto a las subclases mediante un método fábrica.

2. ¿Dónde está el Factory Method?

```cs
public abstract IAnimal CrearAnimal();
```

Ese método es el corazón del patrón.

3. ¿Por qué no hago?

```cs
IAnimal animal = new Perro();
```

Porque:

    Acoplaría el cliente a una implementación concreta.

4. ¿En qué se diferencia de Abstract Factory? (MUY IMPORTANTE)

Respuesta:

    Factory Method crea un único producto, mientras que Abstract Factory crea familias de objetos relacionados.

## Truco de examen:

```cs
FabricaPerro
↓
Perro

FabricaGato
↓
Gato
```

👉 **Factory Method**

```cs
FabricaFantasia
↓
Guerrero
Espada

FabricaCienciaFiccion
↓
Soldado
Rifle
```

👉 **Abstract Factory**