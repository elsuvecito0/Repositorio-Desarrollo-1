class Pedido {
enum Estado {PENDIENTE, PROCESADO, ENVIADO, ENTREGADO}
private Estado estado;
public Pedido() {
estado = Estado.PENDIENTE;
}
public void procesar() {
if(estado == Estado.PENDIENTE) {
estado = Estado.PROCESADO;
}
}
public void enviar() {
if(estado == Estado.PROCESADO) {
estado = Estado.ENVIADO;
}
}
public void entregar() {
if(estado == Estado.ENVIADO) {
estado = Estado.ENTREGADO;
}
}
}