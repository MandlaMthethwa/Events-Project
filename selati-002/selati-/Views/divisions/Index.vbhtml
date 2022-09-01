@ModelType IEnumerable(Of selati_.division)
@Code
ViewData("Title") = "Index"
Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
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
            @Html.DisplayNameFor(Function(model) model.company.companyName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.eventt.eventName)
        </th>
        <th></th>
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
            @Html.DisplayFor(Function(modelItem) item.company.companyName)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.eventt.eventName)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.divisionID }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.divisionID }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.divisionID })
        </td>
    </tr>
Next

</table>
