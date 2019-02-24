using NUnit.Framework;
using Problems;

 namespace tESTS
{
    
    public class UnitTest1
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //arrange
        Program alex = new Program();

        string input = alex.Prefix("hello");
        //assert
        Assert.AreEqual("5,1:hello",input);
        }

         [Test]
        public void Test2()
        {
            //arrange
        Program dominique = new Program();

        string input2 = dominique.Prefix("");
        //assert
        Assert.AreEqual("0,0:",input2);
        }
        
          [Test]
        public void Tester1()
        {
            //arrange
        Program homie = new Program();

        string input2 = homie.Prefix("what ... did you say??");
        //assert
        Assert.AreEqual("22,5:",input2);
        }


        
    }
}