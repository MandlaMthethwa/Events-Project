@ModelType selati_.company
@Code
    ViewData("Title") = "Delete"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2 class="form-header">Delete</h2>

<h3>Are you sure you want to delete this organiser?</h3>
<div>
    
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.companyName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.companyName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.companyUsername)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.companyUsername)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.websiteURL)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.websiteURL)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.companyRegNum)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.companyRegNum)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.companyVATNum)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.companyVATNum)
        </dd>
        <dt>
            @Html.DisplayNameFor(Function(model) model.eventt.eventName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.eventt.eventName)
        </dd>

    </dl>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
    <input type="submit" value="Delete" class="btn button-delete" /> 
    <button class="btn button-back">@Html.ActionLink("Back", "Index")</button>
</div>
    End Using
</div>
