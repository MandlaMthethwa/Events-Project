﻿@ModelType selati_.result
@Code
    ViewData("Title") = "Add Results"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2 class="form-header">Add Results</h2>

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()

    @<div class="form-horizontal">
        
        <hr />
        @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
        <div class="form-group col-md-6">
            @Html.LabelFor(Function(model) model.batch, htmlAttributes:=New With {.class = "control-label col-md-2"})
            
                @Html.EditorFor(Function(model) model.batch, New With {.htmlAttributes = New With {.class = "form-control"}})
                @Html.ValidationMessageFor(Function(model) model.batch, "", New With {.class = "text-danger"})
            
        </div>

        <div class="form-group col-md-6">
            @Html.LabelFor(Function(model) model.gender, htmlAttributes:=New With {.class = "control-label col-md-2"})

            <select wire:model="gender" id="gender" name="gender">
                <option value="Male">Male</option>
                <option value="Female">Female</option>
            </select>
            @Html.ValidationMessageFor(Function(model) model.gender, "", New With {.class = "text-danger"})

        </div>

        <div class="form-group col-md-6">
            @Html.LabelFor(Function(model) model.class, htmlAttributes:=New With {.class = "control-label col-md-2"})
           
                @Html.EditorFor(Function(model) model.class, New With {.htmlAttributes = New With {.class = "form-control"}})
                @Html.ValidationMessageFor(Function(model) model.class, "", New With {.class = "text-danger"})
          
        </div>

        <div class="form-group col-md-6">
            @Html.LabelFor(Function(model) model.raceNumber, htmlAttributes:=New With {.class = "control-label col-md-2"})
            
                @Html.EditorFor(Function(model) model.raceNumber, New With {.htmlAttributes = New With {.class = "form-control"}})
                @Html.ValidationMessageFor(Function(model) model.raceNumber, "", New With {.class = "text-danger"})
            
        </div>

        <div class="form-group col-md-6">
            @Html.LabelFor(Function(model) model.position, htmlAttributes:=New With {.class = "control-label col-md-2"})
           
                @Html.EditorFor(Function(model) model.position, New With {.htmlAttributes = New With {.class = "form-control"}})
                @Html.ValidationMessageFor(Function(model) model.position, "", New With {.class = "text-danger"})
           
        </div>

        <div class="form-group col-md-6">
            @Html.LabelFor(Function(model) model.posGen, htmlAttributes:=New With {.class = "control-label col-md-2"})
            
                @Html.EditorFor(Function(model) model.posGen, New With {.htmlAttributes = New With {.class = "form-control"}})
                @Html.ValidationMessageFor(Function(model) model.posGen, "", New With {.class = "text-danger"})
           
        </div>

        <div class="form-group col-md-6">
            @Html.LabelFor(Function(model) model.category, htmlAttributes:=New With {.class = "control-label col-md-2"})
            
                @Html.EditorFor(Function(model) model.category, New With {.htmlAttributes = New With {.class = "form-control"}})
                @Html.ValidationMessageFor(Function(model) model.category, "", New With {.class = "text-danger"})
            
        </div>

        <div class="form-group col-md-6">
            @Html.LabelFor(Function(model) model.posCat, htmlAttributes:=New With {.class = "control-label col-md-2"})
           
                @Html.EditorFor(Function(model) model.posCat, New With {.htmlAttributes = New With {.class = "form-control"}})
                @Html.ValidationMessageFor(Function(model) model.posCat, "", New With {.class = "text-danger"})
            
        </div>

        <div class="form-group col-md-6">
            @Html.LabelFor(Function(model) model.status, htmlAttributes:=New With {.class = "control-label col-md-2"})
            
                @Html.EditorFor(Function(model) model.status, New With {.htmlAttributes = New With {.class = "form-control"}})
                @Html.ValidationMessageFor(Function(model) model.status, "", New With {.class = "text-danger"})
           
        </div>

        <div class="form-group col-md-6">
            @Html.LabelFor(Function(model) model.time, htmlAttributes:=New With {.class = "control-label col-md-2"})
           
                @Html.EditorFor(Function(model) model.time, New With {.htmlAttributes = New With {.class = "form-control"}})
                @Html.ValidationMessageFor(Function(model) model.time, "", New With {.class = "text-danger"})
           
        </div>

        <div class="form-group col-md-6">
            @Html.LabelFor(Function(model) model.eventID, "eventID", htmlAttributes:=New With {.class = "control-label col-md-2"})
           
                @Html.DropDownList("eventID", Nothing, htmlAttributes:=New With {.class = "form-control"})
                @Html.ValidationMessageFor(Function(model) model.eventID, "", New With {.class = "text-danger"})
           
        </div>

        <div class="form-group col-md-6">
            @Html.LabelFor(Function(model) model.userID, "userID", htmlAttributes:=New With {.class = "control-label col-md-2"})
           
                @Html.DropDownList("userID", Nothing, htmlAttributes:=New With {.class = "form-control"})
                @Html.ValidationMessageFor(Function(model) model.userID, "", New With {.class = "text-danger"})
           
        </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <input type="submit" value="Save" class="button-register" />
            </div>
        </div>
    </div>
End Using

<button>
    @Html.ActionLink("Cancel", "adminIndex")
</button>

@Section Scripts 
    @Scripts.Render("~/bundles/jqueryval")
End Section
