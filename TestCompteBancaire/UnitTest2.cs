using CompteBancaire;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestCompteBancaire
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void Test_GetNbCompte()
        {
            CompteB Compte1 = new CompteB();
            CompteB Compte2 = new CompteB();
            CompteB Compte3 = new CompteB();
            CompteE Compte4 = new CompteE();
            Assert.AreEqual(4, Compte1.getNbComptes());
        }
    }
}