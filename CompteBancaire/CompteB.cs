using System;

namespace CompteBancaire
{
    public class CompteB
    {
        private int _solde;
        private string _titulaire;
        private string _devise;
        private static int _nbComptes;

        public CompteB(int unSolde, string unTitulaire, string uneDevise)
        {
            this.setSolde(unSolde);
            this.setTitulaire(unTitulaire);
            this.setDevise(uneDevise);

            _nbComptes += 1;
        }
        public CompteB(int unSolde)
        {
            this.setSolde(unSolde);
            _nbComptes += 1;
        }
        public CompteB()
        {
            this.setSolde(0);
            _nbComptes += 1;
        }

        public int getSolde()
        {
            return this._solde;
        }
        public string getTitulaire()
        {
            return this._titulaire;
        }
        public string getDevise()
        {
            return this._devise;
        }
        public int getNbComptes()
        {
            return _nbComptes;
        }

        private void setSolde(int unSolde)
        {
            this._solde = unSolde;
        }
        private void setTitulaire(string unTitulaire)
        {
            this._titulaire = unTitulaire;
        }
        private void setDevise(string uneDevise)
        {
            this._devise = uneDevise;
        }

        public void Crediter(int montant)
        {
            this._solde += montant;
        }
        public void Debiter(int montant)
        {
            this._solde -= montant;
        }

        public void ConsulterSolde()
        {
            Console.WriteLine("Votre solde est de : " + this._solde);
        }
    }
}