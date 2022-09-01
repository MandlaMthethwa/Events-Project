@ModelType IndexViewModel
@Code
    ViewBag.Title = "Manage"
End Code
</br></br>
<h2>Menage Password.</h2>

<p class="text-success">@ViewBag.StatusMessage</p>
<div>
    
    <hr />
    <dl class=" ">
        
        <dd>
            
            @If Model.HasPassword Then
            @<a  class="button-update" @Html.ActionLink("Change your password", "ChangePassword")> </a>
            Else
                @Html.ActionLink("Create", "SetPassword")
            End If
            
        </dd>
        
        @*
            Phone Numbers can used as a second factor of verification in a two-factor authentication system.
             
             See <a href="https://go.microsoft.com/fwlink/?LinkId=403804">this article</a>
                for details on setting up this ASP.NET application to support two-factor authentication using SMS.
             
             Uncomment the following block after you have set up two-factor authentication
        *@
        @* 
            <dt>Phone Number:</dt>
            <dd>
                @(If(Model.PhoneNumber, "None"))
                @If (Model.PhoneNumber <> Nothing) Then
                    @<br />
                    @<text>[&nbsp;&nbsp;@Html.ActionLink("Change", "AddPhoneNumber")&nbsp;&nbsp;]</text>
                    @Using Html.BeginForm("RemovePhoneNumber", "Manage", FormMethod.Post, New With {.class = "form-horizontal", .role = "form"})
                        @Html.AntiForgeryToken
                        @<text>[<input type="submit" value="Remove" class="btn-link" />]</text>
                    End Using
                Else
                    @<text>[&nbsp;&nbsp;@Html.ActionLink("Add", "AddPhoneNumber") &nbsp;&nbsp;]</text>
                End If
            </dd>
     
                @If Model.TwoFactor Then
                    @Using Html.BeginForm("DisableTwoFactorAuthentication", "Manage", FormMethod.Post, New With { .class = "form-horizontal", .role = "form" })
                      @Html.AntiForgeryToken()
                      @<text>
                      Enabled
                      <input type="submit" value="Disable" class="btn btn-link" />
                      </text>
                    End Using
                Else
                    @Using Html.BeginForm("EnableTwoFactorAuthentication", "Manage", FormMethod.Post, New With { .class = "form-horizontal", .role = "form" })
                      @Html.AntiForgeryToken()
                      @<text>
                      Disabled
                      <input type="submit" value="Enable" class="btn btn-link" />
                      </text>
                    End Using
                End If
	     *@
        </dd>
    </dl>
</div>
