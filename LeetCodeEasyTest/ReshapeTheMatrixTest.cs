namespace LeetCodeEasyTest;

using LeetCodeEasy;

public class ReshapeTheMatrixTest
{
        [Test]
        public void ReshapeTheMatrix()
        {
                var input = new int[][] { new int[] { 1, 2 }, new int[] { 3, 4 } };
                int r = 1, c = 4;
                var expected = new int[][] { new int[] { 1, 2, 3, 4 } };

                var result = ReshapeTheMatrixTask.MatrixReshape(input, r, c);

                Assert.AreEqual(expected, result);
        }
}