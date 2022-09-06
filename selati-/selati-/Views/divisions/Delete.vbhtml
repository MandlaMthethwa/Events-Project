@ModelType selati_.division
@Code
    ViewData("Title") = "Delete"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2 class="form-header">Delete</h2>

<h3>Are you sure you want to delete this division?</h3>
<div>
    
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.distance)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.distance)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.eventTime)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.eventTime)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.eventType)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.eventType)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.company.companyName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.company.companyName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.eventt.eventName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.eventt.eventName)
        </dd>

    </dl>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="button-delete" /> |
            <div>
                <button class="btn btn-default"> @Html.ActionLink("Back ", "adminIndex")</button>
            </div>
        </div>
    End Using
</div>
