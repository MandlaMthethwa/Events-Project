@ModelType selati_.eventt
@Code
    ViewData("Title") = "Create"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Add Event</h2>

@Using (Html.BeginForm()) 
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
    <hr />
    @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
    <div class="form-group">
        @Html.LabelFor(Function(model) model.eventName, htmlAttributes:=New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.eventName, New With {.htmlAttributes = New With {.class = "form-control", .placeholder = "Enter Event Name"}})
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
            <input type="submit" value="Save" class="btn btn-default" />
            <button class="button-back">
                @Html.ActionLink("Back", "Index")
            </button>
        </div>
    </div>
</div>
End Using



@Section Scripts 
    @Scripts.Render("~/bundles/jqueryval")
End Section
