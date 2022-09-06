@ModelType selati_.division
@Code
    ViewData("Title") = "Details"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Details</h2>

<div>
    <h4>division</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.distance)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.distance)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.eventTime)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.eventTime)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.eventType)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.eventType)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.company.companyName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.company.companyName)
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
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.divisionID }) |
    @Html.ActionLink("Back to List", "Index")
</p>
