# 🧩 Ejercicios de Programación II — Constructores en POO

Este directorio contiene ejercicios centrados en el uso de **constructores**, junto con la aplicación de **encapsulamiento**, métodos y manipulación básica de objetos en C#.

A continuación se listan las consignas trabajadas:

---

## 6️⃣ Ejercicio 6 — Clase **Fruta**

- Crear una clase **Fruta** con las variables privadas:
  - `color`
  - `peso` (entero, en gramos)
  - `esEstEstacional` (booleano)
- Implementar **setters** y **getters** manualmente.
- Crear el método **EsComestible()** que devuelva:
  - `true` si la fruta pesa menos de **200 g** *y* es estacional.
  - `false` en cualquier otro caso.
- Definir **dos constructores**:
  - **Constructor vacío**, para crear la fruta sin valores iniciales.
  - **Constructor con parámetros**, para inicializar color, peso y estacionalidad al momento de instanciar.

---

## 7️⃣ Ejercicio 7 — Clase **Ninja**

- Crear una clase **Ninja** con las variables privadas:
  - `arteMarcial`
  - `arma`
  - `fuerza` (entero)
  - `salto` (entero)
- Implementar **setters** y **getters** manualmente.
- Crear el método **Saltar(int multiplicador)**, que imprima por consola el resultado de `salto × multiplicador`.
- Crear el método **Ataque()**, que imprima por consola el arma utilizada y el arte marcial del ninja.
- Crear **dos instancias** de Ninja:
  - Asignar valores distintos a cada uno de sus atributos.
  - Invocar los métodos **Saltar()** y **Ataque()** para cada instancia.

---