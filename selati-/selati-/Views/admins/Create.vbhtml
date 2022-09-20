@ModelType selati_.user
@Code
    ViewData("Title") = "Create"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Add participant</h2>

@Using (Html.BeginForm()) 
    @Html.AntiForgeryToken()

    @<div class="contact-form">

    <hr />
    @Html.ValidationSummary(True, "", New With {.class = "text-danger"})

    <div class="row">
        <div class="col span-1-of-3">
            <label for="firstName">First Name</label>
        </div>
        <div class="col span-2-of-3">
            <input type="text" name="firstName" model="firstName" id="firstName" placeholder="Enter First Name(s)" required>
        </div>
    </div>

    <div class="row">
        <div class="col span-1-of-3">
            <label for="lastName">Last Name</label>
        </div>
        <div class="col span-2-of-3">
            <input type="text" name="lastName" model="lastName" id="lastName" placeholder="Enter Last Name" required>
        </div>
    </div>

    <div class="row">
        <div class="col span-1-of-3">
            <label for="initials">Initials</label>
        </div>
        <div class="col span-2-of-3">
            <input type="text" name="initials" model="initials" id="initials" placeholder="Enter Initials" required>
        </div>
    </div>

    <div class="row">
        <div class="col span-1-of-3">
            <label for="IDNumber">Identity Number</label>
        </div>
        <div class="col span-2-of-3">
            <input type="text" name="IDNumber" model="IDNumber" id="IDNumber" placeholder="Enter ID Number" required>
        </div>
    </div>
    <div class="row">
        <div class="col span-1-of-3">
            <label for="emailAddress">Email Address</label>
        </div>
        <div class="col span-2-of-3">
            <input type="email" name="emailAddress" model="emailAddress" id="emailAddress" placeholder="Enter parcipant email Address" required>
        </div>
    </div>
    <div class="row">
        <div class="col span-1-of-3">
            <label for="userEmail">User Email Address</label>
        </div>
        <div class="col span-2-of-3">
            <input type="email" name="userEmail" model="userEmail" id="userEmail" placeholder="Enter account user email Address" required>
        </div>
    </div>

    <div class="row">
        <div class="col span-1-of-3">
            <label for="medicalAidName">Medical Aid Name</label>
        </div>
        <div class="col span-2-of-3">
            <input type="text" name="medicalAidName" model="medicalAidName" id="medicalAidName" placeholder="Enter medical name" required>
        </div>
    </div>


    <div class="row">
        <div class="col span-1-of-3">
            <label for="medicalAidNumber">Medical Aid Number</label>
        </div>
        <div class="col span-2-of-3">
            <input type="text" name="medicalAidNumber" model="medicalAidNumber" id="medicalAidNumber" placeholder="Enter medical Number" required>
        </div>
    </div>
    <div class="row">
        <div class="col span-1-of-3">
            <label for="clubName">Club Name</label>
        </div>
        <div class="col span-2-of-3">
            <input type="text" name="clubName" model="clubName" id="clubName" placeholder="Enter Club Name" required>
        </div>
    </div>

    <div class="row">
        <div class="col span-1-of-3">
            <label for="province">Province</label>
        </div>
        <div class="col span-2-of-3">
            <input type="text" name="province" model="province" id="province" placeholder="Enter Province" required>
        </div>
    </div>

    <div class="row">
        <div class="col span-1-of-3">
            <label for="town">Town</label>
        </div>
        <div class="col span-2-of-3">
            <input type="text" name="town" model="town" id="town" placeholder="Enter Town" required>
        </div>
    </div>

    <div class="row">
        <div class="col span-1-of-3">
            <label for="regNo">Registration Number(Race Number)</label>
        </div>
        <div class="col span-2-of-3">
            <input type="text" name="regNo" model="regNo" id="regNo" placeholder="Enter Participant Registration Number" required>
        </div>
    </div>
    <div class="row">
        <div class="col span-1-of-3">
            <label for="tShirt">T-shirt Size</label>
        </div>
        <div class="col span-2-of-3">
            <input type="text" name="tShirt" model="tShirt" id="tShirt" placeholder="Enter T-shirt size if avilable" required>
        </div>
    </div>
    <div class="row">
        <div class="col span-1-of-3">
            <label for="tsbPers">Tsb Pers</label>
        </div>
        <div class="col span-2-of-3">
            <input type="text" name="tsbPers" model="tsbPers" id="tsbPers" placeholder="Enter tsbPers" required>
        </div>
    </div>

    <div class="row">
        <div class="col span-1-of-3">
            <label for="tempNo">Temporary Number</label>
        </div>
        <div class="col span-2-of-3">
            <input type="number" name="tempNo" model="tempNo" id="tempNo" placeholder="Enter Temporary Reg Number" required>
        </div>
    </div>

    <div class="row">
        <div class="col span-1-of-3">
            <label for="tipe">Tipe</label>
        </div>
        <div class="col span-2-of-3">
            <input type="text" name="tipe" model="tipe" id="tipe" placeholder="Enter Tipe" required>
        </div>
    </div>



    <div class="row">
        <div class="col span-1-of-3">
            <label for="bet">Bet</label>
        </div>
        <div class="col span-2-of-3">
            <input type="text" name="bet" model="bet" id="bet" placeholder="Enter Finish time prediction" required>
        </div>
    </div>

    <div class="row">
        <div class="col span-1-of-3">
            <label for="paid">Amount Paid</label>
        </div>
        <div class="col span-2-of-3">
            <input type="text" name="paid" model="paid" id="paid" placeholder="Enter Amount paid" required>
        </div>
    </div>


    <div class="row">
        <div class="col span-1-of-3">
            <label for="receiptNo">Receipt Number</label>
        </div>
        <div class="col span-2-of-3">
            <input type="text" name="receiptNo" model="receiptNo" id="receiptNo" placeholder="Enter Receipt Number" required>
        </div>
    </div>

    <div class="row">
        <div class="col span-1-of-3">
            <label for="depDate">Deputure Date</label>
        </div>
        <div class="col span-2-of-3">
            <input type="date" name="depDate" model="depDate" id="depDate" placeholder="Enter Deputure Date" required>
        </div>
    </div><br />
    <div>
        @Html.LabelFor(Function(model) model.eventID, "Event Name", htmlAttributes:=New With {.class = "col span-1-of-3"})
        <div class="row">

            @Html.DropDownList("eventID", Nothing, htmlAttributes:=New With {.class = "col span-2-of-3"})
        </div>
        @Html.ValidationMessageFor(Function(model) model.eventID, "", New With {.class = "text-danger"})
    </div> <br />
    <div class="form-group">
        @Html.LabelFor(Function(model) model.divisionID, "Distance(KM)", htmlAttributes:=New With {.class = "col span-1-of-3"})
        <div class="row">
            @Html.DropDownList("divisionID", Nothing, htmlAttributes:=New With {.class = "col span-2-of-3"})
            @Html.ValidationMessageFor(Function(model) model.divisionID, "", New With {.class = "text-danger"})
        </div>
    </div>

    <div class="row">
        
            <input type="submit" value="Save" class="btn button-add" />
            <button class="btn button-back">
                @Html.ActionLink("Back", "Index")
            </button>
      
    </div>
</div>
End Using



@Section Scripts 
    @Scripts.Render("~/bundles/jqueryval")
End Section
