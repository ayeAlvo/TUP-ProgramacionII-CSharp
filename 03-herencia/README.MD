🧩 Ejercicios de Programación II — Herencia, Sobrescritura y Extensión de Clases en C#

Este directorio contiene ejercicios progresivos centrados en **clases**, **herencia**, **sobrescritura de métodos** y **extensión de funcionalidad** utilizando C#.

A continuación se listan las consignas trabajadas:

---

8️⃣ **Ejercicio 8 — Clases independientes (sin herencia)**  
Crear una clase **Persona** con los atributos privados:  
- nombre  
- apellido  

Implementar setters y getters manualmente.  

Crear además:  
- **Visitante** (misma estructura que Persona)  
- **Guardia** (misma estructura que Persona)  

Crear una instancia de cada clase, asignar valores y mostrar sus atributos por pantalla.

---

9️⃣ **Ejercicio 9 — Herencia básica**  
Partiendo de la clase **Persona** (nombre y apellido + getters/setters), crear:  
- **Visitante**, que **extiende** de Persona  
- **Guardia**, que **extiende** de Persona  

Crear una instancia de cada clase, asignar valores y mostrarlos por pantalla.  
Comparar este diseño con el ejercicio 8 para identificar las ventajas de la herencia.

---

🔟 **Ejercicio 10 — Sobrescritura de métodos**  
Tomando la estructura del ejercicio 9:  

Modificar Persona agregando:  
- método **presentarse()**, que devuelva *"Nombre Apellido"*.

Crear una instancia de Persona, Visitante y Guardia.

Sobrescribir en Guardia el método **presentarse()** para que retorne:  
> “Hola, mi nombre es &lt;nombre y apellido&gt; y soy el guardia.”

Mostrar por pantalla los resultados de `presentarse()` en cada instancia y observar cómo la sobrescritura tiene precedencia sobre la implementación del padre.

---

1️⃣1️⃣ **Ejercicio 11 — Extensión de clases y nuevos métodos**  
Continuando con las clases creadas previamente:

En **Visitante**:  
- agregar el atributo privado **dni** (numérico)  
- implementar setters y getters correspondientes  

En **Guardia**:  
- agregar el método público **controlarDocumento(int dni)** que devuelva:  
  > “Adelante persona con dni &lt;dni&gt;”

Crear instancias de Persona, Visitante y Guardia, asignar valores y mostrarlos por pantalla, incluyendo la llamada al nuevo método `controlarDocumento()`.

---

1️⃣2️⃣ **Ejercicio 12 — Mejoras en Guardia y uso de objetos como parámetros**

Modificaciones basadas en el ejercicio anterior:

- Actualizar el método `controlarDocumento()` en la clase **Guardia** para que devuelva:
  
  **“Adelante <nombre completo del visitante> con dni <dni>”**

- El método ahora recibe un **objeto Visitante**, utilizando directamente sus propiedades.
- Crear instancias de las clases Visitante y Guardia, asignar valores e invocar el método.
- Analizar si es posible pasar un único parámetro (el visitante) al método:
  - ✔ Más limpio y orientado a objetos.
  - ✔ Evita pasar datos duplicados.
  - ✔ Facilita extensiones futuras.
  - ✘ Aumenta el acoplamiento al tipo Visitante.

---

**Extra Figuras geométricas**

Desarrollar una aplicación que permita conocer el área y el perímetro de un triángulo, de un
cuadrado y de un círculo. Cada figura posee un nombre y un color. La aplicación debe permitir
obtener para cada una de las figuras su nombre, color, perímetro y área. Para probar esta
aplicación, cree por lo menos 1 figura de cada tipo y muestre el resultado de invocar a sus
métodos. Implemente la misma solución utilizando polimorfismo.
