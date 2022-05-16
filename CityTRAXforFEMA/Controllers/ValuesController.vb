Imports System.Net
Imports System.Web.Http
Imports System.Net.Http

Public Class ValuesController
    Inherits ApiController

    ' GET api/values
    Public Function [Get]() As HttpResponseMessage
        Dim retVal = New With {Key .key1 = "value1", Key .key2 = "value2"}
        Return Request.CreateResponse(HttpStatusCode.OK, retVal)
    End Function

    ' GET api/values/5
    Public Function GetValue(ByVal id As Integer) As String
        Return "value"
    End Function

    ' POST api/values
    Public Sub PostValue(<FromBody()> ByVal value As String)

    End Sub

    ' PUT api/values/5
    Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

    End Sub

    ' DELETE api/values/5
    Public Sub DeleteValue(ByVal id As Integer)

    End Sub
End Class
