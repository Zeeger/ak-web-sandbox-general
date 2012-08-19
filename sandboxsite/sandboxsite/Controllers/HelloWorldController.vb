Namespace sandboxsite
    Public Class HelloWorldController
        Inherits System.Web.Mvc.Controller

        '
        ' GET: /HelloWorld

        Function Index() As ActionResult
            Return View()
        End Function

        Public Function Index2() As String
            Return "This is my <b>default</b> action."
        End Function

        Public Function Welcome(name As String, Optional numtimes As Integer = 1) As ActionResult
            'Return "Hello " & name & " this is the " & numtimes.ToString() & " you've been here"

            ViewBag.Message = "Hello " & name
            ViewBag.NumTimes = numtimes

            Return View()
        End Function

    End Class
End Namespace