# FACADE

## 📖 Frase de manual
Proporciona una interfaz unificada para un conjunto de interfaces de un subsistema.

## 🧉 A lo Ayelen
```
Tengo muchas clases complicadas.

Creo una clase "recepcionista"
que recibe el pedido
y se encarga del resto.
```

### Ejemplo:
```
Pago
Stock
Factura
Envio
```

en vez de:
```cs
pago.Pagar();
stock.Reservar();
factura.Generar();
envio.Crear();
```
hago:
```cs
tienda.Comprar();
```

### Cuándo usarlo?
```
Hay muchas clases
y quiero simplificar el acceso.
```

### UML tipico
```
Facade
  |
  +--> SistemaPago
  +--> SistemaStock
  +--> SistemaFactura
```

### Cómo reconcerlo?
Palabras clave:

- Simplificar
- Ocultar complejidad
- Punto único de acceso

## Diferencia con Adapter

Facade:

- Simplifica

Adapter:

- Adapta
