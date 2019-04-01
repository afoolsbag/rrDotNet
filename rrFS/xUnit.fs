namespace rrFS

open Xunit

/// <summary>
/// xUnit https://xunit.net/
/// </summary>
module XUnit = 
    
    [<Fact>]
    let Fact = 
        Assert.Equal(4, 2 + 2)
    
    [<Theory>]
    [<InlineData(3)>]
    [<InlineData(5)>]
    let Theory value =
        Assert.True(value % 2 = 1)
