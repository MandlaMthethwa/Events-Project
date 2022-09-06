@ModelType IEnumerable(Of selati_.company)
@Code
ViewData("Title") = "Index"
Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2 class="form-header">Manage Organisers</h2>

<button class="button-add">
    @Html.ActionLink("Add organiser", "Create")
</button>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.companyName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.companyUsername)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.websiteURL)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.companyRegNum)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.companyVATNum)
        </th>
       
        <th>
            @Html.DisplayNameFor(Function(model) model.eventt.eventName)
        </th>
        <th> Action</th>
    </tr>

    @For Each item In Model
        @<tr>
            <td>
                @Html.DisplayFor(Function(modelItem) item.companyName)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.companyUsername)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.websiteURL)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.companyRegNum)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.companyVATNum)
            </td>
           
            <td>
                @Html.DisplayFor(Function(modelItem) item.eventt.eventName)
            </td>
            <td>
                <button class="button-update"> @Html.ActionLink("Update", "Edit", New With {.id = item.companyID}, New With {.style = "color:white"}) </button>
                <button class="button-delete"> @Html.ActionLink("Delete", "Delete", New With {.id = item.companyID}, New With {.style = "color:white"}) </button>
            </td>
        </tr>
    Next
   

</table>
