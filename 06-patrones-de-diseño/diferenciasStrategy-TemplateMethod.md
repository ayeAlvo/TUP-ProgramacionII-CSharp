| Pregunta                           | Strategy                       | Template Method            |
| ---------------------------------- | ------------------------------ | -------------------------- |
| ¿Qué cambia?                       | El comportamiento completo     | Algunos pasos del proceso  |
| ¿Cómo se implementa?               | Composición                    | Herencia                   |
| ¿Quién decide?                     | El objeto estrategia           | La clase base              |
| ¿El algoritmo principal ya existe? | No necesariamente              | Sí                         |
| ¿Qué se intercambia?               | Estrategias                    | Implementaciones de pasos  |
| Ejemplo                            | atacar con espada/arco/magia   | preparar té/café           |
| Palabra clave                      | algoritmo / estrategia / forma | plantilla / receta / pasos |


## Regla mental

Si el enunciado dice:

"La acción puede realizarse de distintas maneras"

👉 **Strategy**

Ejemplos:

```
Atacar
- Espada
- Arco
- Magia
```

```
Pagar
- Tarjeta
- Transferencia
- Efectivo
```

```
Notificar
- Mail
- WhatsApp
- Telegram
```

Si el enunciado dice:

"Todos siguen el mismo proceso, pero algunos pasos cambian"

👉 **Template Method**

Ejemplos:

```
Preparar bebida
- Hervir agua
- Preparar ingrediente
- Servir
```

```
Generar reporte
- Obtener datos
- Formatear
- Exportar
```

```
Procesar pedido
- Validar
- Procesar
- Confirmar
```

## La pregunta mágica:

## Strategy

`¿Estoy cambiando el CÓMO?`

```
Atacar
↓
Espada o Arco o Magia
```

### Template Method

`¿La receta ya existe?`

```
Preparar bebida
↓
Hervir
↓
???
↓
Servir
```

Solo completás el paso que falta.

### UML mental
 **Strategy**

```
Enemigo
   │
   ▼
IAtaque
   △
 ┌─┼─┐
 │ │ │
Espada
Arco
Magia
```
Fijate:

`COMPOSICIÓN`

Porque:
```cs
private IAtaque ataque;

```

## Template Method
### 

```
Bebida
  △
 ┌┴┐
 │ │
Te Cafe
```
Fijate:

`HERENCIA`

Porque:
```cs
class Te : Bebida
```

# Truco de parcial 🚨

Si ves:

```cs
private IAlgo algo;
```
y despues:
```
ClaseCliente
↓
Interfaz
↓
Varias implementaciones
```

pensá primero en:

👉 **Strategy**

---

Si ves:
```cs
abstract class Algo
{
    MetodoPrincipal()
    {
        Paso1();
        Paso2();
        Paso3();
    }
}
```

pensá inmediatamente en:

👉 **Template Method**

---

```
Strategy
=
cambio el algoritmo.

Template Method
=
completo el algoritmo.
```

conecta con SOLID:
```
Strategy
→ DIP + OCP

Template Method
→ Herencia + Polimorfismo
```




