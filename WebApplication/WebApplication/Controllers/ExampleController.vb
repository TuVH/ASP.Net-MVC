Imports System.Web.Mvc

Namespace Controllers
    Public Class ExampleController
        Inherits Controller

        ' GET: Example
        Function Index() As ActionResult
            Return View()
        End Function

        Function Link() As ActionResult
            Return View()
        End Function

    End Class
End Namespace