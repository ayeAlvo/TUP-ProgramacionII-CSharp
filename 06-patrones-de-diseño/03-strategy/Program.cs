using Strategy.Dominio;

Enemigo enemigo = new Enemigo(
    new AtaqueEspada()
);

enemigo.Atacar();

enemigo.CambiarAtaque(
    new AtaqueArco()
);

enemigo.Atacar();

enemigo.CambiarAtaque(
    new AtaqueMagia()
);

enemigo.Atacar();