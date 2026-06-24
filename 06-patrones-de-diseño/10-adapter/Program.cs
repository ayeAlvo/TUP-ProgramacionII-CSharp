using AdapterEjemplo.Dominio;

ServicioEmailViejo servicioViejo = new ServicioEmailViejo();

INotificador notificador = new NotificadorEmailAdapter(servicioViejo);

notificador.Enviar("Tu pedido fue confirmado.");