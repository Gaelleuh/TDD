
using System;
using Exo1_TDD.Bibliotheque;

namespace Exo2_TDD.TestsxUnit;

public sealed class FibTest
{

    [Fact]   //- Lors du déclenchement de la fonction GetFibSeries() avec un Range de 1 
             //- Le résultat n’est pas vide
    public void GetFibSeries_1_NotEmpty()
    {
        // Arrange
        Fib _fib = new Fib(1);

        // Act
        var result = _fib.GetFibSeries();

        // Assert
        Assert.NotEmpty(result);
    }
    [Fact]  //- Lors du déclenchement de la fonction GetFibSeries() avec un Range de 1
            //- Le résultat correspond à une liste qui contient {0}
    public void GetFibSeries_1_ContainsZero()
    {
        // Arrange
        Fib _fib = new Fib(1);

        // Act
        var result = _fib.GetFibSeries();

        // Assert
        Assert.Contains(0, result);
    }

    [Fact]  //- Lors du déclenchement de la fonction GetFibSeries() avec un Range de 6 
            //- Le résultat contient le chiffre 3
    public void GetFibSeries_6_ContainsThree()
    {
        // Arrange
        Fib _fib = new Fib(6);

        // Act
        var result = _fib.GetFibSeries();

        // Assert
        Assert.Contains(3, result);
    }

    [Fact]  //- Lors du déclenchement de la fonction GetFibSeries() avec un Range de 6 
            //- Le résultat contient 6 éléments 
    public void GetFibSeries_6_ContainsSixElements()
    {
        // Arrange
        Fib _fib = new Fib(6);

    // Act
    var result = _fib.GetFibSeries();

    // Assert
    Assert.Equal(6, result.Count);
    }

    [Fact]  //- Lors du déclenchement de la fonction GetFibSeries() avec un Range de 6 
            //- Le résultat n’a pas le chiffre 4 en son sein 
    public void GetFibSeries_6_DoesNotContainsFour()
    {
        // Arrange
        Fib _fib = new Fib(6);

        // Act
        var result = _fib.GetFibSeries();

        // Assert
        Assert.DoesNotContain(4, result);
    }

    [Fact]  //- Lors du déclenchement de la fonction GetFibSeries() avec un Range de 6 
            //- Le résultat correspond à une liste qui contient {0, 1, 1, 2, 3, 5}
    public void GetFibSeries_6_HasAListOfSixElements()
    {
        // Arrange
        Fib _fib = new Fib(6);
        var expectedList = new List<int>() { 0, 1, 1, 2, 3, 5 };

        // Act
        var result = _fib.GetFibSeries();

        // Assert
        Assert.Equal(expectedList, result);
    }

    [Fact]  //- Lors du déclenchement de la fonction GetFibSeries() avec un Range de 6 
            //- Le résultat est trié de façon ascendance

    public void GetFibSeries_6_ResultOrderByAsc()
    {
        // Arrange
        Fib _fib = new Fib(6);

        // Act
        var result = _fib.GetFibSeries();
        var expectedList = new List<int>() { 0, 1, 1, 2, 3, 5 };

        // Assert
        Assert.Equivalent(expectedList,(result.OrderBy(x=>x)));
    }

}


