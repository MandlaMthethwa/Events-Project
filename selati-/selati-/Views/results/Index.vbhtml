@ModelType PagedList.IPagedList(Of selati_.result)
@Imports PagedList.Mvc
<link href="~/Content/PagedList.css" rel="stylesheet" type="text/css" />

    @Code
        ViewData("Title") = "My Results"
        Layout = "~/Views/Shared/_Layout.vbhtml"

    End Code


    <h2 class="form-header">Results</h2>
<h3> How did you stack up against the other participants ?</h3>

@Using Html.BeginForm()
@<p>
    Find by First Name(s) or Surname: @Html.TextBox("SearchString", TryCast(ViewBag.CurrentFilter, String))
    <input type="submit" value="Search" />
    <button class="btn button-back">
        @Html.ActionLink("Refresh", "Index")
    </button>
</p>
End Using

<table class="table">
<tr>
    <th>
Last Name        </th>
        <th>
                First Name
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


Page @IIf(Model.PageCount < Model.PageNumber, 0 , Model.PageNumber) of @Model.PageCount

@Html.PagedListPager(Model, Function(page) Url.Action("Index", _
    New With {page, .sortOrder = ViewBag.CurrentSort, .currentFilter = ViewBag.CurrentFilter}))


<p> <a class="button-back" @Html.ActionLink("Back", "Index", "Home")</a> </p>