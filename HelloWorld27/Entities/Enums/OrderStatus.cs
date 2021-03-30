
namespace HelloWorld27.Entities.Enums
{
    enum OrderStatus : int // OrderStatus está no tipo 'enum'. // ': int' especifica que os valores do enum são inteiros.
    {
        PeendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3

    }
}
