@ModelType IEnumerable(Of selati_.eventt)
@Code
    ViewData("Title") = "Event"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2 class="form-header">Events</h2>

<p>
   <button class="button-add"> @Html.ActionLink("Add a new event", "Create") </button>
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.eventName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.eventDate)
        </th>
        <th>Action</th>
    </tr>

    @For Each item In Model
        @<tr>
            <td>
                @Html.DisplayFor(Function(modelItem) item.eventName)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.eventDate)
            </td>
            <td>
                <button class="button-update">@Html.ActionLink("Update", "Edit", New With {.id = item.eventID}, New With {.style = "color:white"})</button>
                <button class="button-delete"> @Html.ActionLink("Delete", "Delete", New With {.id = item.eventID}, New With {.style = "color:white"}) </button>
            </td>
        </tr>
    Next

</table>
<button class="btn btn-default">@Html.ActionLink("Back", "homePage", "Admins")</button>