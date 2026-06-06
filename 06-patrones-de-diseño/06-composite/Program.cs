using Composite.Dominio;

Archivo archivo1 = new Archivo("foto.jpg");
Archivo archivo2 = new Archivo("documento.pdf");
Archivo archivo3 = new Archivo("notas.txt");

Carpeta carpetaPersonal = new Carpeta("Personal");

carpetaPersonal.Agregar(archivo1);
carpetaPersonal.Agregar(archivo2);

Carpeta carpetaPrincipal = new Carpeta("Principal");

carpetaPrincipal.Agregar(carpetaPersonal);
carpetaPrincipal.Agregar(archivo3);

carpetaPrincipal.Mostrar();