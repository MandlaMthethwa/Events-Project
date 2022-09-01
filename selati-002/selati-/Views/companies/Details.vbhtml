@ModelType selati_.company
@Code
    ViewData("Title") = "Details"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2 class="form-header">Details</h2>

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
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With {.id = Model.companyID}) |
    @Html.ActionLink("Back to List", "Index")
</p>
