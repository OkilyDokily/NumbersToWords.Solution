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

        [TestMethod]
        public void ConvertArrayToWords_ConvertedArrayWithTeens_True(){
            //arrange
            int[] aa = new int[] {1,1,8};
            string er = "eight hundred eleven";
            //act
            NumToWord ntw = new NumToWord();
            string ar = ntw.ConvertArrayToWords(aa);
            Assert.AreEqual(er,ar);
        }
        [TestMethod]
        public void ConvertListOfArraysToString_CreateFinalOutput_True(){
            //arrange
            List<int[]> al = new List<int[]>{new int[]{3,7,8},new int[]{4,6,4},new int[]{6}};
            string er = "six million four hundred sixty four thousand eight hundred seventy three";
            //act
            NumToWord ntw = new NumToWord();
            string ar = ntw.ConvertListOfArraysToString(al);

            Assert.AreEqual(er,ar);
        }
         [TestMethod]
         public void Convert_TestIntegrationMethod_True(){
            //arrange
            int num = 53423524; 
            string er = "fifty three million four hundred twenty three thousand five hundred twenty four";
            //act
            NumToWord ntw = new NumToWord();
            string ar = ntw.Convert(num);

            Assert.AreEqual(er,ar);
        }
         [TestMethod]
         public void Convert_TestIntegrationMethod_True2(){
            //arrange
            int num = 50423524; 
            string er = "fifty million four hundred twenty three thousand five hundred twenty four";
            //act
            NumToWord ntw = new NumToWord();
            string ar = ntw.Convert(num);

            Assert.AreEqual(er,ar);
        }

         [TestMethod]
         public void Convert_TestIntegrationMethod_True3(){
            //arrange
            int num = 554; 
            string er = "five hundred fifty four";
            //act
            NumToWord ntw = new NumToWord();
            string ar = ntw.Convert(num);

            Assert.AreEqual(er,ar);
        }

        [TestMethod]
         public void Convert_TestIntegrationMethod_True4(){
            //arrange
            int num = 504513321; 
            string er = "five hundred four million five hundred thirteen thousand three hundred twenty one";
            //act
            NumToWord ntw = new NumToWord();
            string ar = ntw.Convert(num);

            Assert.AreEqual(er,ar);
        }                     
    }

}