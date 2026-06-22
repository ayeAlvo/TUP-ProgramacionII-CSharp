# ADAPTER

## 📖 Frase de manual

Convierte la interfaz de una clase en otra interfaz esperada por el cliente.

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
