using NUnit.Framework;

namespace Exercise6.Tests
{
    public class ArrayTests
    {
        private int[] _array1 = new int[10];
        private int[] _array2 = new int[10];

        [Test]
        public void FillArrayWithRandomNumbers_EmptyArray1_Array1ShouldBeFilled()
        {
            // Act
            _array1 = Program.FillArrayWithRandomNumbers(_array1);

            //Assert
            foreach (var value in _array1)
            {
                Assert.AreNotEqual(0, value);
            }
        }

        [Test]
        public void CopyArrayValues_FilledArray1_ArraysShouldBeEqual()
        {
            //Arrange
            _array1 = Program.FillArrayWithRandomNumbers(_array1);

            // Act
            _array2 = Program.CopyArrayValues(_array1, _array2);

            //Assert
            CollectionAssert.AreEqual(_array2, _array1);
        }

        [Test]
        public void ChangeLastValue_FilledArray1_LastArrayValueShouldBeChanged()
        {
            //Arrange
            _array1 = Program.FillArrayWithRandomNumbers(_array1);

            // Act
            Program.ChangeLastValue(_array1);
            var lastValue = -7;

            //Assert
            Assert.AreEqual(lastValue, _array1[_array1.Length-1]);
        }

        [Test]
        public void CompareArrays_ModifiedFirstArray_ArraysShouldNotBeEqual()
        {
            //Arrange
            _array1 = Program.FillArrayWithRandomNumbers(_array1);

            // Act
            _array2 = Program.CopyArrayValues(_array1, _array2);
            Program.ChangeLastValue(_array1);

            //Assert
            CollectionAssert.AreNotEqual(_array2, _array1);
        }
    }
}