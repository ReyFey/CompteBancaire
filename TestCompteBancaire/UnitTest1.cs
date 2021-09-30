using CompteBancaire;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestCompteBancaire
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_soldeCreationCompteB()
        {
            CompteB CompteTest = new CompteB();
            Assert.AreEqual(0, CompteTest.getSolde());
        }
        
        [TestMethod]
        public void Test_soldeCreationCompteB500()
        {
            CompteB CompteTest = new CompteB(500);
            Assert.AreEqual(500, CompteTest.getSolde());
        }
        
        [TestMethod]
        public void Test_soldeApresDebit()
        {
            CompteB CompteTest = new CompteB(500);
            CompteTest.Debiter(100);
            Assert.AreEqual(400, CompteTest.getSolde());
        }
        
        [TestMethod]
        public void Test_SoldeApresCredit()
        {
            CompteB CompteTest = new CompteB(500);
            CompteTest.Crediter(100);
            Assert.AreEqual(600, CompteTest.getSolde());
        }
    }
}