Imports Xunit

''' <summary>
''' xUnit https://xunit.net/
''' </summary>
Public Class XUnit

    <Fact>
    Public Sub Fact()
        Assert.Equal(4, 2 + 2)
    End Sub

    <Theory>
    <InlineData(3)>
    <InlineData(5)>
    Public Sub Theory(value)
        Assert.True(value Mod 2 = 1)
    End Sub

End Class
