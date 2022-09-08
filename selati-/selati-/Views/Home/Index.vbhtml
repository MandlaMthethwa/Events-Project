@ModelType selati_.user
@Imports Microsoft.AspNet.Identity

@Code
    ViewData("Title") = "Home"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code
@If Request.IsAuthenticated Then
@<div class="form-header">
    <h2>
    @("Welcome " + User.Identity.GetUserName())
</h2>
</div>
End If

<div style="position:center">

    <img src="../images/head.png" alt="">
    <h1 class="header">SELATI MARATHON</h1>

    <img src="../images/head2.jpg" alt="">
</div>

   
