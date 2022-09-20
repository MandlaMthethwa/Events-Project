@ModelType selati_.user
@Code
    ViewData("Title") = "Update details"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Update</h2>

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()
    
    @<div class="contact-form">

    <hr />
    @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
    @Html.HiddenFor(Function(model) model.userID)

    <div class="form-group">
        @Html.LabelFor(Function(model) model.firstName, htmlAttributes:=New With {.class = "col span-1-of-3"})
        <div class="row">
            @Html.EditorFor(Function(model) model.firstName, New With {.htmlAttributes = New With {.class = "col span-2-of-3"}})
            @Html.ValidationMessageFor(Function(model) model.firstName, "", New With {.class = "text-danger"})
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.lastName, htmlAttributes:=New With {.class = "col span-1-of-3"})
        <div class="row">
            @Html.EditorFor(Function(model) model.lastName, New With {.htmlAttributes = New With {.class = "col span-2-of-3"}})
            @Html.ValidationMessageFor(Function(model) model.lastName, "", New With {.class = "text-danger"})
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.initials, htmlAttributes:=New With {.class = "col span-1-of-3"})
        <div class="row">
            @Html.EditorFor(Function(model) model.initials, New With {.htmlAttributes = New With {.class = "col span-2-of-3"}})
            @Html.ValidationMessageFor(Function(model) model.initials, "", New With {.class = "text-danger"})
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.IDNumber, htmlAttributes:=New With {.class = "col span-1-of-3"})
        <div class="row">
            @Html.EditorFor(Function(model) model.IDNumber, New With {.htmlAttributes = New With {.class = "col span-2-of-3"}})
            @Html.ValidationMessageFor(Function(model) model.IDNumber, "", New With {.class = "text-danger"})
        </div>
    </div>
    <div class="form-group">
        @Html.LabelFor(Function(model) model.emailAddress, htmlAttributes:=New With {.class = "col span-1-of-3"})
        <div class="row">
            @Html.EditorFor(Function(model) model.emailAddress, New With {.htmlAttributes = New With {.class = "col span-2-of-3"}})
            @Html.ValidationMessageFor(Function(model) model.emailAddress, "", New With {.class = "text-danger"})
        </div>
    </div><div class="form-group">
        @Html.LabelFor(Function(model) model.userEmail, htmlAttributes:=New With {.class = "col span-1-of-3"})
        <div class="row">
            @Html.EditorFor(Function(model) model.userEmail, New With {.htmlAttributes = New With {.class = "col span-2-of-3"}})
            @Html.ValidationMessageFor(Function(model) model.userEmail, "", New With {.class = "text-danger"})
        </div>
    </div>


    <div class="form-group">
        @Html.LabelFor(Function(model) model.medicalAidName, htmlAttributes:=New With {.class = "col span-1-of-3"})
        <div class="row">
            @Html.EditorFor(Function(model) model.medicalAidName, New With {.htmlAttributes = New With {.class = "col span-2-of-3"}})
            @Html.ValidationMessageFor(Function(model) model.medicalAidName, "", New With {.class = "text-danger"})
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.medicalAidNumber, htmlAttributes:=New With {.class = "col span-1-of-3"})
        <div class="row">
            @Html.EditorFor(Function(model) model.medicalAidNumber, New With {.htmlAttributes = New With {.class = "col span-2-of-3"}})
            @Html.ValidationMessageFor(Function(model) model.medicalAidNumber, "", New With {.class = "text-danger"})
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.clubName, htmlAttributes:=New With {.class = "col span-1-of-3"})
        <div class="row">
            @Html.EditorFor(Function(model) model.clubName, New With {.htmlAttributes = New With {.class = "col span-2-of-3"}})
            @Html.ValidationMessageFor(Function(model) model.clubName, "", New With {.class = "text-danger"})
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.province, htmlAttributes:=New With {.class = "col span-1-of-3"})
        <div class="row">
            @Html.EditorFor(Function(model) model.province, New With {.htmlAttributes = New With {.class = "col span-2-of-3"}})
            @Html.ValidationMessageFor(Function(model) model.province, "", New With {.class = "text-danger"})
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.town, htmlAttributes:=New With {.class = "col span-1-of-3"})
        <div class="row">
            @Html.EditorFor(Function(model) model.town, New With {.htmlAttributes = New With {.class = "col span-2-of-3"}})
            @Html.ValidationMessageFor(Function(model) model.town, "", New With {.class = "text-danger"})
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.regNo, htmlAttributes:=New With {.class = "col span-1-of-3"})
        <div class="row">
            @Html.EditorFor(Function(model) model.regNo, New With {.htmlAttributes = New With {.class = "col span-2-of-3"}})
            @Html.ValidationMessageFor(Function(model) model.regNo, "", New With {.class = "text-danger"})
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.tShirt, htmlAttributes:=New With {.class = "col span-1-of-3"})
        <div class="row">
            @Html.EditorFor(Function(model) model.tShirt, New With {.htmlAttributes = New With {.class = "col span-2-of-3"}})
            @Html.ValidationMessageFor(Function(model) model.tShirt, "", New With {.class = "text-danger"})
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.tsbPers, htmlAttributes:=New With {.class = "col span-1-of-3"})
        <div class="row">
            @Html.EditorFor(Function(model) model.tsbPers, New With {.htmlAttributes = New With {.class = "col span-2-of-3"}})
            @Html.ValidationMessageFor(Function(model) model.tsbPers, "", New With {.class = "text-danger"})
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.tempNo, htmlAttributes:=New With {.class = "col span-1-of-3"})
        <div class="row">
            @Html.EditorFor(Function(model) model.tempNo, New With {.htmlAttributes = New With {.class = "col span-2-of-3"}})
            @Html.ValidationMessageFor(Function(model) model.tempNo, "", New With {.class = "text-danger"})
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.tipe, htmlAttributes:=New With {.class = "col span-1-of-3"})
        <div class="row">
            @Html.EditorFor(Function(model) model.tipe, New With {.htmlAttributes = New With {.class = "col span-2-of-3"}})
            @Html.ValidationMessageFor(Function(model) model.tipe, "", New With {.class = "text-danger"})
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.bet, htmlAttributes:=New With {.class = "col span-1-of-3"})
        <div class="row">
            @Html.EditorFor(Function(model) model.bet, New With {.htmlAttributes = New With {.class = "col span-2-of-3"}})
            @Html.ValidationMessageFor(Function(model) model.bet, "", New With {.class = "text-danger"})
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.paid, htmlAttributes:=New With {.class = "col span-1-of-3"})
        <div class="row">
            @Html.EditorFor(Function(model) model.paid, New With {.htmlAttributes = New With {.class = "col span-2-of-3"}})
            @Html.ValidationMessageFor(Function(model) model.paid, "", New With {.class = "text-danger"})
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.receiptNo, htmlAttributes:=New With {.class = "control-label col span-1-of-3"})
        <div class="row">
            @Html.EditorFor(Function(model) model.receiptNo, New With {.htmlAttributes = New With {.class = "col span-2-of-3"}})
            @Html.ValidationMessageFor(Function(model) model.receiptNo, "", New With {.class = "text-danger"})
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.depDate, htmlAttributes:=New With {.class = "col span-1-of-3"})
        <div class="row">
            @Html.EditorFor(Function(model) model.depDate, New With {.htmlAttributes = New With {.class = "col span-2-of-3"}})
            @Html.ValidationMessageFor(Function(model) model.depDate, "", New With {.class = "text-danger"})
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.divisionID, "Distance(KM)", htmlAttributes:=New With {.class = "col span-1-of-3"})
        <div class="row">
            @Html.DropDownList("divisionID", Nothing, htmlAttributes:=New With {.class = "col span-2-of-3"})
            @Html.ValidationMessageFor(Function(model) model.divisionID, "", New With {.class = "text-danger"})
        </div>
    </div>
    <div class="form-group">
        @Html.LabelFor(Function(model) model.eventID, "Event Name", htmlAttributes:=New With {.class = "control-label col span-1-of-3"})
        <div class="row">
            @Html.DropDownList("eventID", Nothing, htmlAttributes:=New With {.class = "col span-2-of-3"})
            @Html.ValidationMessageFor(Function(model) model.eventID, "", New With {.class = "text-danger"})
        </div>
    </div>
    <div class="form-group">
            <input type="submit" value="Save" class="btn btn-default" />
            <button class="btn button-back">
                @Html.ActionLink("Back", "Index")
            </button>
    </div>
</div>
End Using



@Section Scripts 
    @Scripts.Render("~/bundles/jqueryval")
End Section
