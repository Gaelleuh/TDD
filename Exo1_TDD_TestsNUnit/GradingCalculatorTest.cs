using Exo1_TDD.Bibliotheque;
namespace Exo1_TDD_TestsNUnit;

[TestFixture]
public sealed class GradingCalculatorTest
{
    private GradingCalculator? _calculator;

    [SetUp]
    public void SetUp()
    {
        _calculator = new GradingCalculator();
    }

    [TearDown]
    public void TearDown()
    {
        _calculator = null;
    }

    [Test]

    [TestCase(95, 90, 'A')]
    [TestCase(85, 90, 'B')]
    [TestCase(65, 90, 'C')]
    [TestCase(95, 65, 'B')]
    [TestCase(95, 55, 'F')]
    [TestCase(65, 55, 'F')]
    [TestCase(50, 90, 'F')]

    public void GradingCalculator_FromA_ToF(int score, int attendancePercentage, char grade)
    {
        _calculator.Score = score;
        _calculator.AttendancePercentage = attendancePercentage;

        var result = _calculator.GetGrade();

        Assert.That(result, Is.EqualTo(grade));
    }

    //[Test]
    //public void WhenGradingCalculator_95_90_Then_A()
    //{
    //    // Arrange
    //    _calculator.Score = 95;
    //    _calculator.AttendancePercentage = 90;

    //    // Act
    //    var result = _calculator.GetGrade();

    //    // Assert
    //    Assert.That(result, Is.EqualTo('A'));
    //}

    //[Test]
    //public void WhenGradingCalculator_85_90_Then_B()
    //{
    //    _calculator.Score = 85;
    //    _calculator.AttendancePercentage = 90;

    //    var result = _calculator.GetGrade();
    //    Assert.That(result, Is.EqualTo('B'));
    //}

    //[Test]
    //public void WhenGradingCalculator_65_90_Then_C()
    //{
    //    _calculator.Score = 65;
    //    _calculator.AttendancePercentage = 90;

    //    var result = _calculator.GetGrade();
    //    Assert.That(result, Is.EqualTo('C'));
    //}

    //[Test]
    //public void WhenGradingCalculator_95_65_Then_B()
    //{
    //    _calculator.Score = 95;
    //    _calculator.AttendancePercentage = 65;

    //    var result = _calculator.GetGrade();
    //    Assert.That(result, Is.EqualTo('B'));
    //}

    //[Test]
    //public void WhenGradingCalculator_95_55_Then_B()
    //{
    //    _calculator.Score = 95;
    //    _calculator.AttendancePercentage = 55;

    //    var result = _calculator.GetGrade();
    //    Assert.That(result, Is.EqualTo('F'));
    //}

    //[Test]
    //public void WhenGradingCalculator_65_55_Then_F()
    //{
    //    _calculator.Score = 65;
    //    _calculator.AttendancePercentage = 55;

    //    var result = _calculator.GetGrade();
    //    Assert.That(result, Is.EqualTo('F'));
    //}

    //[Test]
    //public void WhenGradingCalculator_50_90_Then_F()
    //{
    //    _calculator.Score = 50;
    //    _calculator.AttendancePercentage = 90;

    //    var result = _calculator.GetGrade();
    //    Assert.That(result, Is.EqualTo('F'));
    //}

}
