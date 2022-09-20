Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports Microsoft.AspNet.Identity
Imports PagedList
Imports selati_

Namespace Controllers
    Public Class resultsController
        Inherits System.Web.Mvc.Controller

        Private db As New Entities1

        ' GET: results
        Function Index(searchString As String) As ActionResult


            ViewBag.CurrentFilter = searchString
            Dim email = User.Identity.GetUserName()
            Dim results = From s In db.results.Where(Function(f) f.emailAddress = email) Select s
            If Not String.IsNullOrEmpty(searchString) Then
                results = results.Where(Function(s) s.firstName.ToUpper().Contains(searchString.ToUpper()) _
                                              Or s.lastName.ToUpper().Contains(searchString.ToUpper()))
            End If

            Return View(results)
        End Function

        Function adminIndex(searchString As String) As ActionResult
            Dim results = From f In db.results Select f
            If Not String.IsNullOrEmpty(searchString) Then
                results = results.Where(Function(s) s.firstName.ToUpper().Contains(searchString.ToUpper()) _
                                              Or s.lastName.ToUpper().Contains(searchString.ToUpper()))
            End If
            Return View(results.ToList())
        End Function

        Function allResults() As ActionResult

            Return View()
        End Function

        Function thirstResults(searchString As String) As ActionResult
            Dim results = From s In db.results.Where(Function(f) f.eventID = 2) Select s
            If Not String.IsNullOrEmpty(searchString) Then
                results = results.Where(Function(s) s.firstName.ToUpper().Contains(searchString.ToUpper()) _
                                        Or s.lastName.ToUpper().Contains(searchString.ToUpper()))
            End If
            Return View(results.ToList())
        End Function
        ' GET: results/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim result As result = db.results.Find(id)
            If IsNothing(result) Then
                Return HttpNotFound()
            End If
            Return View(result)
        End Function

        ' GET: results/Create
        Function Create() As ActionResult
            ViewBag.eventID = New SelectList(db.eventts, "eventID", "eventName")
            Return View()
        End Function

        ' POST: results/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="resultID,lastName,firstName,emailAddress,batch,gender,class,raceNumber,position,posGen,category,posCat,status,time,eventID")> ByVal result As result) As ActionResult


            If ModelState.IsValid Then
                db.results.Add(result)
                db.SaveChanges()
                Return RedirectToAction("adminIndex")
            End If

            ViewBag.eventID = New SelectList(db.eventts, "eventID", "eventName", result.eventID)
            Return View(result)
        End Function

        ' GET: results/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim result As result = db.results.Find(id)
            If IsNothing(result) Then
                Return HttpNotFound()
            End If
            ViewBag.eventID = New SelectList(db.eventts, "eventID", "eventName", result.eventID)
            Return View(result)
        End Function

        ' POST: results/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="resultID,lastName,firstName,emailAddress,batch,gender,class,raceNumber,position,posGen,category,posCat,status,time,eventID")> ByVal result As result) As ActionResult
            If ModelState.IsValid Then
                db.Entry(result).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("adminIndex")
            End If
            ViewBag.eventID = New SelectList(db.eventts, "eventID", "eventName", result.eventID)
            Return View(result)
        End Function

        ' GET: results/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim result As result = db.results.Find(id)
            If IsNothing(result) Then
                Return HttpNotFound()
            End If
            Return View(result)
        End Function

        ' POST: results/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim result As result = db.results.Find(id)
            db.results.Remove(result)
            db.SaveChanges()
            Return RedirectToAction("adminIndex")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
