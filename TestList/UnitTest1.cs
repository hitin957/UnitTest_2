namespace TestList;

[TestClass]
public class UnitTest1//��������� 2 ��������� �� �������;
{
    [TestMethod]
    public void Test_CollectionsInOrder()
    {
        // Arrange
        List<int> expected = new List<int> { 1, 2, 3 };
        List<int> actual = new List<int> { 1, 2, 3 };

        // Act
        // No action needed

        // Assert
        CollectionAssert.AreEqual(expected, actual);
    }
}
[TestClass]
public class UnitTest2//��������� 2 ��������� �� ������� �������� �� �������;
{
    [TestMethod]
    public void Test_CollectionsNotInOrder()
    {
        // Arrange
        List<int> expected = new List<int> { 1, 2, 3 };
        List<int> actual = new List<int> { 3, 2, 1 };

        // Act
        // No action needed

        // Assert
        CollectionAssert.AreEquivalent(expected, actual);
    }
}
[TestClass]
public class UnitTest3//������������ ���������� �������� � �������������� ������.
{
    [TestMethod]
    public void Test_CalculatePercentage()
    {
        // Arrange
        double expected = 75.0;
        double actual = 74.7;
        double delta = 0.1;

        // Act
        // No action needed

        // Assert
        Assert.AreEqual(expected, actual, delta);
    }
}