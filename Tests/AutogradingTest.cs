namespace Tests;
using knightmoves;
using Xunit;

public class AutogradingTest
{
    [Fact]
    public void Should_Create_A_Method_Named_OldEnough_That_Takes_An_Age_And_Returs_The_String_Old_Enough_If_The_Age_Is_Over_17(){
        var verifier = new Verifier();
        Assert.Equal("old enough", verifier.OldEnough(18));
    }

    [Fact]
    public void Should_Return_An_Empty_String_If_An_Age_Of_17_is_Passed_To_OldEnough(){
        var verifier = new Verifier();
        Assert.Equal("", verifier.OldEnough(17));
    }

    [Fact]
    public void Should_Create_A_Method_Named_UnderAge_That_Takes_An_Age_And_Returs_The_String_Under_Age_If_The_Age_Is_Under_18(){
        var verifier = new Verifier();
        Assert.Equal("under age", verifier.UnderAge(17));
    }

    [Fact]
    public void Should_Return_An_Empty_String_If_An_Age_Of_18_is_Passed_To_UnderAge(){
        var verifier = new Verifier();
        Assert.Equal("", verifier.UnderAge(18));
    }

    [Fact]
    public void Should_Create_A_Method_Named_LegalSpeed_That_Takes_A_Speed_And_Returs_The_String_Legal_Speed_If_The_Speed_Is_Under_50(){
        var verifier = new Verifier();
        Assert.Equal("legal speed", verifier.LegalSpeed(49));
    }

    [Fact]
    public void Should_Return_Legal_Speed_If_A_Speed_Of_50_is_Passed_To_LegalSpeed(){
        var verifier = new Verifier();
        Assert.Equal("legal speed", verifier.LegalSpeed(50));
    }

    [Fact]
    public void Should_Return_An_Empty_String_If_An_Speed_Of_51_is_Passed_To_LegalSpeed(){
        var verifier = new Verifier();
        Assert.Equal("", verifier.LegalSpeed(51));
    }

    [Fact]
    public void Should_Create_A_Method_Named_IsGoldenYears_That_Takes_An_Age_And_Returs_The_String_Golden_Years_If_The_Age_Is_Over_65(){
        var verifier = new Verifier();
        Assert.Equal("golden years", verifier.IsGoldenYears(66));
    }

    [Fact]
    public void Should_Return_The_String_Golden_Years_If_An_Age_Of_65_is_Passed_To_IsGoldenYears(){
        var verifier = new Verifier();
        Assert.Equal("golden years", verifier.IsGoldenYears(65));
    }

    [Fact]
    public void Should_Return_An_Empty_String_If_An_Age_Of_64_is_Passed_To_IsGoldenYears(){
        var verifier = new Verifier();
        Assert.Equal("", verifier.IsGoldenYears(64));
    }
}