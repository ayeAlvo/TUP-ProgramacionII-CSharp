
Usé herencia para representar los distintos tipos de cerveza y vasos. Para eso definí Cerveza y Vaso como clases abstractas, y luego creé subclases concretas como RubiaNacional, NegraNacional, RubiaExtranjera, Chopp, VasoMedioLitro y Jarra.

Esto permite agregar nuevos tipos de cerveza o nuevos tipos de vaso en el futuro creando nuevas subclases, sin modificar las clases existentes, aplicando OCP.

Barril contiene un único tipo de cerveza y controla los litros disponibles. AfterOfficeLocal administra los barriles y realiza las ventas.

Venta se encarga de calcular el precio final usando la cerveza, el vaso y el margen de ganancia. Separé esta responsabilidad para no mezclar el cálculo del precio dentro de Barril ni dentro de Cerveza.

Respecto a SOLID, tambien se aplica SRP porque cada clase tiene una responsabilidad clara: Cerveza representa el tipo de cerveza, Vaso representa la capacidad del recipiente, Barril controla disponibilidad, Venta calcula el precio y AfterOfficeLocal coordina la operación.
Y LSP en la jerarquía de Cerveza. Barril trabaja con la clase base Cerveza, pero puede recibir cualquier subclase como RubiaNacional, NegraNacional o RubiaExtranjera sin modificar su comportamiento.