namespace rrFS

open Xunit

module Functions=

    /// <summary>
    /// 最近似 C 语言族的版本。
    /// </summary>
    let add1 (x : int) (y : int) : int =
        x + y

    /// <summary>
    /// 参数类型和返回值类型可以自行推断。
    /// </summary>
    let add2 (x) (y) =
        x + y

    /// <summary>
    /// 推断类型时，参数括号是可选的。
    /// </summary>
    let add3 x y =
        x + y

    /// <summary>
    /// 函数体换行是可选的。
    /// </summary>
    let add4 x y = x + y

    [<Fact>]
    let test =
        Assert.Equal(3, add1 1 2)
        Assert.Equal(5, add2 2 3)
        Assert.Equal(7, add3 3 4)
        Assert.Equal(9, add4 4 5)
