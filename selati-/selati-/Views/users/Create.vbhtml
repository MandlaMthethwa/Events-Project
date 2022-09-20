
@ModelType selati_.user
@Imports System.Data.Entity

@Code
    ViewData("Title") = "Create"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

@Imports Microsoft.AspNet.Identity

<h2 Class="form-header">Enter participant details below</h2>

@Using (Html.BeginForm())
@Html.AntiForgeryToken()

@<div class="contact-form">

    <hr />
    @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
    <div class="row">
        <div class="col span-1-of-3">
            <label for="firstName">First Name</label>
        </div>
        <div class="col span-2-of-3">
            <input type="text" name="firstName" model="firstName" id="firstName" placeholder="Enter First Name(s)" required>
        </div>
    </div>

    <div class="row">
        <div class="col span-1-of-3">
            <label for="lastName">Last Name</label>
        </div>
        <div class="col span-2-of-3">
            <input type="text" name="lastName" model="lastName" id="lastName" placeholder="Enter Last Name" required>
        </div>
    </div>

    <div class="row">
        <div class="col span-1-of-3">
            <label for="initials">Initials</label>
        </div>
        <div class="col span-2-of-3">
            <input type="text" name="initials" model="initials" id="initials" placeholder="Enter Initials" required>
        </div>
    </div>


    <div class="row">
        <div class="col span-1-of-3">
            <label for="IDNumber">Identity Number</label>
        </div>
        <div class="col span-2-of-3">
            <input type="text" name="IDNumber" model="IDNumber" id="IDNumber" placeholder="Enter ID Number" required>
        </div>
    </div>

    <div class="row">
        <div class="col span-1-of-3">
            <label for="emailAddress">Email Address</label>
        </div>
        <div class="col span-2-of-3">
            <input type="email" name="emailAddress" model="emailAddress" id="emailAddress" placeholder="Enter email Address" required>
        </div>
    </div>
    @If Request.IsAuthenticated Then

        @<input type="hidden" class="form-control" wire:model="userEmail" id="userEmail" name="userEmail" value=@User.Identity.GetUserName()>

    End If
    <div class="row">
        <div class="col span-1-of-3">
            <label for="medicalAidName">Medical Aid Name</label>
        </div>
        <div class="col span-2-of-3">
            <input type="text" name="medicalAidName" model="medicalAidName" id="medicalAidName" placeholder="Enter medical name" required>
        </div>
    </div>


    <div class="row">
        <div class="col span-1-of-3">
            <label for="medicalAidNumber">Medical Aid Number</label>
        </div>
        <div class="col span-2-of-3">
            <input type="text" name="medicalAidNumber" model="medicalAidNumber" id="medicalAidNumber" placeholder="Enter medical Number" required>
        </div>
    </div>


    <div class="row">
        <div class="col span-1-of-3">
            <label for="province">Province</label>
        </div>
        <div class="col span-2-of-3">
            <input type="text" name="province" model="province" id="province" placeholder="Enter Province" required>
        </div>
    </div>

    <div class="row">
        <div class="col span-1-of-3">
            <label for="town">Town</label>
        </div>
        <div class="col span-2-of-3">
            <input type="text" name="town" model="town" id="town" placeholder="Enter Town" required>
        </div>
    </div>
    <br />
    <div>
        @Html.LabelFor(Function(model) model.eventID, "Event Name", htmlAttributes:=New With {.class = "col span-1-of-3"})
        <div class="row">

            @Html.DropDownList("eventID", Nothing, htmlAttributes:=New With {.class = "col span-2-of-3"})
        </div>
        @Html.ValidationMessageFor(Function(model) model.eventID, "", New With {.class = "text-danger"})
    </div>
    <br />
    <div>
        @Html.LabelFor(Function(model) model.divisionID, "distance (KM)", htmlAttributes:=New With {.class = "col span-1-of-3"})
        <div class="row">
            @Html.DropDownList("divisionID", Nothing, htmlAttributes:=New With {.class = "col span-2-of-3"})
            </div>
            @Html.ValidationMessageFor(Function(model) model.divisionID, "", New With {.class = "text-danger"})
        </div>



        <br />
        <div class="row">
            <div class="col span-2-of-3">
                <input type="submit" value="Save" class="button-add" />
                <button class="button-back">
                    @Html.ActionLink("Back", "Index", "Eventts")
                </button>
            </div>
        </div>
    </div>
End Using


@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
