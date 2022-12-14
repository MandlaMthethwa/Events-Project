'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Partial Public Class company
    <DisplayName("Organiser")>
    Public Property companyID As Integer
    <DisplayName("Organiser Name")>
    Public Property companyName As String
    <DisplayName("Organiser Username")>
    Public Property companyUsername As String
    <DisplayName("Website")>
    Public Property websiteURL As String
    <DisplayName("Registration Number")>
    Public Property companyRegNum As String
    <DisplayName("VAT Number")>
    Public Property companyVATNum As Integer
    <DisplayName("Event Available")>
    Public Property eventID As Nullable(Of Integer)

    Public Overridable Property eventt As eventt
    Public Overridable Property divisions As ICollection(Of division) = New HashSet(Of division)

End Class
Partial Public Class division
    Public Property divisionID As Integer
    <DisplayName("Distance")>
    Public Property distance As Integer
    <DisplayName("Event Time")>
    <DataType(DataType.Time)>
    Public Property eventTime As System.TimeSpan
    <DisplayName("Type of Event")>
    Public Property eventType As String
    <DisplayName("Amount")>
    Public Property amount As Double

    Public Property eventID As Integer
    Public Property companyID As Nullable(Of Integer)

    Public Overridable Property company As company
    Public Overridable Property eventt As eventt
    Public Overridable Property users As ICollection(Of user) = New HashSet(Of user)

End Class
Partial Public Class eventt
    Public Property eventID As Integer
    <DisplayName("Event Name")>
    Public Property eventName As String
    <DisplayName("Event Date")>
    <DataType(DataType.Date)>
    Public Property eventDate As Date

    Public Overridable Property companies As ICollection(Of company) = New HashSet(Of company)
    Public Overridable Property divisions As ICollection(Of division) = New HashSet(Of division)
    Public Overridable Property results As ICollection(Of result) = New HashSet(Of result)
    Public Overridable Property users As ICollection(Of user) = New HashSet(Of user)

End Class
Partial Public Class result
    <DisplayName("Result")>
    Public Property resultID As Integer
    <DisplayName("Last Name")>
    Public Property lastName As String
    <DisplayName("First Name")>
    Public Property firstName As String
    <DisplayName("Email Address")>
    Public Property emailAddress As String
    <DisplayName("Batch")>
    Public Property batch As String
    <DisplayName("Gender")>
    Public Property gender As String

    <DisplayName("Class")>
    Public Property [class] As String
    <DisplayName("Race Number")>
    Public Property raceNumber As String
    <DisplayName("Position")>
    Public Property position As String
    <DisplayName("Pos Gen")>
    Public Property posGen As Integer
    <DisplayName("category")>
    Public Property category As String
    <DisplayName("Pos Cat")>
    Public Property posCat As Integer
    <DisplayName("Status")>
    Public Property status As String
    <DisplayName("Time")>
    Public Property time As System.TimeSpan
    Public Property eventID As Integer

    Public Overridable Property eventt As eventt

End Class

Partial Public Class user
    <DisplayName("Participant")>
    Public Property userID As Integer
    <DisplayName("First Name(s)")>
    Public Property firstName As String
    <DisplayName("Last Name")>
    Public Property lastName As String
    <DisplayName("Initial(s)")>
    Public Property initials As String
    <DisplayName("Identity Number")>
    Public Property IDNumber As String
    <DisplayName("Participant Email Address")>
    <DataType(DataType.EmailAddress)>
    Public Property emailAddress As String
    <DisplayName("User Email Address")>
    <DataType(DataType.EmailAddress)>
    Public Property userEmail As String
    <DisplayName("Category")>
    Public Property category As String

    <DisplayName("Medical Aid Name")>
    Public Property medicalAidName As String
    <DisplayName("Medical Aid Name")>
    Public Property medicalAidNumber As String
    <DisplayName("Club Name")>
    Public Property clubName As String
    <DisplayName("Province")>
    Public Property province As String
    <DisplayName("Town")>
    Public Property town As String
    <DisplayName("Registration Number")>
    Public Property regNo As Nullable(Of Integer)
    <DisplayName("T-shirt Size")>
    Public Property tShirt As String
    <DisplayName("tsb Person")>
    Public Property tsbPers As String
    <DisplayName("Temporary Number")>
    Public Property tempNo As Nullable(Of Integer)
    <DisplayName("Tipe")>
    Public Property tipe As String
    <DisplayName("finish time prediction")>
    Public Property bet As String
    <DisplayName("Paid Amount")>
    Public Property paid As Nullable(Of Integer)
    <DisplayName("Receipt Number")>
    Public Property receiptNo As String
    <DisplayName("Dep date")>
    <DataType(DataType.Date)>
    Public Property depDate As Nullable(Of Date)
    <DisplayName("Division (KM)")>
    Public Property divisionID As Nullable(Of Integer)
    Public Property eventID As Integer


    Public Overridable Property division As division

    Public Overridable Property eventt As eventt
End Class
