@ModelType selati_.eventt
@Code
    ViewData("Title") = "Details"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Details</h2>

<div>
    <h4>eventt</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.eventName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.eventName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.eventDate)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.eventDate)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.eventID }) |
    @Html.ActionLink("Back to List", "Index")
</p>
