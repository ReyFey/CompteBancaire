using System;

namespace CompteBancaire
{
    public class CompteE : CompteB
    {
        private int _tauxInteret;

        public CompteE(int unTauxInteret)
        {
            this.setTauxInteret(unTauxInteret);
            CompteB._nbComptes++;
        }
        public CompteE()
        {
            _nbComptes++;
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