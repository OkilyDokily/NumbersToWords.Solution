using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using NumbersToWords.Models;
namespace NumbersToWordsTests.ModelsTests
{
    [TestClass]
    public class NumToWordTests
    {
        [TestMethod]
        public void makeListOfThreeElementArray_ConvertsList_True(){
            //arrange
            List<int> aa = new List<int>{3,7,8,4,6,4,6};
            List<int[]> er = new List<int[]>{new int[]{3,7,8},new int[]{4,6,4},new int[]{6}};
            //act
            NumToWord ntw = new NumToWord();
            List<int[]> ar = ntw.makeListOfThreeElementArrays(aa);

            for(int i = 0; i < er.Count; i++){
                CollectionAssert.AreEqual(er[i],ar[i]);
            }    
        }    
    }

}