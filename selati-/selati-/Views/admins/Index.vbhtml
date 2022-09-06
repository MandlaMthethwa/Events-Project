@ModelType IEnumerable(Of selati_.user)
@Code
    ViewData("Title") = "Index"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2 class="form-header">Manage Participants</h2>

<button class="button-add">
    @Html.ActionLink("Add a new participant", "Create", New With {.id = 1}, New With {.style = "color:white;"})
</button>
@Using Html.BeginForm()
    @<p>
        Find by First Name(s) or Surname: @Html.TextBox("SearchString")
        <input type="submit" value="Search" />
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
            @Html.DisplayNameFor(Function(model) model.clubName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.province)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.town)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.regNo)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.tShirt)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.tsbPers)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.tempNo)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.tipe)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.bet)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.paid)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.receiptNo)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.depDate)
        </th>

        <th></th>
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
                @Html.DisplayFor(Function(modelItem) item.clubName)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.province)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.town)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.regNo)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.tShirt)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.tsbPers)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.tempNo)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.tipe)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.bet)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.paid)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.receiptNo)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.depDate)
            </td>


            <td>
                <p class=" button-update"> @Html.ActionLink("Update", "Edit", New With {.id = item.userID}, New With {.style = "color:white"}) </p>

                <p class=" button-delete"> @Html.ActionLink("Delete", "Delete", New With {.id = item.userID}, New With {.style = "color:white"})</p>
            </td>
        </tr>
    Next

</table>
<button class="button-back">
    @Html.ActionLink("Back", "homePage")
</button>