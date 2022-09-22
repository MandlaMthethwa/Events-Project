@ModelType selati_.result
@Code
    ViewData("Title") = "Add Results"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2 class="form-header">Add Results</h2>

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()

    @<div class="contact-form">



    <hr />
    @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
    <div class="form-group ">
        @Html.LabelFor(Function(model) model.lastName, htmlAttributes:=New With {.class = "col span-1-of-3"})
        <div class="row">
            @Html.EditorFor(Function(model) model.lastName, New With {.htmlAttributes = New With {.Class = "form-control"}})
            @Html.ValidationMessageFor(Function(model) model.lastName, "", New With {.class = "text-danger"})
        </div>
    </div>
    <div class="form-group">
        @Html.LabelFor(Function(model) model.firstName, htmlAttributes:=New With {.class = "col span-1-of-3"})
        <div class="row">
        @Html.EditorFor(Function(model) model.firstName, New With {.htmlAttributes = New With {.Class = "form-control"}})
        @Html.ValidationMessageFor(Function(model) model.firstName, "", New With {.class = "text-danger"})
            </div>
    </div>
    <div class="form-group">
        @Html.LabelFor(Function(model) model.emailAddress, htmlAttributes:=New With {.class = "col span-1-of-3"})
        <div class="row">
            @Html.EditorFor(Function(model) model.emailAddress, New With {.htmlAttributes = New With {.Class = "form-control"}})
            @Html.ValidationMessageFor(Function(model) model.emailAddress, "", New With {.class = "text-danger"})
            </div>
        </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.batch, htmlAttributes:=New With {.class = "col span-1-of-3"})
        <div class="row">
            @Html.EditorFor(Function(model) model.batch, New With {.htmlAttributes = New With {.class = "form-control"}})
            @Html.ValidationMessageFor(Function(model) model.batch, "", New With {.class = "text-danger"})
            </div>
        </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.gender, htmlAttributes:=New With {.class = "col span-1-of-3"})
        <div class="row">
            <select class="form-control" wire:model="gender" id="gender" name="gender">
                <option value=" ">-- Select Gender --</option>

                <option value="Male">Male</option>
                <option value="Female">Female</option>
            </select>
            @Html.ValidationMessageFor(Function(model) model.gender, "", New With {.class = "text-danger"})
            </div>
        </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.class, htmlAttributes:=New With {.class = "col span-1-of-3"})
        <div class="row">
            @Html.EditorFor(Function(model) model.class, New With {.htmlAttributes = New With {.class = "form-control"}})
            @Html.ValidationMessageFor(Function(model) model.class, "", New With {.class = "text-danger"})
            </div>
        </div>

    <div class="form-group ">
        @Html.LabelFor(Function(model) model.raceNumber, htmlAttributes:=New With {.class = "col span-1-of-3"})
        <div class="row">
            @Html.EditorFor(Function(model) model.raceNumber, New With {.htmlAttributes = New With {.class = "form-control"}})
            @Html.ValidationMessageFor(Function(model) model.raceNumber, "", New With {.class = "text-danger"})
            </div>
        </div>

    <div class="form-group ">
        @Html.LabelFor(Function(model) model.position, htmlAttributes:=New With {.class = "col span-1-of-3"})
        <div class="row">
            @Html.EditorFor(Function(model) model.position, New With {.htmlAttributes = New With {.class = "form-control"}})
            @Html.ValidationMessageFor(Function(model) model.position, "", New With {.class = "text-danger"})
            </div>
        </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.posGen, htmlAttributes:=New With {.class = "col span-1-of-3"})
        <div class="row">
            @Html.EditorFor(Function(model) model.posGen, New With {.htmlAttributes = New With {.class = "form-control"}})
            @Html.ValidationMessageFor(Function(model) model.posGen, "", New With {.class = "text-danger"})
            </div>
        </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.category, htmlAttributes:=New With {.class = "col span-1-of-3"})
        <div class="row">
            <select class="form-control" wire:model="category" id="category" name="category">
                <option value=" ">-- Select Category --</option>

                <option value="<17">< 17</option>
                <option value="18-24">18 - 24</option>
                <option value="25-31">25 - 31</option>
                <option value="32+">32 +</option>
            </select>
            @Html.ValidationMessageFor(Function(model) model.category, "", New With {.class = "text-danger"})
            </div>
        </div>

    <div class="form-group ">
        @Html.LabelFor(Function(model) model.posCat, htmlAttributes:=New With {.class = "col span-1-of-3"})
        <div class="row">
            @Html.EditorFor(Function(model) model.posCat, New With {.htmlAttributes = New With {.class = "form-control"}})
            @Html.ValidationMessageFor(Function(model) model.posCat, "", New With {.class = "text-danger"})
            </div>
        </div>

    <div class="form-group ">
        @Html.LabelFor(Function(model) model.status, htmlAttributes:=New With {.class = "col span-1-of-3"})
        <div class="row">
            <select class="form-control" wire:model="status" id="status" name="status">
                <option value=" ">-- Select Status --</option>
                <option value="Finished">Finished</option>
                <option value="On going">On going</option>
            </select>
            @Html.ValidationMessageFor(Function(model) model.status, "", New With {.class = "text-danger"})
            </div>
        </div>

    <div class="form-group ">
        @Html.LabelFor(Function(model) model.time, htmlAttributes:=New With {.class = "col span-1-of-3"})
        <div class="row">
            @Html.EditorFor(Function(model) model.time, New With {.htmlAttributes = New With {.class = "form-control"}})
            @Html.ValidationMessageFor(Function(model) model.time, "", New With {.class = "text-danger"})
            </div>
        </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.eventID, "Event", htmlAttributes:=New With {.class = "col span-1-of-3"})
        <div class="row">
            @Html.DropDownList("eventID", Nothing, htmlAttributes:=New With {.class = "form-control"})
            @Html.ValidationMessageFor(Function(model) model.eventID, "", New With {.class = "text-danger"})
            </div>

        </div>
     <div class="form-group">

            <input type="submit" value="Save" class="button-add" />
            <button class="button-back">
                @Html.ActionLink("Cancel", "adminIndex")
            </button>

        </div>
    </div>
End Using



@Section Scripts 
    @Scripts.Render("~/bundles/jqueryval")
End Section
