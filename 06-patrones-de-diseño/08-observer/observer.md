# Observer

## 📖 Frase de manual (PDF)
Define una dependencia uno a muchos entre objetos, de manera que cuando un objeto cambia de estado, todos sus dependientes son notificados automáticamente.

Observer sirve cuando un objeto observado cambia de estado y varios objetos interesados deben enterarse automáticamente.

En el PDF aparece como un patrón donde el observado guarda observadores con `attach()`, los saca con `detach()` y les avisa con `notify()`; los observadores implementan `update()`.

## 🧉 A lo Ayelen
```
Tengo un objeto importante.
Cuando cambia algo en él,
quiero avisarle automáticamente
a varias personas.
```

### Ejemplo:
```
Producto
↓
cambia precio
↓
avisar
Cliente1
Cliente2
Cliente3
```

### Cuándo usarlo?
Cuando:

- Uno cambia
- Muchos deben enterarse

### UML tipico
```
ISujeto
 + Attach()
 + Detach()
 + Notify()

      △

Producto

----------------

IObservador
 + Update()

      △

Cliente
```

### Cómo reconcoerlo?

Palabras clave:

- Notificar
- Avisar
- Suscribirse
- Seguidores
- Alertas
- Cambios automáticos

### Diferencia con Strategy:
Strategy:

- Elijo un comportamiento

Observer:

- Aviso un cambio
