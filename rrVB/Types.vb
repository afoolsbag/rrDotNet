Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()>
Public Class Types

    ''' <summary>
    ''' <para> Primitive Types https://docs.microsoft.com/dotnet/visual-basic/reference/language-specification/types#primitive-types </para>
    ''' </summary>
    <TestMethod()>
    Public Sub PrimitiveTypes()
        Const valBool As Boolean = False

        Const valInt8 As SByte = 0
        Const valInt16 As Short = 0s
        Const valInt32 As Integer = 0i
        Const valInt64 As Long = 0L

        Const valUint8 As Byte = 0
        Const valUint16 As UShort = 0us
        Const valUint32 As UInteger = 0ui
        Const valUint64 As ULong = 0uL

        Const valChar16 As Char = ChrW(0)

        Const valFloat32 As Single = 0.0f
        Const valFloat64 As Double = 0.0r

        Const valDecimal128 As Decimal = 0.0d
    End Sub

End Class
