
Use el patrón Strategy porque el sistema requiere distintas formas de procesamiento para un mismo documento, como encriptación y compresión. Además, el enunciado dice que el procesamiento debe poder cambiarse en tiempo de ejecución y que en el futuro podrían incorporarse nuevos tipos de procesamiento.

IProcesamiento: define la forma en que se debe procesar un documento, sin importar cómo se haga internamente.
Las clases ProcesamientoEncriptado y ProcesamientoComprimido implementan esta interfaz.

ProcesadorDocumento: actúa como contexto del patrón Strategy. Mantiene una referencia a IProcesamiento y delega en esa estrategia el procesamiento del documento. El procesador no necesita conocer detalles de las implementaciones, o sea el cómo?
También permite recibir una estrategia puntual al momento de procesar. De esta forma se puede usar el procesamiento configurado o elegir otro en una ejecución particular.

SOLID: 

DIP: ProcesadorDocumento depende de la abstracción IProcesamiento y no de clases concretas como ProcesamientoEncriptado o ProcesamientoComprimido.

OCP: es posible agregar nuevas estrategias de procesamiento sin modificar las clases existentes, porque puedo agregar nuevas estrategias sin modificar ProcesadorDocumento ni Documento.

Separe las responsabilidades entre Documento y ProcesadorDocumento para respetar SRP. Documento representa la información del documento, mientras que ProcesadorDocumento se encarga de aplicar las estrategias de procesamiento. (primero lo habia hecho todo en una clase)

ISP: la interfaz IProcesamiento es pequeña y específica, ya que solamente obliga a implementar el método necesario para procesar un documento.

LSP: las clases que implementan IProcesamiento pueden usarse en lugar de la interfaz sin alterar el funcionamiento esperado, porque todas cumplen el contrato de Procesar(documento).


¿Rompo encapsulamiento con GetContenido()?
Sí, pero de forma controlada. Documento mantiene su atributo contenido privado. No permito modificar el contenido desde afuera.
Hice el método GetContenido para permitir que las estrategias puedan acceder a la información de contenido.
