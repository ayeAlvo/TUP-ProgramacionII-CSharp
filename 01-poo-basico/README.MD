# 🧩 Ejercicios de Programación II — POO Básico

Este directorio contiene los primeros ejercicios de Programación Orientada a Objetos utilizando C#.

A continuación se listan las consignas trabajadas:

---

## 1️⃣ Ejercicio 1 — Clase **Persona**

- Crear una clase **Persona** con los atributos públicos:
  - `nombre`
  - `apellido`
- Crear una instancia y asignarle valores.
- Mostrar por pantalla los valores asignados.

---

## 2️⃣ Ejercicio 2 — Clase **Vehiculo**

- Crear una clase **Vehiculo** con los atributos públicos:
  - `marca`
  - `modelo`
- Agregar un atributo **privado**:
  - `patente`
- Crear una instancia y asignarle valores.
- Notar que el atributo privado **no está disponible** para asignación externa.
- Mostrar por pantalla los valores públicos asignados.

---

## 3️⃣ Ejercicio 3 — Clase **Articulo**

- Crear una clase **Articulo** con los atributos privados:
  - `marca`
  - `modelo`
- Crear métodos públicos para la asignación de valores.
- Crear una instancia y asignarle valores mediante esos métodos.
- Notar que **no es posible mostrar los valores** por pantalla porque son privados y no existen getters.

---

## 4️⃣ Ejercicio 4 — Clase **Cine** (versión 1)

- Crear una clase **Cine** con los atributos privados:
  - `pelicula`
  - `horario`
- Crear métodos públicos para asignar y recuperar valores.
- Crear un método público:
  - `obtenerCartelera()` → devuelve película + horario.
- Crear una instancia, asignar valores y mostrar la cartelera por pantalla.

---

## 5️⃣ Ejercicio 5 — Clase **Cine** (versión 2)

- Crear una clase **Cine** con los atributos privados:
  - `pelicula`
  - `horario`
- Crear métodos públicos para asignar y recuperar valores.
- Crear una instancia y asignarle valores.
- Mostrar los valores por pantalla.
- Crear una **segunda instancia** y asignarle valores distintos.
- Mostrar por pantalla los valores de ambas instancias.
- Cambiar los valores de la **primera** instancia.
- Volver a mostrar los valores de ambas instancias.
- Concluir que cada llamada a **`new` crea objetos independientes**.

---

📘 *Cada ejercicio tiene su propio proyecto dentro de este directorio para mantener el código organizado y modular.*