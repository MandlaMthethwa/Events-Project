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


    <tr>
        <td>
           Boulders Marthon 2022
        </td>
        <td>
          24 September 2022
        </td>
        <td>
            <button class="button-add">@Html.ActionLink("View Event", "BouldersMarathon") </button>
        </td>
        
    </tr>


</table>
<p><a class="button-back" @Html.ActionLink("Back", "Index", "Home") </a> </p>