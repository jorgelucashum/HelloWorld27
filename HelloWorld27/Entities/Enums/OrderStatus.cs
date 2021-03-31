
namespace HelloWorld27.Entities.Enums
{
    // Enumerações (Enum):
    // - É um tipo especial que serve para especificar de forma literal um conjunto de constantes relacionadas.
    // - Melhor semântica, é do tipo valor, código mais legível e auxiliado pelo compilador.
    
    enum OrderStatus : int // OrderStatus está no tipo 'enum'. // ': int' especifica que os valores do enum são inteiros.
    {
        PeendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3

    }
}
