Public Class Barcode
    Property Index As Integer = 0
    Property SectionName As String = Nothing
    Property BarcodeValue As String = Nothing
    Property OrigPageNo As String = Nothing

    Public Sub New(Index As Integer, SectionName As String, BarcodeValue As String)
        Me.Index = Index
        Me.SectionName = SectionName
        Me.BarcodeValue = BarcodeValue
    End Sub

    'Overload constructor to allow the original page number in the logs
    Public Sub New(Index As Integer, SectionName As String, BarcodeValue As String, OrigPageNo As String)
        Me.Index = Index
        Me.SectionName = SectionName
        Me.BarcodeValue = BarcodeValue
        Me.OrigPageNo = OrigPageNo
    End Sub
End Class
