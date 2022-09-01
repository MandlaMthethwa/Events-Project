@ModelType selati_.eventt
@Code
    ViewData("Title") = "Delete"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2 class="form-header">Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
  
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.eventName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.eventName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.eventDate)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.eventDate)
        </dd>

    </dl>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
    <input type="submit" value="Delete" class="button-delete" />
    <button class="button-back">@Html.ActionLink("Cancel", "adminIndex") </button>
</div>
    End Using
</div>
