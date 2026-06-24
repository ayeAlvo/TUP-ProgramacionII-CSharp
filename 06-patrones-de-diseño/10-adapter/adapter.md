# ADAPTER

## 📖 Frase de manual

Convierte la interfaz de una clase en otra interfaz esperada por el cliente.

Se usa cuando tenés una clase que ya existe, funciona, pero tiene una interfaz distinta a la que tu sistema necesita.

## 🧉 A lo Ayelen
```
Tengo algo que funciona.

Pero habla otro idioma.

Le pongo un traductor.
```

### Ejemplo:
```cs
ImpresoraVieja
 + Imprimir()
 ```

Sistema espera:
```cs
IDocumento
 + Mostrar()
 ```

## Creo:

`AdaptadorImpresora`

### Cuándo usarlo

Cuando:
```
Dos clases son compatibles
conceptualmente

pero sus interfaces no coinciden.
```

### UML tipico
```
Cliente
   |
InterfazEsperada

      △

Adaptador
   |
ClaseVieja
```

### Cómo reconocerlo

Palabras clave:

- Integrar sistema viejo
- Biblioteca externa
- Compatibilidad
- Adaptar interfaz

### Diferencia con Facade

Adapter:

- Hace compatible

Facade:

- Hace simple

## Frase para hoja
Uso Adapter porque necesito que una clase existente con una interfaz incompatible pueda ser utilizada por el sistema mediante la interfaz esperada. El adaptador implementa la interfaz que el cliente espera y, por dentro, llama al método de la clase adaptada.

### Regla mental:

`Adapter = traductor`
