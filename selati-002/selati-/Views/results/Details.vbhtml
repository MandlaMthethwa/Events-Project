﻿@ModelType selati_.result
@Code
    ViewData("Title") = "Details"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Details</h2>

<div>
    <h4>result</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.batch)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.batch)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.gender)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.gender)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.class)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.class)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.raceNumber)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.raceNumber)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.position)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.position)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.posGen)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.posGen)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.category)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.category)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.posCat)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.posCat)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.status)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.status)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.time)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.time)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.eventt.eventName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.eventt.eventName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.user.firstName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.user.firstName)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.resultID }) |
    @Html.ActionLink("Back to List", "Index")
</p>
