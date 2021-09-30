namespace CompteBancaire
{
    public class CompteE
    {
        private int _tauxInteret;

        public CompteE(int unTauxInteret)
        {
            this.setTauxInteret(unTauxInteret);
        }

        public int getTauxInteret()
        {
            return this._tauxInteret;
        }

        private void setTauxInteret(int unTauxInteret)
        {
            this._tauxInteret = unTauxInteret;
        }
    }
}