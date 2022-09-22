@Imports Microsoft.AspNet.Identity
<!DOCTYPE html >
<html lang="en">
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - Pronto </title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")
   
</head>
<body>

    <div class="row">

        <ul style="background-image: linear-gradient(rgba(0, 0, 0, 0.7), rgba(0, 0, 0, 0.7)),Url(../images/logoback.jpg);">

            <li>
                @If Request.IsAuthenticated Then
                    @<div class="user" style="color:white">

                        <img src="../images/pp.jpg" style="background-color: none; border-radius: 45%;" />

                        @(User.Identity.GetUserName())
                    </div>
                End If
            </li>
            <li><h2 style="color: lightblue"> "Motivation is what gets you started. Habit is what keeps you going."</h2></li>
        </ul>


        <nav>



            <ul class="main-nav js--main-nav">
                <li>@Html.ActionLink("Home", "Index", "Home")</li>

                @If User.Identity.GetUserName() = "admin@pronto.ac.za" Then
                    @<li><a href=" @Url.Action("homePage", "Admins")">Manage Here</a></li>
                End If
                @If Request.IsAuthenticated And User.Identity.GetUserName() <> "admin@pronto.ac.za" Then


                    @<li>@Html.ActionLink("Events", "Index", "Eventts")</li>
                    @<li>
                        <a href="#">Results</a>
                        <ul>
                            <li>@Html.ActionLink("My Results", "Index", "Results") </li>
                            <li>@Html.ActionLink("All Results", "allResults", "Results") </li>
                        </ul>
                    </li>
                    @<li>@Html.ActionLink("Your Participants", "Index", "Users")</li>
                End If
            </ul>


            @If Request.IsAuthenticated Then
                @Using Html.BeginForm("LogOff", "Account", FormMethod.Post, New With {.id = "logoutForm", .Class = "menu navbar-right"})
                    @Html.AntiForgeryToken()
                    @<ul class="main-nav">
                        <li>
                            @Html.ActionLink("Update your password ", "ChangePassword", "Manage")
                        </li>
                        <li><a href="javascript:document.getElementById('logoutForm').submit()" , style="color:white;background-color:black">Log off</a></li>
                    </ul>

                End Using
            Else
                @<ul class="menu navbar-right">
                    <li>@Html.ActionLink("Register", "Register", "Account", routeValues:=Nothing, htmlAttributes:=New With {.id = "registerLink", .class = "btn button-add"})</li>
                    <li>@Html.ActionLink("Log in", "Login", "Account", routeValues:=Nothing, htmlAttributes:=New With {.id = "loginLink", .class = "btn button-add"})</li>
                </ul>
            End If

        </nav>
        <a class="mobile-nav-icon js--nav-icon"><i class="ion-navicon-round"></i></a>
    </div>


    <div class="container body-content">
        @RenderBody()
        <hr />

    </div>

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @RenderSection("scripts", required:=False)

    <footer>
        <div class="row">
            <div class="col span-1-of-2">
                <ul class="footer-nav">
                    <li><a href="@Url.Action("About", "Home")">About us</a></li>
                    <li><a href="@Url.Action("Contact", "Home")">Contacts</a></li>

                    <li>@Html.ActionLink("Events", "Index", "Eventts")</li>

                </ul>
            </div>
            
        </div>
        <div class="row">
            <p>&copy; @DateTime.Now.Year Copyright All rights Reseverd</p>            
        </div>
    </footer>
</body>
</html>
