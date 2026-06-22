Hice niveles de soporte. Cada nivel verifica si puede resolver la solicitud segun el criterio de complejidad y tipo. Si puede resolverla, lo hace y el proceso termina. Si no puede, pasa al siguiente nivel.

La clase abstracta Soporte tiene la logica que mediante el atributo siguiente funciona. Las clases SoporteNivel1, SoporteNivel2 y SoporteNivel3 definen su propio criterio de resolucion.

MesaDeEntrada recibe la solicitud y desde ahi comienza la atencion de la solicitud. El orden de los niveles se configura desde afuera usando SetSiguiente(), por lo que puedo cambiar el orden o agregar nuevos niveles sin modificar los niveles existentes.

Aplico SRP porque cada nivel se encarga solamente de su propia resolucion si puede hacerlo.

Aplico OCP porque puedo agregar un nuevo nivel creando una nueva subclase de Soporte, sin modificar las clases existentes.

Aplico LSP porque cualquier nivel, como SoporteNivel1, SoporteNivel2 o SoporteNivel3, puede usarse donde se espera un Soporte. Todos heredan el metodo Atender() y cumplen con PuedeResolver() y Resolver(), por lo que puede funcionar de cualquier forma.