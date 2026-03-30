using System.IO.Pipelines;

class Produit
{
    private string codeArticle;
    private string designation;
    private double prix;

    public Produit(string code, string nom, double px)
    {
        this.codeArticle = code;
        this.designation = nom;
        this.prix = px;
    }
    public Produit()
    {
        this.codeArticle = "";
        this.designation = "";
        this.prix = 0;
    }

    public override string ToString()
    {
        return "Produit { code article : " + codeArticle + ", designation : " + designation + ", prix : " + prix + " }";
    }

    public override bool Equals(object? obj)
    {
        bool result = true;
        if (obj is Produit produit)
        {
            if (this.codeArticle != produit.codeArticle)
            {
                result = false;
            }
            if (this.designation != produit.designation)
            {
                result = false;
            }
            if (this.prix != produit.prix)
            {
                result = false;
            }
        }
        else
        {
            result = false;
        }
        return result;
        
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(codeArticle);
    }

    public string GetCodeArticle()
    {
        return this.codeArticle;
    }
    public string GetDesignation()
    {
        return this.designation;
    }
    public double GetPrix()
    {
        return this.prix;
    }

    public void SetCodeArticle(string codeArticle)
    {
        this.codeArticle = codeArticle;
    }
    public void SetDesignation(string designation)
    {
        this.designation = designation;
    }
    public void SetPrix(double prix)
    {
        this.prix = prix;
    }
}