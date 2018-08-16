namespace rrFS

open System
open Microsoft.VisualStudio.TestTools.UnitTesting

[<TestClass>]
type UnitTests() =

    [<TestMethod>]
    member this.UnitTest() =
        Assert.AreEqual(3, 1 + 2)
