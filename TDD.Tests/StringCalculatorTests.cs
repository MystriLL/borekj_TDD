using System;
using NUnit.Framework;
using TDD;

namespace TDD_Tests;

[TestFixture]
public class StringCalculatorTests
{
    private StringCalculator _calculator;
    
    [SetUp]
    public void Init()
    {
        _calculator = new StringCalculator();
    }
    
    [Test]
    public void CalculatorShouldReturnZero_WhenEmptyStringWasPassed()
    {
        
        const string  input = "";

        var result = _calculator.Calculate(input);

        Assert.AreEqual(0, result);
    }

    [Test]
    public void CalculatorShouldReturnValue_WhenNumberWasPassedInString()
    {
        const string input = "5";

        var result = _calculator.Calculate(input);
        
        Assert.AreEqual(int.Parse(input), result);
    }
    
    [Test]
    public void CalculatorShouldReturnSum_WhenTwoNumbersCommaDelimitedWerePassedInString()
    {
        const string firtNumber = "5";
        const string secondNumber = "3";
        var input = String.Concat(firtNumber, ",", secondNumber);

        var result = _calculator.Calculate(input);
        
        Assert.AreEqual(8, result);
    }
    
    [Test]
    public void CalculatorShouldReturnSum_WhenTwoNumbersNewLineDelimitedWerePassedInString()
    {
        const string firtNumber = "5";
        const string secondNumber = "3";
        var input = String.Concat(firtNumber, "\n", secondNumber);

        var result = _calculator.Calculate(input);
        
        Assert.AreEqual(8, result);
    }
    
    [Test]
    public void CalculatorShouldReturnSum_WhenTreesNumbersDelimitedWerePassedInString()
    {
        const string firtNumber = "5";
        const string secondNumber = "3";
        const string thirdNumber = "12";
        
        var input = String.Concat(firtNumber, "\n", secondNumber, ",", thirdNumber);

        var result = _calculator.Calculate(input);
        
        Assert.AreEqual(20, result);
    }
    
    [Test]
    public void CalculatorShouldThrow_WhenMinusWasPassedInString()
    {
        const string firtNumber = "-5";
        const string secondNumber = "3";
        const string thirdNumber = "12";
        
        var input = String.Concat(firtNumber, "\n", secondNumber, ",", thirdNumber);
        Assert.Throws<ArgumentException>(() => _calculator.Calculate(input));
    }
    
    [Test]
    public void CalculatorShouldOmitNumberBiggerThan1000()
    {
        const string firtNumber = "5";
        const string secondNumber = "3000";
        const string thirdNumber = "12";
        
        var input = String.Concat(firtNumber, "\n", secondNumber, ",", thirdNumber);
        var result = _calculator.Calculate(input);
        Assert.AreEqual(17, result);
    }
    
}