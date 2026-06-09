# defensa oral

```
Problema
↓
Patrón
↓
SOLID
↓
Consecuencia
```

## Strategy
```
El problema era que el documento podía
procesarse de distintas maneras.

Por eso elegí Strategy.

Además aplico DIP porque dependo de
IProcesamiento.

Y aplico OCP porque puedo agregar nuevas
estrategias sin modificar la clase principal.
```

## Singleton

```
Necesitaba asegurar una única instancia.

Por eso utilicé Singleton.

El constructor es privado para evitar
instancias externas.

La consecuencia es que todo el sistema
utiliza el mismo objeto.
```

## Composite

```
Necesitaba representar una estructura
jerárquica.

Por eso utilicé Composite.

La interfaz común permite tratar hojas
y compuestos de la misma manera.

La consecuencia es que puedo recorrer
toda la estructura uniformemente.
```

## Factory Method

```
El problema era que necesitaba crear objetos,
pero sin acoplar el código cliente a clases concretas.

Por eso elegí Factory Method.

La creación queda delegada en una fábrica concreta.

Aplico OCP porque puedo agregar nuevos productos
creando nuevas fábricas sin modificar el cliente.

Aplico DIP porque el cliente trabaja con una abstracción
y no directamente con las clases concretas.

La consecuencia es que el código queda menos acoplado
a la forma exacta en que se crean los objetos.
```

## Abstract Factory

```
El problema era que necesitaba crear familias de objetos
relacionados y compatibles entre sí.

Por eso elegí Abstract Factory.

Cada fábrica concreta crea una familia completa de productos.

Aplico OCP porque puedo agregar una nueva familia
sin modificar el código cliente.

Aplico DIP porque el cliente depende de interfaces
y no de productos concretos.

La consecuencia es que evito mezclar objetos incompatibles
y mantengo el código más extensible.
```

## Decorator

```
El problema era que necesitaba agregar responsabilidades
a un objeto sin modificar su clase original.

Por eso elegí Decorator.

Cada decorador envuelve al objeto base y le agrega
un comportamiento o valor adicional.

Aplico OCP porque puedo agregar nuevos decoradores
sin modificar la clase base.

La consecuencia es que puedo combinar funcionalidades
de manera flexible, evitando crear muchas subclases.
```

## Template Method

```
El problema era que tenía un proceso con pasos generales fijos,
pero algunos pasos podían variar según la subclase.

Por eso elegí Template Method.

La clase base define la estructura del algoritmo
y las subclases completan los pasos variables.

Aplico OCP porque puedo agregar nuevas variantes
creando nuevas subclases.

La consecuencia es que mantengo una receta común,
evitando repetir el algoritmo general.
```

# Diferencias:

```
Factory Method crea un producto.
Abstract Factory crea una familia de productos.

Strategy cambia una forma de hacer algo.
Template Method mantiene una receta y cambia algunos pasos.

Decorator agrega responsabilidades.
Composite representa jerarquías de objetos.
```
