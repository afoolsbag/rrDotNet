Imports Xunit

Public Class Types

    ''' <summary>
    ''' <para> Primitive Types https://docs.microsoft.com/dotnet/visual-basic/reference/language-specification/types#primitive-types </para>
    ''' </summary>
    <Fact>
    Public Sub PrimitiveTypes()
        Const valBool As Boolean = False

        Const valInt8 As SByte = 0
        Const valInt16 As Short = 0S
        Const valInt32 As Integer = 0I
        Const valInt64 As Long = 0L

        Const valUint8 As Byte = 0
        Const valUint16 As UShort = 0US
        Const valUint32 As UInteger = 0UI
        Const valUint64 As ULong = 0UL

        Const valChar16 As Char = ChrW(0)

        Const valFloat32 As Single = 0.0F
        Const valFloat64 As Double = 0.0R

        Const valDecimal128 As Decimal = 0.0D
    End Sub

End Class
