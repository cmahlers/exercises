using Exercises;

namespace ExercisesTestProject
{
    [TestClass]
    public class Test
    {

        [TestMethod]
        [DataRow(new[] { 0 }, 0)]
        [DataRow(new[] { 0, 1, 2 }, 2)]
        [DataRow(new[] { 6, 0, 8, 2, 1, 5 }, 4)]
        [DataRow(new[] { 9, 8, 1, 0, 1, 9, 4, 0, 4, 1 }, 7 )]
        public void MaxWidthRamp(int[] input, int expectedResult)
        {
            Assert.AreEqual(expectedResult, Exercises.Exercises.MaxWidthRamp(input));
        }
    }
}