using ObserverEjemplo.Dominio;

Canal canal = new Canal("Programación con Aye");

Usuario usuario1 = new Usuario("Ana");
Usuario usuario2 = new Usuario("Luis");
Usuario usuario3 = new Usuario("Marta");

canal.Attach(usuario1);
canal.Attach(usuario2);
canal.Attach(usuario3);

Video video1 = new Video("Patrón Observer explicado fácil");

canal.PublicarVideo(video1);

Console.WriteLine();

canal.Detach(usuario2);

Video video2 = new Video("Segundo video del canal");

canal.PublicarVideo(video2);