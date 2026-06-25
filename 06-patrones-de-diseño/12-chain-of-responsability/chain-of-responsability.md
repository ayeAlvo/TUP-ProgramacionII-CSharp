## Frase de Manual

Permite pasar una solicitud a través de una cadena de objetos receptores hasta que uno pueda procesarla.

### A lo Ayelen
```
Tengo un problema.

No sé quién lo puede resolver.

Se lo doy al primero.

Si no puede, lo pasa al siguiente.

Y así sucesivamente.
```

Ejemplo:
```
Empleado
↓
Encargado
↓
Gerente
↓
Director
```

## UML Tipico
```
Soporte
- siguiente : Soporte

+ SetSiguiente()
+ Atender()
+ PuedeResolver()
+ Resolver()
```

`SoporteNivel1 : Soporte`
`SoporteNivel2 : Soporte`
`SoporteNivel3 : Soporte`

