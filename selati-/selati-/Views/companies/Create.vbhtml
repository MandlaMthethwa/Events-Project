﻿@ModelType selati_.company
@Code
    ViewData("Title") = "Add Organiser"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2 class="form-header">Add Organiser (Company)</h2>

@Using (Html.BeginForm()) 
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
       
        <hr />
        @Html.ValidationSummary(True, "", New With { .class = "text-danger" })
        <div class="form-group">
            @Html.LabelFor(Function(model) model.companyName, htmlAttributes:= New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.companyName, New With {.htmlAttributes = New With {.class = "form-control", .placeholder = "Enter Organiser Name"}})
                @Html.ValidationMessageFor(Function(model) model.companyName, "", New With { .class = "text-danger" })
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.companyUsername, htmlAttributes:= New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.companyUsername, New With {.htmlAttributes = New With {.class = "form-control", .placeholder = "Enter Organiser Username(Email)"}})
                @Html.ValidationMessageFor(Function(model) model.companyUsername, "", New With { .class = "text-danger" })
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.websiteURL, htmlAttributes:= New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.websiteURL, New With {.htmlAttributes = New With {.class = "form-control", .placeholder = "Enter Website if available"}})
                @Html.ValidationMessageFor(Function(model) model.websiteURL, "", New With { .class = "text-danger" })
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.companyRegNum, htmlAttributes:= New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.companyRegNum, New With {.htmlAttributes = New With {.class = "form-control", .placeholder = "Enter Organiser Registration Number"}})
                @Html.ValidationMessageFor(Function(model) model.companyRegNum, "", New With { .class = "text-danger" })
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.companyVATNum, htmlAttributes:= New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.companyVATNum, New With {.htmlAttributes = New With {.class = "form-control", .placeholder = "Enter Organiser VAT Number"}})
                @Html.ValidationMessageFor(Function(model) model.companyVATNum, "", New With { .class = "text-danger" })
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.eventID, "Event Name", htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.DropDownList("eventID", Nothing, htmlAttributes:=New With {.class = "form-control", .placeholder = "Enter Event Name"})
                @Html.ValidationMessageFor(Function(model) model.eventID, "", New With {.class = "text-danger"})
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
