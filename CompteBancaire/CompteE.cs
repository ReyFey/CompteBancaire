using System;

namespace CompteBancaire
{
    public class CompteE : CompteB
    {
        private int _tauxInteret;

        public CompteE(int unTauxInteret = 0)
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