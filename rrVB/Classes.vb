Class Clazz

    ''' <summary>
    ''' <para> 构造函数 https://docs.microsoft.com/dotnet/visual-basic/reference/language-specification/type-members#constructors </para>
    ''' </summary>
    Public Sub New ()
        Console.WriteLine("Constructor")
    End Sub

    ''' <summary>
    ''' <para> 析构函数 </para>
    ''' </summary>
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
        Console.WriteLine("Destructor")
    End Sub

End Class

<TestClass()>
Public Class Classes

    <TestMethod()>
    Public Sub TestMethod()
        Dim clz As Clazz = new Clazz()
    End Sub

End Class

