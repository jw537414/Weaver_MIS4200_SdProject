Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "More about Jenna."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Jenna's Contact Information."

        Return View()
    End Function
End Class
