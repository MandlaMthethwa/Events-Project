Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports Microsoft.AspNet.Identity
Imports Microsoft.AspNet.Identity.Owin
Imports selati_

Namespace Controllers
    Public Class usersController
        Inherits System.Web.Mvc.Controller

        Private db As New Entities1


        ' GET: users
        Function Index(searchString As String) As ActionResult
            Dim email = User.Identity.GetUserName()
            Dim users = From s In db.users.Where(Function(f) f.userEmail = email) Select s
            If Not String.IsNullOrEmpty(searchString) Then
                users = users.Where(Function(s) s.firstName.ToUpper().Contains(searchString.ToUpper()) _
                                              Or s.lastName.ToUpper().Contains(searchString.ToUpper()))
            End If
            Return View(users.ToList())
        End Function

        ' GET: users/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim user As user = db.users.Find(id)
            If IsNothing(user) Then
                Return HttpNotFound()
            End If
            Return View(user)
        End Function
        ' GET: users/Create
        Function Create() As ActionResult
            ViewBag.divisionID = New SelectList(db.divisions, "divisionID", "distance")
            ViewBag.eventID = New SelectList(db.eventts, "eventID", "eventName")
            Return View()
        End Function

        ' POST: users/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="userID,firstName,lastName,initials,IDNumber,emailAddress,userEmail,category,medicalAidName,medicalAidNumber,clubName,province,town,regNo,tShirt,tsbPers,tempNo,tipe,bet,paid,receiptNo,depDate,divisionID,eventID")> ByVal user As user) As ActionResult



            If ModelState.IsValid Then
                db.users.Add(user)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If


            ViewBag.divisionID = New SelectList(db.divisions, "divisionID", "distance", user.divisionID)


            ViewBag.eventID = New SelectList(db.eventts, "eventID", "eventName", user.eventID)
            Return View(user)
        End Function

        ' GET: users/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim user As user = db.users.Find(id)
            If IsNothing(user) Then
                Return HttpNotFound()
            End If
            ViewBag.divisionID = New SelectList(db.divisions, "divisionID", "distance", user.divisionID)
            ViewBag.eventID = New SelectList(db.eventts, "eventID", "eventName", user.eventID)

            Return View(user)
        End Function

        ' POST: users/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="userID,firstName,lastName,initials,IDNumber,emailAddress,userEmail,category,medicalAidName,medicalAidNumber,clubName,province,town,regNo,tShirt,tsbPers,tempNo,tipe,bet,paid,receiptNo,depDate,divisionID,eventID")> ByVal user As user) As ActionResult
            If ModelState.IsValid Then
                db.Entry(user).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.divisionID = New SelectList(db.divisions, "divisionID", "distance", user.divisionID)
            ViewBag.eventID = New SelectList(db.eventts, "eventID", "eventName", user.eventID)

            Return View(user)
        End Function

        ' GET: users/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim user As user = db.users.Find(id)
            If IsNothing(user) Then
                Return HttpNotFound()
            End If
            Return View(user)
        End Function

        ' POST: users/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim user As user = db.users.Find(id)
            db.users.Remove(user)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
