namespace GithubActionsLab;

[TestClass]
public class Addition
{
	[TestMethod]
	public void Add_Valid_Patino()
	{
		Assert.AreEqual(3, Program.Add("1", "2"));
		Assert.AreEqual(5, Program.Add("3", "2"));
		Assert.AreEqual(12, Program.Add("5", "7"));
	}

	[TestMethod]
	public void Add_Invalid_Patino()
	{
		Assert.ThrowsException<FormatException>(() => Program.Add("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "a"));
	}

	[TestMethod]
	public void Add_Null_Patino()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add("1", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, "1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, null));
	}

    [TestMethod]
    public void Subtract_Valid_Patino()
    {
        Assert.AreEqual(5, Program.Subtract("3", "2"));
        Assert.AreEqual(-1, Program.Subtract("2", "3"));
        Assert.AreEqual(0, Program.Subtract("5", "5"));
    }

    [TestMethod]
    public void Subtract_Invalid_Patino()
    {
        Assert.ThrowsException<FormatException>(() => Program.Subtract("1", "a"));
        Assert.ThrowsException<FormatException>(() => Program.Subtract("a", "1"));
    }

    [TestMethod]
    public void Subtract_Null_Patino()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract("1", null));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract(null, "1"));
    }
}

[TestClass]
public class Multiplication
{
    [TestMethod]
    public void Multiply_Valid_Patino()
    {
        Assert.AreEqual(6, Program.Multiply("2", "3"));
        Assert.AreEqual(0, Program.Multiply("5", "0"));
        Assert.AreEqual(-4, Program.Multiply("2", "-2"));
    }

    [TestMethod]
    public void Multiply_Invalid_Patino()
    {
        Assert.ThrowsException<FormatException>(() => Program.Multiply("x", "2"));
        Assert.ThrowsException<FormatException>(() => Program.Multiply("2", "x"));

    }

    [TestMethod]
    public void Multiply_Null_Patino()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply(null, "2"));
    }
}

[TestClass]
public class Division
{
    [TestMethod]
    public void Divide_Valid_Patino()
    {
        Assert.AreEqual(2, Program.Divide("6", "3"));
        Assert.AreEqual(2.5, Program.Divide("5", "2"));
    }

    [TestMethod]
    public void Divide_Invalid_Patino()
    {
        Assert.ThrowsException<FormatException>(() => Program.Divide("1", "x"));
        Assert.ThrowsException<FormatException>(() => Program.Divide("x", "1"));
    }

    [TestMethod]
    public void Divide_Null_Patino()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Divide(null, "2"));
	Assert.ThrowsException<ArgumentNullException>(() => Program.Divide("2", null));
    }
}

[TestClass]
public class Power
{
    [TestMethod]
    public void Power_Valid_Patino()
    {
        Assert.AreEqual(8, Program.Power("2", "3"));
        Assert.AreEqual(1, Program.Power("5", "0"));
    }

    [TestMethod]
    public void Power_Invalid_Patino()
    {
        Assert.ThrowsException<FormatException>(() => Program.Power("2", "x"));
        Assert.ThrowsException<FormatException>(() => Program.Power("x", "2"));

    }

    [TestMethod]
    public void Power_Null_Patino()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Power(null, "2"));
	Assert.ThrowsException<ArgumentNullException>(() => Program.Power("2", null));
    }
}
