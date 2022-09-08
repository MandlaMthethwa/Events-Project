@Imports Microsoft.AspNet.Identity
<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title  Selati Marathon</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")

</head>
<body>
    @If Request.IsAuthenticated Then

        @<div class="user" style="color:black">
    <img src="../images/pp.jpg" />
    @(User.Identity.GetUserName())
</div>
    End If
    <div>

        <nav>

            <label class="toggle" for=" drop"> Menu </label>
            <input type="checkbox" id="drop" />

            <ul class="menu">
                <li>@Html.ActionLink("Home", "Index", "Home")</li>
                <li>@Html.ActionLink(" View Results", "Index", "Results")</li>
                <li><a href=" @Url.Action("homePage", "Admins")">Admin</a></li>
            </ul>


            @If Request.IsAuthenticated Then
                @Using Html.BeginForm("LogOff", "Account", FormMethod.Post, New With {.id = "logoutForm", .Class = "menu navbar-right"})
                    @Html.AntiForgeryToken()
                    @<ul class="menu">





                        <li>@Html.ActionLink(" View Events", "Index", "Eventts")</li>
                        <li>@Html.ActionLink(" View Your Participants", "Index", "Users")</li>

                        <li>
                            <a href="" @Html.ActionLink("Update your password ", "ChangePassword", "Manage", New With {.id = 1}, New With {.Class = "navbar-left"})
                        </li>
                        <li><a href="javascript:document.getElementById('logoutForm').submit()" , style="color:white;background-color:black">Log off</a></li>
                    </ul>

                End Using
            Else
                @<ul class="menu navbar-right">
                    <li>@Html.ActionLink("Register", "Register", "Account", routeValues:=Nothing, htmlAttributes:=New With {.id = "registerLink"})</li>
                    <li>@Html.ActionLink("Log in", "Login", "Account", routeValues:=Nothing, htmlAttributes:=New With {.id = "loginLink"})</li>
                </ul>
            End If


        </nav>
    </div>
    <div class="container body-content">
        @RenderBody()
        <hr />

    </div>

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @RenderSection("scripts", required:=False)
</body>
</html>
