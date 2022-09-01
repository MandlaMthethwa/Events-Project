@ModelType selati_.user
@Code
    ViewData("Title") = "Create"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2 class="form-header">Enter participant details below</h2>

@Using (Html.BeginForm()) 
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">

    <hr />
    @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
    <div class="form-group col-md-6">
        @Html.LabelFor(Function(model) model.firstName, htmlAttributes:=New With {.class = "control-label col-md-2"})

        @Html.EditorFor(Function(model) model.firstName, New With {.htmlAttributes = New With {.class = "form-control"}})
        @Html.ValidationMessageFor(Function(model) model.firstName, "", New With {.class = "text-danger"})

    </div>

    <div class="form-group col-md-6">
        @Html.LabelFor(Function(model) model.lastName, htmlAttributes:=New With {.class = "control-label col-md-2"})

        @Html.EditorFor(Function(model) model.lastName, New With {.htmlAttributes = New With {.class = "form-control"}})
        @Html.ValidationMessageFor(Function(model) model.lastName, "", New With {.class = "text-danger"})

    </div>

    <div class="form-group col-md-6">
        @Html.LabelFor(Function(model) model.initials, htmlAttributes:=New With {.class = "control-label col-md-2"})

        @Html.EditorFor(Function(model) model.initials, New With {.htmlAttributes = New With {.class = "form-control"}})
        @Html.ValidationMessageFor(Function(model) model.initials, "", New With {.class = "text-danger"})

    </div>

    <div class="form-group col-md-6">
        @Html.LabelFor(Function(model) model.IDNumber, htmlAttributes:=New With {.class = "control-label col-md-2"})
        @Html.EditorFor(Function(model) model.IDNumber, New With {.htmlAttributes = New With {.class = "form-control"}})
        @Html.ValidationMessageFor(Function(model) model.IDNumber, "", New With {.class = "text-danger"})
    </div>
    <div class="form-group col-md-6">
        @Html.LabelFor(Function(model) model.emailAddress, htmlAttributes:=New With {.class = "control-label col-md-2"})

        @Html.EditorFor(Function(model) model.emailAddress, New With {.htmlAttributes = New With {.class = "form-control"}})
        @Html.ValidationMessageFor(Function(model) model.emailAddress, "", New With {.class = "text-danger"})

    </div>

    <div class="form-group col-md-6">
        @Html.LabelFor(Function(model) model.medicalAidName, htmlAttributes:=New With {.class = "control-label col-md-2"})
        @Html.EditorFor(Function(model) model.medicalAidName, New With {.htmlAttributes = New With {.class = "form-control"}})
        @Html.ValidationMessageFor(Function(model) model.medicalAidName, "", New With {.class = "text-danger"})
    </div>

    <div class="form-group col-md-6">
        @Html.LabelFor(Function(model) model.medicalAidNumber, htmlAttributes:=New With {.class = "control-label col-md-2"})
        @Html.EditorFor(Function(model) model.medicalAidNumber, New With {.htmlAttributes = New With {.class = "form-control"}})
        @Html.ValidationMessageFor(Function(model) model.medicalAidNumber, "", New With {.class = "text-danger"})
    </div>



    <div class="form-group col-md-6">

        @Html.LabelFor(Function(model) model.province, htmlAttributes:=New With {.class = "control-label col-md-2"})
        @Html.EditorFor(Function(model) model.province, New With {.htmlAttributes = New With {.class = "form-control"}})
        @Html.ValidationMessageFor(Function(model) model.province, "", New With {.class = "text-danger"})
    </div>

    <div class="form-group col-md-6">
        @Html.LabelFor(Function(model) model.town, htmlAttributes:=New With {.class = "control-label col-md-2"})
        @Html.EditorFor(Function(model) model.town, New With {.htmlAttributes = New With {.class = "form-control"}})
        @Html.ValidationMessageFor(Function(model) model.town, "", New With {.class = "text-danger"})

    </div>

    <div class="form-group col-md-7">

        @Html.LabelFor(Function(model) model.regNo, htmlAttributes:=New With {.class = "control-label col-md-2"})

        @Html.EditorFor(Function(model) model.regNo, New With {.htmlAttributes = New With {.class = "form-control"}})
        @Html.ValidationMessageFor(Function(model) model.regNo, "", New With {.class = "text-danger"})

    </div>




    <div class="form-group col-md-6">

        @Html.LabelFor(Function(model) model.tempNo, htmlAttributes:=New With {.class = "control-label col-md-2"})

        @Html.EditorFor(Function(model) model.tempNo, New With {.htmlAttributes = New With {.class = "form-control"}})
        @Html.ValidationMessageFor(Function(model) model.tempNo, "", New With {.class = "text-danger"})

    </div>


    <div class="form-group col-md-6">
        @Html.LabelFor(Function(model) model.receiptNo, htmlAttributes:=New With {.class = "control-label col-md-2"})
        @Html.EditorFor(Function(model) model.receiptNo, New With {.htmlAttributes = New With {.class = "form-control"}})
        @Html.ValidationMessageFor(Function(model) model.receiptNo, "", New With {.class = "text-danger"})
    </div>

    <div class="form-group col-md-6">
        @Html.LabelFor(Function(model) model.depDate, htmlAttributes:=New With {.class = "control-label col-md-2"})
        @Html.EditorFor(Function(model) model.depDate, New With {.htmlAttributes = New With {.class = "form-control"}})
        @Html.ValidationMessageFor(Function(model) model.depDate, "", New With {.class = "text-danger"})
    </div>

    <div class="form-group col-md-6">
        @Html.LabelFor(Function(model) model.divisionID, "divisionID", htmlAttributes:=New With {.class = "control-label col-md-2"})
        @Html.DropDownList("divisionID", Nothing, htmlAttributes:=New With {.class = "form-control"})
        @Html.ValidationMessageFor(Function(model) model.divisionID, "", New With {.class = "text-danger"})
    </div>


    <div class="form-group">
        <div class="col-md-offset-2 col-md-10">
            <input type="submit" value="Save" class="button-add" />
            <button class="button-back">
                @Html.ActionLink("Back", "Index")
            </button>
        </div>
    </div>
</div>  End Using



@Section Scripts 
    @Scripts.Render("~/bundles/jqueryval")
End Section
