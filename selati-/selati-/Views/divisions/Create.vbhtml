@ModelType selati_.division
@Code
    ViewData("Title") = "Add division"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code
<h2 class="form-header">Add a division</h2>

@Using (Html.BeginForm()) 
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">

    <hr />
    @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
    <div class="form-group">
        @Html.LabelFor(Function(model) model.distance, htmlAttributes:=New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.distance, New With {.htmlAttributes = New With {.class = "form-control"}})
            @Html.ValidationMessageFor(Function(model) model.distance, "", New With {.class = "text-danger"})
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.eventTime, htmlAttributes:=New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.eventTime, New With {.htmlAttributes = New With {.class = "form-control"}})
            @Html.ValidationMessageFor(Function(model) model.eventTime, "", New With {.class = "text-danger"})
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.eventType, htmlAttributes:=New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.eventType, New With {.htmlAttributes = New With {.class = "form-control"}})
            @Html.ValidationMessageFor(Function(model) model.eventType, "", New With {.class = "text-danger"})
        </div>
    </div>
    <div class="form-group">
        @Html.LabelFor(Function(model) model.amount, htmlAttributes:=New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.amount, New With {.htmlAttributes = New With {.class = "form-control"}})
            @Html.ValidationMessageFor(Function(model) model.amount, "", New With {.class = "text-danger"})
        </div>
    </div>


    <div class="form-group">
        @Html.LabelFor(Function(model) model.eventt, "Event Name", htmlAttributes:=New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.DropDownList("eventID", Nothing, htmlAttributes:=New With {.class = "form-control"})
            @Html.ValidationMessageFor(Function(model) model.eventt, "", New With {.class = "text-danger"})
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.company, "Organiser", htmlAttributes:=New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.DropDownList("companyID", Nothing, htmlAttributes:=New With {.class = "form-control"})
            @Html.ValidationMessageFor(Function(model) model.company, "", New With {.class = "text-danger"})
        </div>
    </div>

    <div class="form-group">
        <div class="col-md-offset-2 col-md-10">
            <input type="submit" value="Create" class="btn btn-default" />
            <button class="btn button-back"> @Html.ActionLink("Back ", "adminIndex")</button>
        </div>
    </div>
</div>
End Using



@Section Scripts 
    @Scripts.Render("~/bundles/jqueryval")
End Section
