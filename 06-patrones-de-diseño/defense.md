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

