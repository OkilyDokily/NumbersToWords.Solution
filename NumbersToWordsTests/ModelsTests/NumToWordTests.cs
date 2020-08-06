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
            List<int[]> ar = ntw.MakeListOfThreeElementArrays(aa);

            for(int i = 0; i < er.Count; i++){
                CollectionAssert.AreEqual(er[i],ar[i]);
            }    
        }
        [TestMethod]
        public void ConvertArrayToWords_ConvertedArray_True(){
            //arrange
            int[] aa = new int[] {3,7,8};
            string er = "eight hundred seventy three";
            //act
            NumToWord ntw = new NumToWord();
            string ar = ntw.ConvertArrayToWords(aa);
            Assert.AreEqual(er,ar);
        }   
    }

}