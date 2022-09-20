@ModelType IEnumerable(Of selati_.result)

@Code
    ViewData("Title") = "Results"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2 class="form-header">Results</h2>
<h3> Let's have a peek </h3>

<table class="table">
    <tr>
        <th>
            #
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.eventt.eventName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.eventt.eventDate)
        </th>
    </tr>




    
    <tr>
        <td>
            2
        </td>
        <td>
            Thirst
        </td>
        <td>
            Tuesday, 30 August 2022
        </td>
        <td>
            <button class="button-add">@Html.ActionLink("View Result", "thirstResults")</button>
        </td>
    </tr>
    <tr>

        <td>
            1
        </td>
        <td>
            Bolders Marathon
        </td>
        <td>
            Saturday, 24 September 2022
        </td>
        <td>
            <button class="button-add">@Html.ActionLink("View Result", "boldersResults")</button>
        </td>
        </tr>

</table>


<p> <a class="button-back" @Html.ActionLink("Back", "Index", "Home") </a></p>