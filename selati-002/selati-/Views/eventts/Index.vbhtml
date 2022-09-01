@ModelType IEnumerable(Of selati_.eventt)
@Code
ViewData("Title") = "Index"
Layout = "~/Views/Shared/_Layout.vbhtml"
End Code
<h2 class="form-header">Events</h2>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.eventName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.eventDate)
        </th>
        <th>Enroll in an event</th>
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
            <button class="button-add">@Html.ActionLink(" Enroll", "Create", "Users", New With {.id = 1}, New With {.style = "color:white;"})  </button>
        </td>
        
    </tr>
Next

</table>
<p><a class="button-back" @Html.ActionLink("Back", "Index", "Home") </a> </p>