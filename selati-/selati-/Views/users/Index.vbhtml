@ModelType IEnumerable(Of selati_.user)
@Code
    ViewData("Title") = "Participants"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2 class="form-header">Your Participants</h2>
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
            @Html.DisplayNameFor(Function(model) model.firstName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.lastName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.initials)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.IDNumber)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.medicalAidName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.medicalAidNumber)
        </th>

        <th>
            @Html.DisplayNameFor(Function(model) model.province)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.town)
        </th>
        <th>
             Event  
        </th>
        <th>Price</th>

    </tr>

    @For Each item In Model
        @<tr>
    <td>
        @Html.DisplayFor(Function(modelItem) item.firstName)
    </td>
    <td>
        @Html.DisplayFor(Function(modelItem) item.lastName)
    </td>
    <td>
        @Html.DisplayFor(Function(modelItem) item.initials)
    </td>
    <td>
        @Html.DisplayFor(Function(modelItem) item.IDNumber)
    </td>
    <td>
        @Html.DisplayFor(Function(modelItem) item.medicalAidName)
    </td>
    <td>
        @Html.DisplayFor(Function(modelItem) item.medicalAidNumber)
    </td>

    <td>
        @Html.DisplayFor(Function(modelItem) item.province)
    </td>
    <td>
        @Html.DisplayFor(Function(modelItem) item.town)
    </td>
    <td>
        @Html.DisplayFor(Function(modelItem) item.eventt.eventName)
        @Html.DisplayFor(Function(modelItem) item.division.distance) KM

    </td>
    <td>
        
       R @Html.DisplayFor(Function(modelItem) item.division.amount) 

    </td>

    <td> <button class="btn button-view">
         Add to checkout
         </button></td>
</tr>
    Next

</table>
