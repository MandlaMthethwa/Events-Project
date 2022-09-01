@ModelType IEnumerable(Of selati_.result)
@Code
    ViewData("Title") = "Manage Results"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2 class="form-header">Results</h2>


<p>
    <button class="button-add">@Html.ActionLink("Enter results", "Create", New With {.id = 1}, New With {.style = "color:white; font-family:Montserrat, sans-serif;"}) </button>
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.batch)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.gender)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.class)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.raceNumber)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.position)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.posGen)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.category)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.posCat)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.status)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.time)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.eventt.eventName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.user.firstName)
        </th>
        <th></th>
    </tr>

    @For Each item In Model
        @<tr>
            <td>
                @Html.DisplayFor(Function(modelItem) item.batch)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.gender)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.class)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.raceNumber)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.position)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.posGen)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.category)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.posCat)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.status)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.time)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.eventt.eventName)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.user.firstName)
            </td>
            <td>
                <button class="button-update">@Html.ActionLink("Update", "Edit", New With {.id = item.resultID}, New With {.style = "color:white; font-family:Montserrat, sans-serif;"})</button>
                <button class="button-delete"> @Html.ActionLink("Delete", "Delete", New With {.id = item.resultID}, New With {.style = "color:white; font-family:Montserrat, sans-serif;"}) </button>
            </td>
        </tr>
    Next

</table>
<button class="btn btn-default">@Html.ActionLink("Back", "homePage", "Admins")</button>
