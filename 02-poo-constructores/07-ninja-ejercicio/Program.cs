Ninja ninja1 = new Ninja();
ninja1.SetArteMarcial("Kenjutsu");
ninja1.SetArma("Katana");
ninja1.SetFuerza(80);
ninja1.SetSalto(5);

Ninja ninja2 = new Ninja();
ninja2.SetArteMarcial("Ninjutsu");
ninja2.SetArma("Shuriken");
ninja2.SetFuerza(60);
ninja2.SetSalto(8);

ninja1.Ataque();
ninja1.Saltar(3);

ninja2.Ataque();
ninja2.Saltar(2);