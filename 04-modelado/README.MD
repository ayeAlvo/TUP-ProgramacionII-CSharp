# 🧩 Ejercicios de Programación II — Modelado en POO

Este directorio contiene ejercicios orientados al **análisis, diseño y modelado de clases**, aplicando conceptos de composición, abstracción y polimorfismo en C#.

A continuación se listan las consignas trabajadas:

---

## 🔧 Ejercicio 13 — Robot explorador **KT-2020**

El laboratorio **Kokumo Technologies** está desarrollando un robot explorador cuyo sistema de tracción puede personalizarse según el terreno.

### 🟦 Especificaciones del robot

- **Número de serie:** `KT-2020-P`  
- **Potencia de tracción base (PTB):** `10 hp`  
- **Tracción:** intercambiable (dependiendo del sistema elegido)

### 🟩 Sistemas de tracción disponibles

#### **1. Rueda de caucho**
- Ideal para entornos urbanos.
- Resta **1 hp** al PTB.
- Permite avanzar **100 km**.
- Debe reemplazarse cuando se gasta.

#### **2. Oruga**
- Apta para cualquier tipo de terreno.
- Resta **3 hp** al PTB.
- Autonomía de **400 km**.
- Incluye sensores **Meke-M0** que permiten obtener la temperatura del entorno.

---

## 🧱 Objetivos del ejercicio

- Analizar y modelar las relaciones entre **Robot** y los distintos sistemas de tracción.
- Implementar:
  - Clase `Robot`
  - Clase abstracta `TipoTraccion`
  - Clases concretas: `RuedaDeCaucho` y `Oruga`
- Crear instancias del robot utilizando distintos sistemas de tracción.
- Mostrar por pantalla:
  - Número de serie  
  - Potencia de tracción final  
  - Tipo de tracción instalada  
  - Autonomía  
  - Datos adicionales (sensores, temperatura, etc.)

---

## 🧪 Demostración esperada

Se deben crear dos configuraciones del robot:

1. **Robot con Rueda de caucho**  
2. **Robot con Oruga**

Para cada caso, se debe imprimir:

- Número de serie  
- Potencia final (PTB − potencia de traccion base)  
- Tipo de tracción  
- Cuántos km puede avanzar  
- Características adicionales según el sistema elegido  

---

