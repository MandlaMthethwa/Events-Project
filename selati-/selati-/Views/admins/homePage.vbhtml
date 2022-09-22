@ModelType selati_.user
@Code
    ViewData("Title") = "Admin Home"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2 class="form-header">Welcome Admin.</h2>
<h3 class="form-header" style="color: #940f1a">Follow the order!</h3>
<div>
    <p><a class="btn button-view" @Html.ActionLink("1. Manage Participants", "Index", "Admins") </a></p> </br>
    <p><a class="btn button-view" @Html.ActionLink("2. Add Event", "adminIndex", "Eventts") </a></p> </br>
    <p><a class="btn button-view" @Html.ActionLink("3. Add Organizer", "Index", "Companies") </a></p> </br>
    <p><a class="btn button-view" @Html.ActionLink("4. Add Divions", "adminIndex", "Divisions") </a></p> </br>

    <p><a class="btn button-view" @Html.ActionLink("5. Manage Results", "adminIndex", "Results") </a></p> </br> </br>

</div>



