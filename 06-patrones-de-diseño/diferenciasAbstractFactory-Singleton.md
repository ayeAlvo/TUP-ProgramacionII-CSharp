# Diferencia rápida

| Pregunta                           | Strategy                       | Abstract Factory                    |
| ---------------------------------- | ------------------------------ | ----------------------------------- |
| ¿Qué cambia?                       | El comportamiento              | La familia de objetos creada        |
| ¿Qué resuelve?                     | Cómo hacer algo                | Qué objetos crear                   |
| ¿Crea varios objetos relacionados? | No necesariamente              | Sí                                  |
| Ejemplo                            | atacar con espada/arco/magia   | mundo fantasía crea guerrero+espada |
| Palabra clave                      | algoritmo / forma / estrategia | familia / fábrica / compatibles     |

## Regla mental

Si el enunciado dice:

“El objeto puede comportarse de distintas maneras”

👉 **Strategy**

Si dice:

“Según el tipo de familia/tema, debo crear varios objetos relacionados”

👉 **Abstract Factory**