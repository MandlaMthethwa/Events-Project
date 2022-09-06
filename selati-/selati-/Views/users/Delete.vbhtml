@ModelType selati_.user
@Code
    ViewData("Title") = "Delete"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>user</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.firstName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.firstName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.lastName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.lastName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.initials)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.initials)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.IDNumber)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.IDNumber)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.medicalAidName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.medicalAidName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.medicalAidNumber)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.medicalAidNumber)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.clubName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.clubName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.province)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.province)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.town)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.town)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.regNo)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.regNo)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.tShirt)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.tShirt)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.tsbPers)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.tsbPers)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.tempNo)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.tempNo)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.tipe)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.tipe)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.bet)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.bet)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.paid)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.paid)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.receiptNo)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.receiptNo)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.depDate)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.depDate)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.division.eventType)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.division.eventType)
        </dd>

    </dl>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
