@Imports Microsoft.AspNet.Identity

@If Request.IsAuthenticated
    @Using Html.BeginForm("LogOff", "Account", FormMethod.Post, New With { .id = "logoutForm", .class = "navbar-right" })
        @Html.AntiForgeryToken()
        @<ul>

    <li> @Html.ActionLink("Welcome " + User.Identity.GetUserName(), "Index", "Home", New With {.area = ""}, New With {.style = "color:white;"})</li>


    <li>  @Html.ActionLink(" Add participant", "Create", "Users", New With {.id = 1}, New With {.style = "color:white;"})</li>
    <li>
        @Html.ActionLink("Upadate your password " + "!", "ChangePassword", "Manage", New With {.id = 1}, New With {.style = "color:white;"})
    </li>

    <li><a href="javascript:document.getElementById('logoutForm').submit()" , style="color:white;background-color:black">Log off</a></li>
</ul>

    End Using
Else
    @<ul>
        <li>@Html.ActionLink("Register", "Register", "Account", routeValues:=Nothing, htmlAttributes:=New With {.id = "registerLink"})</li>
        <li>@Html.ActionLink("Log in", "Login", "Account", routeValues:=Nothing, htmlAttributes:=New With {.id = "loginLink"})</li>
    </ul>
End If

