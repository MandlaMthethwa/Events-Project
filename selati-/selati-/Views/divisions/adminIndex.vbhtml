@ModelType IEnumerable(Of selati_.division)
@Code
    ViewData("Title") = "Division"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2 class="form-header">Divisions</h2>

<p>
     <button class="button-add">@Html.ActionLink("Add a new division", "Create") </button>
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.distance)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.eventTime)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.eventType)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.eventt.eventName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.company.companyName)
        </th>
        <th>
            Action
        </th>
    </tr>

    @For Each item In Model
        @<tr>
    <td>
        @Html.DisplayFor(Function(modelItem) item.distance)
    </td>
    <td>
        @Html.DisplayFor(Function(modelItem) item.eventTime)
    </td>
    <td>
        @Html.DisplayFor(Function(modelItem) item.eventType)
    </td>
    <td>
        @Html.DisplayFor(Function(modelItem) item.eventt.eventName)
    </td>
    <td>
        @Html.DisplayFor(Function(modelItem) item.company.companyName)
    </td>
    <td>
        <button class="button-update"> @Html.ActionLink("Update", "Edit", New With {.id = item.divisionID}, New With {.style = "color:white"}) </button>
        <button class="button-delete"> @Html.ActionLink("Delete", "Delete", New With {.id = item.divisionID}, New With {.style = "color:white"}) </button>
    </td>
</tr>
    Next

</table>
<button class="btn btn-default">@Html.ActionLink("Back", "homePage", "Admins")</button>
