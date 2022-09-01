@Imports Microsoft.AspNet.Identity
<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - Selati Marathon</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")

</head>
<body>
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
                @Using Html.BeginForm("LogOff", "Account", FormMethod.Post, New With {.id = "logoutForm", .class = "navbar-right"})
                    @Html.AntiForgeryToken()
                    @<ul class="menu" >
                           
                        <li> @Html.ActionLink("Welcome " + User.Identity.GetUserName(), "Index", "Home", New With {.area = ""}, New With {.style = "color:white;"})
                            </li>
                                <li> <a href="#"> Activities</a>
                                     <ul>
                                         <li>
                                             @Html.ActionLink("Upadate your password " + "!", "ChangePassword", "Manage", New With {.id = 1}, New With {.style = "color:white;"})
                                         </li>
                                         
                                         <li>@Html.ActionLink(" View Events", "Index", "Eventts")</li>
                                         <li>@Html.ActionLink(" View Participants", "Index", "Users")</li>
                                     </ul>

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
        <footer>
            <p>&copy; @DateTime.Now.Year Copyright</p>
        </footer>
    </div>

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @RenderSection("scripts", required:=False)
</body>
</html>
