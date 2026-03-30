using System.Security.Cryptography.X509Certificates;

namespace tp_class_object;

class Program
{
    static void Main(string[] args)
    {
        Produit p1 = new Produit("122122", "clavier uni-touche", 122);
        Console.WriteLine(p1);

        Produit p2 = new Produit("123456", "caramel sans sucre", 10);
        Produit p3 = new Produit("123456", "caramel sans sucre", 10);
        Console.WriteLine(p2.Equals(p3));
        Console.WriteLine(p2.Equals(p1));
    }
}
