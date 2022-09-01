@ModelType selati_.eventt
@Code
    ViewData("Title") = "Update"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code


<h2 class="form-header">Update</h2>

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()

    @<div class="form-horizontal">

        <hr />
        @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
        @Html.HiddenFor(Function(model) model.eventID)

        <div class="form-group">
            @Html.LabelFor(Function(model) model.eventName, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.eventName, New With {.htmlAttributes = New With {.class = "form-control"}})
                @Html.ValidationMessageFor(Function(model) model.eventName, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.eventDate, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.eventDate, New With {.htmlAttributes = New With {.class = "form-control"}})
                @Html.ValidationMessageFor(Function(model) model.eventDate, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <input type="submit" value="Update" class="btn btn-default" />
            </div>
        </div>
    </div>
End Using

<button class="button-back">
    @Html.ActionLink("Cancel", "adminIndex")
</button>

@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
