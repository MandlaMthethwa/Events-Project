@ModelType PagedList.IPagedList(Of selati_.result)
@Imports PagedList.Mvc
<link href="~/Content/PagedList.css" rel="stylesheet" type="text/css" />
@Code
    ViewData("Title") = "Manage Results"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2 class="form-header">Results</h2>


<p>
    <button class="button-add">@Html.ActionLink("Enter results", "Create") </button>
    <button class="button-back">
        @Html.ActionLink("Back to Menu", "homePage", "Admins")
    </button>
</p>
@Using Html.BeginForm()
    @<p>
        Find by First Name(s) or Surname: @Html.TextBox("SearchString")
        <input type="submit" value="Search" />
        <button class="btn button-back">
            @Html.ActionLink("Refresh", "adminIndex")
        </button>
    </p>
End Using
<table class="table">
    <tr>
        <th>
            Last Name
        </th>
        <th>
            First Name
        </th>
        <th>
            Email Adddress
        </th>
        <th>
            Batch
        </th>
        <th>
            Gender
        </th>
        <th>
            Class
        </th>
        <th>
            Race number
        </th>
        <th>
            Position
        </th>
        <th>
            Pos gen
        </th>
        <th>
            Category
        </th>
        <th>
            Pos cat
        </th>
        <th>
            Status
        </th>
        <th>
            Time
        </th>

        <th>
            Event name
        </th>

        <th> Action</th>
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
                @Html.DisplayFor(Function(modelItem) item.emailAddress)
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

            <td>
                <button class="button-update">@Html.ActionLink("Update", "Edit", New With {.id = item.resultID}, New With {.style = "color:white; font-family:Montserrat, sans-serif;"})</button>
                <button class="button-delete"> @Html.ActionLink("Delete", "Delete", New With {.id = item.resultID}, New With {.style = "color:white; font-family:Montserrat, sans-serif;"}) </button>
            </td>
        </tr>
    Next

</table>
Page @IIf(Model.PageCount < Model.PageNumber, 0, Model.PageNumber) of @Model.PageCount

@Html.PagedListPager(Model, Function(page) Url.Action("adminIndex",
                                        New With {page, .sortOrder = ViewBag.CurrentSort, .currentFilter = ViewBag.CurrentFilter}))
