class ProduitPerissable : Produit
{
    private int joursAvantPeremption;

    public int GetJourAvantPeremption()
    {
        return this.joursAvantPeremption;
    }
    public void SetJoursAvantPeremption(int joursAvantPeremption)
    {
        this.joursAvantPeremption = joursAvantPeremption;
    }
    public ProduitPerissable(string c, string n, double p, int j) : base(c, n, p)
    {
        this.joursAvantPeremption = j;
    }
    public ProduitPerissable() : base()
    {
        this.joursAvantPeremption = 0;
    }
    public int GetJoursAvantPeremption()
    {
        return joursAvantPeremption;
    }
}