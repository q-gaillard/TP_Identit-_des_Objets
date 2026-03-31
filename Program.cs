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

        HashSet<Produit> panier = new HashSet<Produit>();
        panier.Add(p1);
        panier.Add(p2);
        panier.Add(p3);
        Console.WriteLine(panier.Count);

        Produit p4 = new ProduitPerissable("676767", "le bon lait du fermier", 5, 3);
        Console.WriteLine(p4.GetType());

        List<Object> inventaire = new List<Object>();
        inventaire.Add(p1);
        inventaire.Add(p2);
        inventaire.Add(p3);
        inventaire.Add(p4);

        foreach (Object obj in inventaire)
        {
            Console.WriteLine(obj);
            Console.WriteLine($"type : {obj.GetType()}");
            if (obj is Produit produit)
            {
                Console.WriteLine($"code de l'article : {produit.GetCodeArticle()}");
            }
        }
    }
}
