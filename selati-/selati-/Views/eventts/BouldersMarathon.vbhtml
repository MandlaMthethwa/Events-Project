@Code
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code
<h1 > 2022 Boulders Marathon</h1>
<h2>Saturday ,24 September 2022</h2>

<img src="../images/Boulders-Marathon.jpg" />


<table class="table">
    <thead><tr><th>Class</th> <th>Distance</th> <th>Start Time</th> <th style="text-align: center;">Price (pp)</th></tr></thead>
    <tbody>
        <tr>
            <td><strong>10km Boulders Marathon</strong></td>
            <td style="vertical-align: middle;">10 km</td>
            <td style="vertical-align: middle;">06:30</td>
            <th style="vertical-align: middle; text-align: center;">
                R&nbsp;80.00
            </th>
        </tr>
        <tr>
            <td><strong>10km Boulders Marathon</strong></td>
            <td style="vertical-align: middle;">25 km</td>
            <td style="vertical-align: middle;">06:00</td>
            <th style="vertical-align: middle; text-align: center;">
                R&nbsp;140.00
            </th>
        </tr>
        
    </tbody>
</table>
<a href="@Url.Action("Create", "Users")" class="btn btn-lg btn-primary btn-block">
    Enter for 2022  Boulders Marathon »
</a>

