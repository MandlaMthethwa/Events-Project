@ModelType selati_.user
@Code
    ViewData("Title") = "Admin Home"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2 class="form-header">Welcome Admin.</h2>
<div>
    <p><a class="btn btn-default" @Html.ActionLink("Manage Participants", "Index", "Admins") </a></p> </br>
    <p><a class="btn btn-default" @Html.ActionLink("Enter Events", "adminIndex", "Eventts") </a></p> </br>
    <p><a class="btn btn-default" @Html.ActionLink("Add Divions", "adminIndex", "Divisions") </a></p> </br>
    <p><a class="btn btn-default" @Html.ActionLink("Manage Results", "adminIndex", "Results") </a></p> </br> </br>
    <p><a class="btn btn-default" @Html.ActionLink("Add Organizer", "Index", "Companies") </a></p> </br>

</div>



