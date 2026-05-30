using Dominio.Balanceador;


Balanceador balanceador = new Balanceador(3);

balanceador.AsignarPedido(
    new Pedido(1, 100, "CPU")
);

balanceador.AsignarPedido(
    new Pedido(2, 155, "E/S")
);

balanceador.AsignarPedido(
    new Pedido(3, 320, "CPU")
);

balanceador.AsignarPedido(
    new Pedido(4, 240, "CPU")
);

balanceador.AsignarPedido(
    new Pedido(5, 80, "E/S")
);

balanceador.AsignarPedido(
    new Pedido(6, 65, "CPU")
);

balanceador.AsignarPedido(
    new Pedido(7, 70, "E/S")
);

balanceador.AsignarPedido(
    new Pedido(8, 700, "CPU")
);