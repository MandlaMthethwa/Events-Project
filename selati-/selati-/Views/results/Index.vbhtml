@ModelType IEnumerable(Of selati_.result)

@Code
    ViewData("Title") = "My Results"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2 class="form-header">Results</h2>
<h3> How did you stack up against the other participants ?</h3>

@Using Html.BeginForm()
    @<p>
    Find by First Name(s) or Surname: @Html.TextBox("SearchString")
    <input type="submit" value="Search" />
    <button class="btn button-back">
        @Html.ActionLink("Refresh", "Index")
    </button>
</p>
End Using

<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.lastName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.firstName)
        </th>
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




    </tr>

    @For Each item In Model
        @<tr>
            <td>
                @Html.DisplayFor(Function(modelItem) item.lastName)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.firstName)
            </td>
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


        </tr>
    Next

</table>

<p ><a class="button-back" @Html.ActionLink("Back", "Index", "Home")</a> </p>