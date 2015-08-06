Public Class ClassWithStaticField

    Public Const DecimalConstant As Decimal = 375D

    Private Shared ReadOnly DictionaryField As Dictionary(Of String, Single) = New Dictionary(Of String, Single) From {
        {"String1", 1.0F},
        {"String2", 2.0F},
        {"String3", 3.0F}
    }

    Public Shared ReadOnly Property Dictionary As Dictionary(Of String, Single) 
        Get
            Return DictionaryField
        End Get
    End Property

End Class
