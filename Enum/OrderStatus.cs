
namespace Orientado_a_Objetos.Enum
{
    enum OrderStatus : int  
    {
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
    // Formas de uso
    /*
     string s = OrderStatus.Delivered.ToString();
     OrderString os = Enum.Parse<OrderStatus>("Delivered");

    */

}
